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

            if (number1 < 0 && number2 > 0)
            {
                Console.WriteLine("True, одне число вiдємне одне додатне");
            }
            else if (number1 > 0 && number2 < 0)
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

            // Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20
            Console.WriteLine();
            Console.WriteLine("Введiть число1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть число2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int Summ = num1+num2;
            if (num1 ==20 || num2 ==20)
            {
                Console.WriteLine("True, одне з чисел є 20");
            }
            else if (Summ==20)
            {
                Console.WriteLine("True, Сума чисел є 20");
            }
            else
            {
                Console.WriteLine("False, Сума, а також жодне із чисел не є 20");
            }

        }
    }
    }