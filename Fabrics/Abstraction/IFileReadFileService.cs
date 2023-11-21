using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrics.Abstraction
{
    public interface IFileReadFileService
    {
        public int[] ReadFile(string path, ref int[] mas);
    }
}
