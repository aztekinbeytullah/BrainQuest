namespace BrainQuest
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Beyin", 9);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Beyin Sapı", 0);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Limbik Sistem", 1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Serebrum(Neo Korteks)", 2);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Prefrontal Lob", 3);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Temporal Lob", 5);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Motor Korteks", 6);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Serebellum", 7);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Bellek", 8);
            this.saatTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownBaslatButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.sözlükToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denmeSinavlariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.notDefteriToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sozlukToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.yardimToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.saatToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.simgeListView = new System.Windows.Forms.ListView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.desktoppictureBox = new System.Windows.Forms.PictureBox();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desktoppictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saatTimer
            // 
            this.saatTimer.Enabled = true;
            this.saatTimer.Interval = 1000;
            this.saatTimer.Tick += new System.EventHandler(this.saatTimer_Tick);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.simgeListView);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.desktoppictureBox);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1000, 675);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1000, 700);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownBaslatButton,
            this.toolStripSeparator1,
            this.notDefteriToolStripButton,
            this.sozlukToolStripButton,
            this.yardimToolStripButton,
            this.toolStripLabel1,
            this.saatToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(966, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripDropDownBaslatButton
            // 
            this.toolStripDropDownBaslatButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sözlükToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.denmeSinavlariToolStripMenuItem,
            this.toolStripSeparator2,
            this.kapatToolStripMenuItem});
            this.toolStripDropDownBaslatButton.Image = global::BrainQuest.Properties.Resources.icon;
            this.toolStripDropDownBaslatButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownBaslatButton.Name = "toolStripDropDownBaslatButton";
            this.toolStripDropDownBaslatButton.Size = new System.Drawing.Size(50, 22);
            this.toolStripDropDownBaslatButton.Text = "BQ";
            this.toolStripDropDownBaslatButton.ToolTipText = "BrainQuest Başlat";
            // 
            // sözlükToolStripMenuItem
            // 
            this.sözlükToolStripMenuItem.Image = global::BrainQuest.Properties.Resources.sözlükc;
            this.sözlükToolStripMenuItem.Name = "sözlükToolStripMenuItem";
            this.sözlükToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sözlükToolStripMenuItem.Text = "Sözlük";
            this.sözlükToolStripMenuItem.Click += new System.EventHandler(this.sözlükToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Image = global::BrainQuest.Properties.Resources.Help;
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // denmeSinavlariToolStripMenuItem
            // 
            this.denmeSinavlariToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("denmeSinavlariToolStripMenuItem.Image")));
            this.denmeSinavlariToolStripMenuItem.Name = "denmeSinavlariToolStripMenuItem";
            this.denmeSinavlariToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.denmeSinavlariToolStripMenuItem.Text = "Deneme Sınavları";
            this.denmeSinavlariToolStripMenuItem.Click += new System.EventHandler(this.denemSinavlariToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kapatToolStripMenuItem.Image")));
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // notDefteriToolStripButton
            // 
            this.notDefteriToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notDefteriToolStripButton.Image = global::BrainQuest.Properties.Resources.notebook;
            this.notDefteriToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.notDefteriToolStripButton.Name = "notDefteriToolStripButton";
            this.notDefteriToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.notDefteriToolStripButton.Text = "toolStripButton1";
            this.notDefteriToolStripButton.ToolTipText = "Not Defteri-JetTool";
            this.notDefteriToolStripButton.Click += new System.EventHandler(this.notDefteriToolStripButton_Click);
            // 
            // sozlukToolStripButton
            // 
            this.sozlukToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sozlukToolStripButton.Image = global::BrainQuest.Properties.Resources.sözlükc;
            this.sozlukToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sozlukToolStripButton.Name = "sozlukToolStripButton";
            this.sozlukToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.sozlukToolStripButton.Text = "toolStripButton2";
            this.sozlukToolStripButton.ToolTipText = "Sözlük - JetTool";
            this.sozlukToolStripButton.Click += new System.EventHandler(this.sozlukToolStripButton_Click_1);
            // 
            // yardimToolStripButton
            // 
            this.yardimToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yardimToolStripButton.Image = global::BrainQuest.Properties.Resources.Help;
            this.yardimToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yardimToolStripButton.Name = "yardimToolStripButton";
            this.yardimToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.yardimToolStripButton.Text = "toolStripButton3";
            this.yardimToolStripButton.ToolTipText = "Yardım-JetTool";
            this.yardimToolStripButton.Click += new System.EventHandler(this.yardimToolStripButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(760, 22);
            this.toolStripLabel1.Text = resources.GetString("toolStripLabel1.Text");
            // 
            // saatToolStripLabel
            // 
            this.saatToolStripLabel.Name = "saatToolStripLabel";
            this.saatToolStripLabel.Size = new System.Drawing.Size(78, 22);
            this.saatToolStripLabel.Text = "toolStripLabel2";
            // 
            // simgeListView
            // 
            this.simgeListView.BackgroundImage = global::BrainQuest.Properties.Resources.arkaPlan;
            this.simgeListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.simgeListView.Dock = System.Windows.Forms.DockStyle.Left;
            listViewItem2.StateImageIndex = 0;
            this.simgeListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.simgeListView.LargeImageList = this.ımageList1;
            this.simgeListView.Location = new System.Drawing.Point(0, 0);
            this.simgeListView.Name = "simgeListView";
            this.simgeListView.Size = new System.Drawing.Size(140, 675);
            this.simgeListView.SmallImageList = this.ımageList1;
            this.simgeListView.TabIndex = 1;
            this.simgeListView.UseCompatibleStateImageBehavior = false;
            this.simgeListView.SelectedIndexChanged += new System.EventHandler(this.simgeListView_SelectedIndexChanged_1);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "beyinsapi.png");
            this.ımageList1.Images.SetKeyName(1, "limbik.png");
            this.ımageList1.Images.SetKeyName(2, "tüm.png");
            this.ımageList1.Images.SetKeyName(3, "frontal.png");
            this.ımageList1.Images.SetKeyName(4, "pariental.png");
            this.ımageList1.Images.SetKeyName(5, "temproral.png");
            this.ımageList1.Images.SetKeyName(6, "motor.png");
            this.ımageList1.Images.SetKeyName(7, "beyincik.png");
            this.ımageList1.Images.SetKeyName(8, "bellek.png");
            this.ımageList1.Images.SetKeyName(9, "sada.png");
            // 
            // desktoppictureBox
            // 
            this.desktoppictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktoppictureBox.Image = global::BrainQuest.Properties.Resources.arkaPlan;
            this.desktoppictureBox.Location = new System.Drawing.Point(0, 0);
            this.desktoppictureBox.Name = "desktoppictureBox";
            this.desktoppictureBox.Size = new System.Drawing.Size(1000, 675);
            this.desktoppictureBox.TabIndex = 0;
            this.desktoppictureBox.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desktoppictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer saatTimer;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownBaslatButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton notDefteriToolStripButton;
        private System.Windows.Forms.ToolStripButton sozlukToolStripButton;
        private System.Windows.Forms.ToolStripButton yardimToolStripButton;
        private System.Windows.Forms.ListView simgeListView;
        private System.Windows.Forms.PictureBox desktoppictureBox;
        private System.Windows.Forms.ToolStripMenuItem sözlükToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denmeSinavlariToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel saatToolStripLabel;
        private System.Windows.Forms.ImageList ımageList1;
   
              

    }
}

