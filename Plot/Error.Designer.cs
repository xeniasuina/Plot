namespace Plot
{
    partial class Error
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            okButton = new Button();
            errorText = new Label();
            errorText2 = new Label();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(124, 62);
            okButton.Name = "okButton";
            okButton.Size = new Size(50, 29);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // errorText
            // 
            errorText.AutoSize = true;
            errorText.Location = new Point(74, 9);
            errorText.Name = "errorText";
            errorText.Size = new Size(153, 20);
            errorText.TabIndex = 1;
            errorText.Text = "Некорректный ввод!";
            // 
            // errorText2
            // 
            errorText2.AutoSize = true;
            errorText2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            errorText2.Location = new Point(12, 29);
            errorText2.Name = "errorText2";
            errorText2.Size = new Size(270, 20);
            errorText2.TabIndex = 2;
            errorText2.Text = "Перепроверьте введенную функцию.";
            // 
            // Error
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 103);
            Controls.Add(errorText2);
            Controls.Add(errorText);
            Controls.Add(okButton);
            MaximumSize = new Size(300, 150);
            MinimumSize = new Size(300, 150);
            Name = "Error";
            Text = "Error";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Label errorText;
        private Label errorText2;
    }
}
