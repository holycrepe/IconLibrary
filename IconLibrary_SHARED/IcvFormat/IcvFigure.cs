using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IconLibrary.IcvFormat
{
    public class IcvFigure
    {
        private List<IcvPath> m_paths;

        /// <summary>
        /// Initializes a new instance of the <see cref="IcvFigure"/> class.
        /// </summary>
        public IcvFigure()
        {
            m_paths = new List<IcvPath>();
        }

        public override string ToString()
        {
            return $"{m_paths.Count} path(s), {m_paths.Select(actPath => actPath.PointList.Length).Sum()} point(s)";
        }

        public List<IcvPath> Paths
        {
            get { return m_paths; }
        }

        public int FillColorCode
        {
            get;
            set;
        }
    }
}
