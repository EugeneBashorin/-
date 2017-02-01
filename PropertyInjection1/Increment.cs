using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjection1
{
    class Increment : IOperation
    {
        public int DoOperation(int argument)
        {
            return ++argument;
        }
    }
}
