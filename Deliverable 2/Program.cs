using System;
using System.Text;
// Added System.Text so I could use StringBuilder
namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Propmts the user for their message
            Console.WriteLine("What is your message?");
            //Declares and assigns the variable input to the users input
            string input = Console.ReadLine();
            //Converts input to all capitals and assigns it to the variable capital
            string capital = input.ToUpper();
            //Declares the checksum variable
            int checksum = 0;
            //Declares a counter variable to be used for making sure there is not a dash at the end of the encoded message
            int count = 0;
            //Uses a foreach loop on capital to set the variable count to the number of letters in the message
            foreach (char c in capital)
            {
                count++;
            }
            //Creates a StringBuilder called sb to hold the encoded message
            StringBuilder sb = new StringBuilder("Your encoded message is ");
            //Converts capital into a character array called letters
            char[] letters = capital.ToCharArray();
            //Uses a foreach loop to run through every character in letters
            foreach (char item in letters)
            {
                //Subtracts one from count
                count--;
                //Declares and assigns num to the value of each character's Unicode number subtracted by 64. This results in the letter's position in the alphabet
                int num = item - 64;

                if (count > 0)
                {
                    //If count is greater than zero, num and a dash will be added to sb
                    sb.Append(num + " - ");

                }
                else
                {
                    //When count reaches 0 (for the last letter) only num will be added to sb
                    sb.Append(num);
                }
                //The value of each letter before the conversion will be added to checksum
                checksum += item;
            }
            //Converts sb to a string called message
            string message = sb.ToString();
            //Writes message to the console
            Console.WriteLine(message);
            //Writes checksum to to the console
            Console.WriteLine("Message checksum is " + checksum);

        }
    }
}
