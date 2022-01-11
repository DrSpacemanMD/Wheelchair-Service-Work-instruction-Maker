
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
            this.SuspendLayout();
            // 
            // Wheelchairdropdown
            // 
            this.Wheelchairdropdown.FormattingEnabled = true;
            this.Wheelchairdropdown.Location = new System.Drawing.Point(24, 63);
            this.Wheelchairdropdown.Name = "Wheelchairdropdown";
            this.Wheelchairdropdown.Size = new System.Drawing.Size(285, 28);
            this.Wheelchairdropdown.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 798);
            this.Controls.Add(this.Wheelchairdropdown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Wheelchairdropdown;
    }
}

