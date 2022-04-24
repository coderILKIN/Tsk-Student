using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            string subject = Console.ReadLine();

            Student student = new Student("Ilkin Yusubov",subject);

             subject = Console.ReadLine();

            Student student1 = new Student("Tahir Memmedeov",subject);

            Console.WriteLine(student.GroupName() + student.Count);
            Console.WriteLine(student1.GroupName() + student1.Count);

            student.getinfo();
            student1.getinfo();
        }
    }
}
