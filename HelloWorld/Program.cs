using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            foreach(var item in Enumerable.Range(0,10).Where(x=>x%2==0)){
                Console.WriteLine(item);
            }
            ints.AddRange(Enumerable.Range(0,5));
            Console.WriteLine(JsonConvert.SerializeObject(ints)); 
            Console.WriteLine("Hello World!");
        }
    }
}
