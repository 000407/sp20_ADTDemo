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
            AncLecturer[] lecturers = {
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
            anc.LecturerPanel = lecturers;
        }
    }
}
