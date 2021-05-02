
namespace CompanyDB
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddEmp = new System.Windows.Forms.Button();
            this.emps = new MetroFramework.Controls.MetroGrid();
            this.depts = new System.Windows.Forms.ComboBox();
            this.projeName = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emps)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEmp
            // 
            this.AddEmp.Location = new System.Drawing.Point(12, 12);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(171, 66);
            this.AddEmp.TabIndex = 0;
            this.AddEmp.Text = "Add new employee";
            this.AddEmp.UseVisualStyleBackColor = true;
            this.AddEmp.Click += new System.EventHandler(this.Add_employee);
            // 
            // emps
            // 
            this.emps.AllowUserToAddRows = false;
            this.emps.AllowUserToDeleteRows = false;
            this.emps.AllowUserToResizeRows = false;
            this.emps.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.emps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emps.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.emps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.emps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.emps.DefaultCellStyle = dataGridViewCellStyle2;
            this.emps.EnableHeadersVisualStyles = false;
            this.emps.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emps.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.emps.Location = new System.Drawing.Point(34, 222);
            this.emps.Name = "emps";
            this.emps.ReadOnly = true;
            this.emps.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emps.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.emps.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.emps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.emps.Size = new System.Drawing.Size(723, 178);
            this.emps.TabIndex = 1;
            this.emps.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emps_CellDoubleClick);
            // 
            // depts
            // 
            this.depts.FormattingEnabled = true;
            this.depts.Location = new System.Drawing.Point(34, 177);
            this.depts.Name = "depts";
            this.depts.Size = new System.Drawing.Size(121, 21);
            this.depts.TabIndex = 2;
            this.depts.SelectedIndexChanged += new System.EventHandler(this.depts_SelectedIndexChanged);
            // 
            // projeName
            // 
            this.projeName.Location = new System.Drawing.Point(34, 103);
            this.projeName.Name = "projeName";
            this.projeName.Size = new System.Drawing.Size(121, 20);
            this.projeName.TabIndex = 3;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(496, 102);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get Number who are working on project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.projeName);
            this.Controls.Add(this.depts);
            this.Controls.Add(this.emps);
            this.Controls.Add(this.AddEmp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.emps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEmp;
        private MetroFramework.Controls.MetroGrid emps;
        private System.Windows.Forms.ComboBox depts;
        private System.Windows.Forms.TextBox projeName;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button button1;
    }
}

