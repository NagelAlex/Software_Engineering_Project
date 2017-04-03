using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;

namespace NCTSYS
{
    class Car
    {
        //instance variables
        private string regNo;
        private string make;
        private string model;
        private double engine;
        private string color;
        private string fuel;
        protected char carStatus = 'A';
        private string firstRegDate;
        private string currentOwner;

        public Car()
        {
            regNo = "";
            make = "";
            model = "";
            engine = 0.0;
            color = "";
            fuel = "";
            carStatus = ' ';
            firstRegDate = "";
            currentOwner = "";
        }
        public Car(String RegNo, String Make, String Model, double Engine, String Color, String Fuel, char CarStatus, String FirstRegDate, String CurrentOwner)
        {
            regNo = RegNo;
            make = Make;
            model = Model;
            engine = Engine;
            color = Color;
            fuel = Fuel;
            carStatus = CarStatus;
            firstRegDate = FirstRegDate;
            currentOwner = CurrentOwner;

        }
        public String getRegNo()
        {
            return regNo;
        }
        public String getMake()
        {
            return make;
        }
        public String getModel()
        {
            return model;
        }
        public Double getEngine()
        {
            return engine;
        }
        public String getColor()
        {
            return color;
        }
        public String getFuel()
        {
            return fuel;
        }
        public Char getCarStatus()
        {
            return carStatus;
        }
        public String getFirstRegDate()
        {
            return firstRegDate;
        }
        public String getCurrentOwner()
        {
            return currentOwner;
        }
        public void regCar()
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO CARS VALUES('" + this.regNo + "','" + this.make + "','" + this.model + "'," + this.engine + ",'" + this.color + "','" + this.fuel + "','" + this.carStatus + "','" + this.firstRegDate + "','" + this.currentOwner + "')";
            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close DB
            myConn.Close();
        }
        public void getCarDetails(String regNo)
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM CARS WHERE Reg_No = '" + regNo + "'";

            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                this.regNo = dr.GetString(0);
                this.make = dr.GetString(1);
                this.model = dr.GetString(2);
                this.engine = dr.GetDouble(3);
                this.color = dr.GetString(4);
                this.fuel = dr.GetString(5);
                this.carStatus = Convert.ToChar(dr.GetString(6).Substring(0, 1));
                this.firstRegDate = dr.GetDateTime(7).ToString();
            }
            // close DB
            myConn.Close();
        }
        public static void updCurrentOwner(string regNo, string PPSN)
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "UPDATE CARS SET CURRENTOWNER = '" + PPSN + "' WHERE REG_NO = '" + regNo + "'";
            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            cmd.ExecuteNonQuery();

            // close DB
            myConn.Close();

        }
        //de-register a car
        public static void deRegister(string regNo)
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "UPDATE Cars SET CAR_STATUS = 'I' WHERE Reg_No = '" + regNo + "'";

            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

    }
}
