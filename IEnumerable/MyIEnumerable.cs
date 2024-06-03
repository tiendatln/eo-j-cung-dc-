using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace IEnumerable
{
    public class MyIEnumerable : IEnumerator
    {
        private readonly string[] listString;
        private int currentIndex;
        public MyIEnumerable(string[] String)
        {
            listString = String;
            currentIndex = listString.Length;
        }

        public object Current
        {
            get
            {
                return listString[currentIndex];
            }
        }

        public bool MoveNext()
        {
            currentIndex--;

            return currentIndex >= 0;
        }

        public void Reset()
        {
            currentIndex = listString.Length;
        }
    }
}
