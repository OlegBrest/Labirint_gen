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
            this.control_panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.start_bttn = new System.Windows.Forms.Button();
            this.seed_textbx = new System.Windows.Forms.TextBox();
            this.seed_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.X_txtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Y_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.digs_txtbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).BeginInit();
            this.main_splitContainer.Panel1.SuspendLayout();
            this.main_splitContainer.Panel2.SuspendLayout();
            this.main_splitContainer.SuspendLayout();
            this.pict_panel.SuspendLayout();
            this.control_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.main_splitContainer.Size = new System.Drawing.Size(800, 362);
            this.main_splitContainer.SplitterDistance = 312;
            this.main_splitContainer.TabIndex = 0;
            // 
            // pict_panel
            // 
            this.pict_panel.Controls.Add(this.pictureBox);
            this.pict_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pict_panel.Location = new System.Drawing.Point(0, 0);
            this.pict_panel.Name = "pict_panel";
            this.pict_panel.Size = new System.Drawing.Size(800, 312);
            this.pict_panel.TabIndex = 0;
            // 
            // control_panel
            // 
            this.control_panel.Controls.Add(this.label3);
            this.control_panel.Controls.Add(this.digs_txtbx);
            this.control_panel.Controls.Add(this.label2);
            this.control_panel.Controls.Add(this.Y_txtbx);
            this.control_panel.Controls.Add(this.label1);
            this.control_panel.Controls.Add(this.X_txtbx);
            this.control_panel.Controls.Add(this.seed_label);
            this.control_panel.Controls.Add(this.seed_textbx);
            this.control_panel.Controls.Add(this.start_bttn);
            this.control_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_panel.Location = new System.Drawing.Point(0, 0);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(800, 46);
            this.control_panel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 312);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // start_bttn
            // 
            this.start_bttn.Location = new System.Drawing.Point(323, 14);
            this.start_bttn.Name = "start_bttn";
            this.start_bttn.Size = new System.Drawing.Size(75, 23);
            this.start_bttn.TabIndex = 0;
            this.start_bttn.Text = "Start";
            this.start_bttn.UseVisualStyleBackColor = true;
            this.start_bttn.Click += new System.EventHandler(this.start_bttn_Click);
            // 
            // seed_textbx
            // 
            this.seed_textbx.Location = new System.Drawing.Point(132, 17);
            this.seed_textbx.Name = "seed_textbx";
            this.seed_textbx.Size = new System.Drawing.Size(176, 20);
            this.seed_textbx.TabIndex = 1;
            // 
            // seed_label
            // 
            this.seed_label.AutoSize = true;
            this.seed_label.Location = new System.Drawing.Point(129, 1);
            this.seed_label.Name = "seed_label";
            this.seed_label.Size = new System.Drawing.Size(32, 13);
            this.seed_label.TabIndex = 1;
            this.seed_label.Text = "Seed";
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
            // X_txtbx
            // 
            this.X_txtbx.Location = new System.Drawing.Point(6, 17);
            this.X_txtbx.Name = "X_txtbx";
            this.X_txtbx.Size = new System.Drawing.Size(34, 20);
            this.X_txtbx.TabIndex = 3;
            this.X_txtbx.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // Y_txtbx
            // 
            this.Y_txtbx.Location = new System.Drawing.Point(50, 17);
            this.Y_txtbx.Name = "Y_txtbx";
            this.Y_txtbx.Size = new System.Drawing.Size(34, 20);
            this.Y_txtbx.TabIndex = 5;
            this.Y_txtbx.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Digs.";
            // 
            // digs_txtbx
            // 
            this.digs_txtbx.Location = new System.Drawing.Point(90, 17);
            this.digs_txtbx.Name = "digs_txtbx";
            this.digs_txtbx.Size = new System.Drawing.Size(34, 20);
            this.digs_txtbx.TabIndex = 7;
            this.digs_txtbx.Text = "20";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.main_splitContainer);
            this.Name = "Main_Form";
            this.Text = "Map Generator";
            this.main_splitContainer.Panel1.ResumeLayout(false);
            this.main_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_splitContainer)).EndInit();
            this.main_splitContainer.ResumeLayout(false);
            this.pict_panel.ResumeLayout(false);
            this.control_panel.ResumeLayout(false);
            this.control_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.TextBox Y_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox X_txtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox digs_txtbx;
    }
}

