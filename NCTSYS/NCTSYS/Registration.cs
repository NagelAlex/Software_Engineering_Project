using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace NCTSYS
{
    class Registration
    {
        //instance variables
        private string regNo;
        private string ppsn;

        //no arguement constructor
        public Registration()
        {
            regNo = " ";
            ppsn = " ";
        }

        public Registration(String RegNo, String PPSN)
        {
            regNo = RegNo;
            ppsn = PPSN;
        }


        public void regOwnership()
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String currantDate = System.DateTime.Today.ToString("dd-MMM-yyyy");

            String strSQL = "INSERT INTO REGISTRATIONS VALUES('" + this.regNo + "','" + currantDate + "','" + this.ppsn + "')";
            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close DB
            myConn.Close();
        }
        
    }
}
