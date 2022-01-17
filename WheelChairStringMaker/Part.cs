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

        enum Comparison
        {
            Equal,
            NotEqual,
            Greater,
            Less,
            Greaterorequal,
            Lessorequal,
            None
        }

        private Comparison WidthCheck;
        private double WidthValue;

        //public Part(string PartNum, string NameArg, string Cat, string CompChairs)
        public Part(string[] partstring)
        {
            PartNumber = partstring[1];
            Name = partstring[0];
            Category = partstring[2];

            char[] charsToTrim = { '\"', ' ', '\'' };
            string CompChairs = partstring[3].Trim(charsToTrim);
            CompatibleChairs = CompChairs.Split(',').ToList();
            for (int i =0; i < CompatibleChairs.Count;i++)
                CompatibleChairs[i] = CompatibleChairs[i].Trim(charsToTrim);


            WidthCheck = CheckComparison(partstring[4]);
            WidthValue = GetValue(WidthCheck, partstring[4]);

        }

        private Comparison CheckComparison(string str)
        {
            Comparison returncode = Comparison.Equal;
            if (str.Contains(">="))
                returncode= Comparison.Greaterorequal;
            else if (str.Contains(">"))
                returncode= Comparison.Greater;
            else if (str.Contains("<="))
                returncode= Comparison.Lessorequal;
            else if (str.Contains("<"))
                returncode= Comparison.Less;
            else if (str.Contains("!"))
                returncode= Comparison.NotEqual;
            else if (str == "")
                returncode= Comparison.None;

            return returncode;
        }

        private double GetValue(Comparison Comp,String str)
        {
            if (Comp == Comparison.Equal)
                return double.Parse(str);
            else if (Comp == Comparison.Greaterorequal || Comp == Comparison.Lessorequal)
                return double.Parse(str.Substring(2, str.Length - 2));
            else if (Comp == Comparison.None)
                return -1;
            else
                return double.Parse(str.Substring(1, str.Length - 1));
        }

        //This function will take in a wheelchair and connfirm it is compatible 
        public bool CheckCompatibility(WheelChair wheelchair)
        {
            return false;
        }
    }
}
