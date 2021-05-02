
namespace CompanyDB
{
    partial class updateEmp
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
            this.cancel = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_depart_no = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_superviso_ssn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Ssn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.maleCheckBox = new System.Windows.Forms.CheckBox();
            this.femaleCheckbox = new System.Windows.Forms.CheckBox();
            this.depNoCombo = new System.Windows.Forms.ComboBox();
            this.superSsnCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel.Location = new System.Drawing.Point(508, 384);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(109, 33);
            this.cancel.TabIndex = 39;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.done.Location = new System.Drawing.Point(645, 372);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(149, 57);
            this.done.TabIndex = 38;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Or choose from";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 26);
            this.label9.TabIndex = 35;
            this.label9.Text = "Department \r\nNumber";
            // 
            // textBox_depart_no
            // 
            this.textBox_depart_no.Location = new System.Drawing.Point(73, 332);
            this.textBox_depart_no.Multiline = true;
            this.textBox_depart_no.Name = "textBox_depart_no";
            this.textBox_depart_no.Size = new System.Drawing.Size(186, 52);
            this.textBox_depart_no.TabIndex = 34;
            this.textBox_depart_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Or choose from";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 26);
            this.label6.TabIndex = 31;
            this.label6.Text = "Supervisor \r\n ssn";
            // 
            // textBox_superviso_ssn
            // 
            this.textBox_superviso_ssn.Location = new System.Drawing.Point(73, 259);
            this.textBox_superviso_ssn.Multiline = true;
            this.textBox_superviso_ssn.Name = "textBox_superviso_ssn";
            this.textBox_superviso_ssn.Size = new System.Drawing.Size(186, 52);
            this.textBox_superviso_ssn.TabIndex = 30;
            this.textBox_superviso_ssn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Salary";
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(73, 171);
            this.textBox_salary.Multiline = true;
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(186, 52);
            this.textBox_salary.TabIndex = 27;
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(73, 106);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(200, 20);
            this.birthDate.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Birth date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "SSN";
            // 
            // textBox_Ssn
            // 
            this.textBox_Ssn.Location = new System.Drawing.Point(468, 21);
            this.textBox_Ssn.Multiline = true;
            this.textBox_Ssn.Name = "textBox_Ssn";
            this.textBox_Ssn.Size = new System.Drawing.Size(186, 52);
            this.textBox_Ssn.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(73, 21);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(186, 52);
            this.textBox_name.TabIndex = 21;
            // 
            // maleCheckBox
            // 
            this.maleCheckBox.AutoSize = true;
            this.maleCheckBox.Location = new System.Drawing.Point(362, 135);
            this.maleCheckBox.Name = "maleCheckBox";
            this.maleCheckBox.Size = new System.Drawing.Size(49, 17);
            this.maleCheckBox.TabIndex = 41;
            this.maleCheckBox.Text = "Male";
            this.maleCheckBox.UseVisualStyleBackColor = true;
            this.maleCheckBox.CheckedChanged += new System.EventHandler(this.maleCheckBox_CheckedChanged);
            // 
            // femaleCheckbox
            // 
            this.femaleCheckbox.AutoSize = true;
            this.femaleCheckbox.Location = new System.Drawing.Point(568, 135);
            this.femaleCheckbox.Name = "femaleCheckbox";
            this.femaleCheckbox.Size = new System.Drawing.Size(60, 17);
            this.femaleCheckbox.TabIndex = 42;
            this.femaleCheckbox.Text = "Female";
            this.femaleCheckbox.UseVisualStyleBackColor = true;
            this.femaleCheckbox.CheckedChanged += new System.EventHandler(this.femaleCheckbox_CheckedChanged);
            // 
            // depNoCombo
            // 
            this.depNoCombo.FormattingEnabled = true;
            this.depNoCombo.Location = new System.Drawing.Point(426, 335);
            this.depNoCombo.Name = "depNoCombo";
            this.depNoCombo.Size = new System.Drawing.Size(121, 21);
            this.depNoCombo.TabIndex = 44;
            this.depNoCombo.SelectedIndexChanged += new System.EventHandler(this.depNoCombo_SelectionChangeCommitted);
            // 
            // superSsnCombo
            // 
            this.superSsnCombo.FormattingEnabled = true;
            this.superSsnCombo.Location = new System.Drawing.Point(426, 262);
            this.superSsnCombo.Name = "superSsnCombo";
            this.superSsnCombo.Size = new System.Drawing.Size(121, 21);
            this.superSsnCombo.TabIndex = 43;
            this.superSsnCombo.SelectionChangeCommitted += new System.EventHandler(this.superSsnCombo_SelectionChangeCommitted);
            // 
            // updateEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depNoCombo);
            this.Controls.Add(this.superSsnCombo);
            this.Controls.Add(this.femaleCheckbox);
            this.Controls.Add(this.maleCheckBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.done);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_depart_no);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_superviso_ssn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_salary);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Ssn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Name = "updateEmp";
            this.Text = "updateEmp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_depart_no;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_superviso_ssn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Ssn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.CheckBox maleCheckBox;
        private System.Windows.Forms.CheckBox femaleCheckbox;
        private System.Windows.Forms.ComboBox depNoCombo;
        private System.Windows.Forms.ComboBox superSsnCombo;
    }
}