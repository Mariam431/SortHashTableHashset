using System.Collections;

namespace SortHashTableHashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            // Add some items to the hashtable
            ht.Add("key1", "value1");
            ht.Add("key2", "value2");
            ht.Add("key3", "value3");

            // Create a new sorted dictionary based on the hashtable
            var sorted = new SortedDictionary<string, object>(ht);

            // Iterate over the sorted dictionary
            foreach (var entry in sorted)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }




            HashSet<int> hs = new HashSet<int>();

            // Add some items to the hashset
            hs.Add(3);
            hs.Add(1);
            hs.Add(2);

            // Create a new sorted list based on the hashset
            var sorted1 = new List<int>(hs);
            sorted1.Sort();

            // Iterate over the sorted list
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}