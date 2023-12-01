using System;
class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        while (a != 10)
        {
            Console.WriteLine(a);
            a++;
        }

        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        int b = 3;
        while (b >= -2)
        {
            Console.WriteLine(b);
            b -= 2;
        }
        
        for (int i = 3; i >= -2; i -= 2)
        {
            Console.WriteLine(i);
        }

        int c = 10;
        while (c <= 100)
        {
            Console.WriteLine(c);
            c += 10;
        }

        for (int i = 10; i <= 100; i += 10)
        {
            Console.WriteLine(i);
        }

        int d = 1;
        do
        {
            Console.WriteLine(d);
            d *= 2;
        } while (d <= 100);

        for (int i = 1; i <=100; i*=2)
        {
            Console.WriteLine(i);
        }

        // ^ While to for
        // > for to while

        for (int i = 10; i <= 100; i += 10)
        {
            Console.Write(i + " ");
        }

        int e = 10;
        while (e <= 100)
        {
            Console.Write(e + " ");
            e += 10;
        }

        for (double i = 150; i > 2; i /= 2)
        {
            Console.WriteLine(i + " ");
        }

        double f = 150;
        while (f > 2)
        {
            Console.WriteLine(f + " ");
            f /= 2;
        }

        for (int i = 0; i > -30; i -= 1)
        {
            Console.Write(i + " ");
        }

        int g = 0;
        while (g > -30)
        {
            Console.WriteLine(g + " ");
            g -= 1;
        }

        // Implementing for loops


        // Ask the user for a positive integer then use a for loop to compute the sum of all the integers between 1 and the number they entered.
        Console.WriteLine("Enter a positive integer: ");
        int num = int.Parse((Console.ReadLine()));
        int sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
           
        /*
         * 1. It would equal 0
         * 2. Yes it could be
         * 3. sum *= i
         * 4. if (sum % i == 0)








    }
}