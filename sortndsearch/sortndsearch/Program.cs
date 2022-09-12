using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortndsearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = @"C:\dotnet\sortndsearch\sortndsearch\bin\Debug\student1.txt";
            FileStream fs = new FileStream(str, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<Student> list = new List<Student>();
            while (!sr.EndOfStream)
            {
                string k = sr.ReadLine();
                char[] c = new char[]
                { ' ', '\t' };
                string[] man = k.Split(c, StringSplitOptions.None);
                Student s = new Student();
                s.nm = man[0];
                s.Class = Convert.ToInt32(man[1]);
                list.Add(s);
            }
            sr.Close();
            fs.Close();
            sr.Dispose();
            fs.Dispose();

        start:
            Console.WriteLine("*****Program for search and sorting in a text file*****");
            Console.WriteLine(" 1.Sorting in Class 2.Searching in  class 3.Sort through name 4.Searching through name 5.Display");
            Console.WriteLine("enter the choice ");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Sort by Class");
                    var v = list.OrderBy(q => q.Class).ToList();
                   
                    foreach (Student s in v)
                    {
                        
                        Console.WriteLine($"these student {s.nm} is studying  {s.Class} class");
                    }
                    break;
                case 2:
                    Console.WriteLine("Search By Class");
                    foreach (Student s in list)
                    {
                        Console.WriteLine($"the student {s.nm} studying in {s.Class}");
                    }
                    Console.WriteLine("Enter the Class number  in integer  to search");
                    int pr1 = Convert.ToInt32(Console.ReadLine());
                    var vr = list.Where(q => q.Class == pr1).ToList();
                    if (vr != null)
                    {
                        foreach (Student s in vr)
                        {
                            Console.WriteLine($"the student {s.nm} studying in {s.Class}");
                        }

                    }
                    else
                    {
                        Console.WriteLine("----class is empty--- ");
                    }
                   
                    break;
                case 3:
                    Console.WriteLine("Sort by Name");
                    var v1 = list.OrderBy(q => q.nm).ToList();
                    foreach (Student s in v1)
                    {
                        Console.WriteLine($"the student{s.nm} studying in {s.Class}");
                    }
                    
                    break;
                case 4:
                    Console.WriteLine("Search through name");
                    foreach (Student s in list)
                    {
                        Console.WriteLine($" the student {s.nm} studying in {s.Class}");
                    }
                    Console.WriteLine("Enter the name  to search from text file");
                    string pr = Console.ReadLine();
                    var v2= list.Where(q => q.nm == pr).ToList();
                   
                    if (v2 != null)
                    {
                        foreach (Student s in v2)
                        {
                            Console.Write($"the student {s.nm} studying in {s.Class} \n");
                        }

                    }
                    else
                    {
                        Console.WriteLine("-----errorrr---");
                    }
                    break;
                case 5:
                    Console.WriteLine("****The student details are:******");
                    foreach (Student s in list)
                    {
                        Console.Write($" the student is {s.nm} studying in {s.Class}  \n");
                    }
                    break;
            }
            Console.WriteLine("if u want to continue  yes" );
            string cursor = Console.ReadLine();
            if (cursor == "yes")
            {
                goto start;
            }
        }
    }
    public class Student
    {
        public string nm { get; set; }
        public int Class { get; set; }
    }
}
    
