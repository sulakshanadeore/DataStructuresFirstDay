using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace DataStructuresFirstDay
{
    class ListOfObjectsDemo
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee {EmpID=1,EmpName="Akhil",City="Pune",DeptNo=10 });

            
            try
            {

           
            Employee emp1 = new Employee();
            emp1.EmpID = 2;
            emp1.EmpName = "Hari";
            Console.WriteLine("enter deptno");
            emp1.DeptNo = Convert.ToInt32(Console.ReadLine());
            //emp1.DeptNo = 20;
            emp1.City = "Mumbai";
            emp1.CalculateSalary(20000);
            Console.WriteLine(emp1.GrossSalary);
            emplist.Add(emp1);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            foreach (var item in emplist)
            {
                Console.WriteLine(item.EmpID);
                Console.WriteLine(item.EmpName);
                Console.WriteLine(item.DeptNo);
                Console.WriteLine(item.City);
            }


            Console.ReadLine();
        }
    }
}
