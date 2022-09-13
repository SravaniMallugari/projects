using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  
        public class student
        {
            public string name;
            public int clas;
            public char sec;

            public virtual void gettingdetails()
            {
                Console.WriteLine("*****Enter the student details****");
                Console.ForegroundColor = ConsoleColor.Green;   
                Console.WriteLine("Enter the student name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the student class ");
                clas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the student section");
                sec = Convert.ToChar(Console.ReadLine());
            }
            public virtual void printthedetails()
            {
                Console.WriteLine("****Getting and printing  the student details***");
                Console.WriteLine(name);
                Console.WriteLine(clas);
                Console.WriteLine(sec);
            }
        }
        public class teacher : student
        {
            public string subject;
            public override void gettingdetails()
            {
                Console.WriteLine("****enter the belong  teacher details of the student****");
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Enter the class teacher name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the class as integer ");
                clas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the section as character");
                sec = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter the subject name:");
                subject = Console.ReadLine();
            }
            public override void printthedetails()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("***printing  the teacher details****");
                Console.WriteLine(name);
                Console.WriteLine(clas);
                Console.WriteLine(sec);
                Console.WriteLine(subject);
            }
        }
        public class subject : student
        {
            public string subcode;
            public override void gettingdetails()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter the subject details");
                Console.WriteLine("Enter the subject name in string");
                name = Console.ReadLine();  
                Console.WriteLine("Enter the subject code as string ");
                subcode = Console.ReadLine();

        }
            public override void printthedetails()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("print the student details");
                Console.WriteLine(name);
                Console.WriteLine(subcode);
                Console.ReadLine();

            }
        }

    }


