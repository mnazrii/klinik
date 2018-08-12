using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//using DocumentFormat.OpenXml.Packaging;
using System.IO;

namespace Klinik3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Session.Current_QID = "1";
            Session.Username = "Nazri";
            Session.Fullname = "Mohd Nazri";
            //Application.Run(new VisitationHistoryForm());

            //Application.Run(new TreatmentForm());

            Application.Run(new LoginForm());
            //Application.Run(new MasterRecForm());
            //Application.Run(new QueueForm());
            //Session.Username = "admin";
            //var chg = new ChargeForm();
            //chg.qid = Session.Current_QID;
            //Application.Run(chg);

            //Application.Run(new Sales_Report());
            //Application.Run(new MasterRecForm());


            //Test.TestOXML();
        }
    }
}
