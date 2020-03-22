using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson9practice
{
    class FileWriter
    {
        private const string userLogFile = "C:\\weblogs\\userlog.txt";

        public void ExampleWriteFile()
        {
            string fileName = "C:\\weblogs\\log1.txt";
            string data = "Print this info to a log. \n";
            File.AppendAllText(fileName, data);
        }

        public void UpdateUserLog(string username, DateTime logonTime, bool wasLoginSuccessful)
        {
            if(wasLoginSuccessful == true)
            {
                string logEntry = username + " successfully logged in at " + logonTime + "\n";
                File.AppendAllText(userLogFile, logEntry);
            }

            else
            {
                string logEntry = username + " entered a bad password at " + logonTime + "\n";
                File.AppendAllText(userLogFile, logEntry);
            }
        }

        public void CreateHTML(StringBuilder htmlText)
        {
            File.WriteAllText("C:\\weblogs\\myHTML.html", htmlText.ToString());
        }
    }
}
