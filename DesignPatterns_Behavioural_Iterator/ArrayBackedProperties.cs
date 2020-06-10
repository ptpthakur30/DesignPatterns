using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Windows;
using static System.Console;

namespace DesignPatterns_Behavioural_Iterator
{
    public class Creature : IEnumerable<int>
    {
        //Array backded
        private int[] stats = new int[3];

        private const int strength = 0;

        public int Strength
        {
            get => stats[strength];
            set => stats[strength] = value;
        }

        public int Agility { get; set; }
        public int Intelligence { get; set; }

        //We can use array functions 
        public double AverageStat =>
          stats.Average();

        //Can provide array as IEnumerable
        public IEnumerator<int> GetEnumerator()
        {
            return stats.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int this[int index]
        {
            get { return stats[index]; }
            set { stats[index] = value; }
        }
    }

    public class ArrayBackedProperties
    {
        static void Main(string[] args)
        {
        }
    }
}
