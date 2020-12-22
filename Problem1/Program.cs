using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Enum.Parse(typeof(Gender),"M"));
            Employee[] EmpArr = new Employee[3];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter ID: ");
                int ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Security Level: ");
                int SL = int.Parse(Console.ReadLine());
                float Sal = -1 ;
                while (Sal < 0)
                {
                    Console.WriteLine("Enter Salary: ");
                    Sal = float.Parse(Console.ReadLine());
                    if(Sal<0) Console.WriteLine("Invalid Salary, Please Try Again: ");
                }
                String gen;
                Console.WriteLine("Enter Gender (M or m: for male & F or f: for female");
                gen = Console.ReadLine().ToUpper();
                while(gen!="F" && gen != "M")
                {
                    if (gen != "F" || gen != "M")
                        Console.WriteLine("Invalid Gender, Please Try Again: ");
                    Console.WriteLine("Enter Gender (M or m: for male & F or f: for female");
                    gen = Console.ReadLine().ToUpper();

                }
                Gender G = (Gender)Enum.Parse(typeof(Gender), gen);
                int d= -1, m = -1, y= -1;
                Console.WriteLine("Enter Hiredate:");
                while (d<=0 || d>31)
                {
                    Console.WriteLine("Day:");
                    d = int.Parse(Console.ReadLine());
                    if(d<=0 || d>31)
                        Console.WriteLine("Invalid Day, Please try again");


                }

                while (m<= 0 || m > 12)
                {
                    Console.WriteLine("Month:");
                    m= int.Parse(Console.ReadLine());
                    if (m <= 0 || m > 12)
                        Console.WriteLine("Invalid Month, Please try again");

                }

                while (y <= 1900 || y > 2020)
                {
                    Console.WriteLine("Year:");
                    y = int.Parse(Console.ReadLine());
                    if (y <= 1900 || y > 2020)
                        Console.WriteLine("Invalid year, Please try again");

                }

                EmpArr[i] = new Employee(ID, SL, Sal, G, d, m, y);
                Console.WriteLine("");
                Console.WriteLine("You Entered: ");
                Console.WriteLine(EmpArr[i].ToString());
            }
        }
    }
}
