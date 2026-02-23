using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    { //constructor
        T[] iteams;
        public MyList()
        {
            iteams = new T[0];
        }
        public void Add(T item)
        {
            T[] tempiteams = iteams;
            iteams = new T[iteams.Length + 1];
            for (int i = 0; i < tempiteams.Length; i++)
            {
                iteams[i] = tempiteams[i];
            }
            iteams[iteams.Length - 1] = item;
        }
    }
}
