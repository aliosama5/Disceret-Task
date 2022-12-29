// See https://aka.ms/new-console-template for more information

using System;  
public class Disceretproject1
{
    public static void Main()
    {
        int num, i, ctr, stnumber, endnumber;
        Console.WriteLine("Disceret Task: project1");
        Console.Write("Input starting number of range: ");
        stnumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input ending number of range : ");
        endnumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("The prime numbers between {0} and {1} are : \n", stnumber, endnumber);

        for (num = stnumber; num <= endnumber; num++)
        {
            ctr = 0;

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }

            if (ctr == 0 && num != 1)
                Console.Write("{0} ", num);
        }
        Console.Write("\n");
    }
}