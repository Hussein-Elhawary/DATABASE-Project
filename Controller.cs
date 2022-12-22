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
using System.ComponentModel;

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
        public DataTable SelectFirstName(string user)
        {
            string query = "Select [First name] From Employee where Username = '" + user + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployeesbyName(string fname,string mname,string lname)
        {
            string query = "Select * From Employee where  [First name] = '" + fname + "' and  [Middle name]='" + mname + "' and [Last name]='" + lname + "';";
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
        public DataTable SelectEmployeeMiddleNameFromFirstName(string fname)
        {
            string query = "Select DISTINCT [Middle name] From Employee where [First name] = '" + fname + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployeeLastName(string fname,string mname)
        {
            string query = "Select DISTINCT [Last name] From Employee where [First name] = '" + fname + "' and  [Middle name]='" + mname + "';";
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

        public DataTable viewmanagersrequests(string date1,string date2)
        {
            string query = "Select * From ManagerRequests where [Date Issued] >= '" + date1 + "' and " +
                "[Date Issued] <= '" + date2 + "' and [Resolved] = '" + false + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable viewcustomersrequests(string date1, string date2)
        {
            string query = "Select * From CustomerRequests where [Date Issued] >= '" + date1 + "' and " +
                "[Date Issued] <= '" + date2 + "' and [Resolved] = 'No';";
            return dbMan.ExecuteReader(query);
        }
       
        public DataTable forgotpassword(string user, string phone, char t)
        {
            string query = null;
            if (t == 'c' || t == 'C')
            {
                query = "Select * From Customers where Username = '" + user + "' and [Phone Number] ='" + phone + "';";
            }
            else if (t == 'e' || t == 'E')
            {
                query = "Select * From Employee where Username = '" + user + "' and Phone ='" + phone + "';";
            }
            return dbMan.ExecuteReader(query);
        }

        public int changepasswordem(string user1, string phone1, string pass1, char t)
        {
            string query = null;
            if (t == 'c' || t == 'C')
            {
                query = "Update Customers Set Password = '" + pass1 + "' where Username = '" + user1 + "' and " +
                    " [Phone Number] ='" + phone1 + "';";
            }
            else if (t == 'e' || t == 'E')
            {
                query = "Update Employee Set Password = '" + pass1 + "' where Username = '" + user1 + "' and " +
                    " Phone ='" + phone1 + "';";
            }
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable fillemployeesnames()
        {
            string query = "Select * From Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable viewinsurance (string type, string username)
        {
            string query = "Select [Hospital/Clinic/Phamacy Name], [District Address], [Phone Number] From Insurance where " +
                "[Service Type] = '" + type + "' and [City Address] = (Select [City address] From Employee where Username = '" + username + "') ;";
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

        public DataTable retrievemanager(string deptid)
        {
            string query = "Select * From Employee where[Employee ID] = (Select [Manager ID] from Departement where [Departement ID] = '" + deptid + "' )";
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
        public int InsertNewCustRequest(string R_ID, string type, string date, string details, string Resolved, string Emp_ID, string Cust_ID, string Order_ID)
        {
            string query = "insert into CustomerRequests VALUES ('" + R_ID + "','" + type + "','" + date + "','" + details + "','" + Resolved + "','" + Emp_ID + "','" + Cust_ID + "','" + Order_ID + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectProdcutFromID(string id)
        {
            string query = "Select * from Products where [Product ID] = '" + id + "';";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateProductAfterMakingOrder(string name, int amount)                        // Updates Prodcut when someone makes an order
        {
            string query = "UPDATE Products SET [Amount in stock] -= " + amount + " WHERE Name = '" + name + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectMaxOrderNum()
        {
            string query = "select MAX(Cast([Order Number] as INT)) from Orders;";
            return dbMan.ExecuteReader(query);
        }

        public int InsertNewOrder(string OrderNum, string Notes, string Date, string Status, string expected, string Cust_ID)
        {
            string query = "INSERT INTO Orders VALUES ('" + OrderNum + "','" + Notes + "','" + Date + "','" + Status + "','" + expected + "','" + Cust_ID + "');";
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

        public int deleteemployee(string id)
        {
            string query = "Delete From employee where [Employee ID] = '" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectCPassFromCUsername(string UN)
        {
            string query = "Select Password from Customers where Username = '" + UN + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable retrieveemployeebyusername(string idval)
        {
            string storedproc = StoredProcedures.Selecet_employees_by_username;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", idval);
            return dbMan.ExecuteReader(storedproc, Parameters);
        }
        public DataTable SelectDepartmentByID(string ID)
        {
            string storedproc = StoredProcedures.select_department_By_ID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteReader(storedproc, Parameters);
        }
        public DataTable SelectBranchByID(string ID)
        {
            string storedproc = StoredProcedures.select_Branch_by_ID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteReader(storedproc, Parameters);
        }
        public int UpdateEmployeeInfo(string username,  string Country , string City, string District,string Phone)
        {
            string storedproc = StoredProcedures.Update_employee_data;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            Parameters.Add("@Phone", Phone);
            Parameters.Add("@Country", Country);
            Parameters.Add("@City", City);
            Parameters.Add("@District", District);
            return dbMan.ExecuteNonQuery(storedproc, Parameters);
        }


        public int updatemanager(string midn, string deptid, string date)
        {
            string query = "Update Departement Set [Manager ID] = '" + midn + "', [Start Date] = '" + date + "' where [Departement ID] = '" + deptid + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable checkmanager(string managerid)
        {
            string query = "Select * From Departement where [Manager ID] = '" + managerid + "';";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateCustomerPassword(string Cust_ID, string newPass)
        {
            string query = "UPDATE Customers SET Password = '" + newPass + "' where [Customer ID] = '" + Cust_ID + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertContains(string ordernum,string productid,string quantity)
        {
            string query = "INSERT INTO[contains] VALUES('" + ordernum + "','" + productid + "','" + quantity + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetProductIDFromName(string name)
        {
            string query = "SELECT [Product ID] FROM Products WHERE Name = '" + name + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectProjectsByUsernameAndtatusdone(string username, string status)
        {
            string storedproc = StoredProcedures.Select_Projects_by_username_and_status_Done;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@status", status);

            return dbMan.ExecuteReader(storedproc, Parameters);
        }
        public DataTable SelectProjectsByUsernameAndtatusNotdone(string username)
        {
            string storedproc = StoredProcedures.Select_Projects_by_username_and_status_not_Done;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);

            return dbMan.ExecuteReader(storedproc, Parameters);
        }
        public DataTable SelectProjectsByUsernameAndtatusall(string username)
        {
            string storedproc = StoredProcedures.Select_Projects_by_username_and_status_all;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);

            return dbMan.ExecuteReader(storedproc, Parameters);
        }

        public DataTable Select_CustomerComplaints_UNResolved()
        {
            string storedproc = StoredProcedures.Select_TotalCM_Unresolved;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
          
            return dbMan.ExecuteReader(storedproc, Parameters);
        }
    }
}
