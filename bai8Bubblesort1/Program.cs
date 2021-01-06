using System;

namespace Bai8BubbleSort
{
    class Program
    {
        static void BubbleSort(int[] A){
            for(int i=0;i<A.Length-1;i++){
                for(int j=0;j<A.Length - i -1;j++){
                    if(A[j] < A[j+1]){
                        // swap
                            int temp = A[j];
                            A[j] = A[j+1];
                            A[j+1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] mang = {2,3,4,5,61,2,7,6};
            BubbleSort(mang);
            foreach(int i in mang){
                Console.Write(i + " ");
            }
        }
    }
}
