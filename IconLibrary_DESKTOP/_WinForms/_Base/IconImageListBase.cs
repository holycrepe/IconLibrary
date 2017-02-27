using IconLibrary.Caching;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IconLibrary
{
    [DesignTimeVisible(false)]
    public partial class IconImageListBase<EnumType> : Component
        where EnumType : struct
    {
        #region Generic
        private TargetObjectInfo[] m_targets;
        private IconCollectionInfo m_collectionInfo;
        private Control m_hostControl;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="IconImageListBase{EnumType}"/> class.
        /// </summary>
        public IconImageListBase()
        {
            m_targets = new TargetObjectInfo[MAX_COUNT_OF_ITEMS];
            for (int loop = 0; loop < MAX_COUNT_OF_ITEMS; loop++)
            {
                m_targets[loop] = new TargetObjectInfo(this);
            }

            m_collectionInfo = new IconCollectionInfo(typeof(EnumType));
        }

        private void OnHostControl_HandleCreated(object sender, EventArgs e)
        {
            this.UpdateDpiScaleFactor();

            foreach (var actTarget in m_targets)
            {
                actTarget.UpdateTargetObject();
            }
        }

        private void UpdateDpiScaleFactor()
        {
            if(m_hostControl == null) { m_collectionInfo.DpiScaleFactor = 1f; }
            if (!m_hostControl.IsHandleCreated) { m_collectionInfo.DpiScaleFactor = 1f; }

            using (Graphics gfx = m_hostControl.CreateGraphics())
            {
                m_collectionInfo.DpiScaleFactor = gfx.DpiX / 96f;
            }
        }

        [Category("Configuration")]
        [DefaultValue(IconCollectionInfo.DEFAULT_ICON_SIDE_WIDTH)]
        public int ImageSideWidth
        {
            get { return m_collectionInfo.IconSideWidth; }
            set
            {
                if(m_collectionInfo.IconSideWidth != value)
                {
                    m_collectionInfo.IconSideWidth = value;
                    foreach(var actTarget in m_targets)
                    {
                        actTarget.UpdateTargetObject();
                    }
                }
            }
        }

        [Category("Configuration")]
        public Color ForeColor
        {
            get { return Color.FromArgb(m_collectionInfo.IconForeColor); }
            set
            {
                int argb = value.ToArgb();
                if(m_collectionInfo.IconForeColor != argb)
                {
                    m_collectionInfo.IconForeColor = argb;

                    foreach (var actTarget in m_targets)
                    {
                        actTarget.UpdateTargetObject();
                    }
                }
            }
        }

        [Category("Configuration")]
        public Control HostControl
        {
            get { return m_hostControl; }
            set
            {
                if(m_hostControl != value)
                {
                    if(m_hostControl != null)
                    {
                        m_hostControl.HandleCreated -= OnHostControl_HandleCreated;
                    }
                    m_hostControl = value;
                    if(m_hostControl != null)
                    {
                        m_hostControl.HandleCreated += OnHostControl_HandleCreated;
                    }

                    if (m_hostControl.IsHandleCreated)
                    {
                        this.UpdateDpiScaleFactor();
                        foreach (var actTarget in m_targets)
                        {
                            actTarget.UpdateTargetObject();
                        }
                    }
                }
            }
        }

        [Category("Targets")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true)]
        public TargetObjectInfo[] Targets
        {
            get { return m_targets; }
        }

        //*********************************************************************
        //*********************************************************************
        //*********************************************************************        
        /// <summary>
        /// Helper class for ButtonBase
        /// </summary>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class TargetObjectInfo
        {
            private IconImageListBase<EnumType> m_owner;
            private Component m_targetObject;
            private EnumType m_icon;

            public TargetObjectInfo(IconImageListBase<EnumType> owner)
            {
                m_owner = owner;
            }

            internal void UpdateTargetObject()
            {
                if (m_owner == null) { return; }
                if (m_owner.HostControl == null) { return; }
                if (!m_owner.HostControl.IsHandleCreated) { return; }

                ButtonBase targetButton = m_targetObject as ButtonBase;
                if (targetButton != null)
                {
                    targetButton.Image = IconImageCache.Current.GetGdiImage(
                        m_owner.m_collectionInfo,
                        new IconFileInfo(m_icon.ToString()));
                    return;
                }

                ToolStripItem targetToolStrip = m_targetObject as ToolStripItem;
                if(targetToolStrip != null)
                {
                    targetToolStrip.Image = IconImageCache.Current.GetGdiImage(
                        m_owner.m_collectionInfo,
                        new IconFileInfo(m_icon.ToString()));
                    return;
                }
            }

            public override string ToString()
            {
                Control targetControl = m_targetObject as Control;
                if(targetControl != null)
                {
                    return targetControl.Name + ": " + m_icon.ToString();
                }

                ToolStripItem targetToolStrip = m_targetObject as ToolStripItem;
                if(targetToolStrip != null)
                {
                    return targetToolStrip.Name + ": " + m_icon.ToString();
                }

                return "-";
            }

            public Component TargetObject
            {
                get { return m_targetObject; }
                set
                {
                    if (m_targetObject != value)
                    {
                        m_targetObject = value;
                        this.UpdateTargetObject();
                    }
                }
            }

            public EnumType Icon
            {
                get { return m_icon; }
                set
                {
                    if (!m_icon.Equals(value))
                    {
                        m_icon = value;
                        this.UpdateTargetObject();
                    }
                }
            }
        }
    }
}
