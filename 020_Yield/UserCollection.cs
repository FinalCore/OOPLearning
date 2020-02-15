using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Yield
{
    class UserCollection
    {
        public static IEnumerable Power()
        {
            yield return "Hello World!";
            yield return "Hello World!";
        }
    }
}
