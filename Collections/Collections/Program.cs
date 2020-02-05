using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)

        {
            // ARRAYLIST
            // Creates and initializes a new ArrayList.
            // Can hold different types of data
            // Use Add/Remove to insert/delete elements

            ArrayList myAL = new ArrayList();
            myAL.Add("HelloAgain");
            myAL.Add("!");
            myAL.Add("World");
            myAL.Add("!");
            myAL.Add("Hello There");
            //myAL.Add(1);
            //myAL.Add(true);

            bool bContains = myAL.Contains("!");
            int hereItIs = myAL.IndexOf("Hello");  // returns -1
            int hereItIs2 = myAL.LastIndexOf("!");

            myAL.Sort();

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("    Count:    {0}", myAL.Count);
            Console.WriteLine("    Capacity: {0}", myAL.Capacity);
            Console.Write("    Values:");
            PrintValues(myAL);

            // Sorting with IComparable

            // create and initalize new ArrayList, i.e. mylist 
            ArrayList mylist = new ArrayList();
            mylist.Add("Welcome");
            mylist.Add("to");
            mylist.Add("geeks");
            mylist.Add("for");
            mylist.Add("geeks");
            mylist.Add("2");

            IComparer Comp1 = new myClass();

            // sort the value of ArrayList 
            // using Sort(IComparer) method 
            mylist.Sort(Comp1);

            foreach (Object ob in mylist)
            {
                Console.WriteLine(ob);
            }


            // HASHTABLE
            // Create a new hash table.
            // Uses Add/Remove
            Hashtable openWith = new Hashtable();

            // Add some elements to the hash table. There are no 
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            // The Add method throws an exception if the new key is 
            // already in the hash table.
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }
        }
        
        // Calls CaseInsensitiveComparer.Compare 
        // with the parameters REVERSED.  (See b,a in Compare(b,a))
        public class myClass : IComparer
        {

            int IComparer.Compare(Object a, Object b)
            {
                return ((new CaseInsensitiveComparer()).Compare(b, a));
            }
        }

        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}
