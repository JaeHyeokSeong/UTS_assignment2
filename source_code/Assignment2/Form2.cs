using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form2 : Form
    {
        private bool userNameStatus = false, passwordStatus = false, firstNameStatus = false, lastNameStatus = false, dateOfBirthStatus = true, userTypeStatus = false;
        private bool newUserFormCompletion = false;
        private const string FILENAME = "login.txt";

        public Form2()
        {
            InitializeComponent();
        }

        private void RegisterNewUser()
        {
            StreamReader sr = new StreamReader(FILENAME);
            string? content = sr.ReadLine();
            sr.Close();
            if(content != null)
            {
                // if content is not a null, then append a text
                StreamWriter sw = File.AppendText(FILENAME);
                string username = textBox1_username.Text;
                string password = textBox1_password_secondAttempt.Text;
                string userType = comboBox1.SelectedItem.ToString();
                string firstName = textBox1_firstName.Text;
                string lastName = textBox1_lastName.Text;
                string dateOfBirth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                sw.WriteLine(String.Format($"{username},{password},{userType},{firstName},{lastName},{dateOfBirth}"));
                sw.Close(); // close the Stream
            }
            else
            {
                // if content is null, then write a text
                StreamWriter sw = new StreamWriter(FILENAME);
                string username = textBox1_username.Text;
                string password = textBox1_password_secondAttempt.Text;
                string userType = comboBox1.SelectedItem.ToString();
                string firstName = textBox1_firstName.Text;
                string lastName = textBox1_lastName.Text;
                string dateOfBirth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                sw.WriteLine(String.Format($"{username},{password},{userType},{firstName},{lastName},{dateOfBirth}"));
                sw.Close(); // close the Stream
            }
        }
        private void textBox1_username_TextChanged(object sender, EventArgs e)
        {
            // Erase if label_username_warning.Text contains some string type value
            if (!string.IsNullOrEmpty(label_username_warning.Text))
            {
                label_username_warning.Text = "";
            }
        }
        private void textBox1_username_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // If Tab key is pressed, and textBox1_username.Text contains some values, then check the username is exist in the login file
            if (e.KeyData == Keys.Tab)
            {
                if (!string.IsNullOrEmpty(textBox1_username.Text))
                {
                    bool isUsernameExist = IsUsernameExistInTheFile(FILENAME, textBox1_username.Text);
                    if (isUsernameExist)
                    {
                        label_username_warning.Text = "This username is already in use";
                    }
                }
            }
        }
        private void textBox2_password_firstAttempt_Click(object sender, EventArgs e)
        {
            // if textBox2_password_firstAttempt is clicked, then check the user name is exist in the login file
            if (!string.IsNullOrEmpty(textBox1_username.Text))
            {
                bool isUsernameExist = IsUsernameExistInTheFile(FILENAME, textBox1_username.Text);
                if (isUsernameExist)
                {
                    label_username_warning.Text = "This username is already in use";
                }
            }
        }
        private void textBox1_password_secondAttempt_TextChanged(object sender, EventArgs e)
        {
            // if label_passwordIncorret.Text contains some values and if textBox1_password_secondAttempt Text has changed, then erase the label_passwordIncorret.Text
            if (!string.IsNullOrEmpty(label_passwordIncorret.Text))
            {
                label_passwordIncorret.Text = "";
            }
        }
        private void textBox1_password_secondAttempt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // if tab key has pressed, then check the fist attempt password and second attempt password are same or not
            if(e.KeyData == Keys.Tab)
            {
                if (!string.IsNullOrEmpty(textBox1_password_secondAttempt.Text))
                {
                    if(textBox2_password_firstAttempt.Text != textBox1_password_secondAttempt.Text)
                    {
                        label_passwordIncorret.Text = "Password doesn't match";
                    }
                }
            }
        }
        private void textBox1_firstName_Click(object sender, EventArgs e)
        {
            // if firstname textbox is clicked, then check fist attempt password and second attempt password are same or not
            if (textBox2_password_firstAttempt.Text != textBox1_password_secondAttempt.Text)
            {
                label_passwordIncorret.Text = "Password doesn't match";
            }
        }


        private void button2_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Check comma symbol is exist in the string value
        /// </summary>
        /// <param name="str">Enter a string type value you want to confirm</param>
        /// <returns>return true if comma has found, otherwise return false</returns>
        private bool IsCommaInText(string str)
        {
            if (str.Contains(','))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Check inputed username is exist in the entered file
        /// </summary>
        /// <param name="file">File you want to search for</param>
        /// <param name="username">username you want to search for</param>
        /// <returns>return true if the username is exist in the file, otherise return false.</returns>
        private bool IsUsernameExistInTheFile(string file, string username)
        {
            StreamReader streamReader = new StreamReader(FILENAME);
            string? line = streamReader.ReadLine();
            string[] contents = null;
            while(line != null)
            {
                contents = line.Split(',');
                // file content format
                // username,password,userType,firstName,lastName,yyyy-MM-dd
                // username is saved at index 0
                if(username == contents[0])
                {
                    streamReader.Close();
                    return true;
                }
                line = streamReader.ReadLine();
            }
            streamReader.Close(); // Close the Stream
            return false;
        }
        private void button1_submit_Click(object sender, EventArgs e)
        {
            // Check has user filled in all information

            // [1] check username
            if (!string.IsNullOrEmpty(textBox1_username.Text))
            {
                // ',' symbol is not allowed in the username
                // username should be a unique value
                if (!IsCommaInText(textBox1_username.Text) && (!IsUsernameExistInTheFile(FILENAME, textBox1_username.Text)))
                {
                    userNameStatus = true;
                }
                else
                {
                    userNameStatus = false;
                }
            }
            else
            {
                userNameStatus = false;
            }

            // [2] check password
            if (!string.IsNullOrEmpty(textBox2_password_firstAttempt.Text) && !string.IsNullOrEmpty(textBox1_password_secondAttempt.Text))
            {
                // check first attempt and second attempt are same or not
                if(textBox2_password_firstAttempt.Text == textBox1_password_secondAttempt.Text)
                {
                    // check comman is contained or not
                    if (!IsCommaInText(textBox1_password_secondAttempt.Text))
                    {
                        passwordStatus = true;
                    }
                    else
                    {
                        passwordStatus = false;
                    }
                }
                else
                {
                    passwordStatus = false;
                }
            }
            else
            {
                passwordStatus = false;
            }

            // [3] check user type
            if(comboBox1.SelectedItem == null)
            {
                // If selected item is a null value, then the item in the comboBox1 hasn't selected
                userTypeStatus = false;
            }
            else
            {
                userTypeStatus = true;
            }

            // [4] check first name
            if (!string.IsNullOrEmpty(textBox1_firstName.Text))
            {
                // check comman is contained or not
                if (!IsCommaInText(textBox1_firstName.Text))
                {
                    firstNameStatus = true;
                }
                else
                {
                    firstNameStatus = false;
                }
            }
            else
            {
                firstNameStatus = false;
            }

            // [5] check last name
            if (!string.IsNullOrEmpty(textBox1_lastName.Text))
            {
                // check comma is contained or not
                if (!IsCommaInText(textBox1_lastName.Text))
                {
                    lastNameStatus = true;
                }
                else
                {
                    lastNameStatus = false;
                }
            }
            else 
            {
                lastNameStatus = false;
            }

            // [6] check date of birth
            // date of birth is set as a current time 

            // [7] check all status and then assign the result in the newUserFormCompletion variable
            if(userNameStatus && passwordStatus && userTypeStatus && firstNameStatus && lastNameStatus && dateOfBirthStatus)
            {
                newUserFormCompletion = true;
            }
            else
            {
                newUserFormCompletion = false;
            }

            if (newUserFormCompletion)
            {
                RegisterNewUser();
                MessageBox.Show("Your registration has been completed", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("[1] Please fill in all the blanks\n[2] Please do not use commas to fill in the blanks\n[3] Username should be a unique value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
