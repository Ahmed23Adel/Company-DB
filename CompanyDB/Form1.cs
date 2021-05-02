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
    public partial class Form1 : Form
    {
        Controller controller;
        AppLayer appLayer;
        public Form1()
        {
            InitializeComponent();
            controller = Controller.getObject();
            appLayer = AppLayer.getObject();

            loadDepartments();
        }

        private void Add_employee(object sender, EventArgs e)
        {
            AddingEmployee addingEmployee = new AddingEmployee();
            addingEmployee.Show();
        }

        
        public void loadDepartments()
        {
            DataTable dt = controller.selectAllDepartmentNames();
            depts.Items.Add("All");
            for (int i = 0; i < dt.Rows.Count; i++)
                depts.Items.Add(dt.Rows[i]["Dname"]);

            depts.SelectedIndex = 0;
        }

        private void depts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                int deptChosenIndex = depts.SelectedIndex;
                string deptChosen= depts.Items[deptChosenIndex].ToString();
                loadEmployeesInDepartment(deptChosen);
            }
            catch (Exception e2)
            {
            }

            
           
        }
        public void loadEmployeesInDepartment(string deptChosen)
        {
            emps.DataSource = null;
            DataTable dt = appLayer.selectAllEmployeesInDept(deptChosen);
            emps.Rows.Clear();
            emps.DataSource = dt;
            emps.Columns["SSN"].Visible = false;

        }

        private void emps_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string ssn = emps.Rows[e.RowIndex].Cells["SSN"].Value.ToString();
            updateEmp updateEmp = new updateEmp(ssn);
            updateEmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(projeName.Text))
            {
                string projectName = projeName.Text;
                string num = controller.getNumberInProject(projectName).ToString();
                number.Text = num;

            }
        }
    }

    
}
