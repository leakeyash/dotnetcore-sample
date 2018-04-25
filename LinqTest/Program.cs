using System;
using System.Linq;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = MockData.GetInfos();
            var result = data.OrderBy(x=>x.Id).ThenBy(x=>x.Name);
            var query = from item in data.Select(x=>new {Id = x.Id,Name = x.Name, DetailOrigin = x.Details.Select(y=>y.name=="eod")})               
                orderby item.DetailOrigin select item;

            Console.WriteLine(result);
            Console.WriteLine("Hello World!");
        }
    }
}
