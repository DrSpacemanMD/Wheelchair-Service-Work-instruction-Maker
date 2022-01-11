using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelChairStringMaker
{
    class Part
    {
        public string PartNumber;
        public string Name;
        public string Category;
        public List<string> CompatibleChairs = new List<string>();

        public Part(string PartNum, string NameArg, string Cat, string CompChairs)
        {
            PartNumber = PartNum;
            Name = NameArg;
            Category = Cat;
            CompatibleChairs = CompChairs.Split(',').ToList();
        }
    }
}
