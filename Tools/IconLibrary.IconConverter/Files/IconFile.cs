using IconLibrary.IcvFormat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconLibrary.IconConverter.Files
{
    public abstract class IconFile : INotifyPropertyChanged
    {
        private string m_name;

        public event PropertyChangedEventHandler PropertyChanged;

        protected IconFile(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public abstract IcvIcon ConvertToIcv();

        public string Name
        {
            get { return m_name; }
            set
            {
                if(m_name != value)
                {
                    m_name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }
    }
}
