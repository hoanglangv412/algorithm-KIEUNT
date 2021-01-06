using System;

namespace bai18Fibonacci
{
    class Program
    {
        static int Fibonacci(int num){
            if(num==0) return 0 ;
            if(num==1) return 1;
            else return (Fibonacci(num-2)+Fibonacci(num-1));
        }
        static void Main(string[] args)
        {
            for(int i=0;i<9;i++){
                Console.Write(Fibonacci(i) + " ");
            }
        }
    }
}
