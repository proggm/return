using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во патронов в магазине: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Введите количество магазинов: ");             
            int second=int.Parse(Console.ReadLine());    
            
            Console.WriteLine($"Всего патронов: " + Return(first,second));

            Console.ReadKey();            
        }
        public static int Return(int one, int two)
        {
            if (one >30)
            {
                return 0;
            }
            else
            {
                return one * two;
            }
        }

        
        
        
         
        
       
    }
}
