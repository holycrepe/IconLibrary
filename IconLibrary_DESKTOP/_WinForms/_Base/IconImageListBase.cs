using IconLibrary.Caching;
using System;
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
        #region Constants
        private const int DEFAULT_IMAGE_SIDE_WIDTH = 16;
        #endregion

        #region Generic
        private TargetObjectInfo[] m_targets;
        private IconCollectionInfo m_collectionInfo;
        private int m_imageSideWidth;
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

            m_imageSideWidth = DEFAULT_IMAGE_SIDE_WIDTH;

            m_collectionInfo = new IconCollectionInfo(typeof(EnumType));
        }

        [Category("Configuration")]
        [DefaultValue(DEFAULT_IMAGE_SIDE_WIDTH)]
        public int ImageSideWidth
        {
            get { return m_imageSideWidth; }
            set
            {
                if(m_imageSideWidth != value)
                {
                    m_imageSideWidth = value;
                    if(m_imageSideWidth < 16) { m_imageSideWidth = 16; }
                    
                    foreach(var actTarget in m_targets)
                    {
                        actTarget.UpdateTargetObject();
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

                ButtonBase targetButton = m_targetObject as ButtonBase;
                if (targetButton != null)
                {
                    targetButton.Image = IconImageCache.Current.GetGdiImage(
                        m_owner.m_collectionInfo,
                        new IconFileInfo(m_icon.ToString(), m_owner.ImageSideWidth));
                    return;
                }

                ToolStripItem targetToolStrip = m_targetObject as ToolStripItem;
                if(targetToolStrip != null)
                {
                    targetToolStrip.Image = IconImageCache.Current.GetGdiImage(
                        m_owner.m_collectionInfo,
                        new IconFileInfo(m_icon.ToString(), m_owner.ImageSideWidth));
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
