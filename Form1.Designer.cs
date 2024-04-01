namespace calculator.delav
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
            button1 = new Button();
            num2 = new TextBox();
            num1 = new TextBox();
            calculator = new Label();
            sum = new Button();
            multi = new Button();
            sub = new Button();
            div = new Button();
            Result = new Label();
            sqrt = new Button();
            cube = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Location = new Point(596, 12);
            button1.Name = "button1";
            button1.Size = new Size(73, 32);
            button1.TabIndex = 0;
            button1.Text = "Force exit";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // num2
            // 
            num2.BackColor = Color.CornflowerBlue;
            num2.Location = new Point(238, 101);
            num2.Name = "num2";
            num2.Size = new Size(100, 23);
            num2.TabIndex = 1;
            // 
            // num1
            // 
            num1.BackColor = Color.CornflowerBlue;
            num1.Location = new Point(108, 101);
            num1.Name = "num1";
            num1.Size = new Size(100, 23);
            num1.TabIndex = 2;
            num1.TextChanged += num1_TextChanged;
            // 
            // calculator
            // 
            calculator.AutoSize = true;
            calculator.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculator.Location = new Point(51, 12);
            calculator.Name = "calculator";
            calculator.Size = new Size(200, 20);
            calculator.TabIndex = 3;
            calculator.Text = "calculator made by delav";
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            sum.Location = new Point(86, 241);
            sum.Name = "sum";
            sum.Size = new Size(75, 23);
            sum.TabIndex = 4;
            sum.Text = "+";
            sum.UseVisualStyleBackColor = true;
            sum.Click += sum_Click;
            // 
            // multi
            // 
            multi.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            multi.Location = new Point(209, 298);
            multi.Name = "multi";
            multi.Size = new Size(75, 23);
            multi.TabIndex = 5;
            multi.Text = "x";
            multi.UseVisualStyleBackColor = true;
            multi.Click += multi_Click;
            // 
            // sub
            // 
            sub.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            sub.Location = new Point(209, 241);
            sub.Name = "sub";
            sub.Size = new Size(75, 23);
            sub.TabIndex = 6;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = true;
            sub.Click += sub_Click;
            // 
            // div
            // 
            div.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            div.Location = new Point(86, 298);
            div.Name = "div";
            div.Size = new Size(75, 23);
            div.TabIndex = 7;
            div.Text = "%";
            div.UseVisualStyleBackColor = true;
            div.Click += div_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.BackColor = Color.FromArgb(192, 192, 255);
            Result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result.Location = new Point(108, 191);
            Result.Name = "Result";
            Result.Size = new Size(53, 21);
            Result.TabIndex = 8;
            Result.Text = "Result";
            Result.Click += Result_Click;
            // 
            // sqrt
            // 
            sqrt.Location = new Point(338, 241);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(75, 23);
            sqrt.TabIndex = 9;
            sqrt.Text = "sqrt";
            sqrt.UseVisualStyleBackColor = true;
            sqrt.Click += sqrt_Click;
            // 
            // cube
            // 
            cube.Location = new Point(338, 299);
            cube.Name = "cube";
            cube.Size = new Size(75, 23);
            cube.TabIndex = 10;
            cube.Text = "cube";
            cube.UseVisualStyleBackColor = true;
            cube.Click += cube_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(394, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(cube);
            Controls.Add(sqrt);
            Controls.Add(Result);
            Controls.Add(div);
            Controls.Add(sub);
            Controls.Add(multi);
            Controls.Add(sum);
            Controls.Add(calculator);
            Controls.Add(num1);
            Controls.Add(num2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox num2;
        private TextBox num1;
        private Label calculator;
        private Button sum;
        private Button multi;
        private Button sub;
        private Button div;
        private Label Result;
        private Button sqrt;
        private Button cube;
        private PictureBox pictureBox1;
    }
}
