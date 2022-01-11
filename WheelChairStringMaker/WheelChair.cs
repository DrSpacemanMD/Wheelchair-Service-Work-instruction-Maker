using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelChairStringMaker
{
    class WheelChair
    {
        public string Model;
        public double Width;
        public double Depth;
        public string PresCode;
        public WheelChair(string ModelArg, double WidthArg, double DepthArg, string PresCodeArg)
        {
            Model = ModelArg;
            Width = WidthArg;
            Depth = DepthArg;
            PresCode = PresCodeArg;
        }
    }
}
