using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    class Student
    {
        private static int id;
        public int Id { get; set; }

        public string Fullname { get; set; }

        public string Subject { get; set; }

        private static int count = 1000;
        public int Count { get; set; }




        public Student(string fullname,string subject)
        {
            Id = ++id;
            Count = ++count;
            Fullname = fullname;
            Subject = subject;
        }


        public string GroupName()
        {
            return char.ToUpper(Subject[0]) + char.ToUpper(Subject[1]).ToString();
        }

        public void getinfo()
        {
            Console.WriteLine($"Id: {Id},Fullname: {Fullname},Subject: {Subject}, Count: {Count}");
        }


    }
}
