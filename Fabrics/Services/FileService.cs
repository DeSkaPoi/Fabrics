using Fabrics.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrics.Services
{
    public class FileService : IFileWriteToFileService, IFileReadFileService
    {
        public int[] ReadFile(string path, ref int[] mas)
        {
            var line = "";
            string file = File.ReadAllText(path);
            var mas1 = file
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();

            for (int i = 0; i < mas1.Length; i++)
            {
                mas[i] = mas1[i];
            }

            return mas;
        }

        public void WriteToFile(string path, int[] mas)
        {
            File.WriteAllText(path, string.Join(" ", mas));
        }
    }
}
