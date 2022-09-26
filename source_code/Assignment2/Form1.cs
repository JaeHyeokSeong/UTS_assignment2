namespace Assignment2
{
    public partial class Form1 : Form
    {
        private const string FILENAME = "login.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_newUser_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide(); // Hide current form
            form2.ShowDialog();
            this.Show(); // Show the previous form again
        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            Login login = null;
            if(!string.IsNullOrEmpty(textBox_username.Text) && !string.IsNullOrEmpty(textBox_password.Text))
            {
                login = new Login(textBox_username.Text, textBox_password.Text);
                if (login.IsValid())
                {
                    // show the text editor window
                    Form3 form3 = new Form3();
                    form3.UserName = login.Username; // set user same to be displayed in the tool strip label
                    form3.Password = login.Password;
                    form3.EditAble = login.AllowEdit();
                    this.Hide();
                    form3.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login fail", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter username and password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}