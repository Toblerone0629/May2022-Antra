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
/*
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
*/
/*2. Write program to enter an integer number of centuries and convert it to years, days, hours,
    minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
    type for every data conversion
*/
/*
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
        ulong milliseconds = (ulong)(seconds * 100);
        ulong microseconds = milliseconds * 100;
        ulong nanoseconds = microseconds * 100;
        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centries, years, days, hours, minutes);
        Console.WriteLine("= {0} seconds = {1} milliseconds = {2} microseconds = {3} nanoseconds", seconds, milliseconds, microseconds, nanoseconds);
    }
}
*/

/*Controlling Flow and Converting Types
1. What happens when you divide an int variable by 0?
    
2. What happens when you divide a double variable by 0?
3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
4. What is the difference between x = y++; and x = ++y;?
5. What is the difference between break, continue, and return when used inside a loop
statement?
6. What are the three parts of a for statement and which of them are required?
7. What is the difference between the = and == operators?
8. Does the following statement compile? for ( ; true; ) ;
9. What does the underscore _ represent in a switch expression?
10. What interface must an object implement to be enumerated over by using the foreach
statement?
*/