using System;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Helper.Watch(InsertionSort.InsertSort);
            Helper.Watch(InsertionSort.ShellSort);
            Helper.Watch(InsertionSort.BinaryInsertSort);
            Helper.Watch(SelctionSort.SimpleSelectionSort);
            Helper.Watch(SelctionSort.BinarySelectionSort);
            Helper.Watch(SelctionSort.HeapSort);
            Helper.Watch(ExchangeSort.SimpleBubbleSort);
            Helper.Watch(ExchangeSort.BubbleWithFlagSort);
            Helper.Watch(ExchangeSort.BubbleTwoSidesSort);
            Helper.Watch(ExchangeSort.QuickSort);
            Helper.Watch(ExchangeSort.ImprovedQuickSort);
            Helper.Watch(MergeSort.NormalMergeSort);
            Helper.Watch(MergeSort.TwoSidesMergeSort);
            Helper.Watch(Radix.RadixSort);
        }
    }
}
