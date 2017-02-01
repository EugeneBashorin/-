using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjection1
{
    class Program
    {
        static void Main(string[] args)
        {
            Increment inc = new Increment();                 // Создание зависимости
            PropertyInjection pi = new PropertyInjection();
            pi.Argument = 10;
            pi.Operation = inc;                             // Инъекция зависимости через свойство
            pi.SomeOperation();
            Console.WriteLine(pi.Result);
            Console.ReadLine();
        }
    }
}
