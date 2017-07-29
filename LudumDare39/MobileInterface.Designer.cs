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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer gameTimer;
            this.minigamePanel = new System.Windows.Forms.Panel();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.osPanel = new System.Windows.Forms.Panel();
            this.textBoxBattery = new System.Windows.Forms.TextBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.textboxTask = new System.Windows.Forms.TextBox();
            gameTimer = new System.Windows.Forms.Timer(this.components);
            this.minigamePanel.SuspendLayout();
            this.osPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // minigamePanel
            // 
            this.minigamePanel.AccessibleName = "";
            this.minigamePanel.Controls.Add(this.btnStartGame);
            this.minigamePanel.Location = new System.Drawing.Point(-1, 24);
            this.minigamePanel.Name = "minigamePanel";
            this.minigamePanel.Size = new System.Drawing.Size(465, 659);
            this.minigamePanel.TabIndex = 0;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(189, 266);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(73, 21);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnStartGame_MouseClick);
            // 
            // osPanel
            // 
            this.osPanel.BackgroundImage = global::LudumDare39.Properties.Resources.osbar;
            this.osPanel.Controls.Add(this.textBoxBattery);
            this.osPanel.Controls.Add(this.buttonSettings);
            this.osPanel.Controls.Add(this.textboxTask);
            this.osPanel.Location = new System.Drawing.Point(-1, -1);
            this.osPanel.Name = "osPanel";
            this.osPanel.Size = new System.Drawing.Size(465, 27);
            this.osPanel.TabIndex = 1;
            // 
            // textBoxBattery
            // 
            this.textBoxBattery.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxBattery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBattery.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBattery.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxBattery.Location = new System.Drawing.Point(353, 7);
            this.textBoxBattery.Name = "textBoxBattery";
            this.textBoxBattery.ReadOnly = true;
            this.textBoxBattery.Size = new System.Drawing.Size(46, 13);
            this.textBoxBattery.TabIndex = 2;
            this.textBoxBattery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSettings.Location = new System.Drawing.Point(404, 3);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(58, 23);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            // 
            // textboxTask
            // 
            this.textboxTask.BackColor = System.Drawing.SystemColors.Desktop;
            this.textboxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxTask.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxTask.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textboxTask.Location = new System.Drawing.Point(13, 6);
            this.textboxTask.Name = "textboxTask";
            this.textboxTask.ReadOnly = true;
            this.textboxTask.Size = new System.Drawing.Size(268, 13);
            this.textboxTask.TabIndex = 0;
            this.textboxTask.Text = "Press start to begin!";
            // 
            // MobileInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.osPanel);
            this.Controls.Add(this.minigamePanel);
            this.Name = "MobileInterface";
            this.Text = "LDGame";
            this.minigamePanel.ResumeLayout(false);
            this.osPanel.ResumeLayout(false);
            this.osPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel minigamePanel;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Panel osPanel;
        private System.Windows.Forms.TextBox textboxTask;
        private System.Windows.Forms.TextBox textBoxBattery;
        private System.Windows.Forms.Button buttonSettings;
    }
}

