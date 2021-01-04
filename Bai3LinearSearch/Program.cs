using System;

namespace Bai3LinearSearch
{
    class Program
    {
        static int[] A = {4,5,1,2,37,8,0};
        static void LinearSearch(int[] A, int x)
        {
            for(int i = 0; i < A.Length; i++)
            {
                if (A[i] == x) {
                    Console.WriteLine("A[" + i + "] = " + x);
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy");
        }
        static void Main(string[] args)
        {
            LinearSearch(A,5);
        }
    }
}
