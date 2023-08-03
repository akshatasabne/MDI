using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.MdiParent = this;//child form
            employee.Show();
        }

        private void timeSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeSheet timeSheet = new TimeSheet();
            timeSheet.MdiParent=this;//this-refernce of current form
            timeSheet.Show();
        }
    }
}
