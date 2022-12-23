using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class StoredProcedures
    {
        public static string Selecet_employees_by_username = "Select_employee_using_username";
        public static string select_department_By_ID = "Select_department_by_ID";
        public static string select_Branch_by_ID = "Select_Branch_by_ID";
        public static string Update_employee_data = "Update_employee_data";
        public static string Select_Projects_by_username_and_status_all = "Select_Projects_by_username_all";
        public static string Select_Projects_by_username_and_status_Done = "Select_Projects_by_username_done";
        public static string Select_Projects_by_username_and_status_not_Done = "Select_Projects_by_username_not_done";
        public static string Delete_products = "Delete_products";
        public static string Update_products = "Update_products";
        public static string Add_products = "Add_products";
        public static string Select_TotalCM_Unresolved = "Select_CustomerComplaints_UNResolved";
        public static string Select_all_rawmaterials = "Select_all_rawmaterials";
        public static string Select_product_By_name = "Select_product_By_name";
        public static string Insert_in_consumes = "Insert_in_consumes";
        public static string Select_TotalMR_Unresolved = "Select_ManagerRequests_UNResolved";
    }
}
