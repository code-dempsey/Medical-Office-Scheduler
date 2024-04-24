using C969;
using C969.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using C969.Database;
//using MySql.Data.MySqlClient;

namespace SchedulerTest
    
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string room = "room1";
            string room2 = "2";
            DateTime dateTime  = DateTime.Now;
            DateTime dateTime2 = dateTime.AddMinutes(30);
            int physicianID = 1;
            int patientID = 2;
            int appointmentID = 1;




            bool success = TimeCheck.checkAppOverlap(dateTime, dateTime2, physicianID, patientID, appointmentID, room2);

            //bool success = (room == room2);


            Assert.IsTrue(success);
        }
    }
}