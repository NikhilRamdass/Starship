using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StarshipCaptain.Utils
{
    public class WriteToFile
    {
        static async void Write(string text, string path = "")
        {
            if(string.IsNullOrEmpty(path))
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using(StreamWriter sw = new StreamWriter(path))
            {
                await sw.WriteAsync(text);
            }
        }
    }
}
