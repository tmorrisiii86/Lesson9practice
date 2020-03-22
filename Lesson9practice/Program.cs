using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson9practice
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleClass myObj = new SimpleClass();
            myObj.Add(1, 4);
            myObj.Add(6, 9, 11);
            myObj.Add("Hello", "World");

            ChildClass child = new ChildClass();

            if(child is SimpleClass)
            {
                Console.WriteLine("The child class is also a simple class.");
            }

            else
            {
                Console.WriteLine("The child class is not a simple class.");
            }

            FileWriter fileWriter = new FileWriter();
            fileWriter.ExampleWriteFile();

            UserAccount user = new UserAccount("coolUser1", "secretPass12");
            user.Login("coolUser1", "forgot password");
            user.Login("coolUser1", "Password??");
            user.Login("coolUser1", "secretPass12");
            user.GetUserInfo();

            //without StringBuilder
            string string1 = "My first piece of text.";
            string string2 = "My second piece of text";

            string moreText = string1 + string2;
            Console.WriteLine(moreText);

            //with StringBuilder
            StringBuilder paragraph = new StringBuilder();

            paragraph.Append(string1);
            paragraph.Append(string2);
            paragraph.Append("Adding yet more text.");

            Console.WriteLine(paragraph.ToString());

            StringBuilder htmlText = new StringBuilder();
            string bodyOpen = "<body>";
            string bodyClose = "</body>";
            string pOpen = "<p>";
            string pClose = "</p>";
            Console.WriteLine("Enter some text you want to put on your web page.");
            string dynamicHTML = Console.ReadLine();

            htmlText.Append(bodyOpen);
            htmlText.Append(pOpen);
            htmlText.Append(dynamicHTML);
            htmlText.Append(pClose);
            htmlText.Append(bodyClose);
            fileWriter.CreateHTML(htmlText);
        }
    }
}
