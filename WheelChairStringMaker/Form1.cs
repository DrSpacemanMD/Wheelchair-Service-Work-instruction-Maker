using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelChairStringMaker
{
    public partial class Form1 : Form
    {
        private List<WheelChair> WheelChairs;
        private List<Part> Parts;
        public Form1()
        {
            InitializeComponent();

            WheelChairs = new List<WheelChair>();
            using (StreamReader sr = new StreamReader(@"Wheelchairs.csv"))
            {
                string headerLine = sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    WheelChairs.Add(new WheelChair(values[0], Convert.ToDouble(values[1].Split('x')[0]), Convert.ToDouble(values[1].Split('x')[1]), values[2]));
                }
            }

            Parts = new List<Part>();
            using (StreamReader sr = new StreamReader(@"Parts.csv"))
            {
                string headerLine = sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    Parts.Add(new Part(values[0], values[1], values[2], values[3]));
                }
            }

            foreach (WheelChair WC in WheelChairs)
            {
                if (!Wheelchairdropdown.Items.Contains(WC.Model))
                {
                    Wheelchairdropdown.Items.Add(WC.Model);
                }
            }
        }

    }
}
