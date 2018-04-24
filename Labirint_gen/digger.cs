using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint_gen
{
    class digger
    {
        Bitmap Work_Bitmap;
        int cur_x_pos = 0;
        int cur_y_pos = 0;
        PictureBox pictureBox;
        Randomizer random;

        // constructor
        public digger(Bitmap bitmap, PictureBox pb, string sd)
        {
            this.random = new Randomizer(sd);

            this.Work_Bitmap = bitmap;
            this.pictureBox = pb;
            this.pictureBox.Image = this.Work_Bitmap;
        }

        //refreshing screen
        public void Screen_update(int stp,bool update = true)
        {
            Color clr = this.Work_Bitmap.GetPixel(cur_x_pos, cur_y_pos);
            int R = clr.R;
            int G = clr.G;
            int B = clr.B;
            int step = stp;
            if (B < G) R += step;
            if (R > G)
            {
                R = G;
                R -= step;
                G -= step;
                B += step;
                if (R < 0) R = 0;
                if (G < 0) G = 0;
            }
            if (B >= G) B += step;
            Color clr2 = Color.FromArgb(255, R, G, (B > 255 ? 255 : B));
            this.Work_Bitmap.SetPixel(cur_x_pos, cur_y_pos, clr2);
            if (update)
            {
                this.pictureBox.Image = this.Work_Bitmap;
                this.pictureBox.Update();
            }
        }

        //start digger for tonelling
        public Bitmap dig_it(bool noise, bool digger, int deep,int noise_count,ProgressBar pb)
        {
            int width = this.Work_Bitmap.Width;
            int height = this.Work_Bitmap.Height;
            this.cur_x_pos = this.random.NextInt(width*3/4) + (width / 4);
            this.cur_y_pos = this.random.NextInt(height*3/4) + (height / 4);
            int shags = 0;
            pb.Minimum = 0;
            pb.Value = 0;
            if (digger)
            {
                
                while ((this.cur_x_pos > 0) && (this.cur_x_pos < width) &&
                    (this.cur_y_pos > 0) && (this.cur_y_pos < height))
                {
                    int napr = this.random.NextInt(4);
                    if (napr == 0) this.cur_x_pos++;
                    if (napr == 1) this.cur_y_pos++;
                    if (napr == 2) this.cur_x_pos--;
                    if (napr == 3) this.cur_y_pos--;
                    if ((this.cur_x_pos > 0) && (this.cur_x_pos < width) &&
                    (this.cur_y_pos > 0) && (this.cur_y_pos < height))
                    {
                        int updating = shags % 10000;
                        Screen_update(deep,updating == 0);
                        if (updating == 0) shags = 0;
                        shags++;
                    }
                }
            }
            if (noise)
            {
                pb.Maximum = noise_count;
                for (int i = 0; i < noise_count; i++)
                {
                    this.cur_x_pos = this.random.NextInt(width);
                    this.cur_y_pos = this.random.NextInt(height);
                    int updating = shags % 10000;
                    Screen_update(deep,updating == 0);
                    if (updating == 0) shags = 0;
                    shags++;
                    pb.Value = i;
                }
            }
            pb.Value = 0;
            return this.Work_Bitmap;
        }
    }
}
