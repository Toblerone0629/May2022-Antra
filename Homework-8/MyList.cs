using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    public class MyList <T> where T : struct
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
    }
}
