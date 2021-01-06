using System;

namespace bai9Selectionsort
{
    class Program
    {
        static void SelectionSort(int[] Arr){
           	for (int i = 0; i < Arr.Length-1; i++) {
                for (int j = i+1; j < Arr.Length; j++) {
                    if (Arr[i] > Arr[j]) {
                        int temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,88,44,22,22,33};
            SelectionSort(arr);
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
