using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lone._05
{
    internal class _05_04
    {
        static void Main2(string[] args)
        {
            for (int i=0; i<5; i++)
            {
                SortedSet<int> set = new SortedSet<int>();

                foreach (int n in set)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
        public static int MakeLotto()
        {
            SortedSet<int> set = new SortedSet<int>();
            Random random = new Random();

            for ( ; ; )
            {
                int num = random.Next(1, 46);


                if(set.Count == 6)
                {

                }
                return set
            }
        }
    
    
    }


}
