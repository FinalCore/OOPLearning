using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_CustomCollection_2
{
    class Week
    {
        string[] days = { "Monday", "Thuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public IEnumerator GetEnumerator()
        {
            return days.GetEnumerator();
        }
    }
}
