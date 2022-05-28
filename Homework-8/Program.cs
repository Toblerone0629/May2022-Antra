using System;
using Homework_8;
/*
1. generics solves the problem of having to use loosely typed objects
2. create a interface , then create a list, then using the function in interface to add list to list
3. 2
4. True
5. Add(), AddRange()
6. remove(), pop()
7. A generic type is declared by specifying a type parameter in an angle brackets after a type name
8. True
9. True
10.True
*/

// Practice working with generics
//1.
public class Q1
{
    public static void Main()
    {
        MyStack<int> intStack = new MyStack<int>();
        intStack.Print();

        intStack.Push(5);
        intStack.Print();

        intStack.Push(10);
        intStack.Print();

        intStack.Push(20);
        intStack.Print();

        intStack.Pop();
        intStack.Print();
    }
}

//2.
