using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    class Student
    {
        public static int StaticId { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }

        public Student(string? name)
        {
            Id = ++StaticId;
            Name = name;
        }


        public override string ToString()
         => $"{Id} - {Name}";
    }
}
