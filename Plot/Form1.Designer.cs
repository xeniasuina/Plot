namespace Plot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dek_y = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ekr_y = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.dek_x = new System.Windows.Forms.Label();
            this.ekr_x = new System.Windows.Forms.Label();
            this.xxx = new System.Windows.Forms.Label();
            this.minx_dek = new System.Windows.Forms.TextBox();
            this.maxx_dek = new System.Windows.Forms.TextBox();
            this.miny_dek = new System.Windows.Forms.TextBox();
            this.shag = new System.Windows.Forms.TextBox();
            this.maxy_dek = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Декартовы координаты";
            // 
            // dek_y
            // 
            this.dek_y.AutoSize = true;
            this.dek_y.Location = new System.Drawing.Point(42, 65);
            this.dek_y.Name = "dek_y";
            this.dek_y.Size = new System.Drawing.Size(44, 20);
            this.dek_y.TabIndex = 1;
            this.dek_y.Text = "dek y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "экранные координаты";
            // 
            // ekr_y
            // 
            this.ekr_y.AutoSize = true;
            this.ekr_y.Location = new System.Drawing.Point(244, 65);
            this.ekr_y.Name = "ekr_y";
            this.ekr_y.Size = new System.Drawing.Size(40, 20);
            this.ekr_y.TabIndex = 3;
            this.ekr_y.Text = "ekr y";
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic.Location = new System.Drawing.Point(5, 110);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(794, 339);
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            // 
            // dek_x
            // 
            this.dek_x.AutoSize = true;
            this.dek_x.Location = new System.Drawing.Point(42, 34);
            this.dek_x.Name = "dek_x";
            this.dek_x.Size = new System.Drawing.Size(44, 20);
            this.dek_x.TabIndex = 5;
            this.dek_x.Text = "dek x";
            // 
            // ekr_x
            // 
            this.ekr_x.AutoSize = true;
            this.ekr_x.Location = new System.Drawing.Point(244, 34);
            this.ekr_x.Name = "ekr_x";
            this.ekr_x.Size = new System.Drawing.Size(40, 20);
            this.ekr_x.TabIndex = 6;
            this.ekr_x.Text = "ekr x";
            this.ekr_x.Click += new System.EventHandler(this.label2_Click);
            // 
            // xxx
            // 
            this.xxx.AutoSize = true;
            this.xxx.Location = new System.Drawing.Point(413, 9);
            this.xxx.Name = "xxx";
            this.xxx.Size = new System.Drawing.Size(134, 20);
            this.xxx.TabIndex = 7;
            this.xxx.Text = "Диапазон x(в дек)";
            this.xxx.Click += new System.EventHandler(this.xxx_Click);
            // 
            // minx_dek
            // 
            this.minx_dek.Location = new System.Drawing.Point(413, 34);
            this.minx_dek.Name = "minx_dek";
            this.minx_dek.Size = new System.Drawing.Size(43, 27);
            this.minx_dek.TabIndex = 8;
            this.minx_dek.Text = "-2";
            // 
            // maxx_dek
            // 
            this.maxx_dek.Location = new System.Drawing.Point(475, 34);
            this.maxx_dek.Name = "maxx_dek";
            this.maxx_dek.Size = new System.Drawing.Size(44, 27);
            this.maxx_dek.TabIndex = 9;
            this.maxx_dek.Text = "2";
            // 
            // miny_dek
            // 
            this.miny_dek.Location = new System.Drawing.Point(574, 32);
            this.miny_dek.Name = "miny_dek";
            this.miny_dek.Size = new System.Drawing.Size(35, 27);
            this.miny_dek.TabIndex = 10;
            this.miny_dek.Text = "-1";
            this.miny_dek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // shag
            // 
            this.shag.Location = new System.Drawing.Point(346, 77);
            this.shag.Name = "shag";
            this.shag.Size = new System.Drawing.Size(125, 27);
            this.shag.TabIndex = 11;
            this.shag.Text = "0,2";
            this.shag.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // maxy_dek
            // 
            this.maxy_dek.Location = new System.Drawing.Point(655, 34);
            this.maxy_dek.Name = "maxy_dek";
            this.maxy_dek.Size = new System.Drawing.Size(42, 27);
            this.maxy_dek.TabIndex = 12;
            this.maxy_dek.Text = "1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(574, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 27);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "экр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Диапазон у(в дек)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "шаг";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maxy_dek);
            this.Controls.Add(this.shag);
            this.Controls.Add(this.miny_dek);
            this.Controls.Add(this.maxx_dek);
            this.Controls.Add(this.minx_dek);
            this.Controls.Add(this.xxx);
            this.Controls.Add(this.ekr_x);
            this.Controls.Add(this.dek_x);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.ekr_y);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dek_y);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label dek_y;
        private Label label3;
        private Label ekr_y;
        private PictureBox pic;
        private Label dek_x;
        private Label ekr_x;
        private Label xxx;
        private TextBox minx_dek;
        private TextBox maxx_dek;
        private TextBox miny_dek;
        private TextBox shag;
        private TextBox maxy_dek;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}