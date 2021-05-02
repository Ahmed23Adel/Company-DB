
namespace CompanyDB
{
    partial class Provided_func_Full_access
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.button_viewEmps = new System.Windows.Forms.Button();
            this.buttonRetrieveProj = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveProjectsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.Location = new System.Drawing.Point(117, 50);
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Size = new System.Drawing.Size(143, 38);
            this.buttonAddProject.TabIndex = 0;
            this.buttonAddProject.Text = "Add project";
            this.buttonAddProject.UseVisualStyleBackColor = true;
            this.buttonAddProject.Click += new System.EventHandler(this.buttonAddProject_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(117, 234);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(143, 38);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // button_viewEmps
            // 
            this.button_viewEmps.Location = new System.Drawing.Point(117, 176);
            this.button_viewEmps.Name = "button_viewEmps";
            this.button_viewEmps.Size = new System.Drawing.Size(143, 38);
            this.button_viewEmps.TabIndex = 2;
            this.button_viewEmps.Text = "View All employees";
            this.button_viewEmps.UseVisualStyleBackColor = true;
            this.button_viewEmps.Click += new System.EventHandler(this.button_viewEmps_Click);
            // 
            // buttonRetrieveProj
            // 
            this.buttonRetrieveProj.Location = new System.Drawing.Point(117, 116);
            this.buttonRetrieveProj.Name = "buttonRetrieveProj";
            this.buttonRetrieveProj.Size = new System.Drawing.Size(143, 38);
            this.buttonRetrieveProj.TabIndex = 3;
            this.buttonRetrieveProj.Text = "Retrieve Projects";
            this.buttonRetrieveProj.UseVisualStyleBackColor = true;
            this.buttonRetrieveProj.Click += new System.EventHandler(this.buttonRetrieveProj_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(405, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem,
            this.retrieveProjectsToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.projectToolStripMenuItem.Text = "Menu";
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem1,
            this.retrieveProjectsToolStripMenuItem1});
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addProjectToolStripMenuItem.Text = "Projects";
            // 
            // addProjectToolStripMenuItem1
            // 
            this.addProjectToolStripMenuItem1.Name = "addProjectToolStripMenuItem1";
            this.addProjectToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.addProjectToolStripMenuItem1.Text = "Add project";
            this.addProjectToolStripMenuItem1.Click += new System.EventHandler(this.addProjectToolStripMenuItem1_Click);
            // 
            // retrieveProjectsToolStripMenuItem1
            // 
            this.retrieveProjectsToolStripMenuItem1.Name = "retrieveProjectsToolStripMenuItem1";
            this.retrieveProjectsToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.retrieveProjectsToolStripMenuItem1.Text = "Retrieve projects";
            this.retrieveProjectsToolStripMenuItem1.Click += new System.EventHandler(this.retrieveProjectsToolStripMenuItem1_Click);
            // 
            // retrieveProjectsToolStripMenuItem
            // 
            this.retrieveProjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.addEmployeeToolStripMenuItem1});
            this.retrieveProjectsToolStripMenuItem.Name = "retrieveProjectsToolStripMenuItem";
            this.retrieveProjectsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retrieveProjectsToolStripMenuItem.Text = "Employees";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addEmployeeToolStripMenuItem.Text = "View All employees";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem1
            // 
            this.addEmployeeToolStripMenuItem1.Name = "addEmployeeToolStripMenuItem1";
            this.addEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.addEmployeeToolStripMenuItem1.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem1.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem1_Click);
            // 
            // Provided_func_Full_access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 343);
            this.Controls.Add(this.buttonRetrieveProj);
            this.Controls.Add(this.button_viewEmps);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonAddProject);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Provided_func_Full_access";
            this.Text = "Provided functionalities";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button button_viewEmps;
        private System.Windows.Forms.Button buttonRetrieveProj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrieveProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem retrieveProjectsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem1;
    }
}