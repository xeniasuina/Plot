using Plot.Enums;

namespace Plot
{
    public partial class Form1 : Form
    {
        private Graphics _graphics;
        private Painter _painter;

        public Form1()
        {
            InitializeComponent();
            _graphics = plot.CreateGraphics();
            _painter = new Painter(_graphics);

            InitializeUserComponents();
        }

        private void InitializeUserComponents()
        {
            object[] types = { CalculationType.LeftRectandgleMethod.GetString(), CalculationType.RightRectangleMethod.GetString(), CalculationType.CentralRectanleMethod.GetString(),
                CalculationType.TrapeziumMethod.GetString(), CalculationType.SimpsonMethod.GetString() };

            typeCombo.Items.AddRange(types);

            button2.Enabled = false;

            Converter.Size = plot.Size;
            Converter.XMin = Convert.ToDouble(xMinNUD.Value);
            Converter.XMax = Convert.ToDouble(xMaxNUD.Value);

            Converter.YMin = Convert.ToDouble(yMinNUD.Value);
            Converter.YMax = Convert.ToDouble(yMaxNUD.Value);

            _painter.Repaint();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Converter.Size = plot.Size;
            _painter.Repaint();
        }

        private void plot_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "XCrt: " + Math.Round(Converter.XScr2Crt(e.X), 2);
            toolStripStatusLabel2.Text = "YCrt: " + Math.Round(Converter.YScr2Crt(e.Y), 2);

            toolStripStatusLabel3.Text = "XScr: " + Converter.XCrt2Scr(Converter.XScr2Crt(e.X));
            toolStripStatusLabel4.Text = "YScr: " + Converter.YCrt2Scr(Converter.YScr2Crt(e.Y));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _painter.DrawFunction();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _painter.Repaint();
        }

        private void xMinNUD_ValueChanged(object sender, EventArgs e)
        {
            Converter.XMin = Convert.ToDouble(xMinNUD.Value);
            _painter.Repaint();
        }

        private void xMaxNUD_ValueChanged(object sender, EventArgs e)
        {
            Converter.XMax = Convert.ToDouble(xMaxNUD.Value);
            _painter.Repaint();
        }

        private void yMinNUD_ValueChanged(object sender, EventArgs e)
        {
            Converter.YMin = Convert.ToDouble(yMinNUD.Value);
            _painter.Repaint();
        }

        private void yMaxNUD_ValueChanged(object sender, EventArgs e)
        {
            Converter.YMax = Convert.ToDouble(yMaxNUD.Value);
            _painter.Repaint();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _painter.Repaint();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = funcTextBox.Text;

            if (string.IsNullOrEmpty(input))
            {
                return;
            }

            if (Function.GetFunction(input))
            {
                polkTextBox.Text = Function.FuncRPN;
                _painter.Function = Function.FuncValue;
                _painter.Repaint();

                IntegralCalculation.Function = Function.FuncValue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (typeCombo.SelectedIndex == -1)
            {
                return;
            }

            if (string.IsNullOrEmpty(aBox.Text) || string.IsNullOrEmpty(bBox.Text) || string.IsNullOrEmpty(nBox.Text))
            {
                return;
            }    

            var a = Convert.ToDouble(aBox.Text);
            var b = Convert.ToDouble(bBox.Text);
            var n = Convert.ToInt32(nBox.Text);

            _painter.DrawArea(a, b);

            var selected = typeCombo.SelectedItem.ToString();
            var result = 0.0;
            switch (selected) 
            {
                case "Метод левых прямоугольников":
                    result = IntegralCalculation.LeftRectangle(a, b, n);
                    break;
                case "Метод правых прямоугольников":
                    result = IntegralCalculation.RightRectangle(a, b, n);
                    break;
                case "Метод центральных прямоугольников":
                    result = IntegralCalculation.CentralRectangle(a, b, n);
                    break;
                case "Метод трапеций":
                    result = IntegralCalculation.TrapeziumMethod(a, b, n);
                    break;
                case "Метод Симпсона":
                    result = IntegralCalculation.SimpsonMethod(a, b, n);
                    break;
            }

            integralResultBox.Text = Math.Round(result, 5).ToString();
        }

        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeCombo.SelectedIndex == -1)
            {
                return;
            }

            button2.Enabled = true;
        }
    }
}

    
