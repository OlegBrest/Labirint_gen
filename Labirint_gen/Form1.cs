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
        private string old_seed = "";
        public Main_Form()
        {
            InitializeComponent();
        }

        private void start_bttn_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(this.X_txtbx.Text);
            int height = Convert.ToInt32(this.Y_txtbx.Text);
            int diggers = Convert.ToInt32(this.digs_txtbx.Text);
            string seed = this.seed_textbx.Text;
            if ((this.pictureBox.Image == null) || (width!=this.pictureBox.Image.Width) || (height != this.pictureBox.Image.Height)||(!old_seed.Equals(seed)))
            {
                main_scr = new Bitmap(width, height);
                Graphics gr = default(Graphics);
                gr = Graphics.FromImage(main_scr);
                Rectangle rect = new Rectangle(0, 0, width, height);
                gr.FillRectangle(Brushes.Green, rect);
                old_seed = seed;
            }
            else main_scr = (Bitmap)this.pictureBox.Image;
            
            this.pictureBox.Image = main_scr;
            digger dgr = new digger(main_scr, this.pictureBox, this.seed_textbx.Text);
            for (int i = 0; i < diggers; i++)
            {
                main_scr = dgr.dig_it();
            }
            this.pictureBox.Image = main_scr;
        }

    }
}
