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
    public partial class updateEmp : Form
    {
        Controller controller;
        AppLayer appLayer;
        string currentSSN;
        List<string> superSsns;
        List<string> deptNums;
        public updateEmp(string ssn)
        {
            InitializeComponent();
            this.currentSSN = ssn;
            controller = Controller.getObject();
            appLayer = AppLayer.getObject();
            superSsns = new List<string>();
            deptNums = new List<string>();

            loadSuperVisorSsn();
            loadDepartmentNames();
            loadEmpy();
            

        }

        public void loadEmpy()
        {
            DataTable dt = controller.selectEmpAtSSN(currentSSN);
            textBox_name.Text = dt.Rows[0]["name"].ToString();
            textBox_Ssn.Text = dt.Rows[0]["SSN"].ToString();
            //birthDate.Value.ToShortDateString = dt.Rows[0]["Bdate"].ToString();
            //textBox_name.Text = dt.Rows[0]["Bdate"].ToString();
            string sex = dt.Rows[0]["Sex"].ToString();
            if (sex == "M")
                maleCheckBox.Checked = true;
            if (sex == "F")
                femaleCheckbox.Checked = true;

            textBox_salary.Text= dt.Rows[0]["Salary"].ToString();
            textBox_superviso_ssn.Text = dt.Rows[0]["Super_SSN"].ToString();
            textBox_depart_no.Text = dt.Rows[0]["Dno"].ToString();




        }

        public void loadSuperVisorSsn()
        {
            DataTable dt = controller.selectAllEmployeesSsnName();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                superSsnCombo.Items.Add(dt.Rows[i]["name"]);
                superSsns.Add(dt.Rows[i]["SSN"].ToString());

            }

        }

        public void loadDepartmentNames()
        {
            DataTable dt = controller.selectAllDepartmentNumsName();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                depNoCombo.Items.Add(dt.Rows[i]["Dname"]);
                deptNums.Add(dt.Rows[i]["Dnumber"].ToString());

            }

        }

        private void superSsnCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox_superviso_ssn.Text = superSsns[superSsnCombo.SelectedIndex];
        }

        private void depNoCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox_depart_no.Text = deptNums[depNoCombo.SelectedIndex];

        }

        private void maleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            femaleCheckbox.Checked = false;
        }

        private void femaleCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            maleCheckBox.Checked = false;

        }

        private void done_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                string ssn = textBox_Ssn.Text;
                string name = textBox_name.Text;
                string birthDateS = birthDate.Value.ToShortDateString();
                string sex = "M";
                string salary = textBox_salary.Text;
                string superSsn = textBox_superviso_ssn.Text;
                string Dno = textBox_depart_no.Text;
                if (appLayer.updateNewEmployee(ssn, name, birthDateS, sex, salary, superSsn, Dno,currentSSN) > 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There was a problem while insert the date, try again please");

                }
            }
        }


        public bool isDataValid()
        {

            if (textBox_name.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name not valid; it contais numbers");
                return false;
            }

            if (!textBox_Ssn.Text.All(char.IsDigit))
            {
                MessageBox.Show("SSN not valid; it contais other values than digits");
                return false;
            }
            if (!string.IsNullOrEmpty(textBox_superviso_ssn.Text) && !controller.isSSNExist(textBox_superviso_ssn.Text))
            {
                MessageBox.Show("Super SSN not valid; we dont' have any record with the same ssn provided.");
                return false;
            }

            if (!string.IsNullOrEmpty(textBox_depart_no.Text) && !controller.isDeptNumExist(textBox_depart_no.Text))
            {
                MessageBox.Show("department number is not valid; we dont' have any record with the same department number provided.");
                return false;
            }

            return true;

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
