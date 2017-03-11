using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconLibrary.IcvFormat;

namespace IconLibrary.IconConverter.Files
{
    public class IcvIconFile : IconFile
    {
        private IcvIcon m_figure;

        public IcvIconFile(string filePath)
            : base(Path.GetFileName(filePath))
        {

        }

        public override IcvIcon ConvertToIcv()
        {
            return m_figure;
        }

        public override void Draw(Graphics target, int width, int height)
        {
          
        }
    }
}
