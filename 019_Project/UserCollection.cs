using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Project
{
    class UserCollection : IEnumerable, IEnumerator
    {
        Element[] elementArray = null;
        public UserCollection()
        {
            elementArray = new Element[5];
            elementArray[0] = new Element("Иванов", 1);
            elementArray[1] = new Element("Петров", 2);
            elementArray[2] = new Element("Сидоров", 3);
            elementArray[3] = new Element("Смирнов", 4);
            elementArray[4] = new Element("Кузнецов", 5);
        }

        int position = -1;

        public object Current 
        {
            get { return elementArray[position]; }           
        }

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }

        public bool MoveNext()
        {
            if (position < this.elementArray.Length - 1)
            {
                position++;
                return true;
            }
            else return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }

    
}
