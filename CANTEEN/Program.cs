using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of coupons: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 1 || n > 100)
        {
            Console.WriteLine("Number of coupons must be between 1 and 100.");
            return;
        }

        Console.WriteLine("Enter coupon values, separated by spaces:");
        string[] input = Console.ReadLine().Split(' ');
        int[] coupons = new int[n];

        for (int i = 0; i < n; i++)
        {
            coupons[i] = Convert.ToInt32(input[i]);
        }

        int totalValue = 0;
        int maxValue = coupons[0];
        int maxIndex = 0;

        int small = 0, medium = 0, large = 0;

        for (int i = 0; i < n; i++)
        {
            int value = coupons[i];
            totalValue += value;

            if (value > maxValue)
            {
                maxValue = value;
                maxIndex = i;
            }

            if (value <= 50)
                small++;
            else if (value <= 100)
                medium++;
            else
                large++;
        }

        Console.WriteLine("\n----- Daily Coupon Summary -----");
        Console.WriteLine($"Total coupons redeemed  : {n}");
        Console.WriteLine($"Total value collected   : {totalValue}");
        Console.WriteLine($"Highest coupon redeemed : {maxValue} (coupon #{maxIndex + 1})");

        Console.WriteLine("\nCategory breakdown");
        Console.WriteLine($"Small  (≤50)   : {small}");
        Console.WriteLine($"Medium (51-100): {medium}");
        Console.WriteLine($"Large  (>100)  : {large}");
    }
}

