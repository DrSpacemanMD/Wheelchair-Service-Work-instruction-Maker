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
        private Dictionary<string, List<Part>> PartDict = new Dictionary<string, List<Part>>();
        private List<Part> SelectedParts = new List<Part>();

        public Form1()
        {
            try
            {
                InitializeComponent();

                PartsView.Rows.Clear();

                WheelChairs = new List<WheelChair>();
                using (StreamReader sr = new StreamReader(@"Wheelchairs.txt"))
                {
                    string headerLine = sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var values = line.Split('\t');
                        WheelChairs.Add(new WheelChair(values[0], Convert.ToDouble(values[1].Split('x')[0]), Convert.ToDouble(values[1].Split('x')[1]), values[2], values[3]));
                    }
                }

                Parts = new List<Part>();
                using (StreamReader sr = new StreamReader(@"Parts.txt"))
                {
                    string headerLine = sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var values = line.Split('\t');
                        //Parts.Add(new Part(values[1], values[0], values[2], values[3]));
                        Parts.Add(new Part(values));
                    }
                }

                foreach (WheelChair WC in WheelChairs)
                {
                    if (!Wheelchairdropdown.Items.Contains(WC.Model))
                    {
                        Wheelchairdropdown.Items.Add(WC.Model);
                    }
                }

                foreach (Part part in Parts)
                {
                    if (PartDict.ContainsKey(part.Category) == false)
                    {
                        PartDict[part.Category] = new List<Part>();
                        PartDict[part.Category].Add(part);
                    }
                    else
                    {
                        PartDict[part.Category].Add(part);
                    }
                }

                Parts = new List<Part>();
                using (StreamReader sr = new StreamReader(@"DeliveryMethods.txt"))
                {
                    string headerLine = sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //var values = line.Split('\t');
                        DeliveryDrop.Items.Add(line.Split('\t')[0]);
                    }
                }

                Parts = new List<Part>();
                using (StreamReader sr = new StreamReader(@"FootPlates.txt"))
                {
                    string headerLine = sr.ReadLine();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        FootPlateHeightDropDown.Items.Add(line.Split('\t')[0]);
                    }
                }

                Parts.Clear();//Since we added it into the dict lets delete this to use later

                foreach (DataGridViewColumn dgvc in PartsView.Columns)
                {
                    dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                Wheelchairdropdown.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Wheelchairdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SizeDropdown.Items.Clear();
            PropulsionDropdown.Items.Clear();
            Parts.Clear();
            SelectedParts.Clear();


            foreach (WheelChair WC in WheelChairs)
            {
                string Size = WC.Width.ToString() + " x " + WC.Depth.ToString();
                if (!SizeDropdown.Items.Contains(Size) && WC.Model == (string)Wheelchairdropdown.SelectedItem)
                {
                    SizeDropdown.Items.Add(Size);
                }

                if (!PropulsionDropdown.Items.Contains(WC.PropulsionType) && WC.Model == (string)Wheelchairdropdown.SelectedItem)
                {
                    PropulsionDropdown.Items.Add(WC.PropulsionType);
                }
            }

            //We dont want the UpdateParts to be called before we have got rid of the emtpy entry in all the lists so I will unsubscruibe the event then re-add it
            SizeDropdown.SelectedIndexChanged -= new System.EventHandler(this.SelectedIndexChanged);
            PropulsionDropdown.SelectedIndexChanged -= new System.EventHandler(this.SelectedIndexChanged);
            DeliveryDrop.SelectedIndexChanged -= new System.EventHandler(this.SelectedIndexChanged);
            FootPlateHeightDropDown.SelectedIndexChanged -= new System.EventHandler(this.SelectedIndexChanged);

            SizeDropdown.SelectedIndex = 0;
            PropulsionDropdown.SelectedIndex = 0;
            DeliveryDrop.SelectedIndex = 0;
            FootPlateHeightDropDown.SelectedIndex = 0;

            SizeDropdown.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            PropulsionDropdown.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            DeliveryDrop.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            FootPlateHeightDropDown.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);

            UpdateParts();
            UpdateString();
        }

        private void UpdateParts()
        {
            try
            { 

                WheelChair SelectedChairObj = null;
                foreach (WheelChair WC in WheelChairs)
                {
                    string Width = SizeDropdown.SelectedItem.ToString().Split('x')[0];
                    string Depth = SizeDropdown.SelectedItem.ToString().Split('x')[1];
                    if (WC.CheckMatch(Wheelchairdropdown.SelectedItem.ToString(), double.Parse(Width), double.Parse(Depth), PropulsionDropdown.SelectedItem.ToString()) == true)
                    {
                        SelectedChairObj = WC;
                        break;
                    }
                }

                if (SelectedChairObj == null)
                    throw new Exception("Error, This wheel chair config is not found within the input file!");

                PartsView.Rows.Clear();
                Parts.Clear();
                foreach (var EntryLists in PartDict)
                {
                    foreach (Part part in EntryLists.Value)
                    {
                        if (part.CheckCompatibility(SelectedChairObj)) //Replace this function with the check compatibility function
                        {
                            PartsView.Rows.Add(part.Name, part.PartNumber, part.Category);
                            PartsView.Rows[PartsView.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial", 10);
                            if (SelectedParts.Contains(part))
                                PartsView.Rows[PartsView.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                            Parts.Add(part);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            int PrevLen = PropulsionDropdown.Items.Count;
            int previousSelection = PropulsionDropdown.SelectedIndex;
            //repopulate the propulsion dropdown to ensure is still only showing valid configs
            PropulsionDropdown.Items.Clear();
            foreach (WheelChair WC in WheelChairs)
            {
                double Width = double.Parse( SizeDropdown.SelectedItem.ToString().Split('x')[0]);
                double Depth = double.Parse( SizeDropdown.SelectedItem.ToString().Split('x')[1]);
                if (!PropulsionDropdown.Items.Contains(WC.PropulsionType) && WC.Model == (string)Wheelchairdropdown.SelectedItem && Width == WC.Width && Depth == WC.Depth)
                {
                    PropulsionDropdown.Items.Add(WC.PropulsionType);
                }
            }

            //If the dropdown changed then reset the selected to 0
            PropulsionDropdown.SelectedIndexChanged -= new System.EventHandler(this.SelectedIndexChanged);
            if (PrevLen != PropulsionDropdown.Items.Count)
                PropulsionDropdown.SelectedIndex = 0;
            else
                PropulsionDropdown.SelectedIndex = previousSelection;
            PropulsionDropdown.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);

            

            UpdateParts();
            UpdateString();
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            if (PartsView.Rows.Count == 0)
                return;
            int selectedIdx = PartsView.SelectedRows[0].Index;
            PartsView.Rows[selectedIdx].DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            SelectedParts.Add(Parts[selectedIdx]);

            //Check for incompatible parts 
            if (SelectedParts.Last().CheckForInCompatibleParts(SelectedParts) == true) //If true we have incompatible parts
                    MessageBox.Show("Warning Incompatible part added");

            int PartCount = 0; 
            foreach (Part part in SelectedParts)
            {
                if (part.Name == SelectedParts.Last().Name)
                    PartCount += 1;
            }

            if (PartCount > SelectedParts.Last().maxcount)
                MessageBox.Show("Warning max number of this part exceeded");

            UpdateString();
        }

        private void RemovePart_Click(object sender, EventArgs e)
        {
            if (PartsView.Rows.Count == 0)
                return;
            Part DeletedPart = Parts[PartsView.SelectedRows[0].Index];
            for (int i = 0; i < SelectedParts.Count; i++)
            {
                if (SelectedParts[i].Name == DeletedPart.Name && SelectedParts[i].Category == DeletedPart.Category && SelectedParts[i].PartNumber == DeletedPart.PartNumber)
                {
                    int count = SelectedParts.Where(temp => temp.Equals(SelectedParts[i])).Select(temp => temp).Count();
                    SelectedParts[i] = null;
                    if (count ==1)
                        PartsView.Rows[PartsView.SelectedRows[0].Index].DefaultCellStyle.Font = new Font("Arial", 10);
                    break;
                }
            }
            SelectedParts.RemoveAll(item => item == null);
            UpdateString();
        }

        private void UpdateString()
        {
            String Str = "";
            Str += (string)Wheelchairdropdown.SelectedItem + " " + (string)SizeDropdown.SelectedItem + " " + (string)PropulsionDropdown.SelectedItem + "    "; //+ Environment.NewLine;
            Str += "Delivery: "+(string)DeliveryDrop.SelectedItem + "     Foot Plate Size: " + (string)FootPlateHeightDropDown.SelectedItem + Environment.NewLine;
            int count = 1;
            foreach (Part part in SelectedParts)
            {
                Str += count.ToString() + " - " + part.Name + " " + part.PartNumber + Environment.NewLine;
                count += 1;
            }
            TextOutput.Text = Str;
            Clipboard.SetText(Str);

            if (count >= 7)
            {
                MessageBox.Show("Warning: To many lines for text box!");
            }
        }

    }
}
