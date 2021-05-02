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
    public partial class ViewAllEmps : Form
    {
        Controller controller;
        AppLayer appLayer;
        public ViewAllEmps()
        {
            InitializeComponent();
            controller = Controller.getObject();
            appLayer = AppLayer.getObject();

            loadDepartments();
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
                string deptChosen = depts.Items[deptChosenIndex].ToString();
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

        
    }
}
