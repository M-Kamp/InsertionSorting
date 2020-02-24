static void Main(string[] args)
{
            Random RandNum = new Random();
            int[] A = new int[20];
            int Key, i, j, m;

            for (m = 0; m < 19; m++)
            {
                mergeArr[m] = RandNum.Next(1, 100);
            }

            Console.WriteLine("\n before sorting");
            for (i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + "\t");
            }

            // Insertion Sorting
            for (i = 1; i < A.Length; i++) // Start at index 1
            {
                Key = A[i]; // Save the value (key) at index A[1]
                for (j = i - 1; j >= 0 && Key < A[j]; j--) // Check if previous index (j) is smaller than current index(i)
                {
                    A[j + 1] = A[j];
                    A[j] = Key;
                }
            }

            Console.WriteLine("\n After Insertion Sorting \n");
            for (i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + "\t");
            }
            Console.ReadLine();
}
