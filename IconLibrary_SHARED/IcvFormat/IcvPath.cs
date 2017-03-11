using System;
using System.Collections.Generic;
using System.Text;

namespace IconLibrary.IcvFormat
{
    public class IcvPath
    {
        private IcvPoint[] m_pointList;

        public IcvPath()
            : this(new IcvPoint[0])
        {

        }

        public IcvPath(IcvPoint[] pointList)
        {
            m_pointList = pointList;
        }

        public override string ToString()
        {
            return $"{m_pointList.Length} point(s)";
        }

        public IcvPoint[] PointList
        {
            get { return m_pointList; }
            set
            {
                m_pointList = value;
                if (m_pointList == null) { m_pointList = new IcvPoint[0]; }
            }
        }
    }
}
