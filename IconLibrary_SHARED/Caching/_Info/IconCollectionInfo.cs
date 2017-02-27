using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IconLibrary.Caching
{
    public class IconCollectionInfo
    {
        public const int DEFAULT_ICON_SIDE_WIDTH = 16;

        public IconCollectionInfo(Type enumType)
        {
            this.IconEnumType = enumType;
            this.IconSideWidth = DEFAULT_ICON_SIDE_WIDTH;
            this.IconForeColor = -16777216; // Black
            this.DpiScaleFactor = 1f;
        }

        public string IconAssemblyDefaultNamespace
        {
            get
            {
                IconEnumAttribute embeddedResourceBitmap =
                    this.IconEnumType.GetTypeInfo().GetCustomAttribute<IconEnumAttribute>();
                if(embeddedResourceBitmap != null)
                {
                    return embeddedResourceBitmap.AssemblyDefaultNamespace;
                }

                throw new InvalidOperationException($"Attribute {nameof(IconEnumAttribute)} not applied to enuk '{this.IconEnumType.FullName}'!");
            }
        }

        public Assembly IconAssembly => this.IconEnumType.GetTypeInfo().Assembly;

        public int IconSideWidthPixel
        {
            get { return (int)(IconSideWidth * DpiScaleFactor); }
        }

        public Type IconEnumType
        {
            get;
            private set;
        }

        public int IconSideWidth
        {
            get;
            set;
        }

        public int IconForeColor
        {
            get;
            set;
        }

        public float DpiScaleFactor
        {
            get;
            set;
        }
    }
}
