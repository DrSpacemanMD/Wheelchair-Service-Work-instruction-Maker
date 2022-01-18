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
        public string PropulsionType;
        public WheelChair(string ModelArg, double WidthArg, double DepthArg, string PresCodeArg, string PropulsionTypeArg)
        {
            Model = ModelArg;
            Width = WidthArg;
            Depth = DepthArg;
            PresCode = PresCodeArg;
            PropulsionType = PropulsionTypeArg;
        }
        public bool CheckMatch(string ModelArg, double WidthArg, double DepthArg, string PropulsionTypeArg)
        {
            if (ModelArg == Model && WidthArg == Width && DepthArg == Depth && PropulsionTypeArg == PropulsionType)
                return true;
            else
                return false;
        }
    }
}
