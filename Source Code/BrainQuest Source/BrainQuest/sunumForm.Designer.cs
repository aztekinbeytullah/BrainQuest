namespace BrainQuest
{
    partial class sunumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sunumForm));
            this.flashPanel = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.notDefteriPictureBox = new System.Windows.Forms.PictureBox();
            this.sozlükPictureBox = new System.Windows.Forms.PictureBox();
            this.kapatButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flashPanel)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notDefteriPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sozlükPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flashPanel
            // 
            this.flashPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flashPanel.Enabled = true;
            this.flashPanel.Location = new System.Drawing.Point(0, 0);
            this.flashPanel.Name = "flashPanel";
            this.flashPanel.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flashPanel.OcxState")));
            this.flashPanel.Size = new System.Drawing.Size(790, 449);
            this.flashPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flashPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 449);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BackgroundImage = global::BrainQuest.Properties.Resources.sunumUst;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.notDefteriPictureBox);
            this.panel1.Controls.Add(this.sozlükPictureBox);
            this.panel1.Controls.Add(this.kapatButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 101);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(0, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(790, 19);
            this.label1.TabIndex = 6;
            // 
            // notDefteriPictureBox
            // 
            this.notDefteriPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.notDefteriPictureBox.Image = global::BrainQuest.Properties.Resources.notebook;
            this.notDefteriPictureBox.Location = new System.Drawing.Point(728, 54);
            this.notDefteriPictureBox.Name = "notDefteriPictureBox";
            this.notDefteriPictureBox.Size = new System.Drawing.Size(29, 25);
            this.notDefteriPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notDefteriPictureBox.TabIndex = 5;
            this.notDefteriPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.notDefteriPictureBox, "Not Defteri");
            this.notDefteriPictureBox.Click += new System.EventHandler(this.notDefteriPictureBox_Click);
            // 
            // sozlükPictureBox
            // 
            this.sozlükPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.sozlükPictureBox.Image = global::BrainQuest.Properties.Resources.sözlükc;
            this.sozlükPictureBox.Location = new System.Drawing.Point(697, 54);
            this.sozlükPictureBox.Name = "sozlükPictureBox";
            this.sozlükPictureBox.Size = new System.Drawing.Size(29, 25);
            this.sozlükPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sozlükPictureBox.TabIndex = 4;
            this.sozlükPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.sozlükPictureBox, "Sözlük");
            this.sozlükPictureBox.Click += new System.EventHandler(this.sozlükPictureBox_Click);
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
            this.kapatButton.Location = new System.Drawing.Point(697, 23);
            this.kapatButton.Name = "kapatButton";
            this.kapatButton.Size = new System.Drawing.Size(60, 25);
            this.kapatButton.TabIndex = 3;
            this.kapatButton.Text = "     Kapat";
            this.kapatButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kapatButton.UseVisualStyleBackColor = false;
            this.kapatButton.MouseLeave += new System.EventHandler(this.kapatButton_MouseLeave);
            this.kapatButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kapatButton_MouseMove);
            this.kapatButton.Click += new System.EventHandler(this.kapatButton_Click);
            // 
            // sunumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 550);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "sunumForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.sunumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flashPanel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notDefteriPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sozlükPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash flashPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button kapatButton;
        private System.Windows.Forms.PictureBox sozlükPictureBox;
        private System.Windows.Forms.PictureBox notDefteriPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;



    }
}