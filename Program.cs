using System;

namespace CalulatorProject
{
    class Program
    {
        static void Main(string[] args)
        {




            int num1;
            int num2;



            Console.WriteLine("Console Calculator");

            try
            {

                //ask user for a number
                Console.WriteLine("Enter another Number:");
                num1 = Convert.ToInt32(Console.ReadLine());




                //ask user for second number
                Console.WriteLine("Enter another Number:");
                num2 = Convert.ToInt32(Console.ReadLine());





                //user options
                Console.WriteLine("Please Select An Operation:");
                Console.WriteLine("Add");
                Console.WriteLine("Subtract");
                Console.WriteLine("Multiply");
                Console.WriteLine("Divide");

                //user select option
                Console.Write("Operation: ");

                //user input stored in variable operation
                string operation = Console.ReadLine();


                //user selection and equation
                string equal = " is equal to:";
                string errormesg = " is an invalid equation";




                //operation


                if (operation == "+")
                {
                    Console.WriteLine(num1 + (operation) + num2 + equal);
                    Console.WriteLine(num1 + num2);
                }
                else if (operation == "-")
                {
                    Console.WriteLine(num1 + (operation) + num2 + equal);
                    Console.WriteLine(num1 - num2);
                }
                else if (operation == "*")
                {
                    Console.WriteLine(num1 + (operation) + num2 + equal);
                    Console.WriteLine(num1 * num2);
                }
                else if (operation == "/")
                {
                    Console.WriteLine(num1 + (operation) + num2 + equal);
                    Console.WriteLine(num1 / num2);
                }
                //error message for invalid operator

                else Console.WriteLine(num1 + (operation) + num2 + errormesg);

                Console.ReadLine();

            }

            catch (FormatException)
            {
                Console.WriteLine("Numbers Only");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0 is not good");
            }

            Console.ReadKey();
        }

    }
          

}
        

    

    

