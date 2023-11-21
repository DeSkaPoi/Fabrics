using Fabrics.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrics.Commands
{
    public class SelectionSortCommand : BaseSortCommand, ICommand
    {
        public SelectionSortCommand(int[] mas) : base(mas)
        {
        }
        public override void Execute()
        {
            for (int i = 0; i < _mas.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < _mas.Length; j++)
                {
                    if (_mas[j] < _mas[min])
                    {
                        min = j;
                    }
                }

                Swap(ref _mas[min], ref _mas[i]);
            }
        }
    }
}
