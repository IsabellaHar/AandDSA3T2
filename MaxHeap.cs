using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AandDSA3T2
{
    public class MaxHeap
    {
        //Step 3
        public Employee[] heapArray {  get; set; }

        public int capacity { get; set; }

        public int currentHeapSize {  get; set; }

        public MaxHeap(int _capacity)
        {
            capacity = _capacity;
            heapArray = new Employee[_capacity];
            currentHeapSize = 0;
        }


        public bool insertEmployee(Employee _employee)
        {
            if (currentHeapSize == capacity)
            {
                return false;
            }

            int index = currentHeapSize;
            heapArray[index] = _employee;
            currentHeapSize++;

            while (index != 0 && heapArray[index].salary > heapArray[GetParent(index)].salary)
            {
                Swap(ref heapArray[index], ref heapArray[GetParent(index)]);
                    index = GetParent(index);
            }
            return true;
        }

        public int GetParent(int index)
        {
            return (index - 1) / 2;
        }


        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }



        public Employee extractMax()
        {
            if (currentHeapSize <= 0)
            {
                return null;
            }

            if (currentHeapSize == 1)
            {
                currentHeapSize--;
                return heapArray[0];
            }

            Employee max = heapArray[0];

            heapArray[0] = heapArray[currentHeapSize - 1];
            currentHeapSize--;
            MaxHeapify(0);

            return max;

        }

        public void MaxHeapify(int rootIndex)
        {
            int leftChild = LeftChild(rootIndex);
            int rightChild = RightChild(rootIndex);

            int largest = rootIndex;

            if (leftChild < currentHeapSize && heapArray[leftChild].salary > heapArray[largest].salary)
            {
                largest = leftChild;
            }
            if (rightChild < currentHeapSize && heapArray[rightChild].salary > heapArray[largest].salary)
            {
                largest = rightChild;
            }

            if (largest != rootIndex)
            {
                Swap(ref heapArray[rootIndex], ref heapArray[largest]);
                MaxHeapify(largest);
            }

        }


        public int LeftChild(int index)
        {
            return 2 * index + 1;
        }

        public int RightChild(int index)
        {
            return 2 * index + 2;
        }




        public Employee getMax()
        {
            return heapArray[0];
        }

        public void EmptyHeap()
        {
            while (currentHeapSize != 0)
            {
                Employee top = extractMax();
                Console.WriteLine();
                Console.WriteLine("Employee: " + top.name);
                Console.Write("Job Description: ");
                top.OutputJobDescription();
                Console.WriteLine("Annual Earnings: " + top.OutputEarnings().ToString("C"));  
            }
        }
    }
}


/*Reference https://www.geeksforgeeks.org/binary-heap/ */
