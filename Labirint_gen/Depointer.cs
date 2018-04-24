using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint_gen
{
    class Depointer
    {
        PictureBox pictureBox;
        Bitmap Work_Bitmap;

        public Depointer(Bitmap bitmap, PictureBox pb)
        {
            this.pictureBox = pb;
            this.Work_Bitmap = bitmap;
        }

        public Bitmap PointsRemove(ProgressBar pb)
        {
            int height = this.Work_Bitmap.Height;
            int width = this.Work_Bitmap.Width;
            pb.Minimum = 0;
            pb.Maximum = (width - 2) * (height - 2);
            int cor_count = 0;
            for (int x = 1; x < (width - 1); x++)
            {
                for (int y = 1; y < (height - 1); y++)
                {
                    if (this.PointCorrect(x, y)) cor_count++;
                    pb.Value++;
                    if (cor_count > (pb.Maximum / 10))
                    {
                        this.pictureBox.Image = this.Work_Bitmap;
                        this.pictureBox.Update();
                        cor_count = 0;
                    }
                }
            }
            pb.Value = 0;
            return this.Work_Bitmap;
        }

        private bool PointCorrect(int px, int py)
        {
            Color etalon = this.Work_Bitmap.GetPixel(px - 1, py - 1);
            Color central = this.Work_Bitmap.GetPixel(px, py);
            bool need_to_correct = true;
            if (etalon != central)
            {
                for (int x = -1; x <= 1; x++)
                {
                    for (int y = -1; y <= 1; y++)
                    {
                        if (x != y)
                        {
                            Color cur_color = this.Work_Bitmap.GetPixel(px + x, py + y);
                            if (cur_color != etalon) need_to_correct = false;
                        }
                    }
                }
                if (need_to_correct)
                {
                    this.Work_Bitmap.SetPixel(px, py, etalon);
                    this.pictureBox.Image = this.Work_Bitmap;
                }
            }
            return need_to_correct;
        }
    }
}
