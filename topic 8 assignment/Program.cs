using System.Globalization;

namespace topic_8_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int gen1;
            //first assigment
            List<string> colours = new List<string>();

            Console.WriteLine("Input 5 colours.");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a colour");
                colours.Add(Console.ReadLine());

            }

            for (int i = 0; i < colours.Count; i++)
            {
                Console.Write(colours[i] + ", ");

            }
            gen1 = generator.Next(0, colours.Count);
            Console.WriteLine();
            Console.WriteLine("press enter to print a random colour");
            Console.ReadLine();
            Console.WriteLine(colours[gen1] + ".");
            Console.ReadLine();
            //second assignment
            int numbercount, maxvalue, minvalue, singlenumber,count = 0, replace;
            List<int> numbers = new List<int>();
            Console.WriteLine("How many numbers do you want?");
            int.TryParse(Console.ReadLine(), out numbercount);
            Console.WriteLine("enter a minimum value of your numbers");
            int.TryParse(Console.ReadLine(), out minvalue);
            Console.WriteLine("enter a maximum value of these numbers");
            int.TryParse(Console.ReadLine(), out maxvalue);

            if (minvalue > maxvalue)
            {
                int temp = minvalue;
                minvalue = maxvalue;
                maxvalue = temp;
            }



            for (int i = 0;i < numbercount; i++)
            {
                numbers.Add(generator.Next(minvalue, maxvalue + 1));
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("enter a number and i will tell you how many times it is generated");
            int.TryParse(Console.ReadLine(), out singlenumber);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == singlenumber)
                    count++;

            }
            Console.WriteLine(singlenumber + " Was printed " + count + " times");

            Console.WriteLine("give me a number and i'll replace all of them with 0");
            int.TryParse(Console.ReadLine(), out replace);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == replace)
                    numbers[i] = 0;

            }

            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine("press enter to change all the numbers in the list to 0");
            Console.ReadLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                    numbers[i] = 0;

            }

            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine("press enter again to reset the list with new random numbers using the same amounts as before");
            Console.ReadLine();

            numbers.Clear();

            for (int i = 0; i < numbercount; i++)
            {
                numbers.Add(generator.Next(minvalue, maxvalue + 1));
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();

            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine();
        }
    }
}
