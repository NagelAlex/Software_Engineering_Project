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
        private string regDate;
        //no arguement constructor
        public Registration()
        {
            regNo = "";
            regDate = "";
            ppsn = "";
        }

        public Registration(String RegNo, String RegDate, String PPSN)
        {
            regNo = RegNo;
            regDate = RegDate;
            ppsn = PPSN;
        }
        public String getRegNo()
        {
            return regNo;
        }
        public String getPPSN()
        {
            return ppsn;
        }
        public String getRegDate()
        {
            return regDate;
        }

        public void regOwnership()
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            

            String strSQL = "INSERT INTO REGISTRATIONS VALUES('" + this.regNo + "','" + this.regDate + "','" + this.ppsn + "')";
            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close DB
            myConn.Close();
        }

    }
}
