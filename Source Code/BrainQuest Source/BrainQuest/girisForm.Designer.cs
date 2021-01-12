namespace BrainQuest
{
    partial class girisForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.yuklemeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // yuklemeLabel
            // 
            this.yuklemeLabel.AutoSize = true;
            this.yuklemeLabel.BackColor = System.Drawing.Color.Transparent;
            this.yuklemeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yuklemeLabel.Location = new System.Drawing.Point(12, 9);
            this.yuklemeLabel.Name = "yuklemeLabel";
            this.yuklemeLabel.Size = new System.Drawing.Size(0, 13);
            this.yuklemeLabel.TabIndex = 0;
            // 
            // girisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrainQuest.Properties.Resources.giris_ekranı;
            this.ClientSize = new System.Drawing.Size(501, 293);
            this.ControlBox = false;
            this.Controls.Add(this.yuklemeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "girisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label yuklemeLabel;
    }
}