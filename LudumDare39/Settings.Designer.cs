namespace LudumDare39
{
    partial class Settings
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.radioBrightLow = new System.Windows.Forms.RadioButton();
            this.radioBrightMed = new System.Windows.Forms.RadioButton();
            this.radioBrightHigh = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioVolOff = new System.Windows.Forms.RadioButton();
            this.radioVolLow = new System.Windows.Forms.RadioButton();
            this.radioVolMed = new System.Windows.Forms.RadioButton();
            this.radioVolHigh = new System.Windows.Forms.RadioButton();
            this.checkBoxWifi = new System.Windows.Forms.CheckBox();
            this.checkBoxBluetooth = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(109, 292);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrightness.Location = new System.Drawing.Point(115, 23);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(66, 13);
            this.labelBrightness.TabIndex = 1;
            this.labelBrightness.Text = "Brightness";
            // 
            // radioBrightLow
            // 
            this.radioBrightLow.AutoSize = true;
            this.radioBrightLow.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioBrightLow.Location = new System.Drawing.Point(16, 6);
            this.radioBrightLow.Name = "radioBrightLow";
            this.radioBrightLow.Size = new System.Drawing.Size(31, 30);
            this.radioBrightLow.TabIndex = 2;
            this.radioBrightLow.TabStop = true;
            this.radioBrightLow.Text = "Low";
            this.radioBrightLow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioBrightLow.UseVisualStyleBackColor = true;
            // 
            // radioBrightMed
            // 
            this.radioBrightMed.AutoSize = true;
            this.radioBrightMed.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioBrightMed.Location = new System.Drawing.Point(95, 6);
            this.radioBrightMed.Name = "radioBrightMed";
            this.radioBrightMed.Size = new System.Drawing.Size(48, 30);
            this.radioBrightMed.TabIndex = 3;
            this.radioBrightMed.TabStop = true;
            this.radioBrightMed.Text = "Medium";
            this.radioBrightMed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioBrightMed.UseVisualStyleBackColor = true;
            // 
            // radioBrightHigh
            // 
            this.radioBrightHigh.AutoSize = true;
            this.radioBrightHigh.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioBrightHigh.Location = new System.Drawing.Point(189, 6);
            this.radioBrightHigh.Name = "radioBrightHigh";
            this.radioBrightHigh.Size = new System.Drawing.Size(33, 30);
            this.radioBrightHigh.TabIndex = 4;
            this.radioBrightHigh.TabStop = true;
            this.radioBrightHigh.Text = "High";
            this.radioBrightHigh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioBrightHigh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volume";
            // 
            // radioVolOff
            // 
            this.radioVolOff.AutoSize = true;
            this.radioVolOff.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioVolOff.Location = new System.Drawing.Point(13, 5);
            this.radioVolOff.Name = "radioVolOff";
            this.radioVolOff.Size = new System.Drawing.Size(35, 30);
            this.radioVolOff.TabIndex = 6;
            this.radioVolOff.TabStop = true;
            this.radioVolOff.Text = "Mute";
            this.radioVolOff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioVolOff.UseVisualStyleBackColor = true;
            // 
            // radioVolLow
            // 
            this.radioVolLow.AutoSize = true;
            this.radioVolLow.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioVolLow.Location = new System.Drawing.Point(74, 5);
            this.radioVolLow.Name = "radioVolLow";
            this.radioVolLow.Size = new System.Drawing.Size(31, 30);
            this.radioVolLow.TabIndex = 7;
            this.radioVolLow.TabStop = true;
            this.radioVolLow.Text = "Low";
            this.radioVolLow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioVolLow.UseVisualStyleBackColor = true;
            // 
            // radioVolMed
            // 
            this.radioVolMed.AutoSize = true;
            this.radioVolMed.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioVolMed.Location = new System.Drawing.Point(121, 5);
            this.radioVolMed.Name = "radioVolMed";
            this.radioVolMed.Size = new System.Drawing.Size(48, 30);
            this.radioVolMed.TabIndex = 8;
            this.radioVolMed.TabStop = true;
            this.radioVolMed.Text = "Medium";
            this.radioVolMed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioVolMed.UseVisualStyleBackColor = true;
            // 
            // radioVolHigh
            // 
            this.radioVolHigh.AutoSize = true;
            this.radioVolHigh.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioVolHigh.Location = new System.Drawing.Point(186, 5);
            this.radioVolHigh.Name = "radioVolHigh";
            this.radioVolHigh.Size = new System.Drawing.Size(33, 30);
            this.radioVolHigh.TabIndex = 9;
            this.radioVolHigh.TabStop = true;
            this.radioVolHigh.Text = "High";
            this.radioVolHigh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioVolHigh.UseVisualStyleBackColor = true;
            // 
            // checkBoxWifi
            // 
            this.checkBoxWifi.AutoSize = true;
            this.checkBoxWifi.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxWifi.Location = new System.Drawing.Point(74, 206);
            this.checkBoxWifi.Name = "checkBoxWifi";
            this.checkBoxWifi.Size = new System.Drawing.Size(35, 31);
            this.checkBoxWifi.TabIndex = 10;
            this.checkBoxWifi.Text = "Wi Fi";
            this.checkBoxWifi.UseVisualStyleBackColor = true;
            // 
            // checkBoxBluetooth
            // 
            this.checkBoxBluetooth.AutoSize = true;
            this.checkBoxBluetooth.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxBluetooth.Location = new System.Drawing.Point(169, 206);
            this.checkBoxBluetooth.Name = "checkBoxBluetooth";
            this.checkBoxBluetooth.Size = new System.Drawing.Size(56, 31);
            this.checkBoxBluetooth.TabIndex = 11;
            this.checkBoxBluetooth.Text = "Bluetooth";
            this.checkBoxBluetooth.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBrightHigh);
            this.panel1.Controls.Add(this.radioBrightMed);
            this.panel1.Controls.Add(this.radioBrightLow);
            this.panel1.Location = new System.Drawing.Point(23, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 53);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioVolHigh);
            this.panel2.Controls.Add(this.radioVolMed);
            this.panel2.Controls.Add(this.radioVolLow);
            this.panel2.Controls.Add(this.radioVolOff);
            this.panel2.Location = new System.Drawing.Point(26, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 56);
            this.panel2.TabIndex = 13;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxBluetooth);
            this.Controls.Add(this.checkBoxWifi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.buttonClose);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.RadioButton radioBrightLow;
        private System.Windows.Forms.RadioButton radioBrightMed;
        private System.Windows.Forms.RadioButton radioBrightHigh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioVolOff;
        private System.Windows.Forms.RadioButton radioVolLow;
        private System.Windows.Forms.RadioButton radioVolMed;
        private System.Windows.Forms.RadioButton radioVolHigh;
        private System.Windows.Forms.CheckBox checkBoxWifi;
        private System.Windows.Forms.CheckBox checkBoxBluetooth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}