using Fabrics.Abstraction;
using Fabrics.Commands;
using Fabrics.MacroCommands;
using Fabrics.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fabrics.Fabrics
{
    public static class FabricCommands
    {
        public static ICommand CreateWriteToFileCommand(int[] mas, string path) => new WriteToFileCommand(new FileService(), mas, path);
        public static ICommand CreateReadFileCommand(int[] mas, string path) => new ReadFileCommand(new FileService(), ref mas, path);
        public static ICommand CreateSortCommand(SortType type, int[] mas)
        {
            switch (type) 
            {
                case SortType.Insertion:
                    return new InsertionSortCommand(mas);
                case SortType.Selection:
                    return new SelectionSortCommand(mas);
                case SortType.Bubble: 
                    return new BubbleSortCommand(mas);
                default:
                    return null;
            }
        }
        public static ICommand CreateMacroCommand(Queue<ICommand> commands) => new MacroCommand(commands);
    }
}
