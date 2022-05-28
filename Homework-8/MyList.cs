using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    public class MyList<T> where T : struct
    {
        private T[] list;

        public MyList()
        {
            list = new T[10];
        }
        public MyList(int Size)
        {
            list = new T[Size];
        }
        public void Add(T element)
        {

        }
        public T Remove(int index)
        {

        }
        public bool Contains(T element)
        {

        }
        public void Clear()
        {

        }
        public void InsertAt(T element, int index)
        {

        }
        public void DeleteAt(int index)
        {

        }
        public T find(int index)
        {

        }
    }
}
