using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
        
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable filldepartements ()            //to fill the combobox of departements
        {
            string query = "Select * from departement;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable checke(string user, string pass)   //login employees, admins and managers
        {
            string query = "Select * From Employee where Username = '" + user + "' and Password ='" + pass +"';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable checkc(string userc,string passc)       //login customers
        {
            string query = "";
            return dbMan.ExecuteReader(query);
        }

        public DataTable fillnamesbydepartement(string dept)
        {
            string query = "Select * from employee where = '" + dept + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable viewmanagersrequests ()
        {
            string query = "Select * From ManagerRequests;";
            return dbMan.ExecuteReader(query);     
        }

        public DataTable viewcustomersrequests()
        {
            string query = "Select * From CustmoerRequests;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable forgotpasswordem1(string user, string phone)
        {
            string query = "Select * From Employee where Username = '" + user + "' and Phone Number ='" + phone + "';"; 
            return dbMan.ExecuteReader(query);
        }

        public int changepasswordem (string user1, string phone1,string pass1)
        {// will depend on join
            //this function is still in the writing proccess.DON'T USE IT
            string query = "Select * From Employee where Username = '" + user1 + "' and Phone Number ='" + phone1 + "';"; ;
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
