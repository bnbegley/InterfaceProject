using System;

namespace InterfaceProject {
    class Program {
        static void Main(string[] args) {

            IStudent greg = new FakeGreg();
            Student[] students = greg.GetStudents();
            int idx = 0;
                while (idx < students.Length) {
                Console.WriteLine($"Student name is {students[idx].Name}.");
                idx = idx + 1; 
            }

        }
    }

    class Student {
        public string Name { get; set; } 
    }

   interface IStudent {
        Student[] GetStudents();
    }
    class FakeGreg: IStudent {

        public Student[] GetStudents () {
            Student[] students = new Student[] {
                new Student {Name = "Denise"},
                new Student {Name = "Kim"},
                new Student {Name = "Greg"}

            }; 
            return students;
        }
    }
}
