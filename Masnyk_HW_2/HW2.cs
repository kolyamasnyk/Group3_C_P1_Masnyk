namespace Masnyk_HW_2
{
    internal class HW2
    {
        static void Main(string[] args)
        {
      
            Console.WriteLine("Введiть перше число:");
            decimal number1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Введiть друге число:");
            decimal number2 = Convert.ToInt32(Console.ReadLine());

            // print the sum of two numbers
            decimal Summa = number1 + number2;
            Console.WriteLine($"Сумма чисел {number1} та {number2} буде рiвною: {Summa}");

            // print the result of dividing two numbers
            Console.WriteLine();
            decimal Divv = number1 / number2;
            Console.WriteLine($"Дiлення чисела {number1} на число {number2} буде рiвною: {Divv}");

            // print the result of the specified operations 
            Console.WriteLine();
            Console.WriteLine($"Результатом виразу: '-1 + 4 * 6' буде: 23 ");
            var a = -1 + 4 * 6;
            Console.WriteLine(a);

            Console.WriteLine();
            Console.WriteLine($"Результатом виразу: '(35+5) % 7' буде: 5.711428"); // ВИВОДИТЬ 5, ПОНЯТТЯ НЕ МАЮ ЯК ВИПРАВТИ, ГРАВСЯ із КОВЕРТАЦІЄЮ, НЕ ПОЛУЧИЛОСЬ 
            decimal b = Convert.ToDecimal(35 + 5);
            decimal b1 = b % 7;
            Console.WriteLine(b1);

            Console.WriteLine();
            Console.WriteLine($"Результатом виразу: '14 + -4 * 6 / 11' буде: 11.8181 ");//ТУТ ОКРУГЛЮЄ ДО 12 і хоть трісни, не знаю як заставити виводити дробове, із діленням двух чисел полусилось, а тут застряг 
            decimal c = 14 + (-4 * 6 / 11);
            Console.WriteLine(c);

            Console.WriteLine();
            Console.WriteLine($"Результатом виразу: '2 + 15 / 6 * 1 - 7 % 2' буде: 4"); // тут получаєстя або 3 або -1, конвертуваня теж не дало результату
            var d = Convert.ToDecimal(2 + (15 / 6 * 1) - (7 % 2));
            Console.WriteLine(d);

            // swap two numbers 
            Console.WriteLine();
            int N1 = 5;
            int N2 = 6;
            Console.WriteLine($"Числа на початку: First Number={N1} та Second Number={N2} ");
            N2 = N1 + N2;
            N1 = N2 - N1;
            N2 = N2 - N1;
            Console.WriteLine($" ...магiя матиматики... ");
            Console.WriteLine($"Числа пiсля 'swap': First Number={N1} та Second Number={N2} ");

            // print the output of multiplication of three numbers which will be entered by the user
            Console.WriteLine();
            Console.WriteLine("Введiть перше число для множення:");
            var num1 = Convert.ToInt32(Convert.ToString(Console.ReadLine()));
            Console.WriteLine("Введiть друге число для множення:");
            var num2 = Convert.ToInt32(Convert.ToString(Console.ReadLine()));
            Console.WriteLine("Введiть трете число для множення:");
            var num3 = Convert.ToInt32(Convert.ToString(Console.ReadLine()));
            var multiplication = num1 * num2 * num3;
            Console.WriteLine($"Результатом множення чисел: {num1} та {num2} та {num3} буде - {multiplication}");
        }
    }
}