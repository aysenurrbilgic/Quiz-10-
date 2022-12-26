using System;

public class HelloWorld
{
    public static Boolean is_divisible(int nmbr)
    {
        Boolean res = false;
        int number = 0;
        number = nmbr;
        int result = 0;
        while (number > 0)
        {
            result += number % 10;
            number = number / 10;

        }
        if (nmbr % result == 0)
        {
            res = true;
        }

        return res;
    }

    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        Boolean a = is_divisible(num);
        Console.WriteLine(a);
    }
}