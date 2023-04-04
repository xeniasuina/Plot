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
            this.button1 = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.dek_x = new System.Windows.Forms.Label();
            this.dek_y = new System.Windows.Forms.Label();
            this.ekr_x = new System.Windows.Forms.Label();
            this.ekr_y = new System.Windows.Forms.Label();
            this.minx_dek = new System.Windows.Forms.TextBox();
            this.maxx_dek = new System.Windows.Forms.TextBox();
            this.xxx = new System.Windows.Forms.Label();
            this.miny_dek = new System.Windows.Forms.TextBox();
            this.maxy_dek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(713, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "Построить график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic.Location = new System.Drawing.Point(12, 88);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(680, 439);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            // 
            // dek_x
            // 
            this.dek_x.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dek_x.AutoSize = true;
            this.dek_x.Location = new System.Drawing.Point(12, 533);
            this.dek_x.Name = "dek_x";
            this.dek_x.Size = new System.Drawing.Size(44, 20);
            this.dek_x.TabIndex = 3;
            this.dek_x.Text = "dek x";
            // 
            // dek_y
            // 
            this.dek_y.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dek_y.AutoSize = true;
            this.dek_y.Location = new System.Drawing.Point(145, 533);
            this.dek_y.Name = "dek_y";
            this.dek_y.Size = new System.Drawing.Size(44, 20);
            this.dek_y.TabIndex = 4;
            this.dek_y.Text = "dek y";
            this.dek_y.Click += new System.EventHandler(this.label2_Click);
            // 
            // ekr_x
            // 
            this.ekr_x.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ekr_x.AutoSize = true;
            this.ekr_x.Location = new System.Drawing.Point(493, 533);
            this.ekr_x.Name = "ekr_x";
            this.ekr_x.Size = new System.Drawing.Size(40, 20);
            this.ekr_x.TabIndex = 5;
            this.ekr_x.Text = "x ekr";
            // 
            // ekr_y
            // 
            this.ekr_y.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ekr_y.AutoSize = true;
            this.ekr_y.Location = new System.Drawing.Point(560, 533);
            this.ekr_y.Name = "ekr_y";
            this.ekr_y.Size = new System.Drawing.Size(40, 20);
            this.ekr_y.TabIndex = 6;
            this.ekr_y.Text = "y ekr";
            // 
            // minx_dek
            // 
            this.minx_dek.Location = new System.Drawing.Point(419, 41);
            this.minx_dek.Name = "minx_dek";
            this.minx_dek.Size = new System.Drawing.Size(43, 27);
            this.minx_dek.TabIndex = 9;
            this.minx_dek.Text = "-2";
            // 
            // maxx_dek
            // 
            this.maxx_dek.Location = new System.Drawing.Point(509, 41);
            this.maxx_dek.Name = "maxx_dek";
            this.maxx_dek.Size = new System.Drawing.Size(44, 27);
            this.maxx_dek.TabIndex = 10;
            this.maxx_dek.Text = "2";
            // 
            // xxx
            // 
            this.xxx.AutoSize = true;
            this.xxx.Location = new System.Drawing.Point(419, 9);
            this.xxx.Name = "xxx";
            this.xxx.Size = new System.Drawing.Size(134, 20);
            this.xxx.TabIndex = 11;
            this.xxx.Text = "Диапазон x(в дек)";
            // 
            // miny_dek
            // 
            this.miny_dek.Location = new System.Drawing.Point(595, 41);
            this.miny_dek.Name = "miny_dek";
            this.miny_dek.Size = new System.Drawing.Size(35, 27);
            this.miny_dek.TabIndex = 12;
            this.miny_dek.Text = "-1";
            // 
            // maxy_dek
            // 
            this.maxy_dek.Location = new System.Drawing.Point(650, 41);
            this.maxy_dek.Name = "maxy_dek";
            this.maxy_dek.Size = new System.Drawing.Size(42, 27);
            this.maxy_dek.TabIndex = 13;
            this.maxy_dek.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Диапазон у(в дек)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxy_dek);
            this.Controls.Add(this.miny_dek);
            this.Controls.Add(this.xxx);
            this.Controls.Add(this.maxx_dek);
            this.Controls.Add(this.minx_dek);
            this.Controls.Add(this.ekr_y);
            this.Controls.Add(this.ekr_x);
            this.Controls.Add(this.dek_y);
            this.Controls.Add(this.dek_x);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private PictureBox pic;
        private Label dek_x;
        private Label dek_y;
        private Label ekr_x;
        private Label ekr_y;
        private TextBox minx_dek;
        private TextBox maxx_dek;
        private Label xxx;
        private TextBox miny_dek;
        private TextBox maxy_dek;
        private Label label4;
    }
}

