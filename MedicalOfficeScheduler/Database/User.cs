using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeScheduler.Database
{
    public class User
    {


        #region Patient Methods


        public static void AddPatient(string name, int age, string address1, string address2, string city, string state, string postal,
            string phone, string email, string insuranceID, string insuranceGroup, int SSN, string allergies, int createdBy)
        {
            var _createDate = DateTime.UtcNow;
            var _modifyDate = DateTime.UtcNow;
            string _sqlCreateDate = _createDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string _sqlModifyDate = _modifyDate.ToString("yyyy-MM-dd HH:mm:ss.fff");



            try
            {
                string addPatientString;
                if (name.Length <= 1)
                {
                    MessageBox.Show("Please enter a patient name.");
                }
                else
                {                   
                    addPatientString = "Insert INTO patient VALUES (NULL, @name, @age, @address1, @address2, @city, @state, @postal, @phone, @email, " +
                        "@insuranceID, @insuranceGroup, @SSN, @allergies, @sqlCreateDate, @createdBy, @sqlModifyDate, @modifiedBy);";

                    MySqlCommand _addPatientCommand = new MySqlCommand(addPatientString, DBConnect.dbConnection);
                    _addPatientCommand.Parameters.AddWithValue("@name", name);
                    _addPatientCommand.Parameters.AddWithValue("@age", age);
                    _addPatientCommand.Parameters.AddWithValue("@address1", address1);
                    _addPatientCommand.Parameters.AddWithValue("@address2", address2);
                    _addPatientCommand.Parameters.AddWithValue("@city", city);
                    _addPatientCommand.Parameters.AddWithValue("@state", state);
                    _addPatientCommand.Parameters.AddWithValue("@postal", postal);
                    _addPatientCommand.Parameters.AddWithValue("@phone", phone);
                    _addPatientCommand.Parameters.AddWithValue("@email", email);
                    _addPatientCommand.Parameters.AddWithValue("@insuranceID", insuranceID);
                    _addPatientCommand.Parameters.AddWithValue("@insuranceGroup", insuranceGroup);
                    _addPatientCommand.Parameters.AddWithValue("@SSN", SSN);
                    _addPatientCommand.Parameters.AddWithValue("@allergies", allergies);
                    _addPatientCommand.Parameters.AddWithValue("@sqlCreateDate", _sqlCreateDate);
                    _addPatientCommand.Parameters.AddWithValue("@createdBy", createdBy);
                    _addPatientCommand.Parameters.AddWithValue("@sqlModifyDate", _sqlModifyDate);
                    _addPatientCommand.Parameters.AddWithValue("@modifiedBy", createdBy);

                    _addPatientCommand.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public static void ModifyPatient(int patientID, string name, int age, string address1, string address2, string city, string state, string postal,
            string phone, string email, string insuranceID, string insuranceGroup, int SSN, string allergies, int modifiedBy)
        {
            DateTime _modifyDate = DateTime.UtcNow;
            string _sqlModifyDate = _modifyDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            try
            {
                string _modifyPatientString = $"UPDATE patient SET name = @name, age = @age, addressline1 = @address1, addressline2 = @address2, city = @city, state = @state, " +
                    $"postalcode = @postal, phone = @phone, email = @email, insuranceid = @insuranceID, insurancegroup = @insuranceGroup, ssn = @SSN," +
                    $"allergies = @allergies, modifydate = @sqlModifyDate, modifiedby = @modifiedBy WHERE idpatient = @patientID";

                MySqlCommand _modifyPatientCMD = new MySqlCommand(_modifyPatientString, DBConnect.dbConnection);
                _modifyPatientCMD.Parameters.AddWithValue("@patientID", patientID);
                _modifyPatientCMD.Parameters.AddWithValue("@name", name);
                _modifyPatientCMD.Parameters.AddWithValue("@age", age);
                _modifyPatientCMD.Parameters.AddWithValue("@address1", address1);
                _modifyPatientCMD.Parameters.AddWithValue("@address2", address2);
                _modifyPatientCMD.Parameters.AddWithValue("@city", city);
                _modifyPatientCMD.Parameters.AddWithValue("@state", state);
                _modifyPatientCMD.Parameters.AddWithValue("@postal", postal);
                _modifyPatientCMD.Parameters.AddWithValue("@phone", phone);
                _modifyPatientCMD.Parameters.AddWithValue("@email", email);
                _modifyPatientCMD.Parameters.AddWithValue("@insuranceID", insuranceID);
                _modifyPatientCMD.Parameters.AddWithValue("@insuranceGroup", insuranceGroup);
                _modifyPatientCMD.Parameters.AddWithValue("@SSN", SSN);
                _modifyPatientCMD.Parameters.AddWithValue("@allergies", allergies);
                _modifyPatientCMD.Parameters.AddWithValue("@sqlModifyDate", _sqlModifyDate);
                _modifyPatientCMD.Parameters.AddWithValue("@modifiedBy", modifiedBy);

                _modifyPatientCMD.ExecuteNonQuery();

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            



        }

        public static void DeletePatient(int patientID)
        {
            try
            {
                string _deletePatientString = $"DELETE FROM patient WHERE idpatient = @idpatient;";
                MySqlCommand _deletePatientCMD = new MySqlCommand(_deletePatientString, DBConnect.dbConnection);
                _deletePatientCMD.Parameters.AddWithValue("@idpatient", patientID);
                _deletePatientCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static BindingSource PopulatePatientDGV()
        {
            MySqlDataAdapter adapterPatient = new MySqlDataAdapter();

            string selectPatients = "SELECT * FROM patient";

            adapterPatient.SelectCommand = new MySqlCommand(selectPatients, DBConnect.dbConnection);

            DataTable patientTable = new DataTable();

            adapterPatient.Fill(patientTable);

            BindingSource bsPatient = new BindingSource();

            bsPatient.DataSource = patientTable;

            return bsPatient;
        }

        public static string GetPatientNameFromID(int patientID)
        {
            string patientName = "";
            string stringGetPatientName = $"Select name FROM patient WHERE idpatient = @patientID;";
            MySqlCommand cmdGetPatientName = new MySqlCommand(stringGetPatientName, DBConnect.dbConnection);
            cmdGetPatientName.Parameters.AddWithValue("@patientID", patientID);
            MySqlDataReader rdr = cmdGetPatientName.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    patientName = rdr.GetString(0);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                rdr.Close();
            }
            return patientName;

        }

        #endregion

        #region Appointment Methods

        public static void AddAppointment(int patientID, int physicianID, DateTime start, DateTime end, string visitReason, string room, int createdBy)
        {
            var _createDate = DateTime.UtcNow;
            var _modifyDate = DateTime.UtcNow;
            string _sqlCreateDate = _createDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string _sqlModifyDate = _modifyDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string _sqlStartTime = start.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string _sqlEndTime = end.ToString("yyyy-MM-dd HH:mm:ss.fff");
           
            try
            {
                string addAppointmentString = $"INSERT INTO appointment VALUES (NULL, @patientID, @physicianID, @sqlStartTime, @sqlEndTime, " +
                    $" @visitReason, @room, @sqlCreateDate, @createdBy, @sqlModifyDate, @modifiedBy);";

                MySqlCommand addAppointmentCMD = new MySqlCommand(addAppointmentString, DBConnect.dbConnection);
                addAppointmentCMD.Parameters.AddWithValue("@patientID", patientID);
                addAppointmentCMD.Parameters.AddWithValue("physicianID", physicianID);
                addAppointmentCMD.Parameters.AddWithValue("@sqlStartTime", _sqlStartTime);
                addAppointmentCMD.Parameters.AddWithValue("@sqlEndTime", _sqlEndTime);
                addAppointmentCMD.Parameters.AddWithValue("@visitReason", visitReason);
                addAppointmentCMD.Parameters.AddWithValue("@room", room);
                addAppointmentCMD.Parameters.AddWithValue("@sqlCreateDate", _sqlCreateDate);
                addAppointmentCMD.Parameters.AddWithValue("@createdBy", createdBy);
                addAppointmentCMD.Parameters.AddWithValue("@sqlModifyDate", _sqlCreateDate);
                addAppointmentCMD.Parameters.AddWithValue("@modifiedBy", createdBy);

                addAppointmentCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ModifyAppointment(int appointmentID, int patientID, int physicianID, DateTime start, DateTime end, string visitReason, string room, int modifiedBy)
        {
            DateTime _modifyDate = DateTime.UtcNow;
            string _sqlModifyDate = _modifyDate.ToString("yyyy-MM-dd HH:mm:ss.fff"); 

            string _sqlStartTime = start.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string _sqlEndTime = end.ToString("yyyy-MM-dd HH:mm:ss.fff");        

            string modifyAppointmentString = $"UPDATE appointment SET patientid = @patientID, physicianid = @physicianID, " +
                $"start = @sqlStartTime, end = @sqlEndTime, visitreason = @visitReason, room = @room, " +
                $" modifydate = @sqlModifyDate, modifiedBy = @modifiedBy WHERE idappointment = @appointmentID;";
            try
            {
                MySqlCommand modifyAppointmentCMD = new MySqlCommand(modifyAppointmentString, DBConnect.dbConnection);
                modifyAppointmentCMD.Parameters.AddWithValue("@patientID", patientID);
                modifyAppointmentCMD.Parameters.AddWithValue("@physicianID", physicianID);
                modifyAppointmentCMD.Parameters.AddWithValue("@sqlStartTime", _sqlStartTime);
                modifyAppointmentCMD.Parameters.AddWithValue("@sqlEndTime", _sqlEndTime);
                modifyAppointmentCMD.Parameters.AddWithValue("@visitReason", visitReason);
                modifyAppointmentCMD.Parameters.AddWithValue("@room", room);
                modifyAppointmentCMD.Parameters.AddWithValue("@sqlModifyDate", _sqlModifyDate);
                modifyAppointmentCMD.Parameters.AddWithValue("@modifiedBy", modifiedBy);
                modifyAppointmentCMD.Parameters.AddWithValue("appointmentID", appointmentID);

                modifyAppointmentCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return;
        }

        public static void DeleteAppointment(int appointmentID)
        {
            try
            {
                string _deleteAppointmentString = $"DELETE FROM appointment WHERE idappointment = @appointmentID;";
                MySqlCommand _deleteAppointmentCMD = new MySqlCommand(_deleteAppointmentString, DBConnect.dbConnection);
                _deleteAppointmentCMD.Parameters.AddWithValue("@appointmentID", appointmentID);
                _deleteAppointmentCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static BindingSource PopulateAppointmentDGV(string sqlStartDate = "1900-01-01", string sqlEndDate = "2900-01-01")
        {
            BindingSource bsCalendar = new BindingSource();
            try
            {
                MySqlDataAdapter adapterCalendar = new MySqlDataAdapter();

               
                string selectAppointments = $"SELECT idappointment AS ID, physician.name AS Physician, patient.name AS Patient, patientid, physicianid, visitreason AS 'Visit Reason', " +
                    $"room AS Room, CONVERT_TZ(start, '+00:00', '{DateTimeOffset.Now.ToString("zzz")}') AS Start, CONVERT_TZ(end, '+00:00', '{DateTimeOffset.Now.ToString("zzz")}') AS End, " +
                    $"CONVERT_TZ(appointment.createDate, '+00:00', '{DateTimeOffset.Now.ToString("zzz")}'), appointment.createdby, CONVERT_TZ(appointment.modifyDate, '+00:00', '{DateTimeOffset.Now.ToString("zzz")}'), " +
                    $"appointment.modifiedby, patient.age FROM appointment INNER JOIN physician ON (appointment.physicianid = idphysician AND (start > @sqlStartDate AND end < @sqlEndDate)) INNER JOIN patient ON appointment.patientid = patient.idpatient;";


                adapterCalendar.SelectCommand = new MySqlCommand(selectAppointments, DBConnect.dbConnection);

                adapterCalendar.SelectCommand.Parameters.AddWithValue("@sqlStartDate", sqlStartDate);
                adapterCalendar.SelectCommand.Parameters.AddWithValue("@sqlEndDate", sqlEndDate);

                DataTable calendarTable = new DataTable();

                adapterCalendar.Fill(calendarTable);

                bsCalendar.DataSource = calendarTable;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return bsCalendar;
        }

        public static Appointment GetAppointmentInfo(int appointmentID)
        {
            Appointment returnAppointment = new Appointment();
            string stringGetAppointmentInfo = $"SELECT * FROM appointment WHERE idappointment = @appointmentID;";
            try
            {
                MySqlCommand cmdGetAppointmentInfo = new MySqlCommand(stringGetAppointmentInfo, DBConnect.dbConnection);
                cmdGetAppointmentInfo.Parameters.AddWithValue("@appointmentID", appointmentID);
                MySqlDataReader rdr = cmdGetAppointmentInfo.ExecuteReader();

                while (rdr.Read())
                {
                    returnAppointment.AppointmentID = (int)rdr.GetValue(0);
                    returnAppointment.PatientID = (int)rdr.GetValue(1);
                    returnAppointment.PhysicianID = (int)rdr.GetValue(2);
                    returnAppointment.Start = (DateTime)rdr.GetValue(3);
                    returnAppointment.End = (DateTime)rdr.GetValue(4);
                    returnAppointment.VisitReason = rdr.GetString(5);
                    returnAppointment.Room = rdr.GetString(6);
                    returnAppointment.CreateDate = (DateTime)rdr.GetValue(7);
                    returnAppointment.CreatedBy = (int)rdr.GetValue(8);
                    returnAppointment.ModifyDate = (DateTime)rdr.GetValue(9);
                    returnAppointment.ModifiedBy = (int)rdr.GetValue(10);
                    
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return returnAppointment;
        }

        #endregion

        #region Physician Methods

        public static void AddPhysician(string name, string specialty, string phone, string email, int createdBy)
        {
            var _createDate = DateTime.UtcNow;
            var _modifyDate = DateTime.UtcNow;
            string _sqlCreateDate = _createDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string _sqlModifyDate = _modifyDate.ToString("yyyy-MM-dd HH:mm:ss.fff");



            try
            {
                string addPhysicianString;
                if (name.Length <= 1)
                {
                    MessageBox.Show("Please enter a physician name.");
                }
                else
                {
                    addPhysicianString = $"INSERT INTO physician VALUES (NULL, @name, @specialty, @phone, @email, @sqlCreateDate, @createdBy, @sqlModifyDate, @modifiedBy);";

                    MySqlCommand _addPhysicianCommand = new MySqlCommand(addPhysicianString, DBConnect.dbConnection);
                    _addPhysicianCommand.Parameters.AddWithValue("@name", name);
                    _addPhysicianCommand.Parameters.AddWithValue("@specialty", specialty);
                    _addPhysicianCommand.Parameters.AddWithValue("@phone", phone);
                    _addPhysicianCommand.Parameters.AddWithValue("@email", email);
                    _addPhysicianCommand.Parameters.AddWithValue("@sqlCreateDate", _sqlCreateDate);
                    _addPhysicianCommand.Parameters.AddWithValue("@createdBy", createdBy);
                    _addPhysicianCommand.Parameters.AddWithValue("@sqlModifyDate", _sqlCreateDate);
                    _addPhysicianCommand.Parameters.AddWithValue("@modifiedBy", createdBy);

                    _addPhysicianCommand.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void ModifyPhysician(int physicianID, string name, string specialty, string phone, string email, int modifiedBy)
        {
            DateTime _modifyDate = DateTime.UtcNow;
            string _sqlModifyDate = _modifyDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            try
            {
                string _modifyPhysicianString = $"UPDATE physician SET name = @name, specialty = @specialty, phone = @phone, email = @email, modifydate = @sqlModifyDate, " +
                    $"modifiedby = @modifiedBy WHERE idphysician = @physicianID";

                MySqlCommand _modifyPhysicianCommand = new MySqlCommand(_modifyPhysicianString, DBConnect.dbConnection);
                _modifyPhysicianCommand.Parameters.AddWithValue("@name", name);
                _modifyPhysicianCommand.Parameters.AddWithValue("@specialty", specialty);
                _modifyPhysicianCommand.Parameters.AddWithValue("@phone", phone);
                _modifyPhysicianCommand.Parameters.AddWithValue("@email", email);
                _modifyPhysicianCommand.Parameters.AddWithValue("@sqlModifyDate", _sqlModifyDate);
                _modifyPhysicianCommand.Parameters.AddWithValue("@modifiedBy", modifiedBy);
                _modifyPhysicianCommand.Parameters.AddWithValue("@physicianID", physicianID);

                _modifyPhysicianCommand.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeletePhysician(int physicianID)
        {
            try
            {
                string _deletePhysicianString = $"DELETE FROM physician WHERE idphysician = @physicianID;";
                MySqlCommand _deletePhysicianCommand = new MySqlCommand(_deletePhysicianString, DBConnect.dbConnection);
                _deletePhysicianCommand.Parameters.AddWithValue("@physicianID", physicianID);

                _deletePhysicianCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static BindingSource PhysicianList()
        {
            MySqlDataAdapter adapterPhysician = new MySqlDataAdapter();

            string selectPhysicians = "SELECT idphysician, name, specialty, phone, email FROM physician";

            adapterPhysician.SelectCommand = new MySqlCommand(selectPhysicians, DBConnect.dbConnection);

            DataTable physicianTable = new DataTable();

            adapterPhysician.Fill(physicianTable);

            physicianTable.Columns.Add("NameAndSpecialty", typeof(string), "name + ': ' + specialty");

            BindingSource bsPhysician = new BindingSource();

            bsPhysician.DataSource = physicianTable;

            return bsPhysician;
        }

        public static string GetPhysicianNameFromID(int physicianID)
        {
            string physicianName = "";
            string stringGetPhysicianName = $"SELECT name FROM physician WHERE idphysician = @physicianID;";
            try
            {
                MySqlCommand cmdGetPhysicianName = new MySqlCommand(stringGetPhysicianName, DBConnect.dbConnection);
                cmdGetPhysicianName.Parameters.AddWithValue("@physicianID", physicianID);

                MySqlDataReader rdr = cmdGetPhysicianName.ExecuteReader();
                while (rdr.Read())
                {
                    physicianName = rdr.GetString(0);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return physicianName;
        }


        #endregion

        #region Login Methods
        
        public static int currentUserID;
 

        public static bool VerifyUsername(string username)
        { 
            bool isValidUsername = false;
            string validUsernameString = "SELECT strcmp(@username, username) FROM user";
            MySqlCommand findUsername = new MySqlCommand(validUsernameString, DBConnect.dbConnection);
            findUsername.Parameters.AddWithValue("@username", username);
            try
            {
                MySqlDataReader rdr = findUsername.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr.GetInt32(0) == 0)
                    {
                        rdr.Close();
                        isValidUsername = true;
                        return isValidUsername;
                    }
                }
                rdr.Close();
                return isValidUsername;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return isValidUsername;
            }
        }
        public static bool VerifyPassword(string password)
        {
            bool isValidPassword = false;
            string validPasswordSQL = "SELECT strcmp(@password, password) FROM user"; 
            MySqlCommand findPassword = new MySqlCommand(validPasswordSQL, DBConnect.dbConnection);
            findPassword.Parameters.AddWithValue("@password", password);
            try
            {
                MySqlDataReader rdr = findPassword.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr.GetInt32(0) == 0)
                    {
                        rdr.Close();
                        isValidPassword = true;
                        return isValidPassword;
                    }
                }
                rdr.Close();
                return isValidPassword;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return isValidPassword;
            }
        }
        public static void SetCurrentUser(string username)
        {


            string stringGetUserID = $"SELECT iduser from user WHERE userName = @username";
            MySqlCommand cmdGetUserID = new MySqlCommand(stringGetUserID, DBConnect.dbConnection);
            cmdGetUserID.Parameters.AddWithValue("@username", username);

            try
            {
                MySqlDataReader rdr = cmdGetUserID.ExecuteReader();
                while (rdr.Read())
                {
                    currentUserID = rdr.GetInt32(0);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return;
        }
        

        public static string GetCultureInfo()
        {
            string cultureInfo;
            cultureInfo = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            return cultureInfo;
        }


        #endregion

        #region TimeCheck Methods

        public static bool VerifyAppointmentTimes(DateTime appStart, DateTime appEnd, int appointmentPhysician, int appointmentPatient, int appID, string room /*This should be changed to int*/)
        {

            bool isValidAppTimes = false;

            if (CheckBusinessHours(appStart, appEnd) && CheckAppEndAfterStart(appStart, appEnd)
                && CheckAppOverlap(appStart, appEnd, appointmentPhysician, appointmentPatient, appID, room))
            {
                isValidAppTimes = true;
            }
            return isValidAppTimes;
        }
        delegate bool betweenTimes(DateTime appStart, DateTime appEnd);

        private static bool CheckBusinessHours(DateTime appStart, DateTime appEnd)
        {
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            TimeSpan estOffset = tzi.GetUtcOffset(appStart);

            DateTime appStartUTC = appStart.AddHours(-estOffset.Hours);
            DateTime appEndUTC = appEnd.AddHours(-estOffset.Hours);            
            DateTime openTimeUTC = new DateTime(2001, 1, 1, 13, 0, 0);
            DateTime closeTimeUTC = new DateTime(2999, 1, 1, 21, 0, 0);
            DateTime openTime = new DateTime(2001, 1, 1, 09, 0, 0);
            DateTime closeTime = new DateTime(2001, 1, 1, 17, 0, 0);

            betweenTimes withinBusinessHours = (s, e) => s.TimeOfDay >= openTime.TimeOfDay && s.TimeOfDay < closeTime.TimeOfDay
            && e.TimeOfDay <= closeTime.TimeOfDay; 



            if (!withinBusinessHours(appStart, appEnd))
            {
                MessageBox.Show("Appointment times fall outside of business hours.");
            }
            return withinBusinessHours(appStart, appEnd);
        }

        private static bool CheckAppEndAfterStart(DateTime appStart, DateTime appEnd)
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


        private static bool CheckAppOverlap(DateTime appStart, DateTime appEnd, int appointmentPhysician, int appointmentPatient, int appointmentID, string room)
        {
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            TimeSpan estOffset = tzi.GetUtcOffset(appStart);

            DateTime appStartUTC = appStart.AddHours(-estOffset.Hours);
            DateTime appEndUTC = appEnd.AddHours(-estOffset.Hours);
            bool startIsNotBetween = false;
            bool endIsNotBetween = false;
            bool otherIsNotBetween = false;
            bool isValidOverlapCheck = false;

            

            string stringCheckStartOverlap = $"SELECT start, end, appointment.physicianid, appointment.idappointment, physician.name FROM appointment " +
                $"INNER JOIN physician on appointment.physicianid = physician.idphysician WHERE physician.idphysician = @appointmentPhysician;";
            MySqlCommand cmdCheckStartOverlap = new MySqlCommand(stringCheckStartOverlap, DBConnect.dbConnection);
            cmdCheckStartOverlap.Parameters.AddWithValue("@appointmentPhysician", appointmentPhysician);
            MySqlDataReader rdr = cmdCheckStartOverlap.ExecuteReader();
            try
            {
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

                        if ((DateTime)rdr.GetValue(0) <= appStartUTC && (DateTime)rdr.GetValue(1) >= appStartUTC && rdr.GetInt32(3) != appointmentID)
                        {
                            MessageBox.Show($"Start time is during appointment with physician {rdr.GetValue(4)} with ID: {rdr.GetValue(3)}. " +
                                $"Please consult calendar and try again.");
                            rdr.Close();
                            return isValidOverlapCheck;
                        }

                        //Check if end time falls beween another appointment's start and end times.
                        else if ((DateTime)rdr.GetValue(0) <= appEndUTC && (DateTime)rdr.GetValue(1) >= appEndUTC && rdr.GetInt32(3) != appointmentID)
                        {
                            MessageBox.Show($"End time is during appointment with physician {rdr.GetValue(4)} with ID: {rdr.GetValue(3)}. " +
                                 $"Please consult calendar and try again.");
                            rdr.Close();
                            return isValidOverlapCheck;
                        }

                        //Checks if an existing appointment begins within new start end times;
                        else if ((DateTime)rdr.GetValue(0) >= appStartUTC && (DateTime)rdr.GetValue(0) <= appEndUTC && rdr.GetInt32(3) != appointmentID)
                        {
                            MessageBox.Show($"Appointment with physician {rdr.GetValue(4)} with ID: {rdr.GetValue(3)} falls between start and end times." +
                                $"Please consult calendar and try again.");
                            rdr.Close();
                            return isValidOverlapCheck;
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Time Check Error 1" + ex.Message);

            }
            rdr.Close();

            //Check Patient Overlap
            string stringCheckStartOverlapPatient = $"SELECT start, end, appointment.patientid, appointment.idappointment, patient.name FROM appointment " +
            $"INNER JOIN patient on appointment.patientid = patient.idpatient WHERE patient.idpatient = @appointmentPatient;";
            MySqlCommand cmdCheckStartOverlapPatient = new MySqlCommand(stringCheckStartOverlapPatient, DBConnect.dbConnection);
            cmdCheckStartOverlapPatient.Parameters.AddWithValue("@appointmentPatient", appointmentPatient);
            MySqlDataReader rdrPatient = cmdCheckStartOverlapPatient.ExecuteReader();
            try
            {
                //If a user has no appointments the reader will have no rows and there is no need to verify overlap
                if (!rdrPatient.HasRows)
                {
                    startIsNotBetween = true;
                    endIsNotBetween = true;
                    otherIsNotBetween = true;
                }
                else
                {
                    while (rdrPatient.Read())
                    {

                        if ((DateTime)rdrPatient.GetValue(0) <= appStartUTC && (DateTime)rdrPatient.GetValue(1) >= appStartUTC && rdrPatient.GetInt32(3) != appointmentID)
                        {
                            MessageBox.Show($"Start time is during appointment for patient {rdrPatient.GetValue(4)} with ID: {rdrPatient.GetValue(3)}. " +
                                $"Please consult calendar and try again.");
                            rdrPatient.Close();
                            return isValidOverlapCheck;
                        }

                        //Check if end time falls beween another appointment's start and end times.
                        else if ((DateTime)rdrPatient.GetValue(0) <= appEndUTC && (DateTime)rdrPatient.GetValue(1) >= appEndUTC && rdrPatient.GetInt32(3) != appointmentID)
                        {
                            MessageBox.Show($"End time is during appointment for patient {rdrPatient.GetValue(4)} with ID: {rdrPatient.GetValue(3)}. " +
                                 $"Please consult calendar and try again.");
                            rdrPatient.Close();
                            return isValidOverlapCheck;
                        }

                        //Checks if an existing appointment begins within new start end times;
                        else if ((DateTime)rdrPatient.GetValue(0) >= appStartUTC && (DateTime)rdrPatient.GetValue(0) <= appEndUTC && rdrPatient.GetInt32(3) != appointmentID)
                        {
                            MessageBox.Show($"Appointment for patient {rdrPatient.GetValue(4)} with ID: {rdrPatient.GetValue(3)} falls between start and end times." +
                                $"Please consult calendar and try again.");
                            rdrPatient.Close();
                            return isValidOverlapCheck;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Time Check Error 2" + ex.Message);
            }
            rdrPatient.Close();

            //Check Room Overlap
            string stringCheckRoomOverlap = $"SELECT start, end, room FROM appointment WHERE (room = @room AND idappointment != @appointmentID);";
            MySqlCommand cmdCheckRoomOverlap = new MySqlCommand(stringCheckRoomOverlap, DBConnect.dbConnection);
            cmdCheckRoomOverlap.Parameters.AddWithValue("@room", room);
            cmdCheckRoomOverlap.Parameters.AddWithValue("@appointmentID", appointmentID);
            MySqlDataReader rdrRoom = cmdCheckRoomOverlap.ExecuteReader();
            try
            {
                //If a user has no appointments the reader will have no rows and there is no need to verify overlap
                if (!rdrRoom.HasRows)
                {
                    startIsNotBetween = true;
                    endIsNotBetween = true;
                    otherIsNotBetween = true;
                }
                else
                {
                    while (rdrRoom.Read())
                    {
                        if ((DateTime)rdrRoom.GetValue(0) <= appStartUTC && (DateTime)rdrRoom.GetValue(1) >= appStartUTC)
                        {
                            MessageBox.Show($"There is an appointment scheduled in room {rdrRoom.GetValue(2)} during this time. " +
                                $"Please consult calendar and try again.");
                            rdrRoom.Close();
                            return isValidOverlapCheck;
                        }

                        else if ((DateTime)rdrRoom.GetValue(0) <= appEndUTC && (DateTime)rdrRoom.GetValue(1) >= appEndUTC)
                        {
                            MessageBox.Show($"There is an appointment scheduled in room {rdrRoom.GetValue(2)} during this time. " +
                                 $"Please consult calendar and try again.");
                            rdrRoom.Close();
                            return isValidOverlapCheck;
                        }

                        else if ((DateTime)rdrRoom.GetValue(0) >= appStartUTC && (DateTime)rdrRoom.GetValue(0) <= appEndUTC)
                        {
                            MessageBox.Show($"There is an appointment scheduled in room {rdrRoom.GetValue(2)} during this time. " +
                                $"Please consult calendar and try again.");
                            rdrRoom.Close();
                            return isValidOverlapCheck;
                        }
                        else
                        {
                            startIsNotBetween = true;
                            endIsNotBetween = true;
                            otherIsNotBetween = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Time Check Error 3" + ex.Message);
            }
            rdrRoom.Close();

            //If all above conditions are met, the appointment times are valid.
            if (startIsNotBetween && endIsNotBetween && otherIsNotBetween)
            {
                isValidOverlapCheck = true;
            }
            return isValidOverlapCheck;
        }

        #endregion

        #region Reports Methods

        public static BindingSource AppsByPhysicianMonth(int intMonth, int intYear, int physicianID)
        {
            MySqlDataAdapter adapterAppsByPhysMonth = new MySqlDataAdapter();

            string selectAppsByPhysician = $"SELECT patient.name AS 'Patient', room AS 'Room', " +
                $"CONVERT_TZ(appointment.start, '+00:00', '{DateTimeOffset.Now.ToString("zzz")}') AS 'Start' " +
                $"FROM patient INNER JOIN appointment ON appointment.patientid = patient.idpatient " +
                $"WHERE physicianid = @physicianID AND MONTH(start) = @intMonth AND YEAR(start) = @intYear ORDER BY start;";

            adapterAppsByPhysMonth.SelectCommand = new MySqlCommand(selectAppsByPhysician, DBConnect.dbConnection);
            adapterAppsByPhysMonth.SelectCommand.Parameters.AddWithValue("@physicianID", physicianID);
            adapterAppsByPhysMonth.SelectCommand.Parameters.AddWithValue("@intMonth", intMonth);
            adapterAppsByPhysMonth.SelectCommand.Parameters.AddWithValue("@intYear", intYear);

            DataTable appsByUserTable = new DataTable();

            adapterAppsByPhysMonth.Fill(appsByUserTable);

            BindingSource bsAppsByUser = new BindingSource();

            bsAppsByUser.DataSource = appsByUserTable;

            return bsAppsByUser;
        }

        public static BindingSource AppsByPatient(int patientID)
        {
            MySqlDataAdapter adapterAppsByPatient = new MySqlDataAdapter();

            string selectApps = $"SELECT physician.name AS 'Physician', room AS 'Room', CONVERT_TZ(start, '+00:00', '{DateTimeOffset.Now.ToString("zzz")}') " +
                $"AS 'Start' FROM appointment INNER JOIN physician ON idphysician = physicianid WHERE patientid = @patientID;";

            adapterAppsByPatient.SelectCommand = new MySqlCommand(selectApps, DBConnect.dbConnection);
            adapterAppsByPatient.SelectCommand.Parameters.AddWithValue("@patientID", patientID);

            DataTable appsByPatientTable = new DataTable();

            adapterAppsByPatient.Fill(appsByPatientTable);

            BindingSource bsAppsByPatient = new BindingSource();

            bsAppsByPatient.DataSource = appsByPatientTable;

            return bsAppsByPatient;
        }

        public static BindingSource AppsByPhysician(int physicianID)
        {
            MySqlDataAdapter adapterAppsByPhysician = new MySqlDataAdapter();

            string selectAppsByUser = $"SELECT patient.name AS 'Patient', room AS 'Room', " +
                $"CONVERT_TZ(appointment.start, '+00:00', '{DateTimeOffset.Now.ToString("zzz")}') AS 'Start' " +
                $"FROM patient INNER JOIN appointment ON appointment.patientid = patient.idpatient " +
                $"WHERE physicianid = @physicianID ORDER BY start;";

            adapterAppsByPhysician.SelectCommand = new MySqlCommand(selectAppsByUser, DBConnect.dbConnection);
            adapterAppsByPhysician.SelectCommand.Parameters.AddWithValue("@physicianID", physicianID);

            DataTable appsByUserTable = new DataTable();

            adapterAppsByPhysician.Fill(appsByUserTable);

            BindingSource bsAppsByUser = new BindingSource();

            bsAppsByUser.DataSource = appsByUserTable;

            return bsAppsByUser;
        }

        #endregion

        #region Login Log

        private static void WriteLogin(string loginActivity)
        {
            try
            {
                FileStream writeLoginFilestream = new FileStream(string.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "log.txt"), FileMode.Append, FileAccess.Write);
                StreamWriter writeLoginStreamWriter = new StreamWriter((Stream)writeLoginFilestream);
                writeLoginStreamWriter.WriteLine(loginActivity);
                writeLoginStreamWriter.Close();
                writeLoginFilestream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void SuccessfulLogin(string userName)
        {
            DateTime loginTime = DateTime.UtcNow;
            string successfulLogEntry = $"User: {userName} logged in successfully at: {loginTime.ToString()} UTC.";
            WriteLogin(successfulLogEntry);
        }
        public static void FailedLogin(string username)
        {
            DateTime loginTime = DateTime.UtcNow;
            string failedLogEntry = $"Failed login attempt with username: {username} at: {loginTime.ToString()} UTC.";
            WriteLogin(failedLogEntry);
        }

        #endregion
    }

}
