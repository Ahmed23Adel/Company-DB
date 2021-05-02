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
  
    public partial class AddProject : Form
    {
        AppLayer  appLayer;

        public AddProject()
        {
            InitializeComponent();
            appLayer = AppLayer.getObject();

            loadDepartmentNames();
        }

        public void loadDepartmentNames()
        {
            DataTable dt = appLayer.selectAllDepartmentNumsName();
            depNoCombo.DataSource = dt;
            depNoCombo.DisplayMember = "Dname";
            depNoCombo.ValueMember = "Dnumber";


        }

        private void addProjects_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                if (appLayer.insertProject(
                    projName.Text,
                    projNum.Text,
                    projLoc.Text,
                    depNoCombo.SelectedValue.ToString()) > 0)
                {
                    MessageBox.Show("Succfullay added");
                    this.Close();

                }


            }
        }

        public bool isDataValid()
        {
            if (string.IsNullOrEmpty(projNum.Text))
            {
                MessageBox.Show("Project number is empty, please fill it and try again.");
                return false;
            }
            else 
            {
                if (appLayer.isProjNumExist(projNum.Text))
                {
                    MessageBox.Show("Project number exist in our database, please change it.");
                    return false;
                }
                return true;
            }



        }
    }
}
