using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>
            {
                { 1, "Apple" },
                { 2, "Orange" },
                { 3, "bnana" },
                { 4, "Kiwi" }
            };

            GetValueFromDictionary(dic,3);
            PrintKeys(dic.Keys);
            FindKeyByValue(dic,"Kiwi");
            FindValueByKey(dic, 2);
            PrintAllValues(dic);


            dic.Remove(2);//it will remove value from index 2
            int count = dic.Count;

            Console.ReadKey();
          

        }
        public static void GetValueFromDictionary(Dictionary<int, string> dictionary, int key)
        {
            string value;
            if (dictionary.TryGetValue(key, out value))
            {
                Console.WriteLine($"The value of key '{key}' is {value}");
            }
            else
            {
                Console.WriteLine($"The key '{key}' does not exist in the dictionary.");
            }
        }
      

        public static void PrintKeys(Dictionary<int,string>.KeyCollection keys)
        {
            keys.ToList().ForEach(key =>
            {
                Console.WriteLine($"The  key '{key}'");
            });
        }

        public static void FindKeyByValue(Dictionary<int,string> dic,string value)
        {
            int key=dic.Where(x=>x.Value==value).Select(c=>c.Key).FirstOrDefault();
            Console.WriteLine("Get key by Value= "+key);
        }

        public static void FindValueByKey(Dictionary<int, string> dic, int key)
        {
            Console.WriteLine("Get Value by Key "+dic[key]);
        }

        public static void PrintAllValues(Dictionary<int, string> dic)
        {
            foreach (var item in dic)
            {
                Console.WriteLine("Key is= {0} and Value is= {1}",item.Key,item.Value);
            }
        }
}
}
