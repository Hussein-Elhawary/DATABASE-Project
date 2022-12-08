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

        public int checkc(string userc,string passc)       //login customers
        {
            string query = "";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
