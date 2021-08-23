using System;

namespace CalulatorProject
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Console Calculator");


            //ask user for a number
            Console.WriteLine("Enter a Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //ask user for second number
            Console.WriteLine("Enter another Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine(num1 + (operation)  + num2 + " is equal to: ");

            //operation

            if (operation == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            if (operation == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            if (operation == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            if (operation == "/")
            {
                Console.WriteLine(num1 / num2);
            }





        }

            }



            


            }
        

    

    

