namespace Lab5b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.doctorGroupBox = new System.Windows.Forms.GroupBox();
            this.episodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.doctorPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playedbyTextBox = new System.Windows.Forms.TextBox();
            this.playedbyLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companionGroupBox = new System.Windows.Forms.GroupBox();
            this.companionListBox = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.doctorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.companionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorGroupBox
            // 
            this.doctorGroupBox.Controls.Add(this.episodeTextBox);
            this.doctorGroupBox.Controls.Add(this.label4);
            this.doctorGroupBox.Controls.Add(this.doctorPictureBox);
            this.doctorGroupBox.Controls.Add(this.label3);
            this.doctorGroupBox.Controls.Add(this.ageTextBox);
            this.doctorGroupBox.Controls.Add(this.seriesTextBox);
            this.doctorGroupBox.Controls.Add(this.label1);
            this.doctorGroupBox.Controls.Add(this.yearTextBox);
            this.doctorGroupBox.Controls.Add(this.label2);
            this.doctorGroupBox.Controls.Add(this.playedbyTextBox);
            this.doctorGroupBox.Controls.Add(this.playedbyLabel);
            this.doctorGroupBox.Controls.Add(this.doctorLabel);
            this.doctorGroupBox.Controls.Add(this.doctorComboBox);
            this.doctorGroupBox.Location = new System.Drawing.Point(12, 47);
            this.doctorGroupBox.Name = "doctorGroupBox";
            this.doctorGroupBox.Size = new System.Drawing.Size(413, 391);
            this.doctorGroupBox.TabIndex = 0;
            this.doctorGroupBox.TabStop = false;
            this.doctorGroupBox.Text = "The Doctor";
            // 
            // episodeTextBox
            // 
            this.episodeTextBox.Location = new System.Drawing.Point(29, 336);
            this.episodeTextBox.Name = "episodeTextBox";
            this.episodeTextBox.Size = new System.Drawing.Size(359, 22);
            this.episodeTextBox.TabIndex = 12;
            this.episodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "First full episode:";
            // 
            // doctorPictureBox
            // 
            this.doctorPictureBox.Location = new System.Drawing.Point(201, 124);
            this.doctorPictureBox.Name = "doctorPictureBox";
            this.doctorPictureBox.Size = new System.Drawing.Size(187, 191);
            this.doctorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doctorPictureBox.TabIndex = 10;
            this.doctorPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age At Start:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(121, 197);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(54, 22);
            this.ageTextBox.TabIndex = 8;
            this.ageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.Location = new System.Drawing.Point(121, 157);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.Size = new System.Drawing.Size(54, 22);
            this.seriesTextBox.TabIndex = 7;
            this.seriesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Series:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(121, 120);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(54, 22);
            this.yearTextBox.TabIndex = 5;
            this.yearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year:";
            // 
            // playedbyTextBox
            // 
            this.playedbyTextBox.Location = new System.Drawing.Point(121, 84);
            this.playedbyTextBox.Multiline = true;
            this.playedbyTextBox.Name = "playedbyTextBox";
            this.playedbyTextBox.Size = new System.Drawing.Size(267, 22);
            this.playedbyTextBox.TabIndex = 3;
            this.playedbyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // playedbyLabel
            // 
            this.playedbyLabel.AutoSize = true;
            this.playedbyLabel.Location = new System.Drawing.Point(23, 84);
            this.playedbyLabel.Name = "playedbyLabel";
            this.playedbyLabel.Size = new System.Drawing.Size(74, 17);
            this.playedbyLabel.TabIndex = 2;
            this.playedbyLabel.Text = "Played by:";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(23, 50);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(54, 17);
            this.doctorLabel.TabIndex = 1;
            this.doctorLabel.Text = "Doctor:";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(121, 44);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(267, 24);
            this.doctorComboBox.TabIndex = 0;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.DoctorComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // companionGroupBox
            // 
            this.companionGroupBox.Controls.Add(this.companionListBox);
            this.companionGroupBox.Location = new System.Drawing.Point(431, 47);
            this.companionGroupBox.Name = "companionGroupBox";
            this.companionGroupBox.Size = new System.Drawing.Size(424, 391);
            this.companionGroupBox.TabIndex = 2;
            this.companionGroupBox.TabStop = false;
            this.companionGroupBox.Text = "Companions and their first episode with this Doctor:";
            // 
            // companionListBox
            // 
            this.companionListBox.FormattingEnabled = true;
            this.companionListBox.ItemHeight = 16;
            this.companionListBox.Location = new System.Drawing.Point(6, 28);
            this.companionListBox.Name = "companionListBox";
            this.companionListBox.Size = new System.Drawing.Size(412, 356);
            this.companionListBox.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(861, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 278);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(861, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(138, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Solve using LINQ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Solve using SQL";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.companionGroupBox);
            this.Controls.Add(this.doctorGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.doctorGroupBox.ResumeLayout(false);
            this.doctorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.companionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox doctorGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox companionGroupBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playedbyTextBox;
        private System.Windows.Forms.Label playedbyLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.TextBox episodeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox doctorPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox companionListBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

