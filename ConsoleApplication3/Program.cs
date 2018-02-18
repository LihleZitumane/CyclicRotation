using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
    class Program
    {

         static public int OddOccurrencesInArrayValue(int[] A, int N)
        {
            for (int i =0; i < N; i++)
            {
                int CurrentValue = A[i];
                int count = 1;
                int c = 0;
                while (c<N)
                {
                    if (CurrentValue == A[c] && c!=i)
                        count++;
                    c++;
                }
                if ((count % 2) != 0)
                    return CurrentValue;
            }

            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(OddOccurrencesInArrayValue(new int[] { 9,3,9,3,9,7,9}, 7));
            Console.ReadKey();
        }
    }
}
