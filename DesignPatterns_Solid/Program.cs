//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;

//namespace DesignPatterns_Solid
//{
//    //Add and remove the entries
//    public class Journal
//    {
//        private List<string> entries = new List<string>();
//        public static int count = 0;
//        public int addEntry(string text)
//        {
//            entries.Add($"{++count} : {text}");
//            return count;
//        }

//        public void removeEntry(int index)
//        {
//            entries.RemoveAt(index);
//        }

//        public override string ToString()
//        {
//            return string.Join(Environment.NewLine, entries);
//        }
//    }


//    public class Persistence
//    {
//        public void SaveToFile(Journal j, string filename,bool overwrite=false)
//        {
//            if (overwrite || !File.Exists(filename))
//                File.WriteAllText(filename, j.ToString());
//        }
//    }

//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            var journal = new Journal();
//            journal.addEntry("I have eaten");
//            journal.addEntry("I have drunken");
//            Console.WriteLine(journal);
//            var p = new Persistence();
//            string filename = @"C:\C#_Projects\Entries";
//            p.SaveToFile(journal, filename, true);
//            //To start a process    
//            Process.Start(filename);
//        }
//    }
//}
