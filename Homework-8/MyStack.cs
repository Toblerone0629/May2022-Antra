using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    public class MyStack <T> where T : struct
    {
        private T[] arr;
        private int index;
        public MyStack()
        {
            arr = new T[5];
            index = 0;
        }
        public MyStack(int size)
        {
            arr = new T[size];
            index = 0;
        }
        public int Count()
        {
            return index;
        }
        public T Pop()
        {
            T item = arr[index - 1];
            index--;
            return item;
        }
        public void Push(T element)
        {
            arr[index++] = element;
        }
        public void Print()
        {
            if(index == 0)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Stack top is: {0}", arr[index-1]);
            }
        }
    }
}
