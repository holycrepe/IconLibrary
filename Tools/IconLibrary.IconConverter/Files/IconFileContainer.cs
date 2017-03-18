using IconLibrary.IcvFormat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconLibrary.IconConverter.Files
{
    public class IconFileContainer : INotifyPropertyChanged
    { 
        private ObservableCollection<IconFile> m_iconFiles;
        private IcvIcon m_previewIcon;
        private IconFile m_selectedIcon;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler IconCollectionChanged;

        public IconFileContainer()
        {
            m_iconFiles = new ObservableCollection<IconFile>();
            m_iconFiles.CollectionChanged += OnIconFiles_CollectionChanged;
            m_selectedIcon = null;
        }

        private void OnIconFiles_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Remove:
                case NotifyCollectionChangedAction.Replace:
                    if(e.OldItems.Contains(m_selectedIcon))
                    {
                        this.SelectedIcon = null;
                    }
                    break;
            }

            IconCollectionChanged?.Invoke(this, EventArgs.Empty);
        }

        private void OnSelectedIcon_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.PreviewIcon = m_selectedIcon.ConvertToIcv();
        }

        private void OnIcon_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
        }

        private void OnIconFiles_ListChanged(object sender, ListChangedEventArgs e)
        {

            switch(e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    IconFile newIcon = m_iconFiles[e.NewIndex];
                    break;
            }
        }

        public ObservableCollection<IconFile> IconFiles
        {
            get { return m_iconFiles; }
        }

        public IcvIcon PreviewIcon
        {
            get { return m_previewIcon; }
            private set
            {
                if(m_previewIcon != value)
                {
                    m_previewIcon = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PreviewIcon)));
                }
            }
        }

        public IconFile SelectedIcon
        {
            get { return m_selectedIcon; }
            set
            {
                if(m_selectedIcon != value)
                {
                    if(m_selectedIcon != null)
                    {
                        m_selectedIcon.PropertyChanged -= OnSelectedIcon_PropertyChanged;
                    }
                    m_selectedIcon = value;
                    if(m_selectedIcon != null)
                    {
                        this.PreviewIcon = m_selectedIcon.ConvertToIcv();
                        m_selectedIcon.PropertyChanged += OnSelectedIcon_PropertyChanged;
                    }

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedIcon)));
                }
            }
        }
    }
}
