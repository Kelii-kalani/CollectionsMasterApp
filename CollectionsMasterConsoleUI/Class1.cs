using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsMasterConsoleUI
{
    class Class1
    {
        public static IEnumerable<M> NumeroPrinter<M>(M[] items) where M : IEnumerable<int[]>
        {
            items = new M[50];
            for (int i = items.Length; i >= 0; i--)
            {
                yield return items[i];
            }
        }
    }
}
