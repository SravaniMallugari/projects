using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using storingdata;
namespace StoringdataTest
{
    [TestFixture]
    public class Class_test
    {
        
        [TestCase]
        public void test_student()
        {
            student stu = new student();
            stu.student_id = 21;
            stu.student_name = "laura";
            Assert.AreEqual(stu.student_id, 21);
        }
        [TestCase]
        public void test_subject()
        {
            subject sub = new subject();
            sub.subject_id = 100;
            sub.subject_name = "sanskrit";
            sub.subject_marks = 100;
            Assert.AreEqual(sub.subject_marks, 100);
        }
        [TestCase]
        public void test_teacher()
        {
            teacher t = new teacher();
            t.teacher_id = 123;
            t.teacher_name = "radhika";
            Assert.AreEqual(t.teacher_name, "radhika");
        }

    }
}
