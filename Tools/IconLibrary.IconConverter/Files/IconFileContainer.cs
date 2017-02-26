using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconLibrary.IconConverter.Files
{
    public class IconFileContainer
    {
        private BindingList<IconFile> m_iconFiles;

        public IconFileContainer()
        {
            m_iconFiles = new BindingList<IconFile>();
        }

        public BindingList<IconFile> IconFiles
        {
            get { return m_iconFiles; }
        }
    }
}
