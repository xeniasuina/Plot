namespace Plot
{
    public static class Converter
    {
        public static double XMin { get; set; }
                      
        public static double XMax { get; set; }
                      
        public static double YMin { get; set; }  
                      
        public static double YMax { get; set; }

        public static double XDen => Width / (XMax - XMin);

        public static double YDen => Height / (YMax - YMin);
 
        public static Size Size { get; set; }

        public static int Width => Size.Width - 1;

        public static int Height => Size.Height - 1;

        public static int XCrt2Scr(double x)
        {
            var result = (int)(XDen * (x - XMin));
            if (result < -Width) result = -Width;
            if (result > 2 * Width) result = 2 * Width;

            return result;
        }

        public static double XScr2Crt(int x)
        {
            var tempX = x;
            if (tempX < -Width) tempX = -Width;
            if (tempX > 2 * Width) tempX = 2 * Width;

            return tempX / XDen + XMin;
        }

        public static int YCrt2Scr(double y)
        {
            var result = (int)(YDen * (YMax - y));
            if (result < -Height) result = -Height;
            if (result > 2 * Height) result = 2 * Height;

            return result;
        }

        public static double YScr2Crt(int y)
        {
            var tmpY = y;
            if (tmpY < -Height) tmpY = -Height;
            if (tmpY > 2 * Height) tmpY = 2 * Height;

            return YMax - tmpY / YDen;
        }

        public static int XDecToScr(double x_dek,string minx_dek,string maxx_dek, Size picSize)
        {
            int pix_in_one_x;
            if (Math.Abs(Convert.ToDouble(maxx_dek)) > Math.Abs(Convert.ToDouble(minx_dek)))
            {
                pix_in_one_x = Convert.ToInt32(Convert.ToDouble(picSize.Width) / (2 * Math.Abs(Convert.ToDouble(maxx_dek) )));
            }
            else
            {
                pix_in_one_x = Convert.ToInt32(Convert.ToDouble(picSize.Width) / (2 * Math.Abs(Convert.ToDouble(minx_dek) )));
            }
            int x_ekr = Convert.ToInt32(x_dek * pix_in_one_x + picSize.Width / 2);

            return x_ekr;
        }

        public static int YDecToScr(double y_dek, string miny_dek, string maxy_dek, Size picSize)
        {
            int pix_in_one_y;
            if (Math.Abs(Convert.ToDouble(maxy_dek)) > Math.Abs(Convert.ToDouble(miny_dek)))
            {
                pix_in_one_y = Convert.ToInt32(Convert.ToDouble(picSize.Height) / (2 * Math.Abs(Convert.ToDouble(maxy_dek)) ));
            }
            else
            {
                pix_in_one_y = Convert.ToInt32(Convert.ToDouble(picSize.Height) / (2 * Math.Abs(Convert.ToDouble(miny_dek))));
            }
            int y_ekr = Convert.ToInt32(-y_dek * pix_in_one_y + picSize.Height / 2);
            return y_ekr;
        }

        public static double XScrToDec(int x_ekr, string minx_dek, string maxx_dek, Size picSize)
        {
            int pix_in_one_x;
            if (Math.Abs(Convert.ToDouble(maxx_dek)) > Math.Abs(Convert.ToDouble(minx_dek)))
            {
                double i = Convert.ToDouble(maxx_dek);
                pix_in_one_x = Convert.ToInt32(Convert.ToDouble(picSize.Width) / (2 * Math.Abs(i)));
            }
            else
            {
                double j = Convert.ToDouble(minx_dek);
                pix_in_one_x = Convert.ToInt32(Convert.ToDouble(picSize.Width) / (2 * Math.Abs(j)));
            }
            double x_dek = (x_ekr - (Convert.ToDouble(picSize.Width) / 2)) / pix_in_one_x;
            return x_dek;
        }

        public static double YScrToDec(int y_ekr, string miny_dek, string maxy_dek, Size picSize)
        {
            int pix_in_one_y;
            if (Math.Abs(Convert.ToDouble(maxy_dek)) > Math.Abs(Convert.ToDouble(miny_dek)))
            {
                pix_in_one_y = Convert.ToInt32(Convert.ToDouble(picSize.Height) / (2 * Math.Abs(Convert.ToDouble(maxy_dek))));
            }
            else
            {
                pix_in_one_y = Convert.ToInt32(Convert.ToDouble(picSize.Height) / (2 * Math.Abs(Convert.ToDouble(miny_dek))));
            }
            double y_dek = (Convert.ToDouble(picSize.Height) / 2 - y_ekr) / pix_in_one_y;
            return y_dek;
        }

    }
}
