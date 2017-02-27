using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IconLibrary.Caching
{
    /// <summary>
    /// This class is responsible for caching all icons which where loaded before.
    /// </summary>
    public partial class IconImageCache
    {
        private static readonly int[] PNG_ICON_SIZES = new int[] { 64, 48, 32, 16 };


        #region Singleton Instance
        private static IconImageCache s_current;
        #endregion

        /// <summary>
        /// Prevents a default instance of the <see cref="DesktopImageCache"/> class from being created.
        /// </summary>
        private IconImageCache()
        {

        }

        /// <summary>
        /// Generates a key describing the given icon information.
        /// </summary>
        internal string GetIconFileKey(IconCollectionInfo collectionInfo, IconFileInfo fileInfo)
        {
            StringBuilder keyBuilder = new StringBuilder(100);
            keyBuilder.Append($"{collectionInfo.IconAssembly.GetName().Name}");
            keyBuilder.Append(':');
            keyBuilder.Append($"{collectionInfo.IconAssemblyDefaultNamespace}.Assets.Icons.{collectionInfo.IconEnumType.Name}.{fileInfo.ImageName}");
            keyBuilder.Append('_');
            keyBuilder.Append($"{collectionInfo.IconSideWidthPixel}x{collectionInfo.IconSideWidthPixel}");
            keyBuilder.Append('_');
            keyBuilder.Append(collectionInfo.IconForeColor);
            return keyBuilder.ToString();
        }

        /// <summary>
        /// Tries to find an svg icon in the embedded resources of the assembly
        /// where the icon enum is located.
        /// </summary>
        /// <param name="collectionInfo">Information about the icon collection.</param>
        /// <param name="fileInfo">Information about the icon file.</param>
        private AssemblyResourceLink TryFindPngIcon(IconCollectionInfo collectionInfo, IconFileInfo fileInfo)
        {
            string resourcePath = string.Empty;
            AssemblyResourceLink resourceLink = null;
            int actIconsize = collectionInfo.IconSideWidthPixel;
            do
            {
                resourcePath =
                    $"{collectionInfo.IconAssemblyDefaultNamespace}.Assets.Icons.{collectionInfo.IconEnumType.Name}.{fileInfo.ImageName}_{actIconsize}x{actIconsize}.png";
                resourceLink = new AssemblyResourceLink(
                    collectionInfo.IconAssembly,
                    resourcePath);
                if (!resourceLink.IsValid())
                {
                    resourcePath = string.Empty;
                    resourceLink = null;

                    bool found = false;
                    for (int loop = 0; loop < PNG_ICON_SIZES.Length; loop++)
                    {
                        if (PNG_ICON_SIZES[loop] < actIconsize)
                        {
                            actIconsize = PNG_ICON_SIZES[loop];
                            found = true;
                            break;
                        }
                    }
                    if (!found) { actIconsize = -1; }
                }
            }
            while ((resourceLink == null) && (actIconsize > 0));

            return resourceLink;
        }

        /// <summary>
        /// Tries to find a default png icon in the embedded resources of the assembly
        /// where the icon enum is located.
        /// </summary>
        /// <param name="collectionInfo">Information about the icon collection.</param>
        /// <param name="fileInfo">Information about the icon file.</param>
        private AssemblyResourceLink TryFindSvgIcon(IconCollectionInfo collectionInfo, IconFileInfo fileInfo)
        {
            string resourcePath =
                $"{collectionInfo.IconAssemblyDefaultNamespace}.Assets.Icons.{collectionInfo.IconEnumType.Name}.{fileInfo.ImageName}.svg";
            AssemblyResourceLink resourceLink = new AssemblyResourceLink(
                collectionInfo.IconAssembly,
                resourcePath);
            if (!resourceLink.IsValid()) { return null; }

            return resourceLink;
        }

        public static IconImageCache Current
        {
            get
            {
                if(s_current == null) { s_current = new IconImageCache(); }
                return s_current;
            }
        }
    }
}
