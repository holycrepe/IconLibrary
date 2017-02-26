using System;
using System.Collections.Generic;
using System.Text;

namespace IconLibrary.IcvFormat
{
    public class IcvFigure
    {
        private int[] m_pointList;

        /// <summary>
        /// Initializes a new instance of the <see cref="IcvFigure"/> class.
        /// </summary>
        public IcvFigure()
        {
            m_pointList = new int[0];
        }

        public IcvFigure(int[] pointList)
        {
            m_pointList = pointList;
        }

        public int ColorCor
        {
            get;
            set;
        }
    }
}
