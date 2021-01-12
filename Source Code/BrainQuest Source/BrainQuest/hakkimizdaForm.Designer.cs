namespace BrainQuest
{
    partial class hakkimizdaForm
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
            this.kapatLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // kapatLabel
            // 
            this.kapatLabel.BackColor = System.Drawing.Color.Transparent;
            this.kapatLabel.Location = new System.Drawing.Point(304, 13);
            this.kapatLabel.Name = "kapatLabel";
            this.kapatLabel.Size = new System.Drawing.Size(75, 17);
            this.kapatLabel.TabIndex = 0;
            this.toolTip1.SetToolTip(this.kapatLabel, "Kapat");
            this.kapatLabel.Click += new System.EventHandler(this.kapatLabel_Click);
            // 
            // hakkimizdaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrainQuest.Properties.Resources.hakkimizda;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.kapatLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hakkimizdaForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hakkimizdaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label kapatLabel;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}