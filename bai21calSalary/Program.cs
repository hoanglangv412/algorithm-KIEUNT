using System;

namespace bai21calSalary
{
    class Program
    {
        static int calSalaryByRecursion(int salary, int year){
            if(year == 1) return salary;
            else return (calSalaryByRecursion(salary,year-1)+calSalaryByRecursion(salary,year-1)/10);
        }

        static int calSalaryBasic(int salary, int year){
            int finalSalary = 0;
            if(year == 1) finalSalary = salary;  
            else{
                int i = 2;
                finalSalary = salary;
                while(i<=year){
                    finalSalary += finalSalary/10;
                    i++;
                }
            }
            return finalSalary;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Luong de quy: " + calSalaryByRecursion(10000000, 10));
            Console.WriteLine("Luong co ban: " + calSalaryBasic(10000000, 10));
        }
    }
}
