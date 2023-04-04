using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plot
{
    internal static class Koordinate
    {
       public static int Convert_To_X_ekr(double x_dek,string minx_dek,string maxx_dek,PictureBox pic)
        {
            int pix_in_one_x;
            if (Math.Abs(Convert.ToDouble(maxx_dek)) > Math.Abs(Convert.ToDouble(minx_dek)))
            {
                pix_in_one_x = Convert.ToInt32(Convert.ToDouble(pic.Size.Width) / (2 * Math.Abs(Convert.ToDouble(maxx_dek) )));
            }
            else
            {
                pix_in_one_x = Convert.ToInt32(Convert.ToDouble(pic.Size.Width) / (2 * Math.Abs(Convert.ToDouble(minx_dek) )));
            }
            int x_ekr = Convert.ToInt32(x_dek * pix_in_one_x + pic.Size.Width / 2);
            return x_ekr;
        }

        public static int Convert_To_Y_ekr(double y_dek, string miny_dek, string maxy_dek, PictureBox pic)
        {
            int pix_in_one_y;
            if (Math.Abs(Convert.ToDouble(maxy_dek)) > Math.Abs(Convert.ToDouble(miny_dek)))
            {
                pix_in_one_y = Convert.ToInt32(Convert.ToDouble(pic.Size.Height) / (2 * Math.Abs(Convert.ToDouble(maxy_dek)) ));
            }
            else
            {
                pix_in_one_y = Convert.ToInt32(Convert.ToDouble(pic.Size.Height) / (2 * Math.Abs(Convert.ToDouble(miny_dek))));
            }
            int y_ekr = Convert.ToInt32(-y_dek * pix_in_one_y + pic.Size.Height / 2);
            return y_ekr;
        }

        public static double Convert_To_X_dek(int x_ekr, string minx_dek, string maxx_dek, PictureBox pic)
        {
            int pix_in_one_x;
            if (Math.Abs(Convert.ToDouble(maxx_dek)) > Math.Abs(Convert.ToDouble(minx_dek)))
            {
                double i = Convert.ToDouble(maxx_dek);
                pix_in_one_x = Convert.ToInt32(Convert.ToDouble(pic.Size.Width) / (2 * Math.Abs(i)));
            }
            else
            {
                double j = Convert.ToDouble(minx_dek);
                pix_in_one_x = Convert.ToInt32(Convert.ToDouble(pic.Size.Width) / (2 * Math.Abs(j)));
            }
            double x_dek = (x_ekr - (Convert.ToDouble(pic.Size.Width) / 2)) / pix_in_one_x;
            return x_dek;
        }

        public static double Convert_To_Y_dek(int y_ekr, string miny_dek, string maxy_dek, PictureBox pic)
        {
            int pix_in_one_y;
            if (Math.Abs(Convert.ToDouble(maxy_dek)) > Math.Abs(Convert.ToDouble(miny_dek)))
            {
                pix_in_one_y = Convert.ToInt32(Convert.ToDouble(pic.Size.Height) / (2 * Math.Abs(Convert.ToDouble(maxy_dek))));
            }
            else
            {
                pix_in_one_y = Convert.ToInt32(Convert.ToDouble(pic.Size.Height) / (2 * Math.Abs(Convert.ToDouble(miny_dek))));
            }
            double y_dek = (Convert.ToDouble(pic.Size.Height) / 2 - y_ekr) / pix_in_one_y;
            return y_dek;
        }

    }
}
