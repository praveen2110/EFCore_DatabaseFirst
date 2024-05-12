using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_DatabaseFirst
{
    public class Program
    {
        static void Main(string[] args)
        {        
            using (EFDemoEntity context = new EFDemoEntity())
            {
                Student student = new Student();

                /* student.FirstName = "Test";
                 student.LastName = "Test";
                 student.StandardId = 1;

                 context.Students.Add(student);*/

                /*var Allstudent = context.Students.ToList();

                foreach (var stud in Allstudent)
                {
                    Console.WriteLine(stud.LastName);
                }
                Console.ReadKey();*/

                /*student = context.Students.Find(19);

                student.FirstName = "TestUpdate";*/

                /*student = context.Students.Find(19);
                context.Students.Remove(student);*/

                //context.SaveChanges();


            }
        }
    }
}
