namespace WinFormsTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonHypCalc = new Button();
            buttonNonHypCalc = new Button();
            title = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAB = new TextBox();
            textBoxAC = new TextBox();
            textBoxBC = new TextBox();
            buttonReciprocal = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonHypCalc
            // 
            buttonHypCalc.Location = new Point(247, 248);
            buttonHypCalc.Margin = new Padding(3, 2, 3, 2);
            buttonHypCalc.Name = "buttonHypCalc";
            buttonHypCalc.Size = new Size(220, 62);
            buttonHypCalc.TabIndex = 1;
            buttonHypCalc.Text = "AB² = AC² + BC²\r\n(Hypotenusis mode)";
            buttonHypCalc.UseVisualStyleBackColor = true;
            buttonHypCalc.Click += buttonHypCalc_Click;
            // 
            // buttonNonHypCalc
            // 
            buttonNonHypCalc.Location = new Point(12, 248);
            buttonNonHypCalc.Margin = new Padding(3, 2, 3, 2);
            buttonNonHypCalc.Name = "buttonNonHypCalc";
            buttonNonHypCalc.Size = new Size(229, 62);
            buttonNonHypCalc.TabIndex = 5;
            buttonNonHypCalc.Text = "AC² = AB² - BC²\r\n(Adjacent mode)";
            buttonNonHypCalc.UseVisualStyleBackColor = true;
            buttonNonHypCalc.Click += buttonNonHypCalc_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(207, 9);
            title.Name = "title";
            title.Size = new Size(274, 15);
            title.TabIndex = 6;
            title.Text = "Pythagorean Calculation Software v1.0 by Arinone.";
            title.Click += title_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Help;
            pictureBox1.Image = Properties.Resources.right_triangle;
            pictureBox1.Location = new Point(238, 76);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 43);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "[AB]=";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 43);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = "[AC]=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 43);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "[BC]=";
            // 
            // textBoxAB
            // 
            textBoxAB.Location = new Point(49, 40);
            textBoxAB.Name = "textBoxAB";
            textBoxAB.Size = new Size(190, 23);
            textBoxAB.TabIndex = 11;
            // 
            // textBoxAC
            // 
            textBoxAC.Location = new Point(523, 40);
            textBoxAC.Name = "textBoxAC";
            textBoxAC.Size = new Size(169, 23);
            textBoxAC.TabIndex = 12;
            // 
            // textBoxBC
            // 
            textBoxBC.Location = new Point(289, 40);
            textBoxBC.Name = "textBoxBC";
            textBoxBC.Size = new Size(183, 23);
            textBoxBC.TabIndex = 13;
            // 
            // buttonReciprocal
            // 
            buttonReciprocal.Location = new Point(473, 248);
            buttonReciprocal.Name = "buttonReciprocal";
            buttonReciprocal.Size = new Size(215, 62);
            buttonReciprocal.TabIndex = 14;
            buttonReciprocal.Text = "AB² ?= AC² + BC²\r\n(Reciprocal mode)";
            buttonReciprocal.UseVisualStyleBackColor = true;
            buttonReciprocal.Click += buttonReciprocal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 321);
            Controls.Add(buttonReciprocal);
            Controls.Add(textBoxBC);
            Controls.Add(textBoxAC);
            Controls.Add(textBoxAB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(title);
            Controls.Add(buttonNonHypCalc);
            Controls.Add(buttonHypCalc);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Pythagorean Calculation Software v1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button buttonHypCalc;
        private Label title;
        private PictureBox pictureBox1;
        public Button buttonNonHypCalc;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox textBoxAB;
        private TextBox textBoxAC;
        private TextBox textBoxBC;
        private Button buttonReciprocal;
    }
}