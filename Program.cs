using System;

namespace CalulatorProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //used extra write line for padding 
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("Greetings, Math Whiz!");
            Console.WriteLine("Welcome to the C#onsole C#alculator");

            /*variables for operands, change to double, changed to int to display exception instead of infinity
            added bool and while so user is asked to enter a number again
            **Things I was unable to execute:
            a) ask user to input the second number after exception instead of asking for the first number again 
            b) ask user enter a valid operator instead of exiting */

            int num1;
            int num2;
            bool carryon = false;
            while (!carryon)
            {
                carryon = true;

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
                    string errormesg = " is not an equation, Please select +, -, * and / as an operator and try again";




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
                    Console.WriteLine("Format Exception, Please use integers");
                    carryon = false;
                }

                catch (DivideByZeroException)

                {
                    Console.WriteLine("Zero Exception, Please avoid using 0");
                    carryon = false;
                }

            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for using the C#onsole C#alculator, \nHave a nice day :)");
            Console.ReadKey();
        }

    }
          

}
        

    

    

