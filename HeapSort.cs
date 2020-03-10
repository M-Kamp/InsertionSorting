using System;
using System.Collections.Generic;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Aarray = new List<int>();

            Random Rnum = new Random();

            // Fill list with 10 random numbers
            for (int i = 0; i < 10; i++)
            {
                Aarray.Add(Rnum.Next(1, 21));
            }

            Console.WriteLine("\n Random List For Heapsort \n");
            for (int i = 0; i < Aarray.Count; i++)
            {
                Console.Write(Aarray[i] + "\t");
            }
            Console.ReadLine();

            HeapSort(Aarray);

            Console.WriteLine("\n Heapsort Result \n");
            for (int i = 0; i < Aarray.Count; i++)
            {
                Console.Write(Aarray[i] + "\t");
            }
            Console.ReadLine();

            HeapMaximum(Aarray);

            void HeapSort(List<int> A)
            {
                int heapSize = Aarray.Count;
                int key;

                BuildMaxHeap(A);

                for (int i = heapSize - 1; i >= 0; i--)
                {
                    key = A[0];
                    A[0] = A[i];
                    A[i] = key;
                    MaxHeapify(A,i, 0);
                }
            }

            void MaxHeapify(List<int> A, int heapSize, int index)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int largest = index ;
                int key;

                if (left < heapSize && A[left] > A[largest])
                {
                    largest = left;
                }
                

                if (right < heapSize && A[right] > A[largest])
                {
                    largest = right;
                }

                if (largest != index)
                {
                    key = A[index];
                    A[index] = A[largest];
                    A[largest] = key;
                    MaxHeapify(A, heapSize, largest);
                }
            }

            void BuildMaxHeap(List<int> A)
            {
                int heapSize = A.Count;
                for (int i = A.Count / 2 - 1; i >= 0; i--)
                {
                    MaxHeapify(A,heapSize, i);
                }
            }

            void HeapIncreaseKey(List<int> A, int index, int key)
            {
                if (key < A[index])
                {
                    Console.WriteLine("Error: new key is smaller than current key!");
                }

                A[index] = key;
                while (index > 0 && A[Parent(index)] < A[index])
                {
                    A[index] = key;
                    A[index] = A[Parent(index)];
                    A[Parent(index)] = key;
                    index = Parent(index);
                }
            }
        }
    }
}
    
