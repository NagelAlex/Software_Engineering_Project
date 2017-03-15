using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;

namespace NCTSYS
{
    class Centre
    {
        private int CentreId;
        private string CentreName;
        private string add1;
        private string add2;
        private string telNo;
        private string email;
        private string county;
        protected char centreStatus;

        public Centre()
        {
            CentreId = 0;
            CentreName = "";
            add1 = "";
            add2 = "";
            telNo = "";
            email = "";
            county = "";
            centreStatus = ' ';

        }
    //Centre Object constructor
        public Centre(int CentreId, String CentreName, String add1, String add2, String telNo, String email, String county, Char centreStatus)
        {
            this.CentreId = CentreId;
            this.CentreName = CentreName;
            this.add1 = add1;
            this.add2 = add2;
            this.telNo = telNo;
            this.email = email;
            this.county = county;
            this.centreStatus = centreStatus;
        }
        public int getCentreID()
        {
            return CentreId;
        }
        public String getCentreName()
        {
            return CentreName;
        }
        public String getAdd1()
        {
            return add1;
        }
        public String getAdd2()
        {
            return add2;
        }
        public String getTelNo()
        {
            return telNo;
        }
        public String getEmail()
        {
            return email;
        }
        public String getCounty()
        {
            return county;
        }
        public Char getCentreStatus()
        {
            return centreStatus;
        }

        public void regCentre()
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO CENTRES VALUES(" + this.CentreId + ",'" + this.CentreName + "','" + this.add1 + "','" + this.add2 + "','" + this.telNo + "','" + this.email + "','" + this.county + "','" + this.centreStatus + "')";
            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close DB
            myConn.Close();
        }

        public static int nextCentreID()
        {
            int nextID;
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT MAX(CENTRE_ID) FROM CENTRES";
            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if(dr.IsDBNull(0))
            {
                nextID = 1;
            }
            else
            {
                nextID = dr.GetInt32(0) + 1;
            }
            
            myConn.Close();

            return nextID;

        }
    }
}
