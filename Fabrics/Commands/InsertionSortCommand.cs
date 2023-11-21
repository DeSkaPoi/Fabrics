using Fabrics.Abstraction;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrics.Commands
{
    public class InsertionSortCommand : BaseSortCommand, ICommand
    {
        public InsertionSortCommand(int[] mas) : base(mas)
        {
        }
        public override void Execute()
        {
            for (int i = 1; i < _mas.Length; i++)
            {
                int k = _mas[i];
                int j = i - 1;

                while (j >= 0 && _mas[j] > k)
                {
                    _mas[j + 1] = _mas[j];
                    _mas[j] = k;
                    j--;
                }
            }
        }
    }
}
