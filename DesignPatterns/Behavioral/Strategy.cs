using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.DesignPatterns.Behavioral
{
    internal class Strategy
    {
    }
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }

    public class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();  // Default is Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }
    
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort();  not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }
   
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }
   
    public class SortedList
    {
        private List<string> list = new List<string>();
        private SortStrategy sortstrategy;
        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }
        public void Add(string name)
        {
            list.Add(name);
        }
        public void Sort()
        {
            sortstrategy.Sort(list);
            // Iterate over list and display results
            foreach (string name in list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
