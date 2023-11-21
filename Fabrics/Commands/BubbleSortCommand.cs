using Fabrics.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrics.Commands
{
    public class BubbleSortCommand : BaseSortCommand, ICommand
    {
        public BubbleSortCommand(int[] mas) : base(mas)
        {
        }

        public override void Execute()
        {
            for (int i = 0; i < _mas.Length; i++)
            {
                for (int j = 0; j < _mas.Length - 1 - i; j++)
                {
                    if (_mas[j] > _mas[j + 1])
                    {
                        Swap(ref _mas[j], ref _mas[j + 1]);
                    }
                }
            }
        }
    }
}
