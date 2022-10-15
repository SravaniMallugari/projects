using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dallibrary;

namespace departments
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            employ context = new employ();
            DeptMaster deptMaster = new DeptMaster();
            Console.WriteLine("Enter department  code");
            deptMaster.deptcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter deptarment name");
            deptMaster.deptname = Console.ReadLine();
            context.DeptMasters.Add(deptMaster);
            Console.WriteLine("Do you want to add more");
            string m = Console.ReadLine();
            if (m == "Y" || m == "y")
            {
                goto start;
            }
            context.SaveChanges();
        }
    }
}
