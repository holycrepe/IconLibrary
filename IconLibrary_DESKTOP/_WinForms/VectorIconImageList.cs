using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IconLibrary.Caching;
using System.Reflection;

namespace IconLibrary
{
    [DesignTimeVisible(true)]
    public class VectorIconImageList : IconImageListBase<LogisticIcon>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditorIconImageList"/> class.
        /// </summary>
        public VectorIconImageList()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditorIconImageList"/> class.
        /// </summary>
        public VectorIconImageList(IContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            container.Add(this);
        }
    }
}
