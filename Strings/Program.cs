using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            //stringler char array dir.
            //NewMethod();
            string sentence = "Metin örneği";

            var result = sentence.Length;
            var result1 = sentence.Clone();
            sentence = "Nesne";

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(sentence);

            bool result2 = sentence.EndsWith("c");
            bool result3 = sentence.StartsWith("h");

            var result5 = sentence.IndexOf("adım");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, " merhaba");
            var result9 = sentence.Substring(0, 3);
            var result10 = sentence.ToLower();
            var result11 = sentence.Replace("Caner", "Genco");
            var result13 = sentence.Remove(0, 3);   

            Console.ReadLine();
        }

        private static void NewMethod()
        {
            string str = "Sabri";
            string str2 = "Genco";
            foreach (var sr in str)
            {
                Console.WriteLine(sr);
            }
            Console.WriteLine(string.Format("{0}{1}", str, str2));
            Console.WriteLine(str + str2);
        }
    }
}
