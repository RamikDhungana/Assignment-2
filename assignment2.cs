using System;

class Interval
{
    static void Main()
    {
        Console.Write("Enter a real number: ");
        double x = Convert.ToDouble(Console.ReadLine());

        bool belongsToI = IsInInterval(x);

        if (belongsToI)
        {
            Console.WriteLine($"x belongs to I");
        }
        else
        {
            Console.WriteLine($"x does not belong to I");
        }
    }

    static bool IsInInterval(double x)
    {
        bool condition1 = (x >= 2 && x < 3);
        bool condition2 = (x >= 0 && x <= 1);
        bool condition3 = (x >= -10 && x <= -2);
        bool result = condition1 && condition2 && condition3;

        return result;
    }
}
