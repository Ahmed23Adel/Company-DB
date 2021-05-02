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
    public partial class retriveProjects : Form
    {
        AppLayer applayer;
        public retriveProjects()
        {
            InitializeComponent();
            applayer = AppLayer.getObject();


            loadDeptLocations();
        }

        public void loadDeptLocations()
        {
            DataTable dt = applayer.selectAllDeptLocations();
            comboDepts.DataSource = dt;
            comboDepts.DisplayMember = "Dlocation";
            comboDepts.ValueMember = "Dlocation";



        }

        private void comboDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = applayer.selectProjects(comboDepts.SelectedValue.ToString());
            projects.DataSource = dt;

        }
    }
}
