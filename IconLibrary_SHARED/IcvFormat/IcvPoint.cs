using System;
using System.Collections.Generic;
using System.Text;

namespace IconLibrary.IcvFormat
{
    public struct IcvPoint
    {
        public ushort X;
        public ushort Y;

        public IcvPoint(ushort x, ushort y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
