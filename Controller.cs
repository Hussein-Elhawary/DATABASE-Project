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
using System.Diagnostics;
using System.Xml.Linq;
using System.Collections;

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
        public DataTable Select_ManagerRequests_UNResolved()
        {
            string storedproc = StoredProcedures.Select_TotalMR_Unresolved;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(storedproc, Parameters);
        }
        public int closetherequest(string isid, int type, string emid)
        {
            string query = null;
            if (type == 1)
            {
                query = "Update ManagerRequests set Resolved = '" + true + "', [Resolved by] = '" + emid + "' where [Request ID] = '" + isid + "';";
            }
            else if (type == 2)
            {
                query = "Update CustomerRequests set Resolved = 'Yes', [IT ID] = '" + emid + "' where[Request ID] = '" + isid + "'  ";
            }
            return dbMan.ExecuteNonQuery(query);
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
            string query = "Select [Employee ID],phone,Email,[City address],[District address],[Country address],Gender,[Fixed salary],Nationality,Branch From Employee where  [First name] = '" + fname + "' and  [Middle name]='" + mname + "' and [Last name]='" + lname + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployeesBYid(int id)
        {
            string query = "Select [Employee ID],phone,Email,[City address],[District address],[Country address],Gender,[Fixed salary],Nationality,Branch From Employee where Department=" + id+"; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployeesBYidWithNames(int id)
        {
            string query = "Select [First name],[Middle name],[Last name],[Employee ID],phone,Email,[City address],[District address],[Country address],Gender,[Fixed salary],Nationality,Branch From Employee where Department=" + id + "; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDepartment(string user)
        {
            string query = "Select Department From Employee where Username = '" + user + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetProjectDetails(string user)
        {
            string query = "Select * From Projects where Name = '" + user + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectProjectName(int id)
        {
            string query = " Select A.Name From Projects as A,Control as B, Departement as C where A.[Project ID]=B.[Project ID] and C.[Departement ID] = B.[Department ID] and C.[Departement ID] =" + id + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectProjectid(string name)
        {
            string query = " Select [Project ID] From Projects where Name='" + name + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployeesWorkOnProject(int id, int Pid)
        {
            string query = "Select DISTINCT A.Name,B.[Employee ID],D.[Time spent] From Projects as A,Employee as B, Work_on as D, Control as E where B.Department=E.[Department ID] and D.[Employee ID]=B.[Employee ID] and D.[ Project ID]=A.[Project ID] and E.[Project ID]=a.[Project ID] and E.[Department ID]=" + id + " and A.[Project ID]=" + Pid + ";";
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
        public DataTable SelectManagerRequests(int id)
        {
            string query = "Select * From ManagerRequests where [Request By]="+id+";";
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
        public int UpdateSalary(int salary,string fname,string mname,string lname)
        {

            string query = "Update Employee Set [Fixed salary] = " + salary + " where [First name]='" + fname + "' and [Middle name]='" + mname + "' and [Last name]='" + lname + "';";
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

        public int AddNewBranch(int branchno, string country, string city, string district, string email, string phonenum, string type, int id, string date)
        {
            string query = "Insert into Branches VALUES(" + branchno + ",'" + country + "','" + city + "','" + district + "','" + email + "','" + phonenum + "','" + type + "'," + id + ",'" + date + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectMaxCutomerID()            //Gets the max id of the last registered customer
        {
            string query = "Select max(Cast([Customer ID] as int)) from Customers;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectBranches()
        {
            string query = "Select * From Branches ";
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

        public DataTable GetOrdersforSelectedCustomer(string id)            //Gets Orders for specific customer
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
            string query = "Select Max(Cast(([Request ID]) as int)) from CustomerRequests;";
            return dbMan.ExecuteReader(query);
        }
        public int InsertNewCustRequest(string R_ID, string type, string date, string details, string Resolved, string Emp_ID, string Cust_ID, string Order_ID)
        {
            string query = "insert into CustomerRequests VALUES ('" + R_ID + "','" + type + "','" + date + "','" + details + "','" + Resolved + "'," + Emp_ID + ",'" + Cust_ID + "','" + Order_ID + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertManagerRequest(int id, string type, string date, string details, string resolved,string employeeid, int managerid)
        {
            string query = "insert into ManagerRequests VALUES(" + id + ",'" + type + "','" + date + "','" + details + "','" + resolved + "'," + employeeid + " ," + managerid + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectProductFromID(string id)
        {
            string query = "Select * from Products where [Product ID] = '" + id + "';";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateProductAfterMakingOrder(string name, int amount)                        // Updates Product when someone makes an order
        {
            string query = "UPDATE Products SET [Amount in stock] -= " + amount + " WHERE Name = '" + name + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectMaxOrderNum()
        {
            string query = "select MAX(Cast([Order Number] as INT)) from Orders;";
            return dbMan.ExecuteReader(query);
        }

        public int InsertNewOrder(string OrderNum, string Notes, string Date, string Status, string expected, string Cust_ID,string TotalPrice,string TotalProduction)
        {
            string query = "INSERT INTO Orders VALUES ('" + OrderNum + "','" + Notes + "','" + Date + "','" + Status + "','" + expected + "','" + Cust_ID + "','" + TotalPrice + "','" + TotalProduction + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable fillemployeebydept(int val)
        {
            string query = "Select [First name], [Employee ID], Username, [Fixed Salary] From employee where Department = '" + val.ToString() + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable retrieveemployeebyid(int idval)
        {
            string query = "Select [Employee ID], Username from employee where [Employee ID] = '" + idval.ToString() + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetEmployeeIdFromUsername(string us)
        {
            string query = "Select [Employee ID] from Employee where [Username] = '" + us + "';";
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
        }public int Update_Raw_materials(string ID,  string Name , string Description,float Price, string weight_in_stock, string type)
        {
            string storedproc = StoredProcedures.Update_Raw_materials;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Name", Name);
            Parameters.Add("@Description", Description);
            Parameters.Add("@Price", Price);
            Parameters.Add("@weight_in_stock", weight_in_stock);
            Parameters.Add("@type", type);

            return dbMan.ExecuteNonQuery(storedproc, Parameters);
        }
        public DataTable Select_All_raw_materials_and_their_suppliers()
        {
            string storedproc = StoredProcedures.Select_All_raw_materials_and_their_suppliers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            return dbMan.ExecuteReader(storedproc, Parameters);
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

        public DataTable SelectMaxRequestID()
        {
            string query = "select MAX(Cast([Request ID] as INT)) from ManagerRequests;";
            return dbMan.ExecuteReader(query);
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
        public DataTable SelectProjectsByUsernameAndtatusNotdone(string username ,string status)
        {
            string storedproc = StoredProcedures.Select_Projects_by_username_and_status_not_Done;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@status", status);

            return dbMan.ExecuteReader(storedproc, Parameters);
        }
        public DataTable SelectProjectsByUsernameAndtatusall(string username)
        {
            string storedproc = StoredProcedures.Select_Projects_by_username_and_status_all;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);

            return dbMan.ExecuteReader(storedproc, Parameters);
        }
        public int DeleteProduct(string ID)
        {
            string storedproc = StoredProcedures.Delete_products;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            
            return dbMan.ExecuteNonQuery(storedproc, Parameters);
        }   
        public int Delete_Rawmaterial(string ID)
        {
            string storedproc = StoredProcedures.Delete_Rawmaterial;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            
            return dbMan.ExecuteNonQuery(storedproc, Parameters);
        }
        public int UpdateProduct(string ID, string Name, string discription, float price, int amountinstock, int production_cost)
        {
            string storedproc = StoredProcedures.Update_products;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@Name", Name);
            Parameters.Add("@Description", discription);
            Parameters.Add("@Price", price);
            Parameters.Add("@Amount_in_stock", amountinstock);
            Parameters.Add("@Production_Cost", production_cost);
            return dbMan.ExecuteNonQuery(storedproc, Parameters);
        }
        public int Add_products(string Name, string discription, float price, int amountinstock, int production_cost)
        {
            string storedproc = StoredProcedures.Add_products;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            Parameters.Add("@Description", discription);
            Parameters.Add("@Price", price);
            Parameters.Add("@Amount_in_stock", amountinstock);
            Parameters.Add("@Production_Cost", production_cost);
            return dbMan.ExecuteNonQuery(storedproc, Parameters);
        }     
        public int Add_Raw_material(string Name, string discription, float price, int weight, string supID,string type)
        {
            string storedproc = StoredProcedures.Add_Raw_material;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            Parameters.Add("@type", type);
            Parameters.Add("@supID", supID);
            Parameters.Add("@Price", price);
            Parameters.Add("@wight", weight);
            Parameters.Add("@descrition", discription);
            
            
            return dbMan.ExecuteNonQuery(storedproc, Parameters);
        }

        public DataTable Select_CustomerComplaints_UNResolved()
        {
            string storedproc = StoredProcedures.Select_TotalCM_Unresolved;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            return dbMan.ExecuteReader(storedproc, Parameters);
        }    
        public DataTable Select_all_rawmaterials()
        {
            string storedproc = StoredProcedures.Select_all_rawmaterials;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            return dbMan.ExecuteReader(storedproc, Parameters);
        }    
        public DataTable Select_all_Suppliers()
        {
            string storedproc = StoredProcedures.Select_all_Suppliers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            return dbMan.ExecuteReader(storedproc, Parameters);
        }    
        public DataTable Select_product_By_name(string name)
        {
            string storedproc = StoredProcedures.Select_product_By_name;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            
            return dbMan.ExecuteReader(storedproc, Parameters);
        } 
        public int Insert_in_consumes(string Productid,string rawmaterialsID)
        {
            string storedproc = StoredProcedures.Insert_in_consumes;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ProID", Productid);
            Parameters.Add("@RMID", rawmaterialsID);
            
            return dbMan.ExecuteNonQuery(storedproc, Parameters);
        }

        public DataTable getordersnew (string date1, string date2)
        {
            string query = "Select * From Orders where [Order Date] >= '" + date1 + "' and [Order Date] <= '" + date2 + "'";
            return dbMan.ExecuteReader(query);
        }

        public int addnewEmployee (string id, string phone, string email, string user, string pass, string city, string district, string country,string f, string m, string l, string g, string spe, string fix, string bd, string nation, string extne, string dept, string bran)
        {
            string query = null;
            if (g == "M")
            {
                query = "Insert into Employee Values ('" + id + "','" + phone + "','" + email + "','" + user + "','" + pass + "','" + city + "'," +
                    "'" + district + "','" + country + "','" + f + "','" + m + "','" + l + "','" + true + "','" + spe + "','" + fix + "', 0 ,'" + bd + "'," +
                    "'" + nation + "','" + extne + "'," + dept + "," + bran + ")";
            }
            else if ( g == "F")
            {
                query = "Insert into Employee Values ('" + id + "','" + phone + "','" + email + "','" + user + "','" + pass + "','" + city + "'," +
                     "'" + district + "','" + country + "','" + f + "','" + m + "','" + l + "','" + false + "','" + spe + "','" + fix + "', 0 ,'" + bd + "'," +
                     "'" + nation + "','" + extne + "'," + dept + "," + bran + ")";
            }
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable fillbranch()
        {
            string query = "Select * From Branches;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewOrderDetails(string order_num)
        {
            string query = "SELECT P.Name,P.Price,C.Quantity as 'Amount',P.Price * C.Quantity as 'Total' from [contains] C,Products P WHERE C.[Product ID] = P.[Product ID] and C.[Order ID] = '" + order_num + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable CustomerViewRequest(string cust_ID)
        {
            string query = "select [Request Type],[Date Issued] as 'Date Issued',Details,Resolved,R.[request on] as 'Order' from CustomerRequests R,Customers C where C.[Customer ID] = R.[Request from] and [Request from] = '" + cust_ID + "';";
            return dbMan.ExecuteReader(query);
        }

        public int updatextension (string iddd, string ext)
        {
            string query = "Update Employee Set Extension = '" + ext + "' where [Employee ID] = '" + iddd + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int changepassbyit(string passs, string iddd)
        {
            string query = "Update Employee Set Password = '" + passs + "' where [Employee ID] = '" + iddd + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateuserma(string usern, string idddd)
        {
            string query = "Update Employee Set Username = '" + usern +"' Where [Employee ID] = '" + idddd + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateuserem(string usern, string idddd)
        {
            string query = "Update Employee Set Username = '" + usern + "' Where [Employee ID] = '" + idddd + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectMaxEmployeeID()
        {
            string query = "select max(Cast(([Employee ID]) as int)) from Employee";
            return dbMan.ExecuteReader(query);
        }

        public int Editsalary(string sala, string id)
        {
            string query = "Update Employee Set [Fixed salary] = '" + sala + "' where [Employee ID] = '" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updatepending (string date)
        {
            string query = "Update Orders set [Order Status] = 'delivered' where [Expected Delivery Date] <= '" + date + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable groupproducts()
        {
            string query = "Select p.Name, Sum([Quantity]) as Quantity From[contains] c,Products p where p.[Product ID] = c.[Product ID] Group BY p.Name";
            return dbMan.ExecuteReader(query);
        }

        public DataTable grouporders()
        {
            string query = "Select [Country Delivery Address] as [Country],Count(o.[Order Number]) as [Number of Orders] from Orders o,Customers c where o.[Customer ID] = c.[Customer ID] GROUP BY [Country Delivery Address];";
            return dbMan.ExecuteReader(query);
        }

        public DataTable groupRawMaterials()
        {
            string query = "select r.Name,Count(c.[Raw material ID]) as [Consumed Amount] from [Raw Materials] r,Consume c where r.[Material ID] = c.[Raw material ID] group by r.Name;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable groupsuppliers()
        {
            string query = "select a.Name,Count(b.[Supplied by]) as [Number of Materials] from [Raw Materials] b,Suppliers a where b.[Supplied by]=a.[Supplier ID] group by a.Name;";
            return dbMan.ExecuteReader(query);
        }

    }
}
