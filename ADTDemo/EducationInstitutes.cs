using System;

namespace ADTDemo
{
    class EducationInstitute
    {
        public IEducator[] LecturerPanel {
            get; set;
        }
    }

    interface IEducator { // Somewhat synonymous with ROLE
        // This is a contract
        // A contract defines abtract behaviours (behaviour placeholder)
        // Groups together related abstract behaviours
        void Teach();
        void Assess();
        void Prepare();
        void Read();
        void Research(); // E.g. Enforces the fact that lecturer should be able to do research. How the research is done is not relevant here.
    }

    class Employee : Person
    { 
    
    }

    class Person
    {
        public string NicNumber
        {
            get; set;
        }

        public string FirstName {
            get; set;
        }

        public string LastName
        {
            get; set;
        }
    }

    class AncEmployee : Employee, IEducator
    { 
        public string EmployeeNumber {
            get; set;
        }

        //To abide by the IEducator contract, the concrete brehaviours for the IEducator behaviours should be provided.
        public void Teach() {
            Console.WriteLine("Teaching...");
        }
        public void Assess() {
            Console.WriteLine("Asessing...");
        }
        public void Prepare() {
            Console.WriteLine("Preparing...");
        }
        public void Read() {
            Console.WriteLine("Reading...");
        }
        public void Research() {
            Console.WriteLine("Doing research...");
        }
    }

    class AncLecturer : AncEmployee
    { 
        
    }

    class BncEmployee : Employee
    {
        public string EmployeeNumber
        {
            get; set;
        }
    }

    class BncLecturer : AncEmployee
    {

    }
}
