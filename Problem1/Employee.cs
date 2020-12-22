using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public enum Gender
    {
        M, F
    }

    public struct Employee
    {
        int id, securityLevel;
        float salary;
        HireDate hireDate;
        Gender gender;

        public Employee(int ID, int SL, float Sal,Gender G, int d,int m, int y )
        {
            id = ID;
            securityLevel= SL;
            salary = Sal;
            gender = G;
            hireDate = new HireDate(d, m, y);

        }

        public override string ToString()
        {
            String data = "";
            data += "Employee ID: " + id + "\n";
            data += "Security Level: " + securityLevel + "\n";
            data += "Salary: " + salary.ToString("C") + "\n";
            data += "Gender: " + gender + "\n";
            data += "Hire date: " + hireDate.getDay() + "/"
                                  + hireDate.getMonth() + "/"
                                  + hireDate.getyear() + "\n";
            return data;
        }

    }
}
