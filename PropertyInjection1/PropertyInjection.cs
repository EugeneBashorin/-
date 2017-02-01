using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjection1
{
    class PropertyInjection
    {
        public int Argument { get; set; }
        public int Result { get; set; }
        public IOperation Operation { get; set; } // Инъекция через свойство

        public void SomeOperation()
        {
            Result = Operation.DoOperation(Argument);
        }
    }
}
