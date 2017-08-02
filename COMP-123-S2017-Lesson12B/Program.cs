using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 
 * Name - Gurmanpreet Kaur
 * Student_ID - 300933392
 * Description - Demo Application to showcase windows forms and UI Controls
 * Version: 0.1 - Project was Created 
 * */
namespace COMP_123_S2017_Lesson12B
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
            Application.Run(new DemoForm());
        }
    }
}
