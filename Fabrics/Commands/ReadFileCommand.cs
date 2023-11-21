using Fabrics.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrics.Commands
{
    public class ReadFileCommand : ICommand
    {
        public IFileReadFileService _fileWriteToFileService;
        private int[] _mas;
        private string _path;
        public ReadFileCommand(IFileReadFileService fileWriteToFileService, ref int[] mas, string path)
        {
            _fileWriteToFileService = fileWriteToFileService;
            _mas = mas;
            _path = path;
        }
        public void Execute()
        {
            _fileWriteToFileService.ReadFile(_path, ref _mas);
        }
    }
}
