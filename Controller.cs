using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Reflection;

namespace DBapplication
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

        public int InsertBook(int type,int AuthorID,string Title)
        {
            string query = "INSERT INTO Novel VALUES ('"+ Title + "'," + AuthorID + ","+ type+ ")";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectAllBooks(/**ADD PARAMS HERE IF NEEDED**/)
        {
            string query = "select N.Title ,A.name ,T.type FROM Novel N,Author A,Type T WHERE N.Author_id=A.id and N.type_id=T.id";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAuthorsOfType(string type)
        {
            string query = "select DISTINCT A.id,A.name FROM Author A,Novel N,TYPE T WHERE A.id=N.Author_id and T.id=N.Type_id and T.type='" + type+"'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAuthors(/**ADD PARAMS HERE IF NEEDED**/)
        {
            string query = "select id,name FROM Author";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectTypes(/**ADD PARAMS HERE IF NEEDED**/)
        {
            string query = "select id,type FROM Type";
            return dbMan.ExecuteReader(query);
        }

    }
}
