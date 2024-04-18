using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIHR_TASK_LAST;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

using System.Windows.Forms;


namespace FIHR_TASK_LAST

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
            Application.Run(new Form1());
        }
    }
}