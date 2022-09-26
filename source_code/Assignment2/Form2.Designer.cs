namespace Assignment2
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_username_warning = new System.Windows.Forms.Label();
            this.label_passwordIncorret = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2_cancel = new System.Windows.Forms.Button();
            this.button1_submit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_password_secondAttempt = new System.Windows.Forms.TextBox();
            this.label1_reenterPassword = new System.Windows.Forms.Label();
            this.textBox2_password_firstAttempt = new System.Windows.Forms.TextBox();
            this.textBox1_username = new System.Windows.Forms.TextBox();
            this.label1_password = new System.Windows.Forms.Label();
            this.label1_username = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_username_warning);
            this.groupBox1.Controls.Add(this.label_passwordIncorret);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2_cancel);
            this.groupBox1.Controls.Add(this.button1_submit);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1_lastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1_firstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1_password_secondAttempt);
            this.groupBox1.Controls.Add(this.label1_reenterPassword);
            this.groupBox1.Controls.Add(this.textBox2_password_firstAttempt);
            this.groupBox1.Controls.Add(this.textBox1_username);
            this.groupBox1.Controls.Add(this.label1_password);
            this.groupBox1.Controls.Add(this.label1_username);
            this.groupBox1.Location = new System.Drawing.Point(51, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 868);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label_username_warning
            // 
            this.label_username_warning.AutoSize = true;
            this.label_username_warning.ForeColor = System.Drawing.Color.Red;
            this.label_username_warning.Location = new System.Drawing.Point(41, 82);
            this.label_username_warning.Name = "label_username_warning";
            this.label_username_warning.Size = new System.Drawing.Size(0, 25);
            this.label_username_warning.TabIndex = 18;
            // 
            // label_passwordIncorret
            // 
            this.label_passwordIncorret.AutoSize = true;
            this.label_passwordIncorret.ForeColor = System.Drawing.Color.Red;
            this.label_passwordIncorret.Location = new System.Drawing.Point(41, 269);
            this.label_passwordIncorret.Name = "label_passwordIncorret";
            this.label_passwordIncorret.Size = new System.Drawing.Size(0, 25);
            this.label_passwordIncorret.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(41, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 16;
            // 
            // button2_cancel
            // 
            this.button2_cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2_cancel.Location = new System.Drawing.Point(41, 781);
            this.button2_cancel.Name = "button2_cancel";
            this.button2_cancel.Size = new System.Drawing.Size(172, 44);
            this.button2_cancel.TabIndex = 15;
            this.button2_cancel.Text = "Cancel";
            this.button2_cancel.UseVisualStyleBackColor = true;
            this.button2_cancel.Click += new System.EventHandler(this.button2_cancel_Click);
            // 
            // button1_submit
            // 
            this.button1_submit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1_submit.Location = new System.Drawing.Point(242, 781);
            this.button1_submit.Name = "button1_submit";
            this.button1_submit.Size = new System.Drawing.Size(172, 44);
            this.button1_submit.TabIndex = 14;
            this.button1_submit.Text = "Submit";
            this.button1_submit.UseVisualStyleBackColor = true;
            this.button1_submit.Click += new System.EventHandler(this.button1_submit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.comboBox1.Location = new System.Drawing.Point(41, 672);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "User-Type";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 530);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(373, 31);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date of Birth";
            // 
            // textBox1_lastName
            // 
            this.textBox1_lastName.Location = new System.Drawing.Point(41, 441);
            this.textBox1_lastName.Name = "textBox1_lastName";
            this.textBox1_lastName.Size = new System.Drawing.Size(373, 31);
            this.textBox1_lastName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // textBox1_firstName
            // 
            this.textBox1_firstName.Location = new System.Drawing.Point(41, 364);
            this.textBox1_firstName.Name = "textBox1_firstName";
            this.textBox1_firstName.Size = new System.Drawing.Size(373, 31);
            this.textBox1_firstName.TabIndex = 7;
            this.textBox1_firstName.Click += new System.EventHandler(this.textBox1_firstName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // textBox1_password_secondAttempt
            // 
            this.textBox1_password_secondAttempt.Location = new System.Drawing.Point(41, 220);
            this.textBox1_password_secondAttempt.Name = "textBox1_password_secondAttempt";
            this.textBox1_password_secondAttempt.Size = new System.Drawing.Size(373, 31);
            this.textBox1_password_secondAttempt.TabIndex = 5;
            this.textBox1_password_secondAttempt.UseSystemPasswordChar = true;
            this.textBox1_password_secondAttempt.TextChanged += new System.EventHandler(this.textBox1_password_secondAttempt_TextChanged);
            this.textBox1_password_secondAttempt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_password_secondAttempt_PreviewKeyDown);
            // 
            // label1_reenterPassword
            // 
            this.label1_reenterPassword.AutoSize = true;
            this.label1_reenterPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_reenterPassword.Location = new System.Drawing.Point(41, 189);
            this.label1_reenterPassword.Name = "label1_reenterPassword";
            this.label1_reenterPassword.Size = new System.Drawing.Size(172, 28);
            this.label1_reenterPassword.TabIndex = 4;
            this.label1_reenterPassword.Text = "Re-Enter Password";
            // 
            // textBox2_password_firstAttempt
            // 
            this.textBox2_password_firstAttempt.Location = new System.Drawing.Point(41, 138);
            this.textBox2_password_firstAttempt.Name = "textBox2_password_firstAttempt";
            this.textBox2_password_firstAttempt.Size = new System.Drawing.Size(373, 31);
            this.textBox2_password_firstAttempt.TabIndex = 3;
            this.textBox2_password_firstAttempt.UseSystemPasswordChar = true;
            this.textBox2_password_firstAttempt.Click += new System.EventHandler(this.textBox2_password_firstAttempt_Click);
            // 
            // textBox1_username
            // 
            this.textBox1_username.Location = new System.Drawing.Point(41, 48);
            this.textBox1_username.Name = "textBox1_username";
            this.textBox1_username.Size = new System.Drawing.Size(373, 31);
            this.textBox1_username.TabIndex = 2;
            this.textBox1_username.TextChanged += new System.EventHandler(this.textBox1_username_TextChanged);
            this.textBox1_username.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_username_PreviewKeyDown);
            // 
            // label1_password
            // 
            this.label1_password.AutoSize = true;
            this.label1_password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_password.Location = new System.Drawing.Point(37, 107);
            this.label1_password.Name = "label1_password";
            this.label1_password.Size = new System.Drawing.Size(93, 28);
            this.label1_password.TabIndex = 1;
            this.label1_password.Text = "Password";
            // 
            // label1_username
            // 
            this.label1_username.AutoSize = true;
            this.label1_username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_username.Location = new System.Drawing.Point(41, 17);
            this.label1_username.Name = "label1_username";
            this.label1_username.Size = new System.Drawing.Size(99, 28);
            this.label1_username.TabIndex = 0;
            this.label1_username.Text = "Username";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 922);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "New User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1_reenterPassword;
        private TextBox textBox2_password_firstAttempt;
        private TextBox textBox1_username;
        private Label label1_password;
        private Label label1_username;
        private TextBox textBox1_password_secondAttempt;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox1_lastName;
        private Label label2;
        private TextBox textBox1_firstName;
        private Label label1;
        private Button button2_cancel;
        private Button button1_submit;
        private ComboBox comboBox1;
        private Label label5;
        private Label label_passwordIncorret;
        private Label label_username_warning;
    }
}