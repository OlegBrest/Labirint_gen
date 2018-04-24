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
        string[] seed;
        Random[] random;

        // constructor
        public digger(Bitmap bitmap, PictureBox pb, string sd)
        {
            seeding(sd);
            this.random = new Random[1];
            this.random[0] = new Random();
            if (seed.Length > 0)
            {
                this.random = new Random[seed.Length];
                for (int i = 0; i < seed.Length; i++)
                {
                   this.random[i] = new Random(StrToInt(seed[i]));
                }
            }
            this.Work_Bitmap = bitmap;
            this.pictureBox = pb;
            
        }

        //refreshing screen
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
            this.Work_Bitmap.SetPixel(cur_x_pos, cur_y_pos, clr2);
            this.pictureBox.Image = this.Work_Bitmap;
            if (update) this.pictureBox.Update();
        }

        //start digger for tonelling
        public Bitmap dig_it()
        {
            /* Random [] random = new Random[seed.Length];
             for (int i = 0; i <seed.Length;i++)
             {
                 random[i] = new Random(StrToInt(seed[i]));
             }*/
            

            int width = this.Work_Bitmap.Width;
            int height = this.Work_Bitmap.Height;
            this.cur_x_pos = NextInt(width / 2, this.random) + (width / 4);
            this.cur_y_pos = NextInt(height / 2, this.random) + (height / 4);
            int shags = 0;


            while ((this.cur_x_pos > 0) && (this.cur_x_pos < width) &&
                (this.cur_y_pos > 0) && (this.cur_y_pos < height))
            {
                int napr = NextInt(4, this.random);
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
            for (int i = 0; i < (width * height / 4); i++)
            {
                this.cur_x_pos = NextInt(width, this.random);
                this.cur_y_pos = NextInt(height, this.random);
                int updating = shags % 10000;
                Screen_update(updating == 0);
                if (updating == 0) shags = 0;
                shags++;
            }
            return this.Work_Bitmap;
        }

        //fill array by seed
        public void seeding(string sd)
        {
            int array_lenght = (int)Math.Round(0.4999999 + ((double)sd.Length / 4.0), 0);
            this.seed = new string[array_lenght];
            int curr_arr = 0;
            for (int i = 0; i < sd.Length; i += 4)
            {
                this.seed[curr_arr] = sd.Substring(i, (sd.Length - i) >= 4 ? 4 : sd.Length - i);
                curr_arr++;
            }
        }

        // convert string value to integer
        public int StrToInt(string str)
        {
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                result += (int) (((char)str[i]) * Math.Pow(2, i));
            }
            return result;
        }

        // getting array randoms middle
        public int NextInt(int max_value, Random[] array, int center_x = 0, int center_y = 0)
        {
            int lenght = array.Length;
            int [] result = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                result [i] = array[i].Next(max_value);
            }
            return result[this.random[0].Next(lenght)];
        }
    }
}
