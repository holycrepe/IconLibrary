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
        public IconFileInfo(string imageName)
        {
            this.ImageName = imageName;
        }

        public string ImageName
        {
            get;
            set;
        }
    }
}
