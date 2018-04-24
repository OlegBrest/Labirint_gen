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
            for (int d = 1; d < 5; d++)
            {
                pb.Maximum = (width - 2*d) * (height - 2*d);
                int cor_count = 0;
                for (int x = d; x < (width - d); x++)
                {
                    for (int y = d; y < (height - d); y++)
                    {
                        if (this.PointCorrect(x, y, d,d)) cor_count++;
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
                this.pictureBox.Image = this.Work_Bitmap;
                this.pictureBox.Update();
            }
            return this.Work_Bitmap;
        }

        private bool PointCorrect(int px, int py, int start_end,int  cnt)
        {
            Color etalon = this.Work_Bitmap.GetPixel(px - start_end, py - start_end);
            Color etalon2 = this.Work_Bitmap.GetPixel(px + start_end, py + start_end);
            Color central = this.Work_Bitmap.GetPixel(px, py);
            bool need_to_correct = true;
            if ((etalon != central) || (etalon2 != central))
            {
                int count = 0;
                for (int x = -start_end; x <= start_end; x++)
                {
                    for (int y = -start_end; y <= start_end; y++)
                    {
                        if (x != y)
                        {
                            Color cur_color = this.Work_Bitmap.GetPixel(px + x, py + y);
                            if (cur_color != etalon) count++;
                        }
                        if (count > (cnt))
                        {
                            need_to_correct = false;
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
