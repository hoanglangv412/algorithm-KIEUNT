using System;

namespace bai21calSalary
{
    class Program
    {
        static int calSalaryByRecursion(int salary, int year){
            if(year == 0) return 0;
            if(year == 1) return salary;
            else return (salary+calSalaryByRecursion(salary,year-1)/10);
        }
        static int calSalaryBasic(int salary, int year){
            int finalSalary = 0;
            if(year == 0) finalSalary = 0;
            else if(year == 1) finalSalary = salary;  
            else{
                int i = 2;
                int beforeYear = salary;
                while(i<=year){
                    finalSalary =  salary + beforeYear/10;
                    beforeYear = salary + beforeYear/10;
                    i++;
                }
            }
            return finalSalary;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(calSalaryByRecursion(10000000, 5));
            Console.WriteLine(calSalaryBasic(10000000, 6));
        }
    }
}
