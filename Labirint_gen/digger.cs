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
            this.Work_Bitmap = bitmap;
            this.pictureBox = pb;
            this.cur_x_pos = bitmap.Width / 2;
            this.cur_y_pos = bitmap.Height / 2;
        }

        public void Screen_update(bool update = true)
        {
            this.Work_Bitmap.SetPixel(cur_x_pos, cur_y_pos, Color.Black);
            this.pictureBox.Image = this.Work_Bitmap;
            if(update)this.pictureBox.Update();
        }

        public Bitmap dig_it()
        {
            Random random = new Random();
            int shags = 0;
            while ((this.cur_x_pos > 0) && (this.cur_x_pos < this.Work_Bitmap.Width) &&
                (this.cur_y_pos > 0) && (this.cur_y_pos < this.Work_Bitmap.Height))
            {
                int napr = random.Next(4);
                if (napr == 0) this.cur_x_pos++;
                if (napr == 1) this.cur_y_pos++;
                if (napr == 2) this.cur_x_pos--;
                if (napr == 3) this.cur_y_pos--;
                if ((this.cur_x_pos > 0) && (this.cur_x_pos < this.Work_Bitmap.Width) &&
                (this.cur_y_pos > 0) && (this.cur_y_pos < this.Work_Bitmap.Height))
                {
                    int updating = shags % 100;
                    Screen_update(updating == 0);
                    if (updating == 0) shags = 0;
                     shags++;
                    
                }
            }
            return this.Work_Bitmap;
        }
        
    }
}
