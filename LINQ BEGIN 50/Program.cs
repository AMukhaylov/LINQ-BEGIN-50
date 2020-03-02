using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        // Вариант 2 Beginer
        // Задача 50
        static void Main(string[] args)
        {

            List<string> strList1 = new List<string> { "bzdfg", "crerg", "afdsdfg", "gegdhgd" };
            List<string> strList2 = new List<string> { "gergdfh", "tyr", "hfgh", "jhgjhgjt", "jhgjg", "ertreg", "fghgfbr", "fghgfhfgh" };

            var result4 = strList1.GroupJoin(
                strList2,   // второй набор
                s => s[0],  // свойство-селектор первого набора
                x => x[0],  // свойство-селектор второго набора
                (s, x) => new
                {
                    Name = s,
                    Count = x.Count()
                });

            foreach (var i in result4)
            {
                Console.WriteLine(string.Format("{0}:{1}", i.Name, i.Count));
            }
            Console.ReadKey();
        }
    }
}
