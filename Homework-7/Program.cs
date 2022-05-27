using System;
/*
1.  Public: set element public to all that could be reached
    Private: set element private only code could call it
    Protected: element is only accessable in class
    Internal: access is limited exclusively to classes defined within the current project 
    Protected Internal: access the protected internal member only in the same assembly or in a derived class in other assemblies
    Private Protected: access members inside the containing class or in a class that derives from a containing class, but only in the same assembly(project)
2.  Static: static modifier is to declare a static number which belongs to the type itself rather than to a specific object
    Const: can be referenced through classname
    Readonly: only be initialized at the class level
3.  constructor will construct all elements we need in the class that we could modify them later
4.  The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace
5.  tuple is a pair that contains two elements
6.  define a reference type that provides built-in functionality for encapsulating data
7.  Overloading occurs when two or more methods in one class have the same method name but different parameters. 
    Overriding occurs when two methods have the same method name and parameters
8.  A field is a variable of any type that is declared directly in a class. 
    A property is a member that provides a flexible mechanism to read, write or compute the value of a private field. 
    A field can be used to explain the characteristics of an object or a class
9.  implement an optional parameter by using the parameter arrays (using the params keyword). 
    It allows us to pass any number of parameters to the methods
10. An abstract class permits you to make functionality that subclasses can implement or override whereas an interface only permits you to state functionality but not to implement it
11. The access level for class members and struct members, including nested classes and structs, is private by default
12. True
13. True
14. True
15. False
16. False
17. True
18. True
19. True
20. True
21. True
22. False
23. True
*/

/*
1.
 */
public class Q1
{
    public static int[] GenerateNumber()
    {
        Random rnd = new Random();
        int digits = rnd.Next(10, 20);
        Console.WriteLine(digits);

        int[] numbers = new int[digits];

        for(int i = 0; i < digits; i++)
        {
            numbers[i] = rnd.Next(0, 15);
        }
        return numbers;
    }
    public static void PrintNumber(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0, 2}", arr[i]);
            Console.Write("  ");
        }
        Console.WriteLine();
    }
    public static void ReverseNumber(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        while(left < right)
        {
            (arr[left], arr[right]) = (arr[right], arr[left]);
            left++;
            right--;
        }
    }
    public static void Main()
    {
        //Console.WriteLine("Hi");
        int[] arr1 = GenerateNumber();
        int[] arr2 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        PrintNumber(arr1);
        ReverseNumber(arr1);
        PrintNumber(arr1);
        Console.WriteLine();
        PrintNumber(arr2);
        ReverseNumber(arr2);
        PrintNumber(arr2);
    }
}

/*
2.
*/