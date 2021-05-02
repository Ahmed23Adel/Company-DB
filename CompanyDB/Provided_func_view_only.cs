using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyDB
{
    public partial class Provided_func_view_only : Form
    {
        public Provided_func_view_only()
        {
            InitializeComponent();
        }

        private void addProjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AddProject().Show();
        }

        private void buttonAddProject_Click(object sender, EventArgs e)
        {
            new AddProject().Show();

        }

        private void buttonRetrieveProj_Click(object sender, EventArgs e)
        {
            new retriveProjects().Show();
        }

        private void retrieveProjectsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new retriveProjects().Show();
        }

        private void button_viewEmps_Click(object sender, EventArgs e)
        {
            new ViewAllEmps().Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewAllEmps().Show();

        }

        private void addEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddingEmployee addingEmployee = new AddingEmployee();
            addingEmployee.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
