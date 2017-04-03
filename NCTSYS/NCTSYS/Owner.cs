using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;

namespace NCTSYS
{
    class Owner
    {
        private string ppsn;
        private string ownerSname;
        private string ownerFname;
        private string dob;
        private string telNum;
        private string email;
        private string ownerAdd1;
        private string ownerAdd2;
        private string ownerCounty;

        //no arguement constructor
        public Owner()
        {
            ppsn = "";
            ownerSname = "";
            ownerFname = "";
            dob = "";
            telNum = "";
            email = "";
            ownerAdd1 = "";
            ownerAdd2 = "";
            ownerCounty = "";
        }
        public Owner(String PPSN, String OwnerSname, String OwnerFname, String DOB, String TelNum, String Email, String OwnerAdd1, String OwnerAdd2, String OwnerCounty)
        {
            ppsn = PPSN;
            ownerSname = OwnerSname;
            ownerFname = OwnerFname;
            dob = DOB;
            telNum = TelNum;
            email = Email;
            ownerAdd1 = OwnerAdd1;
            ownerAdd2 = OwnerAdd2;
            ownerCounty = OwnerCounty;
        }

        public String getPPSN()
        {
            return ppsn;
        }
        public String getSname()
        {
            return this.ownerSname;
        }
        public String getFname()
        {
            return this.ownerFname;
        }
        public String getDOB()
        {
            return this.dob;
        }
        public String getTelNum()
        {
            return this.telNum;
        }
        public String getEmail()
        {
            return this.email;
        }
        public String getAdd1()
        {
            return this.ownerAdd1;
        }
        public String getAdd2()
        {
            return this.ownerAdd2;
        }
        public String getCounty()
        {
            return this.ownerCounty;
        }

        //insert owner details into Owners table
        public void regOwner()
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO OWNERS VALUES('" + this.ppsn + "','" + this.ownerSname + "','" + this.ownerFname + "','" + this.dob + "','" + this.telNum + "','" + this.email + "','" + this.ownerAdd1 + "','" + this.ownerAdd2 + "','" + this.ownerCounty + "')";
            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close DB
            myConn.Close();
        }

        //retriving Owner detail from Owners Table
        public void getOwnerDetails(String PPSN)
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Owners WHERE PPSN = '" + PPSN + "'";

            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                this.ppsn = dr.GetString(0);
                this.ownerSname = dr.GetString(1);
                this.ownerFname= dr.GetString(2);
                this.dob = dr.GetDateTime(3).ToString();
                this.telNum = dr.GetString(4);
                this.email= dr.GetString(5);
                this.ownerAdd1 = dr.GetString(6);
                this.ownerAdd2 = dr.GetString(7);
                this.ownerCounty = dr.GetString(8);
            }
            // close DB
            myConn.Close();
        }

    }

}
