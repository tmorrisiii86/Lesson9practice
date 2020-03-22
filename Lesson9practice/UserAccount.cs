using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson9practice
{
    class UserAccount
    {
        private string username;
        private string password;

        private DateTime lastLogOnDate;
        private int badPasswordAttempts;
        private bool isLoggedIn;

        FileWriter filewriter;

        public UserAccount(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void Login(string usernameAttempt, string passwordAttempt)
        {
            if(passwordAttempt == password & usernameAttempt == username)
            {
                isLoggedIn = true;
                FileWriter fileWriter = new FileWriter();
                DateTime logonTime = DateTime.Now;
                lastLogOnDate = logonTime;
                fileWriter.UpdateUserLog(username, logonTime, true);
            }

            else
            {
                isLoggedIn = false;
                badPasswordAttempts += 1;
                FileWriter fileWriter = new FileWriter();
                DateTime logonTime = DateTime.Now;
                fileWriter.UpdateUserLog(username, logonTime, false);
            }
        }

        public void GetUserInfo()
        {
            Console.WriteLine("username = " + username);
            Console.WriteLine("last logon = " + lastLogOnDate);
            Console.WriteLine("bad password tries = " + badPasswordAttempts);
            Console.WriteLine("is logged in? " + isLoggedIn);

        }
    }
}
