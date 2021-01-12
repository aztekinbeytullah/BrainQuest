namespace BrainQuest
{
    partial class yardimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yardimForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kapatButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BrainQuest.Properties.Resources.yardinUstMenu;
            this.panel1.Controls.Add(this.kapatButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 100);
            this.panel1.TabIndex = 0;
            // 
            // kapatButton
            // 
            this.kapatButton.BackColor = System.Drawing.Color.Transparent;
            this.kapatButton.FlatAppearance.BorderSize = 0;
            this.kapatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.kapatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.kapatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapatButton.Image = ((System.Drawing.Image)(resources.GetObject("kapatButton.Image")));
            this.kapatButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.kapatButton.Location = new System.Drawing.Point(698, 22);
            this.kapatButton.Name = "kapatButton";
            this.kapatButton.Size = new System.Drawing.Size(60, 25);
            this.kapatButton.TabIndex = 4;
            this.kapatButton.Text = "     Kapat";
            this.kapatButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kapatButton.UseVisualStyleBackColor = false;
            this.kapatButton.MouseLeave += new System.EventHandler(this.kapatButton_MouseLeave);
            this.kapatButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kapatButton_MouseMove);
            this.kapatButton.Click += new System.EventHandler(this.kapatButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.axShockwaveFlash1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 425);
            this.panel2.TabIndex = 1;
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(0, 0);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(790, 425);
            this.axShockwaveFlash1.TabIndex = 0;
            // 
            // yardimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yardimForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yardimForm";
            this.Load += new System.EventHandler(this.yardimForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button kapatButton;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
    }
}