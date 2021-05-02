using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CompanyDB.Controller;

namespace CompanyDB
{
    public partial class Login : Form
    {
        Controller controller;

        public Login()
        {
            InitializeComponent();
            controller = Controller.getObject();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = username.Text.Trim();
            string password = pass.Text.Trim();
            PRIVILIAGE priv=controller.CheckPassword_Basic(userName, password);
            ProcessPriv(priv);
        }

        public void ProcessPriv(PRIVILIAGE result)
        {
            switch (result)
            {
                case PRIVILIAGE.NONE:
                    MessageBox.Show("Either username or password is wrong, please try again.");
                    break;
                
                case PRIVILIAGE.FULL_ACCESS:
                    new Provided_func_Full_access().Show();
                    this.Close();
                    break;
                
                case PRIVILIAGE.VIEW_ONLY:
                    new Provided_func_view_only().Show();
                    this.Close();
                    break;

            }
        }
    }
}
