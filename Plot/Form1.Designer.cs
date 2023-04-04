namespace Plot
{
    using System.Windows.Forms.DataVisualization;

    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.xxx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.integralResultBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.polkTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.funcTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plot = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xMinNUD = new System.Windows.Forms.NumericUpDown();
            this.xMaxNUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.yMaxNUD = new System.Windows.Forms.NumericUpDown();
            this.yMinNUD = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xMinNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMinNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // xxx
            // 
            this.xxx.AutoSize = true;
            this.xxx.Location = new System.Drawing.Point(11, 9);
            this.xxx.Name = "xxx";
            this.xxx.Size = new System.Drawing.Size(104, 15);
            this.xxx.TabIndex = 11;
            this.xxx.Text = "Диапазон x(в дек)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Диапазон у(в дек)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 735);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1439, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.nBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.integralResultBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.typeCombo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.aBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.polkTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.funcTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1211, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 662);
            this.panel1.TabIndex = 18;
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(52, 294);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(100, 23);
            this.nBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Кол-во отрезков";
            // 
            // integralResultBox
            // 
            this.integralResultBox.Location = new System.Drawing.Point(57, 423);
            this.integralResultBox.Name = "integralResultBox";
            this.integralResultBox.PlaceholderText = "Результат";
            this.integralResultBox.Size = new System.Drawing.Size(100, 23);
            this.integralResultBox.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Вычислить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(11, 348);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(194, 23);
            this.typeCombo.TabIndex = 10;
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.typeCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Выберите метод вычисления";
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(79, 243);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(100, 23);
            this.bBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Введите b:";
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(79, 214);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(100, 23);
            this.aBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вычислить интеграл";
            // 
            // polkTextBox
            // 
            this.polkTextBox.Location = new System.Drawing.Point(3, 104);
            this.polkTextBox.Name = "polkTextBox";
            this.polkTextBox.ReadOnly = true;
            this.polkTextBox.Size = new System.Drawing.Size(202, 23);
            this.polkTextBox.TabIndex = 3;
            this.polkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Конвертировать в польскую запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // funcTextBox
            // 
            this.funcTextBox.Location = new System.Drawing.Point(3, 28);
            this.funcTextBox.Name = "funcTextBox";
            this.funcTextBox.Size = new System.Drawing.Size(202, 23);
            this.funcTextBox.TabIndex = 1;
            this.funcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите функцию";
            // 
            // plot
            // 
            this.plot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plot.Location = new System.Drawing.Point(4, 4);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(1204, 662);
            this.plot.TabIndex = 19;
            this.plot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plot_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.plot);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(8, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1426, 675);
            this.panel2.TabIndex = 20;
            // 
            // xMinNUD
            // 
            this.xMinNUD.Location = new System.Drawing.Point(12, 28);
            this.xMinNUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xMinNUD.Name = "xMinNUD";
            this.xMinNUD.Size = new System.Drawing.Size(39, 23);
            this.xMinNUD.TabIndex = 21;
            this.xMinNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.xMinNUD.ValueChanged += new System.EventHandler(this.xMinNUD_ValueChanged);
            // 
            // xMaxNUD
            // 
            this.xMaxNUD.Location = new System.Drawing.Point(74, 28);
            this.xMaxNUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xMaxNUD.Name = "xMaxNUD";
            this.xMaxNUD.Size = new System.Drawing.Size(41, 23);
            this.xMaxNUD.TabIndex = 22;
            this.xMaxNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.xMaxNUD.ValueChanged += new System.EventHandler(this.xMaxNUD_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "-";
            // 
            // yMaxNUD
            // 
            this.yMaxNUD.Location = new System.Drawing.Point(228, 28);
            this.yMaxNUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.yMaxNUD.Name = "yMaxNUD";
            this.yMaxNUD.Size = new System.Drawing.Size(41, 23);
            this.yMaxNUD.TabIndex = 25;
            this.yMaxNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.yMaxNUD.ValueChanged += new System.EventHandler(this.yMaxNUD_ValueChanged);
            // 
            // yMinNUD
            // 
            this.yMinNUD.Location = new System.Drawing.Point(166, 28);
            this.yMinNUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.yMinNUD.Name = "yMinNUD";
            this.yMinNUD.Size = new System.Drawing.Size(39, 23);
            this.yMinNUD.TabIndex = 24;
            this.yMinNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.yMinNUD.ValueChanged += new System.EventHandler(this.yMinNUD_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 757);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yMaxNUD);
            this.Controls.Add(this.yMinNUD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.xMaxNUD);
            this.Controls.Add(this.xMinNUD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xxx);
            this.MaximumSize = new System.Drawing.Size(1455, 796);
            this.MinimumSize = new System.Drawing.Size(1455, 796);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xMinNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMinNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label xxx;
        private Label label4;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel toolStripStatusLabel2;
        public ToolStripStatusLabel toolStripStatusLabel1;
        private Panel panel1;
        private TextBox integralResultBox;
        private Button button2;
        private ComboBox typeCombo;
        private Label label6;
        private TextBox bBox;
        private Label label5;
        private TextBox aBox;
        private Label label3;
        private Label label2;
        private TextBox polkTextBox;
        private Button button1;
        private TextBox funcTextBox;
        private Label label1;
        private Panel plot;
        private Panel panel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private NumericUpDown xMinNUD;
        private NumericUpDown xMaxNUD;
        private Label label7;
        private Label label8;
        private NumericUpDown yMaxNUD;
        private NumericUpDown yMinNUD;
        private TextBox nBox;
        private Label label9;
    }
}

