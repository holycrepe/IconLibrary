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
        public IconCollectionInfo(Type enumType)
        {
            this.IconEnumType = enumType;
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

        public Type IconEnumType
        {
            get;
            private set;
        }
    }
}
