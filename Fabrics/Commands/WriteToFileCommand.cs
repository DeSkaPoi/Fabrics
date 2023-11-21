using Fabrics.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrics.Commands
{
    public class WriteToFileCommand : ICommand
    {
        public IFileWriteToFileService _fileWriteToFileService;
        private int[] _mas;
        private string _path;
        public WriteToFileCommand(IFileWriteToFileService fileWriteToFileService, int[] mas, string path)
        {
            _fileWriteToFileService = fileWriteToFileService;
            _mas = mas;
            _path = path;
        }
        public void Execute()
        {
            _fileWriteToFileService.WriteToFile(_path, _mas);
        }
    }
}
