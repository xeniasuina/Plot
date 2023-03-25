using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Plot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //SetSize();
            //setpixel();


        }
        int pix_in_one_x = 1;
        Bitmap map = new Bitmap(100, 100);
        Graphics g;
        Koordinate Koord = new Koordinate(0, 0, 0, 0);
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            
            /*if (Math.Abs(Convert.ToDouble(maxx_dek.Text)) > Math.Abs(Convert.ToDouble(minx_dek.Text)))
            {
                pix_in_one_x = Convert.ToInt32(Convert.ToDouble(pic.Size.Width) / (2*Math.Abs(Convert.ToDouble(maxx_dek.Text))+ 1));
            }
            else
            {
                pix_in_one_x = Convert.ToInt32(Convert.ToDouble(pic.Size.Width) / (2 * Math.Abs(Convert.ToDouble(minx_dek.Text)) + 1));
            }*/
            //int pix_in_one_y = Convert.ToInt32(Convert.ToDouble(pic.Size.Height) / (Convert.ToDouble(maxy_dek.Text) - Convert.ToDouble(miny_dek.Text) + 1));
            ekr_y.Text = e.Y.ToString();
            dek_y.Text =Koord.Convert_To_Y_dek(e.Y,miny_dek.Text,maxy_dek.Text,pic).ToString();
            ekr_x.Text = e.X.ToString();
            dek_x.Text = Koord.Convert_To_X_dek(e.X, minx_dek.Text, maxx_dek.Text, pic).ToString();


            //map.SetPixel(e.X, e.Y, Color.Black);
            //setpixel();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { if (textBox1.Text != "")
            {
                double x_dek = Convert.ToDouble(textBox1.Text);
                string minx = minx_dek.Text;
                string maxx = maxx_dek.Text;
                int x_ekr = Koord.Convert_To_X_ekr(x_dek, minx, maxx, pic);
                label2.Text = x_ekr.ToString();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void xxx_Click(object sender, EventArgs e)
        {

        }
        /*private void setpixel()
{
int y_ekr;
double y_dek = 0;
int x_ekr = 0;
double x_dek = 0;
//for (int i=2;i<5;i++)
//{
//x_dek = i;
//x_ekr = Convert.ToInt32(pic.Size.Width / 2 + 20 * x_dek); 
//y_dek = x_dek - 2;
//y_ekr = Convert.ToInt32(pic.Size.Height / 2 + 20 * y_dek);
for (int i = 0; i < 100; i++)
{
map.SetPixel(50, i, Color.Black);
}

//}
}*/
        // Create a Bitmap object from a file.
        /*private void SetSize()
        {
            g = Graphics.FromImage(map);
            for (int x = 0; x < map.Width; x++)
            {
                for (int y = 0; y < map.Height; y++)
                {
                    map.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                }
            }*/
    }
}

    
