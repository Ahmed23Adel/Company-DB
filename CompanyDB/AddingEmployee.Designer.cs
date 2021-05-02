
namespace CompanyDB
{
    partial class AddingEmployee
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Ssn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_superviso_ssn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.superSsnCombo = new System.Windows.Forms.ComboBox();
            this.depNoCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_depart_no = new System.Windows.Forms.TextBox();
            this.done = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(67, 30);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(186, 52);
            this.textBox_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SSN";
            // 
            // textBox_Ssn
            // 
            this.textBox_Ssn.Location = new System.Drawing.Point(462, 30);
            this.textBox_Ssn.Multiline = true;
            this.textBox_Ssn.Name = "textBox_Ssn";
            this.textBox_Ssn.Size = new System.Drawing.Size(186, 52);
            this.textBox_Ssn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birth date";
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(67, 115);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(200, 20);
            this.birthDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary";
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(67, 180);
            this.textBox_salary.Multiline = true;
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(186, 52);
            this.textBox_salary.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Supervisor \r\n ssn";
            // 
            // textBox_superviso_ssn
            // 
            this.textBox_superviso_ssn.Location = new System.Drawing.Point(67, 268);
            this.textBox_superviso_ssn.Multiline = true;
            this.textBox_superviso_ssn.Name = "textBox_superviso_ssn";
            this.textBox_superviso_ssn.Size = new System.Drawing.Size(186, 52);
            this.textBox_superviso_ssn.TabIndex = 10;
            this.textBox_superviso_ssn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Or choose from";
            // 
            // superSsnCombo
            // 
            this.superSsnCombo.FormattingEnabled = true;
            this.superSsnCombo.Location = new System.Drawing.Point(399, 276);
            this.superSsnCombo.Name = "superSsnCombo";
            this.superSsnCombo.Size = new System.Drawing.Size(121, 21);
            this.superSsnCombo.TabIndex = 14;
            this.superSsnCombo.SelectionChangeCommitted += new System.EventHandler(this.superSsnCombo_SelectionChangeCommitted);
            // 
            // depNoCombo
            // 
            this.depNoCombo.FormattingEnabled = true;
            this.depNoCombo.Location = new System.Drawing.Point(399, 349);
            this.depNoCombo.Name = "depNoCombo";
            this.depNoCombo.Size = new System.Drawing.Size(121, 21);
            this.depNoCombo.TabIndex = 18;
            this.depNoCombo.SelectionChangeCommitted += new System.EventHandler(this.depNoCombo_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Or choose from";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Department \r\nNumber";
            // 
            // textBox_depart_no
            // 
            this.textBox_depart_no.Location = new System.Drawing.Point(67, 341);
            this.textBox_depart_no.Multiline = true;
            this.textBox_depart_no.Name = "textBox_depart_no";
            this.textBox_depart_no.Size = new System.Drawing.Size(186, 52);
            this.textBox_depart_no.TabIndex = 15;
            this.textBox_depart_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // done
            // 
            this.done.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.done.Location = new System.Drawing.Point(639, 381);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(149, 57);
            this.done.TabIndex = 19;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = false;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel.Location = new System.Drawing.Point(502, 393);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(109, 33);
            this.cancel.TabIndex = 20;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddingEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.done);
            this.Controls.Add(this.depNoCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_depart_no);
            this.Controls.Add(this.superSsnCombo);
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
            this.Name = "AddingEmployee";
            this.Text = "AddingEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Ssn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_superviso_ssn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox superSsnCombo;
        private System.Windows.Forms.ComboBox depNoCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_depart_no;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button cancel;
    }
}