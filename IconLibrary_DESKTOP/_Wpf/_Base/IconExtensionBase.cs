using IconLibrary.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Imaging;

namespace IconLibrary
{
    public class IconExtensionBase<EnumType> : MarkupExtension
        where EnumType : struct
    {
        private IconCollectionInfo m_collectionInfo;

        protected IconExtensionBase()
        {
            this.SideWidth = 16;

            m_collectionInfo = new IconCollectionInfo(typeof(EditorIcon));
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            BitmapImage result = IconImageCache.Current.GetWpfBitmapImage(
                m_collectionInfo,
                new IconFileInfo(this.Icon.ToString()));

            // Create the result object
            switch (this.ResultType)
            {
                case WpfIconResultType.Control:
                    Image imgControl = new Image();
                    imgControl.Source = result;
                    imgControl.Width = this.SideWidth;
                    imgControl.Height = this.SideWidth;
                    return imgControl;

                case WpfIconResultType.BitmapImage:
                    return result;
            }

            return null;
        }

        public EnumType Icon
        {
            get;
            set;
        }

        public WpfIconResultType ResultType
        {
            get;
            set;
        }

        public int SideWidth
        {
            get;
            set;
        }
    }
}
