namespace LudumDare39
{
    partial class MobileInterface
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureOSBar = new System.Windows.Forms.PictureBox();
            this.pictureMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOSBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(193, 365);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_click);
            // 
            // pictureOSBar
            // 
            this.pictureOSBar.Location = new System.Drawing.Point(1, -1);
            this.pictureOSBar.Name = "pictureOSBar";
            this.pictureOSBar.Size = new System.Drawing.Size(464, 35);
            this.pictureOSBar.TabIndex = 2;
            this.pictureOSBar.TabStop = false;
            // 
            // pictureMenu
            // 
            this.pictureMenu.ImageLocation = "";
            this.pictureMenu.InitialImage = null;
            this.pictureMenu.Location = new System.Drawing.Point(1, 31);
            this.pictureMenu.Name = "pictureMenu";
            this.pictureMenu.Size = new System.Drawing.Size(464, 775);
            this.pictureMenu.TabIndex = 1;
            this.pictureMenu.TabStop = false;
            // 
            // MobileInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 801);
            this.Controls.Add(this.pictureOSBar);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureMenu);
            this.Name = "MobileInterface";
            this.Text = "LDGame";
            this.Load += new System.EventHandler(this.MobileInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOSBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureMenu;
        private System.Windows.Forms.PictureBox pictureOSBar;
    }
}

