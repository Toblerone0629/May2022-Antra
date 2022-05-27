using System;
/*
1.When to use String vs. StringBuilder in C# ?
    string is when we need to initialize a string that we would used for visit
    stringbuilder is when we need to change elements in a string
2. What is the base class for all arrays in C#?
    The Array class is the base class for all the arrays in C#
    It is defined in the System namespace
3.How do you sort an array in C#?
    using Array.sort()
4.What property of an array object can be used to get the total number of elements in
an array?
    using .length
5. Can you store multiple data types in System.Array?
    no
6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
    copyto is that we copy all data to another place
    clone is that we clone whole array to a new place
*/

//Practice Arrays
/*
 * 1. Copying an Array
Write code to create a copy of an array. First, start by creating an initial array. (You can use
whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it.Use the things we’ve discussed to put some values
in the array.
Now create a second array variable. Give it a new array with the same length as the first.
Instead of using a number for this length, use the Lengthproperty to get the size of the
original array.
Use a loop to read values from the original array and place them in the new array.Also
print out the contents of both arrays, to be sure everything copied correctly.
*/
/*
public class Q1
{
    public static void print(int[] arr)
    {
        for(int i=0; i<10; i++)
        {
            Console.Write(arr[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    public static void Main()
    {
        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] arr2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        Console.WriteLine("Before copy");
        print(arr1);
        print(arr2);
        Array.Copy(arr1, arr2, 10);
        Console.WriteLine("After copy");
        print(arr1);
        print(arr2);
    }
}
*/

/*
 * 2.Write a simple program that lets the user manage a list of elements.It can be a grocery list,
"to do" list, etc.Refer to Looping Based on a Logical Expression if necessary to see how to
implement an infinite loop. Each time through the loop, ask the user to perform an
operation, and then show the current contents of their list. The operations available should
be Add, Remove, and Clear. The syntax should be as follows:
+some item
- some item
--
*/
/*
public class Q2
{
    public static string getItem(string s)
    {
        int i = 0;
        while (!Char.IsLetter(s[i]))
        {
            i++;
        }
        return s.Substring(i);
    }
    public static void Add(string item, HashSet<string> Items)
    {
        Items.Add(item);
        Console.WriteLine("Add element {0} successfully", item);
    }
    public static void Remove(string item, HashSet<string> Items)
    {
        if (Items.Contains(item))
        {
            Items.Remove(item);
            Console.WriteLine("Remove successfully");
            return;
        }
        Console.WriteLine("Did not find such item");
    }
    public static void Clear(HashSet<string> Items)
    {
        Items.Clear();
        Console.WriteLine("Clear successfully");
    }
    public static void Main()
    {
        Console.WriteLine("Enter command (+ item, - item, -- to clear, or exit to exit):");
        string s = Console.ReadLine();
        HashSet<string> Items = new HashSet<string>();
        while (s != "exit")
        {
            if (s[0] == '-' && s[1] == '-')
            {
                Clear(Items);
            }
            
            else if (s[0] == '+')
            {
                string item = getItem(s);
                Add(item, Items);
            }
            else if (s[0] == '-')
            {
                string item = getItem(s);
                Remove(item, Items);
            }
            s = Console.ReadLine();
        }
        Console.WriteLine("Finished");
    }
}
*/

/*
3. find prime number
*/
/*
public class Q3
{
    public static void Main()
    {
        
        Console.WriteLine("Please input your starting number:");
        int startNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please input your ending number:");
        int endNum = Convert.ToInt32(Console.ReadLine());
        List<int> primes = new List<int>();
        

        for(int i=startNum; i<endNum; i++)
        {
            bool isPrime = true;
            for (int j=2; j<i; j++)
            {
                if(i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primes.Add(i);
            }
        }
        for(int i = 0; i < primes.Count; i++)
        {
            Console.Write(primes[i]);
            Console.Write(" ");
        }
    }
}
*/

/*
4.
*/
/*
public class Q4
{
    public static void digitSwap(int[] arr, int index)
    {
        int[] result = new int[arr.Length];
        print(arr, true);
        //print(result);
        for(int i = 0; i < index; i++)
        {
            int pointer = arr.Length - i - 1;
            Console.Write("rotated{0}[] = ", i+1);
            for (int j = 0; j < arr.Length; j++)
            {
                result[j] += arr[pointer];
                Console.Write("{0, 3}", arr[pointer]);
                Console.Write(" ");
                pointer++;
                pointer %= arr.Length;
            }
            Console.WriteLine();
        }
        print(result, false);
    }
    public static void print(int[] arr, bool begin)
    {
        if (begin)
        {
            Console.Write("   Array[] = ");
        }
        else
        {
            Console.Write("     sum[] = ");
        }
        for (int i=0; i<arr.Length; i++)
        {
            Console.Write("{0, 3}", arr[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    public static void Main()
    {
        int[] arr1 = { 3, 2, 4, -1 };
        int k1 = 2;
        int[] arr2 = { 1, 2, 3, 4, 5 };
        int k2 = 3;
        Console.WriteLine("Array 1");
        digitSwap(arr1, k1);
        Console.WriteLine("Array 2");
        digitSwap(arr2, k2);
    }
}
*/

/*
5.
*/
public class Q5
{
    public static void longestSubsequence(int[] arr)
    {
        int currDigit = arr[0];
        int maxDigit = 0;
        int maxNum = 0;
        int count = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != currDigit && count > maxNum)
            {
                maxDigit = currDigit;
                currDigit = arr[i];
                maxNum = count;
                count = 1;
            }
            else
            {
                count++;
            }
        }

        if(count > maxNum)
        {
            maxDigit = currDigit;
            maxNum = count;
        }

        for(int j = 0; j < maxNum; j++)
        {
            Console.Write(maxDigit);
            Console.Write("  ");
        }
        Console.WriteLine();
    }
    public static void Main()
    {
        int[] arr1 = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int[] arr2 = { 1, 1, 1, 2, 3, 1, 3, 3 };
        int[] arr3 = { 4, 4, 4, 4 };
        int[] arr4 = { 0, 1, 1, 5, 2, 2, 6, 3, 3 };

        longestSubsequence(arr1);
        longestSubsequence(arr2);
        longestSubsequence(arr3);
        longestSubsequence(arr4);
    }
}