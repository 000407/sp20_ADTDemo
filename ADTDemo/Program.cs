using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*AncLecturer[] lecturers = {
                new AncLecturer() { 
                    FirstName = "Kanchana",
                    LastName = "Senadheera",
                    NicNumber = "123456789012",
                    EmployeeNumber = "23478"
                },
                new AncLecturer() {
                    FirstName = "Ramona",
                    LastName = "David",
                    NicNumber = "123456789123",
                    EmployeeNumber = "23475"
                }
            };

            EducationInstitute anc = new EducationInstitute();
            anc.LecturerPanel = lecturers;*/
            MyByteStack stack = new MyByteStack(3);

            stack.Push(13);
            stack.Push(-9);
            stack.Push(23);
            stack.Push(-56); // Will display error message

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Push(17);
            stack.Push(21);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.ReadLine();
        }
    }
}
