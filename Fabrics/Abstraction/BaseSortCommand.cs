using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrics.Abstraction
{
    public abstract class BaseSortCommand : ICommand
    {
        protected int[] _mas;
        public BaseSortCommand(int[] mas)
        {
            _mas = mas;
        }

        public abstract void Execute();
        
        protected void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
