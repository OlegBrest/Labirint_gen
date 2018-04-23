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

        public digger (Bitmap bitmap, PictureBox pb)
        {
            Random random = new Random();
            this.Work_Bitmap = bitmap;
            this.pictureBox = pb;
            this.cur_x_pos = random.Next(bitmap.Width / 2)+ (bitmap.Width / 4);
            this.cur_y_pos = random.Next(bitmap.Height / 2) + (bitmap.Height / 4);
        }

        public void Screen_update(bool update = true)
        {
            Color clr = this.Work_Bitmap.GetPixel(cur_x_pos, cur_y_pos);
            int R = clr.R;
            int G = clr.G;
            int B = clr.B;
            int step = 20;
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
            this.Work_Bitmap.SetPixel(cur_x_pos, cur_y_pos,clr2);
            this.pictureBox.Image = this.Work_Bitmap;
            if(update)this.pictureBox.Update();
        }

        public Bitmap dig_it()
        {
            Random random = new Random();
            
            int width = this.Work_Bitmap.Width;
            int height = this.Work_Bitmap.Height;
            int shags = 0;
            
            
            while ((this.cur_x_pos > 0) && (this.cur_x_pos < width) &&
                (this.cur_y_pos > 0) && (this.cur_y_pos < height))
            {
                int napr = random.Next(4);
                if (napr == 0) this.cur_x_pos++;
                if (napr == 1) this.cur_y_pos++;
                if (napr == 2) this.cur_x_pos--;
                if (napr == 3) this.cur_y_pos--;
                if ((this.cur_x_pos > 0) && (this.cur_x_pos < width) &&
                (this.cur_y_pos > 0) && (this.cur_y_pos < height))
                {
                    int updating = shags % 10000;
                    Screen_update(updating == 0);
                    if (updating == 0) shags = 0;
                     shags++;
                }
            }
            for (int i = 0; i < (width * height / 4);i++)
            {
                this.cur_x_pos = random.Next(width);
                this.cur_y_pos = random.Next(height);
                int updating = shags % 10000;
                Screen_update(updating == 0);
                if (updating == 0) shags = 0;
                shags++;
            }
            return this.Work_Bitmap;
        }
    }
}
