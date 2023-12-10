using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AandDSA3T2
{
    internal class CEO : Employee
    {
        int annualBonus {  get; set; }


        public CEO(string _name, int _salary, int _annualBonus) : base(_name, _salary)
        {
            annualBonus = _annualBonus;
        }

        public override int OutputEarnings()
        {
            return salary + annualBonus;
        }


        public override void OutputJobDescription()
        {
            Console.WriteLine("The CEO's job is to set the company strategy, lead and manage staff and ensure the company's overall success.");
        }

        public void OutputAnnualBonus()
        {
            Console.WriteLine("The CEO's projected annual bonus is $" + annualBonus);
        }

    }
}
