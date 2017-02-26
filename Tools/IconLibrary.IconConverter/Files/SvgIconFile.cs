using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconLibrary.IconConverter.Files
{
    public class SvgIconFile : IconFile
    {
        public SvgIconFile(string filePath)
            : base(Path.GetFileNameWithoutExtension(filePath))
        {

        }

        public override void Draw(Graphics target, int width, int height)
        {
            
        }
    }
}
