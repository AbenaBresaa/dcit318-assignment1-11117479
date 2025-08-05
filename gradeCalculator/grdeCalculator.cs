using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numerical grade (0-100): ");
            int grade = Convert.ToInt32(Console.ReadLine());
            char letter;

            if (grade >= 90)
                letter = 'A';
            else if (grade >= 80)
                letter = 'B';
            else if (grade >= 70)
                letter = 'C';
            else if (grade >= 60)
                letter = 'D';
            else
                letter = 'F';

            Console.WriteLine("Letter Grade: " + letter);
        }
    }
}
