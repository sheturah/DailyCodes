using System;

namespace NewNetId
{
    class Program
    {
        //This metod returns the first initial of the user
        public static string getFirst()
        {
            Console.WriteLine("Enter the first letter of your name: ");
            string first = Console.ReadLine();

            //Throws an exception if the user puts an invalid letter
            if(first.Length<1 || first.Length>1)
                {
                throw new BadName("An initial is one letter");
                }
            else if (first.Contains("!"))
            {
                throw new BadName("Constains invalid characters");
            }
            return first;

        }

        //This method returns the number the user entered
        public static int getNumb()
        {
            int numb = 0;
            bool inBound = false;

                Console.WriteLine("Enter a valid whole number (1-9999): ");
                numb = Int32.Parse(Console.ReadLine());

                if (numb < 1 || numb > 9999)
                {
                    throw new BadNumb("The number was either too high or too low\nTry Again.");
                }
                else
                { 
                    inBound = true;

                }


            return numb;
        }

        public static string getLast()
        {
            Console.WriteLine("Enter your last name: ");
            string last = Console.ReadLine();
            return last;
        
        }

        //good ole main method
        static void Main(string[] args)
        {
            string first = "";
            string last = "";
            float numb = 0;

            Console.WriteLine("[KSU NetID Generator]");

            //try block to confirm the answers match the critia 
            //might use regular expressions
            try
            {
                first = getFirst();
                last = getLast();
                numb = getNumb();
            }
            catch (BadName bn)
            {
                Console.WriteLine("The name was invalid because: " + bn.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("That input was not a number");
            }
            catch (BadNumb ba)
            {
                Console.WriteLine("The number input was invalid " + ba.Message);
            }

            Console.WriteLine("Your KSU NetID is " + first + last + numb + ". You can log into KSU computers with \nthis NetID as your username and your email password as the \npassword.\nYour email address is " + first + last + numb + "@students.kennesaw.edu.") ;
               
            
        }

        
    }
}
