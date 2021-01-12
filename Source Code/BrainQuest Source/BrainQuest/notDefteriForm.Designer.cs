namespace BrainQuest
{
    partial class notDefteriForm
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
            this.aramaAktifCheckBox = new System.Windows.Forms.CheckBox();
            this.kaydetLabel = new System.Windows.Forms.Label();
            this.silLabel = new System.Windows.Forms.Label();
            this.kapatLabel = new System.Windows.Forms.Label();
            this.baslikTextBox = new System.Windows.Forms.TextBox();
            this.icerikTextBox = new System.Windows.Forms.TextBox();
            this.konuComboBox = new System.Windows.Forms.ComboBox();
            this.baslikComboBox = new System.Windows.Forms.ComboBox();
            this.duzeltLabel = new System.Windows.Forms.Label();
            this.islemDurumLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // aramaAktifCheckBox
            // 
            this.aramaAktifCheckBox.AutoSize = true;
            this.aramaAktifCheckBox.Location = new System.Drawing.Point(142, 290);
            this.aramaAktifCheckBox.Name = "aramaAktifCheckBox";
            this.aramaAktifCheckBox.Size = new System.Drawing.Size(15, 14);
            this.aramaAktifCheckBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.aramaAktifCheckBox, "Aramayı Başlat");
            this.aramaAktifCheckBox.UseVisualStyleBackColor = true;
            this.aramaAktifCheckBox.CheckedChanged += new System.EventHandler(this.aramaAktifCheckBox_CheckedChanged);
            // 
            // kaydetLabel
            // 
            this.kaydetLabel.BackColor = System.Drawing.Color.Transparent;
            this.kaydetLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydetLabel.Location = new System.Drawing.Point(40, 219);
            this.kaydetLabel.Name = "kaydetLabel";
            this.kaydetLabel.Size = new System.Drawing.Size(66, 21);
            this.kaydetLabel.TabIndex = 1;
            this.kaydetLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.kaydetLabel, "Kaydet");
            this.kaydetLabel.Click += new System.EventHandler(this.kaydetLabel_Click);
            // 
            // silLabel
            // 
            this.silLabel.BackColor = System.Drawing.Color.Transparent;
            this.silLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.silLabel.Enabled = false;
            this.silLabel.Location = new System.Drawing.Point(40, 289);
            this.silLabel.Name = "silLabel";
            this.silLabel.Size = new System.Drawing.Size(64, 14);
            this.silLabel.TabIndex = 2;
            this.toolTip1.SetToolTip(this.silLabel, "Sil");
            this.silLabel.Click += new System.EventHandler(this.silLabel_Click);
            // 
            // kapatLabel
            // 
            this.kapatLabel.BackColor = System.Drawing.Color.Transparent;
            this.kapatLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kapatLabel.Location = new System.Drawing.Point(307, 11);
            this.kapatLabel.Name = "kapatLabel";
            this.kapatLabel.Size = new System.Drawing.Size(52, 15);
            this.kapatLabel.TabIndex = 3;
            this.toolTip1.SetToolTip(this.kapatLabel, "Kapat");
            this.kapatLabel.Click += new System.EventHandler(this.kapatLabel_Click);
            // 
            // baslikTextBox
            // 
            this.baslikTextBox.BackColor = System.Drawing.Color.White;
            this.baslikTextBox.Location = new System.Drawing.Point(146, 92);
            this.baslikTextBox.MaxLength = 30;
            this.baslikTextBox.Name = "baslikTextBox";
            this.baslikTextBox.Size = new System.Drawing.Size(213, 20);
            this.baslikTextBox.TabIndex = 5;
            // 
            // icerikTextBox
            // 
            this.icerikTextBox.BackColor = System.Drawing.Color.White;
            this.icerikTextBox.Location = new System.Drawing.Point(145, 132);
            this.icerikTextBox.MaxLength = 1000;
            this.icerikTextBox.Multiline = true;
            this.icerikTextBox.Name = "icerikTextBox";
            this.icerikTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.icerikTextBox.Size = new System.Drawing.Size(213, 112);
            this.icerikTextBox.TabIndex = 6;
            // 
            // konuComboBox
            // 
            this.konuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.konuComboBox.DropDownWidth = 213;
            this.konuComboBox.FormattingEnabled = true;
            this.konuComboBox.Items.AddRange(new object[] {
            "Beyin Sapı",
            "Limbik Sistem",
            "Serebrum",
            "Frontal Lob",
            "Pariental Lob",
            "Motor Korteks",
            "Oksipital Lob",
            "Temporal Lob",
            "Serebellum"});
            this.konuComboBox.Location = new System.Drawing.Point(146, 53);
            this.konuComboBox.Name = "konuComboBox";
            this.konuComboBox.Size = new System.Drawing.Size(213, 21);
            this.konuComboBox.TabIndex = 7;
            this.konuComboBox.SelectedIndexChanged += new System.EventHandler(this.konuComboBox_SelectedIndexChanged);
            // 
            // baslikComboBox
            // 
            this.baslikComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baslikComboBox.DropDownWidth = 213;
            this.baslikComboBox.FormattingEnabled = true;
            this.baslikComboBox.Location = new System.Drawing.Point(146, 92);
            this.baslikComboBox.Name = "baslikComboBox";
            this.baslikComboBox.Size = new System.Drawing.Size(213, 21);
            this.baslikComboBox.TabIndex = 8;
            this.baslikComboBox.Visible = false;
            this.baslikComboBox.SelectedIndexChanged += new System.EventHandler(this.baslikComboBox_SelectedIndexChanged);
            // 
            // duzeltLabel
            // 
            this.duzeltLabel.BackColor = System.Drawing.Color.Transparent;
            this.duzeltLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duzeltLabel.Enabled = false;
            this.duzeltLabel.Location = new System.Drawing.Point(37, 257);
            this.duzeltLabel.Name = "duzeltLabel";
            this.duzeltLabel.Size = new System.Drawing.Size(66, 14);
            this.duzeltLabel.TabIndex = 9;
            this.toolTip1.SetToolTip(this.duzeltLabel, "Düzelt");
            this.duzeltLabel.Click += new System.EventHandler(this.duzeltLabel_Click);
            // 
            // islemDurumLabel
            // 
            this.islemDurumLabel.BackColor = System.Drawing.Color.Transparent;
            this.islemDurumLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.islemDurumLabel.Location = new System.Drawing.Point(294, 298);
            this.islemDurumLabel.Name = "islemDurumLabel";
            this.islemDurumLabel.Size = new System.Drawing.Size(88, 21);
            this.islemDurumLabel.TabIndex = 10;
            this.islemDurumLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // notDefteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrainQuest.Properties.Resources.notDefteriArkaPlan;
            this.ClientSize = new System.Drawing.Size(398, 350);
            this.Controls.Add(this.islemDurumLabel);
            this.Controls.Add(this.duzeltLabel);
            this.Controls.Add(this.baslikComboBox);
            this.Controls.Add(this.konuComboBox);
            this.Controls.Add(this.icerikTextBox);
            this.Controls.Add(this.baslikTextBox);
            this.Controls.Add(this.kapatLabel);
            this.Controls.Add(this.silLabel);
            this.Controls.Add(this.kaydetLabel);
            this.Controls.Add(this.aramaAktifCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "notDefteriForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notDefteriForm";
            this.Load += new System.EventHandler(this.notDefteriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox aramaAktifCheckBox;
        private System.Windows.Forms.Label kaydetLabel;
        private System.Windows.Forms.Label silLabel;
        private System.Windows.Forms.Label kapatLabel;
        private System.Windows.Forms.TextBox baslikTextBox;
        private System.Windows.Forms.TextBox icerikTextBox;
        private System.Windows.Forms.ComboBox konuComboBox;
        private System.Windows.Forms.ComboBox baslikComboBox;
        private System.Windows.Forms.Label duzeltLabel;
        private System.Windows.Forms.Label islemDurumLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}