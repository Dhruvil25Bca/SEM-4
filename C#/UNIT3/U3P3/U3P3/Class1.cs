using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3P3
{
    class Employee
    {
        int empcode;
        string empname;
        long salary;
        public Employee()
        {

        }
        public Employee(int ecode)
        {
            empcode=ecode;
        }
        public Employee(int ecode,string ename)
        {
            empcode = ecode;
            empname = ename;
        }
        public Employee(int ecode, string ename,long sal)
        {
            empcode = ecode;
            empname = ename;
            salary = sal;
        }
        public string showdata()
        {
            string str;
            str = "EmpCode: " + empcode + " EmpName: " + empname + " Salary: " + salary;
            return str;
        }
    }
}
