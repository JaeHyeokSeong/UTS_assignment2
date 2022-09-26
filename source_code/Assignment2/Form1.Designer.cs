namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3_exit = new System.Windows.Forms.Button();
            this.button2_newUser = new System.Windows.Forms.Button();
            this.button1_login = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3_exit);
            this.groupBox1.Controls.Add(this.button2_newUser);
            this.groupBox1.Controls.Add(this.button1_login);
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Controls.Add(this.textBox_username);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(37, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Username Login";
            // 
            // button3_exit
            // 
            this.button3_exit.Location = new System.Drawing.Point(294, 266);
            this.button3_exit.Name = "button3_exit";
            this.button3_exit.Size = new System.Drawing.Size(112, 40);
            this.button3_exit.TabIndex = 6;
            this.button3_exit.Text = "Exit";
            this.button3_exit.UseVisualStyleBackColor = true;
            this.button3_exit.Click += new System.EventHandler(this.button3_exit_Click);
            // 
            // button2_newUser
            // 
            this.button2_newUser.Location = new System.Drawing.Point(148, 266);
            this.button2_newUser.Name = "button2_newUser";
            this.button2_newUser.Size = new System.Drawing.Size(112, 40);
            this.button2_newUser.TabIndex = 5;
            this.button2_newUser.Text = "New User";
            this.button2_newUser.UseVisualStyleBackColor = true;
            this.button2_newUser.Click += new System.EventHandler(this.button2_newUser_Click);
            // 
            // button1_login
            // 
            this.button1_login.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1_login.Location = new System.Drawing.Point(33, 196);
            this.button1_login.Name = "button1_login";
            this.button1_login.Size = new System.Drawing.Size(484, 47);
            this.button1_login.TabIndex = 4;
            this.button1_login.Text = "Login";
            this.button1_login.UseVisualStyleBackColor = true;
            this.button1_login.Click += new System.EventHandler(this.button1_login_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(89, 125);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(428, 34);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(89, 66);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(428, 34);
            this.textBox_username.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Assignment2.Properties.Resources.passwordIcon2;
            this.pictureBox2.Location = new System.Drawing.Point(31, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment2.Properties.Resources.idIcon;
            this.pictureBox1.Location = new System.Drawing.Point(31, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 386);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Login Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_password;
        private TextBox textBox_username;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button3_exit;
        private Button button2_newUser;
        private Button button1_login;
    }
}