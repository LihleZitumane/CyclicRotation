using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleRotation
{
    class Program
    {
        static int[] solution(int[] A, int K)
        {
            int[] newArray = new int[A.Length];
            int newInd = 0;
            for (int i=0; i < A.Length; i++)
            {
                newInd = i;
                newInd += K;
                if (newInd > A.Length - 1)
                    newInd = newInd - A.Length;
                newArray[newInd] = A[i];
            }
            return newArray; 
        }
        static void Main(string[] args)
        {
            Console.Write(string.Join(",",solution(new int[] { 3, 8, 9, 7, 6 }, 3)));
            Console.ReadLine();
        }
    }
}
