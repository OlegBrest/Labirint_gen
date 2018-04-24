using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint_gen
{
    public partial class Main_Form : Form
    {
        public Bitmap main_scr;
        public Main_Form()
        {
            InitializeComponent();
        }

        private void start_bttn_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(this.X_numeric.Value);
            int height = Convert.ToInt32(this.Y_numeric.Value);
            int diggers = Convert.ToInt32(this.digs_numeric.Value);
            if ((this.pictureBox.Image == null) || (width != this.pictureBox.Image.Width) || (height != this.pictureBox.Image.Height))
            {
                main_scr = new Bitmap(width, height);
                Graphics gr = default(Graphics);
                gr = Graphics.FromImage(main_scr);
                Rectangle rect = new Rectangle(0, 0, width, height);
                gr.FillRectangle(Brushes.Green, rect);
            }
            else main_scr = (Bitmap)this.pictureBox.Image;

            this.pictureBox.Image = main_scr;
            digger dgr = new digger(main_scr, this.pictureBox, this.seed_textbx.Text);
            for (int i = 0; i < diggers; i++)
            {
                main_scr = dgr.dig_it(this.noise_chkbx.Checked, this.digs_chkbx.Checked, (int)this.deep_numeric.Value, (int)this.noise_numeric.Value, this.progressBar);
            }
            this.pictureBox.Image = main_scr;
        }

        private void clear_bttn_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(this.X_numeric.Value);
            int height = Convert.ToInt32(this.Y_numeric.Value);
            main_scr = new Bitmap(width, height);
            Graphics gr = default(Graphics);
            gr = Graphics.FromImage(main_scr);
            Rectangle rect = new Rectangle(0, 0, width, height);
            gr.FillRectangle(Brushes.Green, rect);
            this.pictureBox.Image = main_scr;
        }

        private void depoint_bttn_Click(object sender, EventArgs e)
        {
            Depointer dnr = new Depointer(main_scr, this.pictureBox);
            main_scr = dnr.PointsRemove(this.progressBar);
            this.pictureBox.Image = main_scr;
            this.pictureBox.Update();
        }
    }
}
