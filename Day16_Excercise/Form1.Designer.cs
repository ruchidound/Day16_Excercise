
namespace Day16_Excercise
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.ComboGender = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtConfirmPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birth Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Confirm Password";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(382, 82);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(235, 30);
            this.TxtFirstName.TabIndex = 8;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(382, 136);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(235, 30);
            this.TxtLastName.TabIndex = 9;
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpBirthDate.Location = new System.Drawing.Point(382, 183);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(235, 30);
            this.DtpBirthDate.TabIndex = 10;
            // 
            // ComboGender
            // 
            this.ComboGender.FormattingEnabled = true;
            this.ComboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.ComboGender.Location = new System.Drawing.Point(382, 228);
            this.ComboGender.Name = "ComboGender";
            this.ComboGender.Size = new System.Drawing.Size(235, 33);
            this.ComboGender.TabIndex = 11;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(382, 286);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(241, 30);
            this.TxtEmail.TabIndex = 12;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(382, 335);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(241, 30);
            this.TxtPassword.TabIndex = 13;
            // 
            // TxtConfirmPass
            // 
            this.TxtConfirmPass.Location = new System.Drawing.Point(382, 392);
            this.TxtConfirmPass.Name = "TxtConfirmPass";
            this.TxtConfirmPass.PasswordChar = '*';
            this.TxtConfirmPass.Size = new System.Drawing.Size(241, 30);
            this.TxtConfirmPass.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Location = new System.Drawing.Point(253, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Red;
            this.BtnReset.Location = new System.Drawing.Point(459, 477);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(136, 45);
            this.BtnReset.TabIndex = 16;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(835, 558);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtConfirmPass);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.ComboGender);
            this.Controls.Add(this.DtpBirthDate);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.ComboBox ComboGender;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtConfirmPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnReset;
    }
}

