// See https://aka.ms/new-console-template for more information
using System;
public class Disceretproject2
{
    public static void Main()
    {
        int num, i, sum, stanumber, endnumber;
        Console.WriteLine("Disceret Task: project2");
        Console.Write("Input the starting range or number : ");
        stanumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the ending range of number : ");
        endnumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("The Perfect numbers within the given range : ");
        for (num = stanumber; num <= endnumber; num++)
        {
            i = 1;
            sum = 0;
            while (i < num)
            {
                if (num % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == num)
                Console.Write("{0} ", num);
        }
        Console.Write("\n");
    }
}
