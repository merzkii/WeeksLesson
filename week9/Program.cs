using System;

namespace week9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            student.Name = GetInputName("student");
            Console.WriteLine("enter age");
            student.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter data");
            student.StartStudyYear = int.Parse(Console.ReadLine());
            student.PrintMyInfo();
            Console.WriteLine("====================");


            var teacher = new Teacher();
            teacher.Name = GetInputName("teacher");
            string check=teacher.CheckSubject();
            Console.WriteLine(check);
            


        }


        public static string GetInputName(string someone)
        {
            Console.WriteLine($"enter {someone} name");
            var name = Console.ReadLine();
            return name;
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int StartStudyYear { get; set; }

        public static string GetRandomSubject()
        {
            string[] subjects = new string[] { "maths", "english", "chemistry", "other" };

            Random rnd = new Random();
            int index = rnd.Next(subjects.Length);
            return subjects[index];
        }
        public int GetLeftYears()
        {
            var result = 4 - (DateTime.Now.Year - StartStudyYear);
            return result;
        }

        public void PrintMyInfo()
        {
            Console.WriteLine($"me var {Name}, vswavlob {GetRandomSubject()}-s, damrcha {GetLeftYears()}");
        }
    }

    public class Teacher
    {
        public string Name { get; set; }
        public bool IsCertified { get; set; }

        public string CheckSubject()
        {
            var subject = Student.GetRandomSubject();
            if (subject == "maths")
            {
                return "2+2=4";
            }
            else if (subject =="english")
            {
               return "i'm table";
            }
            else if(subject =="chemistry")
            {
               return "h2o";
            }
            else
            {
                return "not competent";
            }
        }

    }


}






