using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace DataStructuresFirstDay
{
    class LinkedListObjectsDemo
    {
        static void Main(string[] args)
        {
            LinkedList<Employee> emp = new LinkedList<Employee>();
            emp.AddFirst(new Employee { EmpID = 1, EmpName = "Jack", DeptNo = 10, City = "Hyderabad" });

            emp.AddFirst(new Employee { EmpID = 5, EmpName = "Jim", DeptNo = 20, City = "Bangalore" });
            //emp.AddAfter(emp.First.Next, new Employee { });
            Employee empF=emp.ElementAt(2);
            emp.AddAfter(emp.Find(empF), new Employee { });


            //Jack,Jill,Jim
            //Jack,Jill,Hari,Jim
            //Jack,Jill,Pari,Hari,Jim
            //Remove Jim
            //add at the end--- Veena




        }
    }
}
