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

        
        private void chart1_Click(object sender, EventArgs e)
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
    }
}
