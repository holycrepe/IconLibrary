using System;
using System.Collections.Generic;
using System.Text;

namespace IconLibrary.IcvFormat
{
    public class IcvIcon
    {
        #region Constants
        private const string FILE_FIGURE = "figure";
        public const ushort REFERENCE_SIDE_WIDTH = 1000;
        #endregion

        private List<IcvFigure> m_figures;

        /// <summary>
        /// Initializes a new instance of the <see cref="IcvIcon"/> class.
        /// </summary>
        public IcvIcon()
        {
            m_figures = new List<IcvFigure>();
        }

        public override string ToString()
        {
            return $"{m_figures.Count} figure(s)";
        }

        public List<IcvFigure> Figures
        {
            get { return m_figures; }
        }
    }
}
