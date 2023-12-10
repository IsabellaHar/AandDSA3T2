using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AandDSA3T2
{
    internal class Programmer : Employee
    {
        int bugsFixed { get; set; }
        int bugsCreated { get; set; }


        public Programmer(string _name, int _salary, int _bugsFixed, int _bugsCreated) : base(_name, _salary)
        {
            bugsFixed = _bugsFixed;
            bugsCreated = _bugsCreated;
        }

        public override void OutputJobDescription()
        {
            Console.WriteLine("A programmers job is to develop and code the company's applications, systems and websites.");
        }


        public void OutputBugsFixed()
        {
            Console.WriteLine("Bugs fixed: " +  bugsFixed);
        }

        public void OutputBugsCreated()
        {
            Console.WriteLine("Bugs created: " + bugsCreated);
        }

    }
}
