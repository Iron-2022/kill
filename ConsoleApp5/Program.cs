using System;

class Program
{
    static double SolveEquation(int eqNum)
    {
        double x = 0;
        if (eqNum == 1)
        {
            x = Math.Sin(x + 2) * 3;
        }
        else if (eqNum == 2)
        {
            x = Math.Cos(2 * x) * 5;
        }
        else if (eqNum == 3)
        {
            x = Math.Sin(x) + Math.Cos(x);
        }
        else if (eqNum == 4)
        {
            x = 2 * Math.Sin(x) + 3 * Math.Cos(x);
        }
        else if (eqNum == 5)
        {
            x = (Math.Sin(x) + Math.Cos(x)) / 2;
        }
        else if (eqNum == 6)
        {
            x = Math.Sin(x) - 2 * Math.Cos(x);
        }
        else if (eqNum == 7)
        {
            x = 5 * Math.Sin(x) - 7 * Math.Cos(x);
        }
        else if (eqNum == 8)
        {
            x = 8 * Math.Sin(2 * x) - Math.Cos(2 * x);
        }
        else if (eqNum == 9)
        {
            x = 4 * Math.Sin(x) * 5 * Math.Cos(x);
        }
        else if (eqNum == 10)
        {
            x = 8 * Math.Sin(2 * x) - Math.Cos(2 * x);
        }
        else
        {
            x = double.NaN;
        }
        return x;
    }

    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            double equationSolution = SolveEquation(i);
            if (!double.IsNaN(equationSolution))
            {
                Console.WriteLine("Equation " + i + ": " + equationSolution);
            }
            else
            {
                Console.WriteLine("Equation " + i + " is undefined");
            }
        }
    }
}