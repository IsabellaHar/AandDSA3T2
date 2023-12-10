using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AandDSA3T2
{
    public class Janitor : Employee
    {
        public Janitor(string _name, int _salary) : base(_name, _salary) 
        {
        }

        public override void OutputJobDescription()
        {
            Console.WriteLine("The janitor's job is to keep the workplace clean and tidy.");
        }


    }
}
