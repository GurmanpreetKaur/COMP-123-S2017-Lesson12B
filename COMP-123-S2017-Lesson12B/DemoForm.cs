using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the HelloButton Event handler for the click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void HelloButton_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text.Length > 0)
            {
                HelloLabel.Text = "Hello, " + NameTextBox.Text;
            }
            else
            {
                HelloLabel.Text = "Hello, World!!";
            }
        }

    }
}
