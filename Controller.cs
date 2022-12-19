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
            string query = "Select * From CustomerRequests;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable forgotpasswordem1(string user, string phone)
        {
            string query = "Select * From Employee where Username = '" + user + "' and Phone Number ='" + phone + "';"; 
            return dbMan.ExecuteReader(query);
        }

        public int changepasswordem (string user1, string phone1,string pass1)
        { 
            string query = "Update Password From Employee where Username = '" + user1 + "' and " +
                "Phone Number ='" + phone1 + "' and Password = '" + pass1 + "';"; 
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable fillemployeesnames()
        {
            string query = "Select * From Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable viewhospitals()
        {
            string query = "Select * From Insurance Where Service Type = '+H+';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable viewlaboratories()
        {
            string query = "Select * From Insurance Where Service Type == L  ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable viewpharmacies()
        {
            string query = "Select * From Insurance Where Service Type == P  ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectMaxCutomerID()            //Gets the max id of the last registered customer
        {
            string query = "Select max([Customer ID]) from Customers;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetUsernamefromCustomerUsername(string Username)            //Need it for checking an existing username
        {
            string query = "Select Username from Customers where Username = '" + Username + "';";
            return dbMan.ExecuteReader(query);
        }

        public int InsertNewCustomer(string id, string password, string username, string FirstName, string MiddleName, string LastName, string COR, string City, string Address, string Email, string Ccode, string phone, string BDate, string Gender, string PreTime)
        {
            string query = "insert into Customers values ('" + id + "',':" + password + "','" + username + "','" + FirstName + "','" + MiddleName + "','" + LastName + "',' " + COR + "','" + Address + "','" + City + "','" + Email + "','" + phone + "','" + Ccode + "','" + BDate + "','" + Gender + "','" + PreTime + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable retrievePD (string username1)
        {
            string query = "Select * From Employee where Username = '" + username1 + "';";
            return dbMan.ExecuteReader(query);
        }
    }
}
