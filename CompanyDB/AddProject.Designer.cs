
namespace CompanyDB
{
    partial class AddProject
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
            this.projName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.projLoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.depNoCombo = new System.Windows.Forms.ComboBox();
            this.addProjects = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projName
            // 
            this.projName.Location = new System.Drawing.Point(143, 49);
            this.projName.Name = "projName";
            this.projName.Size = new System.Drawing.Size(155, 20);
            this.projName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Number";
            // 
            // projNum
            // 
            this.projNum.Location = new System.Drawing.Point(143, 118);
            this.projNum.Name = "projNum";
            this.projNum.Size = new System.Drawing.Size(155, 20);
            this.projNum.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Project Location";
            // 
            // projLoc
            // 
            this.projLoc.Location = new System.Drawing.Point(143, 183);
            this.projLoc.Name = "projLoc";
            this.projLoc.Size = new System.Drawing.Size(155, 20);
            this.projLoc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Department";
            // 
            // depNoCombo
            // 
            this.depNoCombo.FormattingEnabled = true;
            this.depNoCombo.Location = new System.Drawing.Point(143, 263);
            this.depNoCombo.Name = "depNoCombo";
            this.depNoCombo.Size = new System.Drawing.Size(155, 21);
            this.depNoCombo.TabIndex = 7;
            // 
            // addProjects
            // 
            this.addProjects.Location = new System.Drawing.Point(95, 324);
            this.addProjects.Name = "addProjects";
            this.addProjects.Size = new System.Drawing.Size(90, 36);
            this.addProjects.TabIndex = 8;
            this.addProjects.Text = "Add project";
            this.addProjects.UseVisualStyleBackColor = true;
            this.addProjects.Click += new System.EventHandler(this.addProjects_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(112, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "*";
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 398);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addProjects);
            this.Controls.Add(this.depNoCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.projNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projName);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox projName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox projNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox depNoCombo;
        private System.Windows.Forms.Button addProjects;
        private System.Windows.Forms.Label label5;
    }
}