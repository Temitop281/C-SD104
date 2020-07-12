using System;
using System.Text;

namespace ConsoleAppLesson9_4LAB
{
    class Program
    {
        private static string string1;
        private static string string2;
        private static object mywriter;

        static void Main(string[] args)
        {
            _ = new Header();
            _ = new UnorderedList();
            _ = new StringBuilder();


            string moreText = string1 + string2;
            Console.WriteLine(moreText);


            //with string builder
            StringBuilder paragraph = new StringBuilder();

            paragraph.Append(string1);
            paragraph.Append(string2);
            paragraph.Append("Adding yet more text. ");

            Console.WriteLine(paragraph.ToString());

            StringBuilder htmlText = new StringBuilder();
             
            

            string bodyOpen = "<body>";
            string bodyClose = "</body>";
            string headingOpen = "<h1>";
            string headingClose = "</h1>";
            string UnorderListOpen = "<ul>";
            string UnorderListClose = "</ul>";
         
         
            string pOpen = "<p>";
            string pClose = "</p>";
            Console.WriteLine("Enter some text you want to put on your web page.");
            string dynamicHTML = Console.ReadLine();

            Console.WriteLine("Enter some text for your first item");
            _ = Console.ReadLine();
            Console.WriteLine("Enter some text for your second item");
            _ = Console.ReadLine();




            htmlText.Append(bodyOpen);
            htmlText.Append(pOpen);
            htmlText.Append(headingOpen);
            htmlText.Append(headingClose);
            htmlText.Append(UnorderListOpen);
            htmlText.Append(UnorderListClose);
            
           
            htmlText.Append(dynamicHTML);
            htmlText.Append(pClose);
            htmlText.Append(bodyClose);
            mywriter.CreateHTML(htmlText);




        }
    }
}
