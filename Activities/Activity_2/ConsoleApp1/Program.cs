using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Transpose Matrix");
        Console.WriteLine("2. Interchange Columns of Matrix");
        Console.WriteLine("3. Interchange Rows of Matrix");
        Console.WriteLine("4. Concatenate Two Strings");
        Console.WriteLine("5. Sort an Array");
        Console.WriteLine("6. Search an Element in an Array");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Transpose();
                break;
            case 2:
                ChangeColumns();
                break;
            case 3:
                ChangeRows();
                break;
            case 4:
                Concatenate();
                break;
            case 5:
                SortArray();
                break;
            case 6:
                SearchElement();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void Transpose()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        int[,] transpose = GetTranspose(matrix);
        Console.WriteLine("Transposed Matrix:");
        PrintMatrix(transpose);
    }

    static void ChangeColumns()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        int col1 = 0, col2 = 2; 
        ChangeColumns(matrix, col1, col2);

        Console.WriteLine("Matrix after interchanging columns:");
        PrintMatrix(matrix);
    }

    static void ChangeRows()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        int row1 = 0, row2 = 2; 
        ChangeRows(matrix, row1, row2);

        Console.WriteLine("Matrix after interchanging rows:");
        PrintMatrix(matrix);
    }

    static void Concatenate()
    {
        Console.WriteLine("Enter first string:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter second string:");
        string str2 = Console.ReadLine();

        string result = str1 + str2;
        Console.WriteLine("Concatenated string: " + result);
    }

    static void SortArray()
    {
        Console.WriteLine("Choose sorting algorithm:");
        Console.WriteLine("1. Insertion Sort");
        Console.WriteLine("2. Bubble Sort");
        Console.WriteLine("3. Quick Sort");
        Console.WriteLine("4. Merge Sort");
        int sortChoice = Convert.ToInt32(Console.ReadLine());

        int[] array = { 34, 7, 23, 32, 5, 62 };

        switch (sortChoice)
        {
            case 1:
                InsertionSort(array);
                break;
            case 2:
                BubbleSort(array);
                break;
            case 3:
                QuickSort(array, 0, array.Length - 1);
                break;
            case 4:
                array = MergeSort(array);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine("Sorted array:");
        PrintArray(array);
    }

    static void SearchElement()
    {
        int[] array = { 34, 7, 23, 32, 5, 62 };
        Console.WriteLine("Enter element to search:");
        int element = Convert.ToInt32(Console.ReadLine());

        int index = Array.IndexOf(array, element);
        if (index >= 0)
        {
            Console.WriteLine($"Element found at index {index}.");
        }
        else
        {
            Console.WriteLine("Element not found.");
        }
    }

    static int[,] GetTranspose(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int[,] transpose = new int[columns, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        return transpose;
    }

    static void ChangeColumns(int[,] matrix, int col1, int col2)
    {
        int rows = matrix.GetLength(0);
        for (int i = 0; i < rows; i++)
        {
            int temp = matrix[i, col1];
            matrix[i, col1] = matrix[i, col2];
            matrix[i, col2] = temp;
        }
    }

    static void ChangeRows(int[,] matrix, int row1, int row2)
    {
        int columns = matrix.GetLength(1);
        for (int i = 0; i < columns; i++)
        {
            int temp = matrix[row1, i];
            matrix[row1, i] = matrix[row2, i];
            matrix[row2, i] = temp;
        }
    }

    static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }

    static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(array, low, high);
            QuickSort(array, low, pi - 1);
            QuickSort(array, pi + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        int temp1 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp1;
        return i + 1;
    }

    static int[] MergeSort(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int mid = array.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, array.Length - mid);

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

    static int[] Merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int leftIndex = 0, rightIndex = 0, resultIndex = 0;

        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex] <= right[rightIndex])
            {
                result[resultIndex++] = left[leftIndex++];
            }
            else
            {
                result[resultIndex++] = right[rightIndex++];
            }
        }

        while (leftIndex < left.Length)
        {
            result[resultIndex++] = left[leftIndex++];
        }

        while (rightIndex < right.Length)
        {
            result[resultIndex++] = right[rightIndex++];
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
