using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969.Database;
using MySql.Data.MySqlClient;

namespace C969.Forms
{
    public class TimeCheck
    {
        public static bool verifyAppointmentTimes(DateTime appStart, DateTime appEnd, string appointmentUser, int appID)
        {
            bool isValidAppTimes = false;
            //BIG IF
            if (checkBusinessHours(appStart,appEnd) && checkAppEndAfterStart(appStart, appEnd)
                && checkAppOverlap(appStart, appEnd, appointmentUser, appID))
            {
                isValidAppTimes = true;
            }
            return isValidAppTimes;
        }
        delegate bool betweenTimes(DateTime appStart, DateTime appEnd);
        //REQUIREMENT F: EXCEPTION CONTROL ******NO LONGER TRUE, FIND ELSEWHERE
        //The method below checks that the appointment times fall in between business hours using if/else mechanisms.
        public static bool checkBusinessHours(DateTime appStart, DateTime appEnd)
        {

            DateTime openTimeEST = new DateTime(2001, 1, 1, 9, 0, 0);
            DateTime closeTimeEST = new DateTime(2999, 1, 1, 17, 0, 0);

            betweenTimes withinBusinessHours = (s, e) =>  s.TimeOfDay >= openTimeEST.TimeOfDay && s.TimeOfDay < closeTimeEST.TimeOfDay 
            && e.TimeOfDay <= closeTimeEST.TimeOfDay; //Lamba function here reduced the amount of code needed
                                                      //to check if appointment times were during business hours
           
            if (!withinBusinessHours(appStart, appEnd))
            {
                MessageBox.Show("Appointment times fall outside of business hours.");
            }
            return withinBusinessHours(appStart, appEnd);
        }
        
        public static bool checkAppEndAfterStart(DateTime appStart, DateTime appEnd)
        {
            bool isValidTimes = false;

            if (appEnd > appStart)
            {
                isValidTimes = true;
            }
            else
            {
                MessageBox.Show("Appointment start time must precede end time.");
            }

            return isValidTimes;
        }

        //REQUIREMENT F: EXCEPTION CONTROL
        //Below is exception control for preventing appointments from overlapping for a specific user.
        //Try/catch and if/else mechanisms are both in use.
        public static bool checkAppOverlap(DateTime appStart,DateTime appEnd, string appointmentUser, int appID)
        {    
            bool startIsNotBetween = false;
            bool endIsNotBetween = false;
            bool otherIsNotBetween = false;
            bool isValidOverlapCheck = false;
            DateTime appStartUTC = appStart.ToUniversalTime();
            DateTime appEndUTC = appEnd.ToUniversalTime();

            string stringCheckStartOverlap = $"SELECT start, end, appointment.userId, appointment.appointmentId FROM appointment " +
                $"INNER JOIN user on appointment.userId = user.userId WHERE user.userName = '{appointmentUser}';";
            MySqlCommand cmdCheckStartOverlap = new MySqlCommand(stringCheckStartOverlap, DBConnect.dbConnection);
            MySqlDataReader rdr = cmdCheckStartOverlap.ExecuteReader();
            try
            {
                //If a user has no appointments the reader will have no rows and there is no need to verify overlap
                if (!rdr.HasRows)
                {
                    startIsNotBetween = true;
                    endIsNotBetween = true;
                    otherIsNotBetween = true;
                }
                else
                {
                    while (rdr.Read())
                    {
                        //Logic to check if start time falls between another appointment's start and end time
                        if ((DateTime)rdr.GetValue(0) <= appStartUTC && (DateTime)rdr.GetValue(1) >= appStartUTC && rdr.GetInt32(3) != appID)
                        {
                            MessageBox.Show($"Start time is during appointment with ID: {rdr.GetValue(3)}. " +
                                $"Please consult calendar and try again.");
                        }
                        
                        //Check if end time falls beween another appointment's start and end times.
                        else if ((DateTime)rdr.GetValue(0) <= appEndUTC && (DateTime)rdr.GetValue(1) >= appEndUTC && rdr.GetInt32(3) != appID)
                        {
                            MessageBox.Show($"End time is during appointment with ID: {rdr.GetValue(3)}. " +
                                 $"Please consult calendar and try again.");
                        }
                        
                        //Checks if an existing appointment begins within new start end times;
                        //should eliminate appointment encapsulation
                        else if ((DateTime)rdr.GetValue(0) >= appStartUTC && (DateTime)rdr.GetValue(0) <= appEndUTC && rdr.GetInt32(3) != appID)
                        {
                            MessageBox.Show($"Appointment with ID: {rdr.GetValue(3)} falls between start and end times." +
                                $"Please consult calendar and try again.");
                        }
                        else
                        {
                            startIsNotBetween = true;
                            endIsNotBetween = true;
                            otherIsNotBetween = true;
                        }

                    }
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                rdr.Close();
            }
            //If all above conditions are met, the appointment times should be good.
            if (startIsNotBetween && endIsNotBetween && otherIsNotBetween)
            {
                isValidOverlapCheck = true;
            }
            return isValidOverlapCheck;
        }
    }
}
