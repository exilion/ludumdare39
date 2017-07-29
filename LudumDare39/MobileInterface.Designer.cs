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
            gameTimer = new System.Windows.Forms.Timer(this.components);
            this.minigamePanel.SuspendLayout();
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
            this.minigamePanel.Size = new System.Drawing.Size(285, 237);
            this.minigamePanel.TabIndex = 0;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(100, 81);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(73, 21);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnStartGame_MouseClick);
            // 
            // MobileInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.minigamePanel);
            this.Name = "MobileInterface";
            this.Text = "Form1";
            this.minigamePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel minigamePanel;
        private System.Windows.Forms.Button btnStartGame;
    }
}

