using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IconLibrary.Caching
{
    public struct IconFileInfo
    {
        public IconFileInfo(string imageName, int imageSideWidth)
        {
            this.ImageName = imageName;
            this.ImageSideWidth = imageSideWidth;
        }

        public string ImageName
        {
            get;
            set;
        }

        public int ImageSideWidth
        {
            get;
            set;
        }
    }
}
