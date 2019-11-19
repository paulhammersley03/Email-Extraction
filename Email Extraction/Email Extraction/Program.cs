using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Return_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> EmailAddress = new List<string>();

            //var SecondWord = "";

            //Load text file as string and split at '@' sign into an array
            string[] stringSeparators = new string[] { "@" };
            string InputText = System.IO.File.ReadAllText(@"C:\Work\Training\RegEx\Email_Address.txt");
            string[] InputArray = InputText.Split(stringSeparators,
                     StringSplitOptions.RemoveEmptyEntries);

            //Return first and last word of the array and put into 'EmailAddress' list
            int ArrayLength = InputArray.Length;//Converts Indicies in array into number
            string LastWord = "";//Variable String to store Last word of Index
            int Counter = 0;//Variable to store number of @softwire.com instances

            for (int i = 0; i < ArrayLength; i++)//Counter to loop the length of the array
            {
                LastWord = "";//Resets Last Word to nothing

                var SplitSection = InputArray[i];
                string[] SplitOnSpace = SplitSection.Split();//Creates an array to split the InputArray on spaces
                LastWord = SplitOnSpace.First();//Returns the first word into a string variable
                EmailAddress.Add(LastWord);//Adds the email address to the list

                if (LastWord.Equals("softwire.com"))//checks if lastword string variable contains "@softwire.com"
                {
                    Counter++;//if true, adds 1 to counter
                }
            }
            Console.WriteLine("There are: " + Counter + " instances of @softwire.com");
            Console.ReadLine();
        }
    }
}
