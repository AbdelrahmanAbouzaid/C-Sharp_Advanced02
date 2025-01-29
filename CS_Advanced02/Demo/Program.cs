using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void DisplayList(ICollection collection)
        {
            foreach (var item in collection)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region What is Collections
            // Collection in C#
            //  Lists
            //  HashTables

            // Generic - Non-Generic
            // Lists
            //  Non-Generic : ArrayList - Stack - Queue
            //  Generic     : List - LinkedList - Stack - Queue

            // HashTables
            //  Non-Generic : HashTable
            //  Generic     : Dictionary - SortedDictionary 
            #endregion

            #region ArrayList
            // Lists [ArrayList]
            //  Non-Generic : ArrayList 
            // ArrayList Like Array
            // Array Based
            // Indexed

            // Array     : Indexed Collection : Fixed Length
            // ArrayList : Indexed Collection : Dynamic Length


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //ArrayList list = new ArrayList();
            //Console.WriteLine($"Count : {list.Count} , Capacity: {list.Capacity}");
            //list.Add( 1 );
            //ArrayList list = new ArrayList(numbers);
            //Console.WriteLine($"Count : {list.Count} , Capacity: {list.Capacity}");// 10 , 10 

            //Console.WriteLine(list.IsFixedSize);
            //Console.WriteLine(list.IsReadOnly);
            //Console.WriteLine(list[1]);

            //list.AddRange(new int[] { 10, 20, 30 });
            //int index = list.BinarySearch(2);
            //bool flag = list.Contains(index);

            //int[] arr = new int[list.Count];
            ////list.CopyTo(arr);
            ////list.CopyTo(arr, 0);
            //list.CopyTo(1, arr, 0, 4);

            //// ArrayList list2 = list.GetRange(3, 5);

            //int x = list.IndexOf(index);

            //DisplayList(list);
            ////DisplayList(list2);

            //DisplayList(arr);
            ////list.Clear(); 
            #endregion

            #region List

            // Lists
            //  Generic : List
            // List : Virsion Generic Of ArrayList

            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //List<int> list = new List<int>(new int[] { 1, 2, 3, 4, 5 });

            //list.AddRange(new int[] { 6, 7, 8, 9, 10 });
            //list.Sort(); 
            #endregion









        }
    }
}
