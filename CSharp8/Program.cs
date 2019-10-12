using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp8
{
    class Program
    {
        public static List<Student> People { get; private set; }

        static void Main(string[] args)
        {
            var names = GetEnrollees().ToList();
            Console.ReadLine();
        }

        static IEnumerable<string> GetEnrollees()
        {
            People = new List<Student>
            {
                new Student { Name = "test1", Graduated = true },
                new Student { Name = "test2", Graduated = false },
                new Student { Name = "test3", Graduated = false },
                new Student { Name = "test4", Graduated = false },
            };
            foreach (var p in People)
            {
                if (p is Student { Graduated: false, Name: string name })
                {
                    yield return name;
                }
            }
        }
    }

    public class Student
    {
        public bool Graduated { get; set; }
        public string Name { get; set; }
    }
}
