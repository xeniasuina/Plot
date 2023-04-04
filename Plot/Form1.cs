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
       
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            
            
            ekr_y.Text = e.Y.ToString();
            dek_y.Text =Koordinate.Convert_To_Y_dek(e.Y,miny_dek.Text,maxy_dek.Text,pic).ToString();
            ekr_x.Text = e.X.ToString();
            dek_x.Text = Koordinate.Convert_To_X_dek(e.X, minx_dek.Text, maxx_dek.Text, pic).ToString();

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
        {
            if (textBox1.Text != "" & textBox1.Text != "-")
            {
                double x_dek = Convert.ToDouble(textBox1.Text);
                string minx = minx_dek.Text;
                string maxx = maxx_dek.Text;
                int x_ekr = Koordinate.Convert_To_X_ekr(x_dek, minx, maxx, pic);
                rrr.Text = x_ekr.ToString();
            }
        }
    }
}

    
