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

        private List<string> CompatibleChairs = new List<string>();

        private Comparison WidthCheck;
        private double WidthValue;

        private Comparison DepthCheck;
        private double DepthValue;

        private List<string> CompatibleProps = new List<string>();
        private List<string> InCompatibleParts = new List<string>();

        public int maxcount=int.MaxValue;

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

            DepthCheck = CheckComparison(partstring[5]);
            DepthValue = GetValue(DepthCheck, partstring[5]);

            string CompProps = partstring[6].Trim(charsToTrim);
            CompatibleProps = CompProps.Split(',').ToList();
            for (int i = 0; i < CompatibleProps.Count; i++)
                CompatibleProps[i] = CompatibleProps[i].Trim(charsToTrim);

            string InCompParts = partstring[7].Trim(charsToTrim);
            InCompatibleParts = InCompParts.Split(',').ToList();
            for (int i = 0; i < InCompatibleParts.Count; i++)
                InCompatibleParts[i] = InCompatibleParts[i].Trim(charsToTrim);

            if (partstring[8]!="")
                maxcount = int.Parse(partstring[8]);

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
            bool Compatible = true;
            if (CompatibleChairs.Contains(wheelchair.Model) == false)
                Compatible = false;

            if (CheckValue(wheelchair.Width, WidthValue, WidthCheck)==false)
                Compatible = false;

            if (CheckValue(wheelchair.Depth, DepthValue, DepthCheck) == false)
                Compatible = false;

            if (CompatibleProps.Contains(wheelchair.PropulsionType) == false && CompatibleProps[0]!="")
                Compatible = false;

            return Compatible;
        }

         private bool CheckValue(double value, double Ref, Comparison operatorCode)
        {
            if (operatorCode == Comparison.None)
                return true;
            else if (operatorCode == Comparison.Greater)
                return value > Ref;
            else if (operatorCode == Comparison.Less)
                return value < Ref;
            else if (operatorCode == Comparison.Greaterorequal)
                return value >= Ref;
            else if (operatorCode == Comparison.Lessorequal)
                return value <= Ref;
            else if (operatorCode == Comparison.NotEqual)
                return value != Ref;
            else if (operatorCode == Comparison.Equal)
                return value == Ref;
            else
                throw new Exception("Error! Unable to find correct comparison token");
        }

        public bool CheckForInCompatibleParts(List<Part> SelectedParks)
        {
            foreach (Part part in SelectedParks)
            {
                if (InCompatibleParts.Contains(part.Name) == true)
                    return true;
                if (part.InCompatibleParts.Contains(this.Name) == true)
                    return true;
            }

            return false;
        }

       
    }

}
