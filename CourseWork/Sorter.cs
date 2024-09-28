using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CourseWork
{
    public class Sorter
    {
        private bool IsAscending;
        private bool IsAnim;
        public int Complexity = 0;
        private int maxDepth = 0;
        private int permutNum = 0;
        public Stopwatch ExecutionTime = new Stopwatch();
        public Sorter()
        {
            IsAscending = true;
            IsAnim = false;
        }
        public Sorter(bool isAscending)
        {
            IsAscending = isAscending;
            IsAnim = false;
        }
        public Sorter(bool isAscending, bool isAnim)
        {
            IsAscending = isAscending;
            IsAnim = isAnim;
        }

        private bool Compare(int a, int b)
        {
            if (IsAscending)
                return a < b;
            else
                return a > b;
        }
        private void Swap(List<int> array, int i, int j)
        {
            if (IsAnim)
                Program.mainWindow.tuplesAnimation.Add((i, j));
            (array[i], array[j]) = (array[j], array[i]);
        }

        // Метод для сортування злиттям
        public void MergeSort(List<int> array)
        {
            ExecutionTime.Start();
            MergeSortRecursive(array, 0, array.Count - 1, 0);
            ExecutionTime.Stop();
            Complexity = array.Count * maxDepth;
        }
        private void MergeSortRecursive(List<int> array, int left, int right, int currentDepth)
        {
            if (currentDepth > maxDepth)
                maxDepth = currentDepth;
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSortRecursive(array, left, middle, currentDepth + 1);
                MergeSortRecursive(array, middle + 1, right, currentDepth + 1);
                Merge(array, left, middle, right);
            }
        }
        private void Merge(List<int> array, int left, int middle, int right)
        {
            int i = left, j = middle + 1, k = 0;
            if (IsAnim)
            {
                ExecutionTime.Stop();
                int midTemp = middle;
                int[] tempAnim = array.GetRange(left, right - left + 1).ToArray();
                while (i <= midTemp && j <= right)
                {
                    if (Compare(array[i], array[j]))
                        i++;
                    else
                    {
                        int tempNum = array[j];
                        int index = j;
                        while (index > i)
                        {
                            Program.mainWindow.tuplesAnimation.Add((index, index - 1));
                            array[index] = array[index - 1];
                            index--;
                        }
                        array[i] = tempNum;
                        midTemp++;
                        i++;
                        j++;
                    }
                }
                for (int t = 0; t < tempAnim.Length; t++)
                    array[left + t] = tempAnim[t];
                i = left;
                j = middle + 1;
                ExecutionTime.Start();
            }
            int[] temp = new int[right - left + 1];
            while (i <= middle && j <= right)
            {
                if (Compare(array[i], array[j]))
                    temp[k++] = array[i++];
                else
                    temp[k++] = array[j++];
            }
            while (i <= middle)
                temp[k++] = array[i++];
            while (j <= right)
                temp[k++] = array[j++];
            for (i = left, k = 0; i <= right; i++, k++)
                array[i] = temp[k];
        }

        // Метод для швидкого сортування
        public void QuickSort(List<int> array)
        {
            ExecutionTime.Start();
            QuickSortRecursive(array, 0, array.Count - 1, 0);
            ExecutionTime.Stop();
            Complexity = array.Count * maxDepth;
        }
        private void QuickSortRecursive(List<int> array, int low, int high, int currentDepth)
        {
            if (currentDepth > maxDepth)
                maxDepth = currentDepth;
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSortRecursive(array, low, pivotIndex - 1, currentDepth + 1);
                QuickSortRecursive(array, pivotIndex + 1, high, currentDepth + 1);
            }
        }
        private int Partition(List<int> array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (Compare(array[j], pivot))
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);
            return i + 1;
        }

        // Інтроспективне сортування
        public void IntroSort(List<int> array)
        {
            ExecutionTime.Start();
            int depthLimit = (int)(2.0 * Math.Log(array.Count));
            IntroSortRecursive(array, 0, array.Count - 1, depthLimit, 0);
            ExecutionTime.Stop();
            Complexity = (permutNum > 0) ? permutNum : array.Count * maxDepth;
        }
        private void IntroSortRecursive(List<int> array, int start, int end, int depthLimit, int currentDepth)
        {
            if (currentDepth > maxDepth)
                maxDepth = currentDepth;
            if (start < end)
            {
                if (depthLimit == 0)
                {
                    HeapSort(array, start, end);
                }
                else
                {
                    int pivot = Partition(array, start, end);
                    IntroSortRecursive(array, start, pivot - 1, depthLimit - 1, currentDepth + 1);
                    IntroSortRecursive(array, pivot + 1, end, depthLimit - 1, currentDepth + 1);
                }
            }
        }

        // Метод для сортування кучами
        private void HeapSort(List<int> array, int start, int end)
        {
            int n = end - start + 1;
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i + start, start);
            for (int i = end; i > start; i--)
            {
                Swap(array, start, i);
                permutNum++;
                Heapify(array, i - start, start, start);
            }
        }
        private void Heapify(List<int> array, int n, int i, int offset)
        {
            int largest = i;
            int left = 2 * (i - offset) + 1 + offset;
            int right = 2 * (i - offset) + 2 + offset;

            if (left < n + offset && Compare(array[largest], array[left]))
                largest = left;
            if (right < n + offset && Compare(array[largest], array[right]))
                largest = right;
            if (largest != i)
            {
                Swap(array, i, largest);
                permutNum++;
                Heapify(array, n, largest, offset);
            }
        }
    }
}