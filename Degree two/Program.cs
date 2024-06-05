namespace Degree_two
{
    class Program
    {
        static void Main(string[] args)
        {
            int degreeNumber = 0;
            int randomNumber;
            int divisor = 2;
            double numberInPower = 1;
            Random random = new Random();

            randomNumber = random.Next(int.MaxValue);

            for (int number = randomNumber; number >= 1; number /= divisor)
            {
                degreeNumber++;
            }

            for (int i = 0; i < degreeNumber; i++)
            {
                numberInPower *= divisor;
            }

            Console.WriteLine($"Произвольное число: {randomNumber}");
            Console.WriteLine($"Степень числа {divisor}: {degreeNumber}");
            Console.WriteLine($"Число в степени {divisor}: {numberInPower}");
        }
    }
}