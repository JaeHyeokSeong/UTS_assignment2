using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Login
    {
        // variables
        private const string FILENAME = "login.txt";
        private string username = "", password = "";
        private List<string> fileContents = null;
        private string[] userInformation;
        // accessor
        public string Username
        {
            get { return username; }
        }
        public string Password
        {
            get { return password; }
        }
        // constructor
        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        // load all users from the "login.txt" file into appropriate data structure
        public void LoadAllUsers()
        {
            StreamReader sr = new StreamReader(FILENAME);
            string? line = sr.ReadLine();
            while (line != null)
            {
                // file content format
                // username,password,userType,firstName,lastName,yyyy-MM-dd
                fileContents.Add(line);
                line = sr.ReadLine();
            }
            sr.Close(); // close the stream
        }
        // checking if a username and password provided by the user is valid
        /// <summary>
        /// check provided username and password are valid or invalid
        /// </summary>
        /// <returns>return true if username and password are valid, otherwise return false.</returns>
        public bool IsValid()
        {
            StreamReader sr = new StreamReader(FILENAME);
            string? line = sr.ReadLine();
            string[] contents = null
;           while(line != null)
            {
                // file content format
                // username,password,userType,firstName,lastName,yyyy-MM-dd
                // check username and passowrd -> index 0 and 1
                contents = line.Split(',');
                if(username == contents[0] && password == contents[1])
                {
                    userInformation = contents;
                    sr.Close(); // close the stream
                    return true; // valid
                }
                line = sr.ReadLine();
            }
            sr.Close(); // close the stream
            return false; // invalid
        }
        /// <summary>
        /// check type of users
        /// </summary>
        /// <returns>return true if user has create and edit permission, otherise return false</returns>
        public bool AllowEdit()
        {
            if (IsValid())
            {
                // file content format
                // username,password,userType,firstName,lastName,yyyy-MM-dd
                // check userType -> index 2
                if (userInformation[2] == "Edit")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
