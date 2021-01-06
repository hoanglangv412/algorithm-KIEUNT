using System;

namespace bai10Insertionsort
{
    class Program
    {   
        static void InsertionSort(int[] arr){
            int key;
            for(int i=1;i<arr.Length;i++){
                key = arr[i];
                int j = i-1;
                while(j>=0 && arr[j]<key){
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1] = key;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8,9};
            InsertionSort(arr);
            foreach(int num in arr){
                Console.Write(num + " ");
            }
        }
    }
}
