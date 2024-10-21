using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Hasher
    {
        private Dictionary<int, string> data = new Dictionary<int, string>();

        // Add entries to the dictionary
        public void AddData(int key, string value)
        {
            data.Add(key, value);
        }

        // Search for a value by key
        public void SearchByKey(int key)
        {
            if (data.ContainsKey(key))
            {
                Console.WriteLine($"Key: {key}, Value: {data[key]}");
            }
            else
            {
                Console.WriteLine($"Key {key} not found.");
            }
        }

        // Display all key-value pairs
        public void DisplayAllData()
        {
            foreach (var item in data)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }

}
