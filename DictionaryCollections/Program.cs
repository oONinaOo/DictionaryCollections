using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable lookup = new Hashtable();
            lookup["0"] = "zero";
            lookup["1"] = "one";
            lookup["2"] = "two";
            lookup["3"] = "three";
            lookup["4"] = "four";
            lookup["5"] = "five";
            lookup["6"] = "six";
            lookup["7"] = "seven";
            lookup["8"] = "eight";
            lookup["9"] = "nine";

            string number = "305-345-5688";
            foreach(char c in number)
            {
                string getNumber = c.ToString();
                if (lookup.ContainsKey(getNumber))
                {
                    Console.WriteLine(lookup[getNumber]);
                }
            }
        }
    }
}
