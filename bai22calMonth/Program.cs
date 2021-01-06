using System;

namespace bai22calMonth
{
    class Program
    {
        static int calMonthcheck(int money, int rate,int month){
            if(month == 0) return money;
            else return calMonthcheck(money,rate, month-1) + calMonthcheck(money,rate, month-1)/rate;
        }
        static int calMonthRecursion(int money,int rate){
            int countMonth = 0;
            int finalMoney = money;
            while(calMonthcheck(money,rate,countMonth) < money * 2){
                finalMoney+=calMonthcheck(finalMoney,rate,countMonth+1);
                countMonth++;
            }
            return countMonth;
        }
        static int calMonthBasic(int money, int rate){
            int countMonth = 0;
            int finalMoney = money;
            while(finalMoney<money*2){
                finalMoney += finalMoney/rate;
                countMonth++;
            }
            return countMonth;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("It takes: "  + calMonthBasic(100000,20) + " months to double the money with 10% interest with basic");
            Console.WriteLine("It takes: "  + calMonthRecursion(100000,20) + " months to double the money with 10% interest with basic");
        }
    }
}
