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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobileInterface));
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureMenu
            // 
            this.pictureMenu.Image = global::LudumDare39.Properties.Resources.menu;
            this.pictureMenu.ImageLocation = "./menu.jpg";
            this.pictureMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureMenu.InitialImage")));
            this.pictureMenu.Location = new System.Drawing.Point(1, 31);
            this.pictureMenu.Name = "pictureMenu";
            this.pictureMenu.Size = new System.Drawing.Size(468, 759);
            this.pictureMenu.TabIndex = 1;
            this.pictureMenu.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 35);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MobileInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 801);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureMenu);
            this.Controls.Add(this.buttonStart);
            this.Name = "MobileInterface";
            this.Text = "LDGame";
            this.Load += new System.EventHandler(this.MobileInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

