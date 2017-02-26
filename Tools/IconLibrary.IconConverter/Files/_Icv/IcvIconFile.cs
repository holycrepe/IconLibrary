using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconLibrary.IconConverter.Files
{
    public class IcvIconFile : IconFile
    {


        public IcvIconFile(string filePath)
            : base(Path.GetFileName(filePath))
        {

        }

        public override void Draw(Graphics target, int width, int height)
        {
          
        }
    }
}
