using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
        //TODO: functions in the requirement
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
