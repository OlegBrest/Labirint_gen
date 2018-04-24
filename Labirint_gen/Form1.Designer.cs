namespace Labirint_gen
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_splitContainer = new System.Windows.Forms.SplitContainer();
            this.pict_panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.control_panel = new System.Windows.Forms.Panel();
            this.noise_numeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.depoint_bttn = new System.Windows.Forms.Button();
            this.Y_numeric = new System.Windows.Forms.NumericUpDown();
            this.X_numeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.digs_numeric = new System.Windows.Forms.NumericUpDown();
            this.deep_numeric = new System.Windows.Forms.NumericUpDown();
            this.digs_chkbx = new System.Windows.Forms.CheckBox();
            this.noise_chkbx = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seed_label = new System.Windows.Forms.Label();
            this.seed_textbx = new System.Windows.Forms.TextBox();
            this.clear_bttn = new System.Windows.Forms.Button();
            this.start_bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).BeginInit();
            this.main_splitContainer.Panel1.SuspendLayout();
            this.main_splitContainer.Panel2.SuspendLayout();
            this.main_splitContainer.SuspendLayout();
            this.pict_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.control_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noise_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digs_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deep_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // main_splitContainer
            // 
            this.main_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.main_splitContainer.Location = new System.Drawing.Point(0, 0);
            this.main_splitContainer.Name = "main_splitContainer";
            this.main_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // main_splitContainer.Panel1
            // 
            this.main_splitContainer.Panel1.Controls.Add(this.pict_panel);
            // 
            // main_splitContainer.Panel2
            // 
            this.main_splitContainer.Panel2.Controls.Add(this.control_panel);
            this.main_splitContainer.Size = new System.Drawing.Size(867, 400);
            this.main_splitContainer.SplitterDistance = 298;
            this.main_splitContainer.TabIndex = 0;
            // 
            // pict_panel
            // 
            this.pict_panel.Controls.Add(this.pictureBox);
            this.pict_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pict_panel.Location = new System.Drawing.Point(0, 0);
            this.pict_panel.Name = "pict_panel";
            this.pict_panel.Size = new System.Drawing.Size(867, 298);
            this.pict_panel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(867, 298);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // control_panel
            // 
            this.control_panel.Controls.Add(this.noise_numeric);
            this.control_panel.Controls.Add(this.label5);
            this.control_panel.Controls.Add(this.progressBar);
            this.control_panel.Controls.Add(this.depoint_bttn);
            this.control_panel.Controls.Add(this.Y_numeric);
            this.control_panel.Controls.Add(this.X_numeric);
            this.control_panel.Controls.Add(this.label4);
            this.control_panel.Controls.Add(this.digs_numeric);
            this.control_panel.Controls.Add(this.deep_numeric);
            this.control_panel.Controls.Add(this.digs_chkbx);
            this.control_panel.Controls.Add(this.noise_chkbx);
            this.control_panel.Controls.Add(this.label3);
            this.control_panel.Controls.Add(this.label2);
            this.control_panel.Controls.Add(this.label1);
            this.control_panel.Controls.Add(this.seed_label);
            this.control_panel.Controls.Add(this.seed_textbx);
            this.control_panel.Controls.Add(this.clear_bttn);
            this.control_panel.Controls.Add(this.start_bttn);
            this.control_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_panel.Location = new System.Drawing.Point(0, 0);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(867, 98);
            this.control_panel.TabIndex = 0;
            // 
            // noise_numeric
            // 
            this.noise_numeric.Location = new System.Drawing.Point(126, 61);
            this.noise_numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.noise_numeric.Name = "noise_numeric";
            this.noise_numeric.Size = new System.Drawing.Size(74, 20);
            this.noise_numeric.TabIndex = 17;
            this.noise_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.noise_numeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Count";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 88);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(867, 10);
            this.progressBar.TabIndex = 15;
            // 
            // depoint_bttn
            // 
            this.depoint_bttn.Location = new System.Drawing.Point(349, 45);
            this.depoint_bttn.Name = "depoint_bttn";
            this.depoint_bttn.Size = new System.Drawing.Size(75, 36);
            this.depoint_bttn.TabIndex = 14;
            this.depoint_bttn.Text = "Depoint";
            this.depoint_bttn.UseVisualStyleBackColor = true;
            this.depoint_bttn.Click += new System.EventHandler(this.depoint_bttn_Click);
            // 
            // Y_numeric
            // 
            this.Y_numeric.Location = new System.Drawing.Point(3, 62);
            this.Y_numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Y_numeric.Name = "Y_numeric";
            this.Y_numeric.Size = new System.Drawing.Size(64, 20);
            this.Y_numeric.TabIndex = 13;
            this.Y_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Y_numeric.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // X_numeric
            // 
            this.X_numeric.Location = new System.Drawing.Point(3, 18);
            this.X_numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.X_numeric.Name = "X_numeric";
            this.X_numeric.Size = new System.Drawing.Size(64, 20);
            this.X_numeric.TabIndex = 12;
            this.X_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.X_numeric.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Deep";
            // 
            // digs_numeric
            // 
            this.digs_numeric.Location = new System.Drawing.Point(126, 18);
            this.digs_numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.digs_numeric.Name = "digs_numeric";
            this.digs_numeric.Size = new System.Drawing.Size(72, 20);
            this.digs_numeric.TabIndex = 10;
            this.digs_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.digs_numeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // deep_numeric
            // 
            this.deep_numeric.Location = new System.Drawing.Point(206, 62);
            this.deep_numeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.deep_numeric.Name = "deep_numeric";
            this.deep_numeric.Size = new System.Drawing.Size(56, 20);
            this.deep_numeric.TabIndex = 10;
            this.deep_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.deep_numeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // digs_chkbx
            // 
            this.digs_chkbx.AutoSize = true;
            this.digs_chkbx.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.digs_chkbx.Checked = true;
            this.digs_chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digs_chkbx.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.digs_chkbx.Location = new System.Drawing.Point(70, 2);
            this.digs_chkbx.Name = "digs_chkbx";
            this.digs_chkbx.Size = new System.Drawing.Size(47, 31);
            this.digs_chkbx.TabIndex = 9;
            this.digs_chkbx.Text = "Diggers";
            this.digs_chkbx.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.digs_chkbx.UseVisualStyleBackColor = true;
            // 
            // noise_chkbx
            // 
            this.noise_chkbx.AutoSize = true;
            this.noise_chkbx.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.noise_chkbx.Checked = true;
            this.noise_chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noise_chkbx.Location = new System.Drawing.Point(73, 51);
            this.noise_chkbx.Name = "noise_chkbx";
            this.noise_chkbx.Size = new System.Drawing.Size(38, 31);
            this.noise_chkbx.TabIndex = 8;
            this.noise_chkbx.Text = "Noise";
            this.noise_chkbx.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.noise_chkbx.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // seed_label
            // 
            this.seed_label.AutoSize = true;
            this.seed_label.Location = new System.Drawing.Point(261, 1);
            this.seed_label.Name = "seed_label";
            this.seed_label.Size = new System.Drawing.Size(32, 13);
            this.seed_label.TabIndex = 1;
            this.seed_label.Text = "Seed";
            // 
            // seed_textbx
            // 
            this.seed_textbx.Location = new System.Drawing.Point(204, 19);
            this.seed_textbx.Name = "seed_textbx";
            this.seed_textbx.Size = new System.Drawing.Size(139, 20);
            this.seed_textbx.TabIndex = 1;
            this.seed_textbx.Text = "aNy teXt To sEEd";
            // 
            // clear_bttn
            // 
            this.clear_bttn.Location = new System.Drawing.Point(349, 3);
            this.clear_bttn.Name = "clear_bttn";
            this.clear_bttn.Size = new System.Drawing.Size(75, 39);
            this.clear_bttn.TabIndex = 0;
            this.clear_bttn.Text = "Clear";
            this.clear_bttn.UseVisualStyleBackColor = true;
            this.clear_bttn.Click += new System.EventHandler(this.clear_bttn_Click);
            // 
            // start_bttn
            // 
            this.start_bttn.Location = new System.Drawing.Point(268, 45);
            this.start_bttn.Name = "start_bttn";
            this.start_bttn.Size = new System.Drawing.Size(75, 37);
            this.start_bttn.TabIndex = 0;
            this.start_bttn.Text = "Start";
            this.start_bttn.UseVisualStyleBackColor = true;
            this.start_bttn.Click += new System.EventHandler(this.start_bttn_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 400);
            this.Controls.Add(this.main_splitContainer);
            this.Name = "Main_Form";
            this.Text = "Map Generator";
            this.main_splitContainer.Panel1.ResumeLayout(false);
            this.main_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).EndInit();
            this.main_splitContainer.ResumeLayout(false);
            this.pict_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.control_panel.ResumeLayout(false);
            this.control_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noise_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digs_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deep_numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer main_splitContainer;
        private System.Windows.Forms.Panel pict_panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Label seed_label;
        private System.Windows.Forms.TextBox seed_textbx;
        private System.Windows.Forms.Button start_bttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox digs_chkbx;
        private System.Windows.Forms.CheckBox noise_chkbx;
        private System.Windows.Forms.Button clear_bttn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown deep_numeric;
        private System.Windows.Forms.NumericUpDown digs_numeric;
        private System.Windows.Forms.NumericUpDown Y_numeric;
        private System.Windows.Forms.NumericUpDown X_numeric;
        private System.Windows.Forms.Button depoint_bttn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.NumericUpDown noise_numeric;
        private System.Windows.Forms.Label label5;
    }
}

