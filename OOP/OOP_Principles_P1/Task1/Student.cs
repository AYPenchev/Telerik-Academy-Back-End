﻿namespace Task1
{
    using System;
    using System.Collections.Generic;

    public class Student : Human
    {
        public Student() : base()
        {

        }

        public int ClassNumber { get;  set; }
        public override int Age { get; set; }

        public void Learn(Discipline discipline)
        {
            Console.WriteLine(discipline.Name);
        }
    }
}
