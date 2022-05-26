/*What type would you choose for the following “numbers”?
    A person’s telephone number                                 -- long
    A person’s height                                           -- int
    A person’s age                                              -- int
    A person’s gender (Male, Female, Prefer Not To Answer)      -- string
    A person’s salary                                           -- int
    A book’s ISBN                                               -- string
    A book’s price                                              -- double
    A book’s shipping weight                                    -- float  
    A country’s population                                      -- long
    The number of stars in the universe                          -- string
    The number of employees in each of the small or medium businesses in the
    United Kingdom (up to about 50,000 employees per business)                      -- int
2. What are the difference between value type and reference type variables? What is
boxing and unboxing?
    value type will store a value and reference type will store a pointer to what address of the value we want
    boxing is the process of converting a value type to the type object or to any interface type implemented by this value type
    unboxing is change from an interface type to a value type that implements the interface
3. What is meant by the terms managed resource and unmanaged resource in .NET
    Managed resources are those that are pure . NET code and managed by the runtime and are under its direct control. 
    Unmanaged resources are those that are not
4. Whats the purpose of Garbage Collector in .NET?
    . NET's garbage collector manages the allocation and release of memory for your application
*/

/*Practice number sizes and ranges
1. Create a console application project named /02UnderstandingTypes/ that outputs the number of bytes in memory that each of 
    the following number types uses, and the minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
    ulong, float, double, and decimal
*/
using System;
public class Q1
{
    public static void Main()
    {
        string[] names = { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal" };
        Decimal[] decimalsMin = { sbyte.MinValue, byte.MinValue, short.MinValue, ushort.MinValue, int.MinValue, uint.MinValue, 
            long.MinValue, ulong.MinValue, decimal.MinValue };
        Decimal[] decimalsMax = { sbyte.MaxValue, byte.MaxValue, short.MaxValue, ushort.MaxValue, int.MaxValue, uint.MaxValue,
            long.MaxValue, ulong.MaxValue, decimal.MaxValue};
        Console.WriteLine("{0, -10}   {1, 15}    {2, 30}    {3, 30}\n", "Name", "Bytes in Memory", "MinValue", "MaxValue");
        Console.WriteLine("{0, -10}   {1, 15}    {2, 30}    {3, 30}\n", names[0], 1, decimalsMin[0], decimalsMax[0]);
        Console.WriteLine("{0, -10}   {1, 15}    {2, 30}    {3, 30}\n", names[1], 1, decimalsMin[1], decimalsMax[1]);
        Console.WriteLine("{0, -10}   {1, 15}    {2, 30}    {3, 30}\n", names[2], 2, decimalsMin[2], decimalsMax[2]);
        Console.WriteLine("{0, -10}   {1, 15}    {2, 30}    {3, 30}\n", names[3], 2, decimalsMin[3], decimalsMax[3]);
        Console.WriteLine("{0, -10}   {1, 15}    {2, 30}    {3, 30}\n", names[4], 4, decimalsMin[4], decimalsMax[4]);
        Console.WriteLine("{0, -10}   {1, 15}    {2, 30}    {3, 30}\n", names[5], 4, decimalsMin[5], decimalsMax[5]);
        Console.WriteLine("{0, -10}   {1, 15}    {2, 30}    {3, 30}\n", names[6], 8, decimalsMin[6], decimalsMax[6]);
        Console.WriteLine("{0, -10}   {1, 15}    {2, 30}    {3, 30}\n", names[7], 8, decimalsMin[7], decimalsMax[7]);
        Console.WriteLine("{0, -10}   {1, 15}    {2, 30}    {3, 30}\n", names[8], 4, float.MinValue, float.MaxValue);
        Console.WriteLine("{0, -10}   {1, 15}    {2, 30}    {3, 30}\n", names[9], 8, double.MinValue, double.MaxValue);
        Console.WriteLine("{0, -10}   {1, 15}    {2, 30}    {3, 30}\n", names[10], 24, decimalsMin[8], decimalsMax[8]);
    }
}

/*2. Write program to enter an integer number of centuries and convert it to years, days, hours,
    minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
    type for every data conversion
*/
public class Q2
{
    public static void Main()
    {
        Console.WriteLine("Type centries you want to transfer:");
        String s = Console.ReadLine();
        int centries = Convert.ToInt32(s);
        int years = centries * 100;
        int days = (int)(years * 365.242199);
        int hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        ulong milliseconds = (ulong)(seconds * 1000);
        ulong microseconds = milliseconds * 1000;
        ulong nanoseconds = microseconds * 1000;
        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centries, years, days, hours, minutes);
        Console.WriteLine("= {0} seconds = {1} milliseconds = {2} microseconds = {3} nanoseconds", seconds, milliseconds, microseconds, nanoseconds);
    }
}

/*Controlling Flow and Converting Types
1. What happens when you divide an int variable by 0?
    undefined
2. What happens when you divide a double variable by 0?
    result in positive infinity
3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
    If an integer addition overflows, then the result is the low-order bits of the mathematical sum as represented in some sufficiently large two's-complement format. 
    If overflow occurs, then the sign of the result is not the same as the sign of the mathematical sum of the two operand values.
4. What is the difference between x = y++; and x = ++y;?
    x = y++ is x = y
    x = ++y is x = (y + 1)
5. What is the difference between break, continue, and return when used inside a loop
statement?
    break will pop out the whole loop
    continue will jump out current loop and continue to next loop
    return will stop all process and return result
6. What are the three parts of a for statement and which of them are required?
    first element is initialize a element
    second element is the situations that element should follow
    third element is how the element will increment
7. What is the difference between the = and == operators?
    = means we need to assign the operator a value
    == means we check if two elements are same
8. Does the following statement compile? for ( ; true; ) ;
    it will not
9. What does the underscore _ represent in a switch expression?
    means the default case
10. What interface must an object implement to be enumerated over by using the foreach
statement?
   The IEnumerable interface    
*/

/* Practice loops and operators
1. Create a console application in Chapter03 named Exercise03 that outputs a simulatedFizzBuzz game counting up to 100. 
*/
public class Q3
{
    public static void FizzBuzz()
    {
        int max = 100;
        for (int i = 1; i <= max; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Buzz");
            }
            else
            {
                Console.Write(i);
            }
            Console.Write("  ");
            if (i % 10 == 0)
            {
                Console.Write("\n");
            }
        }
    }
    public static void GuessGame()
    {
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("Please Guess a number between 1-3:");
        int guessNumber = Convert.ToInt32(Console.ReadLine());
        while(guessNumber != correctNumber)
        {
            if(guessNumber > correctNumber)
            {
                Console.WriteLine("The number {0} you guessed is larger", guessNumber);
            }
            else
            {
                Console.WriteLine("The number {0} you guessed is smaller", guessNumber);
            }
            Console.WriteLine("Please Guess another number: ");
            guessNumber = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The number you guessed {0} is right", guessNumber);
    }

    public static void Main()
    {
        FizzBuzz();
        Console.WriteLine();
        GuessGame();
    }
}

/*
2. Print A Pyramid
*/
public class Q4
{
    public static void Main()
    {
        string stars = "*";
        int layer = 20;

        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j < layer; j++)
            {
                Console.Write(" ");
            }
            Console.Write(stars);
            Console.WriteLine();
            stars += "**";
            layer--;
        }
    }
}

/*
3.
*/
public class Q5
{
    public static void Main()
    {
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("Please Guess a number between 1-3:");
        int guessNumber = Convert.ToInt32(Console.ReadLine());
        while (guessNumber != correctNumber)
        {
            if(guessNumber > 3 || guessNumber < 1)
            {
                Console.WriteLine("The number {0} you guessed is not a valid guess", guessNumber);
            }
            else if (guessNumber > correctNumber)
            {
                Console.WriteLine("The number {0} you guessed is larger", guessNumber);
            }
            else
            {
                Console.WriteLine("The number {0} you guessed is smaller", guessNumber);
            }
            Console.WriteLine("Please Guess another number: ");
            guessNumber = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The number you guessed {0} is right", guessNumber);
    }
}

/*
4.
*/
public class Q6
{
    public static void Main()
    {
        Console.WriteLine("Please input your birth month:");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please input your birth date:");
        int DaysToBirthDay = Convert.ToInt32(Console.ReadLine());
        int currentMonth = 5;
        int DaysToToday = 25;

        int[] daysInMonth_Normal = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        for(int i = 0; i < Math.Max(month, currentMonth); i++)
        {
            if(i < month)
            {
                DaysToBirthDay += daysInMonth_Normal[i];
            }
            if(i < currentMonth)
            {
                DaysToToday += daysInMonth_Normal[i];
            }
        }
        Console.WriteLine("Days to Birth date is: {0}", Math.Abs(DaysToToday - DaysToBirthDay));
    }
}

/*
5.
*/
public class Q7
{
    public static void Main()
    {
        Console.WriteLine(DateTime.Now);
        if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour <= 12)
        {
            Console.WriteLine("Good Morning");
        }

        if (DateTime.Now.Hour > 12 && DateTime.Now.Hour <= 18)
        {
            Console.WriteLine("Good Afternoon");
        }

        if (DateTime.Now.Hour > 18 && DateTime.Now.Hour <= 22)
        {
            Console.WriteLine("Good Evening");
        }

        if (DateTime.Now.Hour > 22 || DateTime.Now.Hour < 6)
        {
            Console.WriteLine("Good Night");
        }

    }
}

/*
6.
*/
public class Q8
{
    public static void print(int increment)
    {
        for (int i = 0; i <= 24; i+=increment)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    public static void Main()
    {
        print(1);
        print(2);
        print(3);
        print(4);
    }
}