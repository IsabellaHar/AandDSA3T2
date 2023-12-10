using System;

namespace AandDSA3T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Step 3
            MaxHeap employeeHeap = new MaxHeap(10);

            //Step 4
            
            CEO theCEO = new CEO("Ross McEwen", 3790000, 1500000);
            addEmployee(employeeHeap, theCEO);

                
            Programmer P1 = new Programmer("Isabella Harbour", 500000, 1000, 0);
            addEmployee(employeeHeap, P1);

            Programmer P2 = new Programmer("Aisha Patel", 400000, 345, 2);
            addEmployee(employeeHeap, P2);

            Programmer P3 = new Programmer("Sakura Tanaka", 300000, 245, 24);
            addEmployee(employeeHeap, P3);

            Programmer P4 = new Programmer("Chen Wei", 200000, 200, 36);
            addEmployee(employeeHeap, P4);

            Programmer P5 = new Programmer("Marek Petrov", 180000, 180, 45);
            addEmployee(employeeHeap, P5);

            Programmer P6 = new Programmer("Mateo Coli", 175000, 150, 50);
            addEmployee(employeeHeap, P6);

            Programmer P7 = new Programmer("Omar Mansour", 150000, 140, 60);
            addEmployee(employeeHeap, P7);

            Janitor J1 = new Janitor("Anastasia Ivanova", 50000);
            addEmployee(employeeHeap, J1);

            Janitor J2 = new Janitor("Peter Muller", 49000);
            addEmployee(employeeHeap, J2);


            employeeHeap.EmptyHeap();


        }

        public static void addEmployee(MaxHeap _employeeHeap, Employee _employee)
        {
            if (_employeeHeap.insertEmployee(_employee))  Console.WriteLine(_employee.name + " was added to the Heap") ;
            else Console.WriteLine("Heap is full, new employee not added");
        }
    }
}
