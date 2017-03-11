namespace Mario
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
            this.components = new System.ComponentModel.Container();
            this.scene = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.block = new System.Windows.Forms.PictureBox();
            this.scene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).BeginInit();
            this.SuspendLayout();
            // 
            // scene
            // 
            this.scene.Controls.Add(this.block);
            this.scene.Controls.Add(this.player);
            this.scene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scene.Location = new System.Drawing.Point(0, 0);
            this.scene.Name = "scene";
            this.scene.Size = new System.Drawing.Size(1094, 631);
            this.scene.TabIndex = 0;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player.Location = new System.Drawing.Point(240, 248);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(25, 25);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // block
            // 
            this.block.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.block.Location = new System.Drawing.Point(481, 550);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(304, 81);
            this.block.TabIndex = 1;
            this.block.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 631);
            this.Controls.Add(this.scene);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mario - Paweł Jadanowski";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.scene.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scene;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox block;
    }
}

