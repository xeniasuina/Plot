namespace Функция
{
    public partial class FuncForm : Form
    {
        public FuncForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Function.GetFunction(this.textBox1.Text))
            {
                this.label1.Text = Function.FuncRPN;
                this.label2.Text = "";
                for (int i = -5; i < 5; i ++) this.label2.Text += Function.FuncValue(i).ToString() + ";;;    ";
                this.label2.Text += Function.FuncValue(5).ToString();
                return;
            }
            else new Error().ShowDialog();
        }
    }
}