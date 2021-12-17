using System;
using System.Collections.Generic;
namespace Small_Bank
{
public class HeapSort {
    public void sort(List<int> arr, List<string> names)
    {
        int n = arr.Count;
        // Build heap (rearrange array)
        for (int i = n / 2 - 1; i >= 0; i--)
            heapify(arr, n, i,names);

        // One by one extract an element from heap
        for (int i = n - 1; i > 0; i--) {
            // Move current root to end
            int temp = arr[0];
            string Stemp = names[0];
            arr[0] = arr[i];
            names[0] = names[i];
            arr[i] = temp;
            names[i] = Stemp;

            // call max heapify on the reduced heap
            heapify(arr, i, 0, names);
        }
    }

    // To heapify a subtree rooted with node i which is
    // an index in arr[]. n is size of heap
    void heapify(List<int> arr, int n, int i, List<string> nameArr)
    {
        int largest = i; // Initialize largest as root
        int l = 2 * i + 1; // left = 2*i + 1
        int r = 2 * i + 2; // right = 2*i + 2

        // If left child is larger than root
        if (l < n && arr[l] > arr[largest])
            largest = l;

        // If right child is larger than largest so far
        if (r < n && arr[r] > arr[largest])
            largest = r;

        // If largest is not root
        if (largest != i) {
            int swap = arr[i];
            string help = nameArr[i];
            arr[i] = arr[largest];
            nameArr[i] = nameArr[largest];
            nameArr[largest] = help;
            arr[largest] = swap;

            // Recursively heapify the affected sub-tree
            heapify(arr, n, largest, nameArr);
        }
    }

    /* A utility function to print array of size n */
    public void printArray(List<int> arr,List<string> nameArr)
    {
        int n = arr.Count;
        Console.ForegroundColor = ConsoleColor.Blue;
        for (int i = 0; i < n; ++i)
        {
            Console.Write(nameArr[i] + " ");
            Console.WriteLine(arr[i] + " ");
        }
        Console.ResetColor();
    }
}
}