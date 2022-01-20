
namespace WheelChairStringMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Wheelchairdropdown = new System.Windows.Forms.ComboBox();
            this.SizeDropdown = new System.Windows.Forms.ComboBox();
            this.PropulsionDropdown = new System.Windows.Forms.ComboBox();
            this.PartsView = new System.Windows.Forms.DataGridView();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPart = new System.Windows.Forms.Button();
            this.TextOutput = new System.Windows.Forms.TextBox();
            this.RemovePart = new System.Windows.Forms.Button();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.PropLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeliveryDrop = new System.Windows.Forms.ComboBox();
            this.FootPlateHeightDropDown = new System.Windows.Forms.ComboBox();
            this.Deliverylabel = new System.Windows.Forms.Label();
            this.FootPlateLabel = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartsView)).BeginInit();
            this.SuspendLayout();
            // 
            // Wheelchairdropdown
            // 
            this.Wheelchairdropdown.BackColor = System.Drawing.SystemColors.Window;
            this.Wheelchairdropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Wheelchairdropdown.FormattingEnabled = true;
            this.Wheelchairdropdown.Location = new System.Drawing.Point(12, 63);
            this.Wheelchairdropdown.MaxDropDownItems = 20;
            this.Wheelchairdropdown.Name = "Wheelchairdropdown";
            this.Wheelchairdropdown.Size = new System.Drawing.Size(285, 28);
            this.Wheelchairdropdown.TabIndex = 0;
            this.Wheelchairdropdown.SelectedIndexChanged += new System.EventHandler(this.Wheelchairdropdown_SelectedIndexChanged);
            // 
            // SizeDropdown
            // 
            this.SizeDropdown.BackColor = System.Drawing.SystemColors.Window;
            this.SizeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeDropdown.FormattingEnabled = true;
            this.SizeDropdown.Location = new System.Drawing.Point(312, 63);
            this.SizeDropdown.MaxDropDownItems = 20;
            this.SizeDropdown.Name = "SizeDropdown";
            this.SizeDropdown.Size = new System.Drawing.Size(195, 28);
            this.SizeDropdown.TabIndex = 1;
            this.SizeDropdown.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // PropulsionDropdown
            // 
            this.PropulsionDropdown.BackColor = System.Drawing.SystemColors.Window;
            this.PropulsionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PropulsionDropdown.FormattingEnabled = true;
            this.PropulsionDropdown.Location = new System.Drawing.Point(521, 63);
            this.PropulsionDropdown.MaxDropDownItems = 20;
            this.PropulsionDropdown.Name = "PropulsionDropdown";
            this.PropulsionDropdown.Size = new System.Drawing.Size(195, 28);
            this.PropulsionDropdown.TabIndex = 2;
            this.PropulsionDropdown.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // PartsView
            // 
            this.PartsView.AllowUserToAddRows = false;
            this.PartsView.AllowUserToDeleteRows = false;
            this.PartsView.AllowUserToResizeColumns = false;
            this.PartsView.AllowUserToResizeRows = false;
            this.PartsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName,
            this.PartNumber,
            this.Cat});
            this.PartsView.Location = new System.Drawing.Point(746, 63);
            this.PartsView.MultiSelect = false;
            this.PartsView.Name = "PartsView";
            this.PartsView.ReadOnly = true;
            this.PartsView.RowHeadersVisible = false;
            this.PartsView.RowHeadersWidth = 62;
            this.PartsView.RowTemplate.Height = 28;
            this.PartsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsView.Size = new System.Drawing.Size(633, 707);
            this.PartsView.TabIndex = 3;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Part Name";
            this.PartName.MinimumWidth = 8;
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            this.PartName.Width = 150;
            // 
            // PartNumber
            // 
            this.PartNumber.HeaderText = "Part Number";
            this.PartNumber.MinimumWidth = 8;
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.ReadOnly = true;
            this.PartNumber.Width = 150;
            // 
            // Cat
            // 
            this.Cat.HeaderText = "Category";
            this.Cat.MinimumWidth = 8;
            this.Cat.Name = "Cat";
            this.Cat.ReadOnly = true;
            this.Cat.Width = 150;
            // 
            // AddPart
            // 
            this.AddPart.Location = new System.Drawing.Point(521, 107);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(195, 53);
            this.AddPart.TabIndex = 4;
            this.AddPart.Text = "Add Part";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // TextOutput
            // 
            this.TextOutput.Location = new System.Drawing.Point(12, 333);
            this.TextOutput.Multiline = true;
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextOutput.Size = new System.Drawing.Size(728, 437);
            this.TextOutput.TabIndex = 5;
            // 
            // RemovePart
            // 
            this.RemovePart.Location = new System.Drawing.Point(521, 166);
            this.RemovePart.Name = "RemovePart";
            this.RemovePart.Size = new System.Drawing.Size(195, 53);
            this.RemovePart.TabIndex = 6;
            this.RemovePart.Text = "Remove Part";
            this.RemovePart.UseVisualStyleBackColor = true;
            this.RemovePart.Click += new System.EventHandler(this.RemovePart_Click);
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(12, 40);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(52, 20);
            this.ModelLabel.TabIndex = 7;
            this.ModelLabel.Text = "Model";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(308, 40);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(40, 20);
            this.SizeLabel.TabIndex = 8;
            this.SizeLabel.Text = "Size";
            // 
            // PropLabel
            // 
            this.PropLabel.AutoSize = true;
            this.PropLabel.Location = new System.Drawing.Point(517, 40);
            this.PropLabel.Name = "PropLabel";
            this.PropLabel.Size = new System.Drawing.Size(83, 20);
            this.PropLabel.TabIndex = 9;
            this.PropLabel.Text = "Propulsion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Parts List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Text Output";
            // 
            // DeliveryDrop
            // 
            this.DeliveryDrop.BackColor = System.Drawing.SystemColors.Window;
            this.DeliveryDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeliveryDrop.FormattingEnabled = true;
            this.DeliveryDrop.Location = new System.Drawing.Point(12, 130);
            this.DeliveryDrop.MaxDropDownItems = 20;
            this.DeliveryDrop.Name = "DeliveryDrop";
            this.DeliveryDrop.Size = new System.Drawing.Size(285, 28);
            this.DeliveryDrop.TabIndex = 12;
            this.DeliveryDrop.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // FootPlateHeightDropDown
            // 
            this.FootPlateHeightDropDown.BackColor = System.Drawing.SystemColors.Window;
            this.FootPlateHeightDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FootPlateHeightDropDown.FormattingEnabled = true;
            this.FootPlateHeightDropDown.Location = new System.Drawing.Point(312, 130);
            this.FootPlateHeightDropDown.MaxDropDownItems = 20;
            this.FootPlateHeightDropDown.Name = "FootPlateHeightDropDown";
            this.FootPlateHeightDropDown.Size = new System.Drawing.Size(195, 28);
            this.FootPlateHeightDropDown.TabIndex = 13;
            this.FootPlateHeightDropDown.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // Deliverylabel
            // 
            this.Deliverylabel.AutoSize = true;
            this.Deliverylabel.Location = new System.Drawing.Point(12, 104);
            this.Deliverylabel.Name = "Deliverylabel";
            this.Deliverylabel.Size = new System.Drawing.Size(119, 20);
            this.Deliverylabel.TabIndex = 14;
            this.Deliverylabel.Text = "Deivery Method";
            // 
            // FootPlateLabel
            // 
            this.FootPlateLabel.AutoSize = true;
            this.FootPlateLabel.BackColor = System.Drawing.Color.Transparent;
            this.FootPlateLabel.Location = new System.Drawing.Point(308, 107);
            this.FootPlateLabel.Name = "FootPlateLabel";
            this.FootPlateLabel.Size = new System.Drawing.Size(133, 20);
            this.FootPlateLabel.TabIndex = 15;
            this.FootPlateLabel.Text = "Foot Plate Height";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(521, 225);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(195, 53);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 798);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.FootPlateLabel);
            this.Controls.Add(this.Deliverylabel);
            this.Controls.Add(this.FootPlateHeightDropDown);
            this.Controls.Add(this.DeliveryDrop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PropLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.RemovePart);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.PartsView);
            this.Controls.Add(this.PropulsionDropdown);
            this.Controls.Add(this.SizeDropdown);
            this.Controls.Add(this.Wheelchairdropdown);
            this.Name = "Form1";
            this.Text = "Work Instruction Builder";
            ((System.ComponentModel.ISupportInitialize)(this.PartsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Wheelchairdropdown;
        private System.Windows.Forms.ComboBox SizeDropdown;
        private System.Windows.Forms.ComboBox PropulsionDropdown;
        private System.Windows.Forms.DataGridView PartsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.TextBox TextOutput;
        private System.Windows.Forms.Button RemovePart;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label PropLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DeliveryDrop;
        private System.Windows.Forms.ComboBox FootPlateHeightDropDown;
        private System.Windows.Forms.Label Deliverylabel;
        private System.Windows.Forms.Label FootPlateLabel;
        private System.Windows.Forms.Button Clear;
    }
}

