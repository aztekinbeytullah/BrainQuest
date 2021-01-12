namespace BrainQuest
{
    partial class sozlukForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.kelimeListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kelimeAnlamiTextBox = new System.Windows.Forms.TextBox();
            this.arananKelimeTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kapatLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Bulunan Kelimeler";
            // 
            // kelimeListBox
            // 
            this.kelimeListBox.FormattingEnabled = true;
            this.kelimeListBox.Location = new System.Drawing.Point(103, 55);
            this.kelimeListBox.Name = "kelimeListBox";
            this.kelimeListBox.Size = new System.Drawing.Size(121, 69);
            this.kelimeListBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.kelimeListBox, "Bulunan Kelimeler..Seçiniz");
            this.kelimeListBox.SelectedIndexChanged += new System.EventHandler(this.kelimeListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Seçilen Kelimenin Anlamı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Aranılan Kelime:";
            // 
            // kelimeAnlamiTextBox
            // 
            this.kelimeAnlamiTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kelimeAnlamiTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.kelimeAnlamiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelimeAnlamiTextBox.ForeColor = System.Drawing.Color.Red;
            this.kelimeAnlamiTextBox.Location = new System.Drawing.Point(21, 198);
            this.kelimeAnlamiTextBox.Multiline = true;
            this.kelimeAnlamiTextBox.Name = "kelimeAnlamiTextBox";
            this.kelimeAnlamiTextBox.ReadOnly = true;
            this.kelimeAnlamiTextBox.Size = new System.Drawing.Size(215, 87);
            this.kelimeAnlamiTextBox.TabIndex = 3;
            // 
            // arananKelimeTextBox
            // 
            this.arananKelimeTextBox.Location = new System.Drawing.Point(103, 16);
            this.arananKelimeTextBox.Name = "arananKelimeTextBox";
            this.arananKelimeTextBox.Size = new System.Drawing.Size(121, 20);
            this.arananKelimeTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.arananKelimeTextBox, "Aradığınız kelimeyi giriniz");
            this.arananKelimeTextBox.TextChanged += new System.EventHandler(this.arananKelimeTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BrainQuest.Properties.Resources.sözlükArkaplan;
            this.panel1.Controls.Add(this.kapatLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 26);
            this.panel1.TabIndex = 19;
            // 
            // kapatLabel
            // 
            this.kapatLabel.BackColor = System.Drawing.Color.Transparent;
            this.kapatLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kapatLabel.Location = new System.Drawing.Point(176, 12);
            this.kapatLabel.Name = "kapatLabel";
            this.kapatLabel.Size = new System.Drawing.Size(68, 13);
            this.kapatLabel.TabIndex = 0;
            this.toolTip1.SetToolTip(this.kapatLabel, "Kapat");
            this.kapatLabel.Click += new System.EventHandler(this.kapatLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.arananKelimeTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.kelimeListBox);
            this.groupBox1.Location = new System.Drawing.Point(21, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // sozlukForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrainQuest.Properties.Resources.sözlükArkaplan;
            this.ClientSize = new System.Drawing.Size(265, 320);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kelimeAnlamiTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sozlukForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sozlukForm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox kelimeListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kelimeAnlamiTextBox;
        private System.Windows.Forms.TextBox arananKelimeTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label kapatLabel;
        private System.Windows.Forms.ToolTip toolTip1;


    }
}