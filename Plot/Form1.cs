namespace Plot
{
    public partial class Form1 : Form
    {
        double x1 = -10;
        double x2 = 10;
        double h = 0.1;
        double func(double x)
        {
            return Math.Pow(x,2);
        }
        public Form1()
        {
            InitializeComponent();
            


        }
        int pix_in_one_x = 1;
        Bitmap map = new Bitmap(100, 100);
        Graphics g;
        Koordinate Koord = new Koordinate(0, 0, 0, 0,1,1);
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for (double x = x1; x<= x2; x+=h) 
            {
                double y = func(x);
                chart1.Series[0].Points.AddXY(x, y);
            }
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
        
    }
}

    
