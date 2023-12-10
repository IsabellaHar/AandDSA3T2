using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AandDSA3T2
{
    public class Employee
    {

        public int ID {  get; }
        public string name {  get; set; }
        public int salary { get; set; }

        public Employee (string _name, int _salary)
        {
            name = _name;
            salary = _salary;
        }

        public virtual int OutputEarnings()
        {
            return salary;
        }

        public virtual void OutputJobDescription()
        {

        }

    }
}
