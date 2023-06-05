namespace Masnyk_HW_3
{
    internal class HW3
    {
        static void Main(string[] args)
        {

            //Write a C# program to check two given integers and return true if one is negative and one is positive.
            Console.WriteLine("Введiть перше число:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть друге число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 <0 && number2>0)
             {
                Console.WriteLine("True, одне число вiдємне одне додатне");
             }
            else if (number1 >0 && number2<0)
            {
                Console.WriteLine("True, одне число вiдємне одне додатне");
            }
            else if (number1 < 0 && number2 < 0)
            {
                Console.WriteLine("False, обивда числа вiдємнi");
            }
            else if (number1 > 0 && number2 > 0)
            {
                Console.WriteLine("False, обивда числа додатнi");
            }
            else if (number1 == 0 || number2 == 0)
            {
                Console.WriteLine("False, одне iз чисел дорiюнює НУЛЬ");
            }
            else
            {
                Console.WriteLine("Ви вели не коректнi занчення"); // літери чи спец символи водити не можна бо по умові інпути є int, але на всякий випадок.
            }
        }
        }
    }