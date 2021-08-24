using System;

namespace CalulatorProject
{
    class Program
    {
        static void Main(string[] args)
        {


            //variables for operands, change to double, changed to int to display exception instead of infinity

            int num1;
            int num2;

            //used extra write line for padding 
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("Greetings, Math Whiz!");
            Console.WriteLine("Welcome to the C#onsole C#alculator");

            try
            {

                //ask user for a number
                Console.WriteLine("\n" + "\n");
                Console.WriteLine($"Enter the First Operand:");
                num1 = Convert.ToInt32(Console.ReadLine());
              
               

                //ask user for second number
                Console.WriteLine("\n");
                Console.WriteLine("Enter the Second Operand:");
                num2 = Convert.ToInt32(Console.ReadLine());
                

                //user operator options
                Console.WriteLine("\n");
                Console.WriteLine("Please Choose an Operator:");
                Console.WriteLine("");
                Console.WriteLine("Add \t\t (+)");
                Console.WriteLine("Subtract \t (-)");
                Console.WriteLine("Multiply \t (*)");
                Console.WriteLine("Divide \t \t (/)");

                //user select option
                Console.WriteLine("\n");
                Console.Write("Operator Selected >>  ");

                //user input stored in variable operation
                string operation = Console.ReadLine();


                //equals and error message for invalid operator
                string equal = " = ";
                string errormesg = " is not an equation, Please select +, -, * and / as an operator ";




                //operation

                Console.WriteLine("");
                if (operation == "+")

                {
                    Console.WriteLine(num1 + " + " + num2 + equal + (num1 + num2));
                    
                }

                else if (operation == "-")

                {
                    Console.WriteLine(num1 + " - " + num2 + equal + (num1 - num2));
            
                }

                else if (operation == "*")

                {
                    Console.WriteLine(num1 + " x " + num2 + equal + (num1 * num2));
                  
                }

                else if (operation == "/")
                // used  actual division sign in equation
                {
                    Console.WriteLine(num1 + " \u00f7 " + num2 + equal + (num1 / num2));   

                }

                //error message for invalid operator

                else Console.WriteLine(num1 + (operation) + num2 + errormesg);

                Console.ReadLine();

            }
            // format exception and divide by zero exception
            catch (FormatException)

            {
                Console.WriteLine("Format Exception, Use integers");

            }

            catch (DivideByZeroException)

            {
                Console.WriteLine("Zero Exception, Don't use 0");

            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for using the C#onsole C#alculator, \nHave a nice day :)");
            Console.ReadKey();
        }

    }
          

}
        

    

    

