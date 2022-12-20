using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Security;

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

        public DataTable filldepartements()            //to fill the combobox of departements
        {
            string query = "Select * from departement;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable checke(string user, string pass)   //login employees, admins and managers
        {
            string query = "Select * From Employee where Username = '" + user + "' and Password ='" + pass + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectManagerName(string user)
        {
            string query = "Select [First name] From Employee where Username = '" + user + "';";
            return dbMan.ExecuteReader(query);
        }
        
        public DataTable SelectDepartment(string user)
        {
            string query = "Select Department From Employee where Username = '" + user + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployeeFirstNameFromDepartmentid(int id)
        {
            string query = "Select DISTINCT [First name] From Employee where Department = " + id + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployeeMiddleNameFromDepartmentid(int id)
        {
            string query = "Select DISTINCT [Middle name] From Employee where Department = " + id + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployeeLastNameFromDepartmentid(int id)
        {
            string query = "Select DISTINCT [Last name] From Employee where Department = " + id + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable checkc(string userc, string passc)       //login customers
        {
            string query = "";
            return dbMan.ExecuteReader(query);
        }

        public DataTable fillnamesbydepartement(string dept)
        {
            string query = "Select * from employee where = '" + dept + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable viewmanagersrequests()
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

        public int changepasswordem(string user1, string phone1, string pass1)
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
            string query = "insert into Customers values ('" + id + "','" + password + "','" + username + "','" + FirstName + "','" + MiddleName + "','" + LastName + "',' " + COR + "','" + Address + "','" + City + "','" + Email + "','" + phone + "','" + Ccode + "','" + BDate + "','" + Gender + "','" + PreTime + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable retrievePD(string username1)
        {
            string query = "Select * From Employee where Username = '" + username1 + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable retrievemanager (string deptid)
        {
        string query = "Select[First Name] From Employee where[Employee ID] = (Select[Manager ID] from Departement where[Departement ID] =  1)";        
        return dbMan.ExecuteReader(query);
        }

        public DataTable GetCustomerINFO(string id)            //Gets all customer Attributes for specific customer
        {
            string query = "Select * from Customers where [Customer ID] = '" + id + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetOdersforSelectedCustomer(string id)            //Gets Orders for specific customer
        {
            string query = "Select [Order Number],Notes,[Order Date],[Order Status],[Expected Delivery Date] from Customers C,Orders O where C.[Customer ID] = O.[Customer ID] and C.[Customer ID] = '" + id + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetNumberofOrdersForSelectedCustomer(string id)            //Gets Order Count for specific customer
        {
            string query = "Select Count([Order Number])  from Customers C,Orders O where C.[Customer ID] = O.[Customer ID] and C.[Customer ID] = '" + id + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetCustIDfromCustUn(string UN)            //Need to send the id of the customer to his form
        {
            string query = "select [Customer ID] from Customers where Username = '" + UN + "';";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateCustomerInfo(string Cust_ID, string COD, string City, string Address, string Ccode, string phone, string email)                        // Updates Cutomer Information
        {
            string query = "UPDATE Customers SET [Country Delivery Address] = '" + COD + "', [City Delivery Address] = '" + City + "', [District Delivery Address] = '" + Address + "' , [Country Code] = '" + Ccode + "' , [Phone Number] = '" + phone + "' , Email = '" + email + "' where [Customer ID] = '" + Cust_ID + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectAllProdcuts()
        {
            string query = "Select * from Products";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllProdcutsForDatagrid()
        {
            string query = "Select Name,Description,Price,[Amount in stock] as 'stock' from Products";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectMaxCustRequetID()            //Gets the max id of the last Request
        {
            string query = "Select Max([Request ID]) from CustomerRequests;";
            return dbMan.ExecuteReader(query);
        }
        public int InsertNewCustRequest(string R_ID,string type,string date,string details,string Resolved,string Emp_ID,string Cust_ID,string Order_ID)
        {
            string query = "insert into CustomerRequests VALUES ('" + R_ID + "','" + type + "','" + date + "','" + details + "','" + Resolved + "','" + Emp_ID + "','" + Cust_ID + "','" + Order_ID + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectProdcutFromID(string id)
        {
            string query = "Select * from Products where [Product ID] = '" + id + "';";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateProductAfterMakingOrder(string name,int amount)                        // Updates Prodcut when someone makes an order
        {
            string query = "UPDATE Products SET [Amount in stock] -= " + amount + " WHERE Name = '" + name + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectMaxOrderNum()
        {
            string query = "select MAX(Cast([Order Number] as INT)) from Orders;";
            return dbMan.ExecuteReader(query);
        }

        public int InsertNewOrder(string OrderNum,string Notes,string Date,string Status,string expected,string Cust_ID)
        {
            string query = "INSERT INTO Orders VALUES ('" + OrderNum + "','" + Notes + "','" + Date + "','" + Status + "','" + expected + "','" + Cust_ID + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Addemployee (string ph, string mail, string user, string pass, string cit, string dist, string coun,string fn, string mn, string ln, string ge, string spec, string sala)
        {// not finished
            string query = "Insert Into employee values";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable fillemployeebydept(int val)
        {
            string query = "Select [First name], [Employee ID] From employee where Department = '" + val.ToString() + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable retrieveemployeebyid(int idval)
        {
            string query = "Select [Employee ID] from employee where [Employee ID] = '" + idval.ToString() + "';";
            return dbMan.ExecuteReader(query);
        }

    }
}
