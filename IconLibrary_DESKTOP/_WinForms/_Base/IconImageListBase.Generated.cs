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
    public partial class IconImageListBase<EnumType>
    {
        #region Constants
        private const int MAX_COUNT_OF_ITEMS = 50;
        #endregion

        //*********************************************************************
        //*********************************************************************
        //*********************************************************************
        // Accessors for all objects

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object001
        {
            get { return m_targets[0].TargetObject; }
            set { m_targets[0].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object001Icon
        {
            get 
            {
                if(m_targets[0].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[0].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[0].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object002
        {
            get { return m_targets[1].TargetObject; }
            set { m_targets[1].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object002Icon
        {
            get 
            {
                if(m_targets[1].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[1].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[1].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object003
        {
            get { return m_targets[2].TargetObject; }
            set { m_targets[2].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object003Icon
        {
            get 
            {
                if(m_targets[2].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[2].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[2].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object004
        {
            get { return m_targets[3].TargetObject; }
            set { m_targets[3].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object004Icon
        {
            get 
            {
                if(m_targets[3].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[3].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[3].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object005
        {
            get { return m_targets[4].TargetObject; }
            set { m_targets[4].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object005Icon
        {
            get 
            {
                if(m_targets[4].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[4].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[4].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object006
        {
            get { return m_targets[5].TargetObject; }
            set { m_targets[5].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object006Icon
        {
            get 
            {
                if(m_targets[5].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[5].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[5].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object007
        {
            get { return m_targets[6].TargetObject; }
            set { m_targets[6].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object007Icon
        {
            get 
            {
                if(m_targets[6].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[6].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[6].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object008
        {
            get { return m_targets[7].TargetObject; }
            set { m_targets[7].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object008Icon
        {
            get 
            {
                if(m_targets[7].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[7].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[7].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object009
        {
            get { return m_targets[8].TargetObject; }
            set { m_targets[8].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object009Icon
        {
            get 
            {
                if(m_targets[8].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[8].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[8].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object010
        {
            get { return m_targets[9].TargetObject; }
            set { m_targets[9].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object010Icon
        {
            get 
            {
                if(m_targets[9].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[9].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[9].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object011
        {
            get { return m_targets[10].TargetObject; }
            set { m_targets[10].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object011Icon
        {
            get 
            {
                if(m_targets[10].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[10].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[10].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object012
        {
            get { return m_targets[11].TargetObject; }
            set { m_targets[11].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object012Icon
        {
            get 
            {
                if(m_targets[11].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[11].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[11].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object013
        {
            get { return m_targets[12].TargetObject; }
            set { m_targets[12].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object013Icon
        {
            get 
            {
                if(m_targets[12].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[12].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[12].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object014
        {
            get { return m_targets[13].TargetObject; }
            set { m_targets[13].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object014Icon
        {
            get 
            {
                if(m_targets[13].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[13].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[13].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object015
        {
            get { return m_targets[14].TargetObject; }
            set { m_targets[14].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object015Icon
        {
            get 
            {
                if(m_targets[14].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[14].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[14].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object016
        {
            get { return m_targets[15].TargetObject; }
            set { m_targets[15].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object016Icon
        {
            get 
            {
                if(m_targets[15].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[15].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[15].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object017
        {
            get { return m_targets[16].TargetObject; }
            set { m_targets[16].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object017Icon
        {
            get 
            {
                if(m_targets[16].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[16].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[16].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object018
        {
            get { return m_targets[17].TargetObject; }
            set { m_targets[17].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object018Icon
        {
            get 
            {
                if(m_targets[17].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[17].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[17].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object019
        {
            get { return m_targets[18].TargetObject; }
            set { m_targets[18].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object019Icon
        {
            get 
            {
                if(m_targets[18].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[18].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[18].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object020
        {
            get { return m_targets[19].TargetObject; }
            set { m_targets[19].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object020Icon
        {
            get 
            {
                if(m_targets[19].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[19].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[19].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object021
        {
            get { return m_targets[20].TargetObject; }
            set { m_targets[20].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object021Icon
        {
            get 
            {
                if(m_targets[20].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[20].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[20].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object022
        {
            get { return m_targets[21].TargetObject; }
            set { m_targets[21].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object022Icon
        {
            get 
            {
                if(m_targets[21].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[21].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[21].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object023
        {
            get { return m_targets[22].TargetObject; }
            set { m_targets[22].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object023Icon
        {
            get 
            {
                if(m_targets[22].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[22].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[22].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object024
        {
            get { return m_targets[23].TargetObject; }
            set { m_targets[23].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object024Icon
        {
            get 
            {
                if(m_targets[23].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[23].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[23].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object025
        {
            get { return m_targets[24].TargetObject; }
            set { m_targets[24].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object025Icon
        {
            get 
            {
                if(m_targets[24].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[24].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[24].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object026
        {
            get { return m_targets[25].TargetObject; }
            set { m_targets[25].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object026Icon
        {
            get 
            {
                if(m_targets[25].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[25].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[25].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object027
        {
            get { return m_targets[26].TargetObject; }
            set { m_targets[26].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object027Icon
        {
            get 
            {
                if(m_targets[26].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[26].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[26].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object028
        {
            get { return m_targets[27].TargetObject; }
            set { m_targets[27].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object028Icon
        {
            get 
            {
                if(m_targets[27].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[27].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[27].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object029
        {
            get { return m_targets[28].TargetObject; }
            set { m_targets[28].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object029Icon
        {
            get 
            {
                if(m_targets[28].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[28].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[28].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object030
        {
            get { return m_targets[29].TargetObject; }
            set { m_targets[29].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object030Icon
        {
            get 
            {
                if(m_targets[29].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[29].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[29].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object031
        {
            get { return m_targets[30].TargetObject; }
            set { m_targets[30].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object031Icon
        {
            get 
            {
                if(m_targets[30].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[30].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[30].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object032
        {
            get { return m_targets[31].TargetObject; }
            set { m_targets[31].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object032Icon
        {
            get 
            {
                if(m_targets[31].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[31].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[31].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object033
        {
            get { return m_targets[32].TargetObject; }
            set { m_targets[32].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object033Icon
        {
            get 
            {
                if(m_targets[32].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[32].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[32].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object034
        {
            get { return m_targets[33].TargetObject; }
            set { m_targets[33].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object034Icon
        {
            get 
            {
                if(m_targets[33].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[33].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[33].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object035
        {
            get { return m_targets[34].TargetObject; }
            set { m_targets[34].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object035Icon
        {
            get 
            {
                if(m_targets[34].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[34].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[34].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object036
        {
            get { return m_targets[35].TargetObject; }
            set { m_targets[35].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object036Icon
        {
            get 
            {
                if(m_targets[35].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[35].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[35].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object037
        {
            get { return m_targets[36].TargetObject; }
            set { m_targets[36].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object037Icon
        {
            get 
            {
                if(m_targets[36].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[36].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[36].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object038
        {
            get { return m_targets[37].TargetObject; }
            set { m_targets[37].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object038Icon
        {
            get 
            {
                if(m_targets[37].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[37].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[37].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object039
        {
            get { return m_targets[38].TargetObject; }
            set { m_targets[38].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object039Icon
        {
            get 
            {
                if(m_targets[38].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[38].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[38].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object040
        {
            get { return m_targets[39].TargetObject; }
            set { m_targets[39].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object040Icon
        {
            get 
            {
                if(m_targets[39].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[39].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[39].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object041
        {
            get { return m_targets[40].TargetObject; }
            set { m_targets[40].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object041Icon
        {
            get 
            {
                if(m_targets[40].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[40].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[40].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object042
        {
            get { return m_targets[41].TargetObject; }
            set { m_targets[41].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object042Icon
        {
            get 
            {
                if(m_targets[41].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[41].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[41].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object043
        {
            get { return m_targets[42].TargetObject; }
            set { m_targets[42].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object043Icon
        {
            get 
            {
                if(m_targets[42].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[42].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[42].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object044
        {
            get { return m_targets[43].TargetObject; }
            set { m_targets[43].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object044Icon
        {
            get 
            {
                if(m_targets[43].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[43].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[43].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object045
        {
            get { return m_targets[44].TargetObject; }
            set { m_targets[44].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object045Icon
        {
            get 
            {
                if(m_targets[44].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[44].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[44].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object046
        {
            get { return m_targets[45].TargetObject; }
            set { m_targets[45].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object046Icon
        {
            get 
            {
                if(m_targets[45].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[45].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[45].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object047
        {
            get { return m_targets[46].TargetObject; }
            set { m_targets[46].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object047Icon
        {
            get 
            {
                if(m_targets[46].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[46].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[46].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object048
        {
            get { return m_targets[47].TargetObject; }
            set { m_targets[47].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object048Icon
        {
            get 
            {
                if(m_targets[47].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[47].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[47].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object049
        {
            get { return m_targets[48].TargetObject; }
            set { m_targets[48].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object049Icon
        {
            get 
            {
                if(m_targets[48].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[48].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[48].Icon = iconItem; 
            }
        }

        [Browsable(false)]
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Component Object050
        {
            get { return m_targets[49].TargetObject; }
            set { m_targets[49].TargetObject = value; }
        }

        [Browsable(false)]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Object050Icon
        {
            get 
            {
                if(m_targets[49].Icon.Equals(default(EnumType))){ return ""; }
                return m_targets[49].Icon.ToString(); 
            }
            set 
            { 
                EnumType iconItem = default(EnumType);
                if(!Enum.TryParse<EnumType>(value, out iconItem)){ return; }
                m_targets[49].Icon = iconItem; 
            }
        }
    }
}
