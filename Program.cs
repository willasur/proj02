using System;

namespace CalulatorProject
{
    class Program
    {
        static void Main(string[] args)
        {


            //variables for operands

            int num1;
            int num2;


            Console.WriteLine("Greetings, Math Whiz!");
            Console.WriteLine("Welcome to C#onsole C#alculator");

            try
            {

                //ask user for a number
                Console.WriteLine("Enter the First Operand:");
                num1 = Convert.ToInt32(Console.ReadLine());




                //ask user for second number
                Console.WriteLine("Enter the Second Operand:");
                num2 = Convert.ToInt32(Console.ReadLine());





                //user operator options
                Console.WriteLine("Please Choose an Operator:");
                Console.WriteLine("Add \t\t (+)");
                Console.WriteLine("Subtract \t (-)");
                Console.WriteLine("Multiply \t (*)");
                Console.WriteLine("Divide \t \t (/)");

                //user select option
                Console.Write("Operation: ");

                //user input stored in variable operation
                string operation = Console.ReadLine();


                //equals and error message for invalid operator
                string equal = " = ";
                string errormesg = " is an invalid equation";




                //operation


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
                Console.WriteLine("Numbers Only");

            }

            catch (DivideByZeroException)

            {
                Console.WriteLine("0 is not good");

            }

            Console.WriteLine("Have a Nice Day");
            Console.ReadKey();
        }

    }
          

}
        

    

    

