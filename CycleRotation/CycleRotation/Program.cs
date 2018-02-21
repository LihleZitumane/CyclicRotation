using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleRotation
{
    class Program
    {
        static int[] solution(int[] A, int N, int K)
        {
            int[] newArray = new int[N];
            int newInd = 0;
            for (int i=0; i < N; i++)
            {
                newInd = i;
                newInd += K;
                if (newInd > N - 1)
                    newInd = newInd - N;
                newArray[newInd] = A[i];
            }
            return newArray.ToArray(); 
        }
        static void Main(string[] args)
        {
            Console.Write(solution(new int[] { 0, 0, 0}, 5, 3));
            Console.ReadLine();
        }
    }
}
