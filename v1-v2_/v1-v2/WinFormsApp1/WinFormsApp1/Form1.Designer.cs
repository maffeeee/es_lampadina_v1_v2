namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(56, 41);
            button1.Name = "button1";
            button1.Size = new Size(170, 171);
            button1.TabIndex = 0;
            button1.Text = "ACCENDI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(547, 41);
            button2.Name = "button2";
            button2.Size = new Size(170, 171);
            button2.TabIndex = 1;
            button2.Text = "SPEGNI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._22;
            pictureBox1.Location = new Point(255, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._23;
            pictureBox2.Location = new Point(255, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 179);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(547, 235);
            button3.Name = "button3";
            button3.Size = new Size(170, 171);
            button3.TabIndex = 4;
            button3.Text = "ABBASSA";
            button3.UseVisualStyleBackColor = true;
            button3.MouseDown += buttonAbbassa_MouseDown;
            button3.MouseUp += button_MouseUp;
            // 
            // button4
            // 
            button4.Location = new Point(56, 235);
            button4.Name = "button4";
            button4.Size = new Size(170, 171);
            button4.TabIndex = 5;
            button4.Text = "ALZA";
            button4.UseVisualStyleBackColor = true;
            button4.MouseDown += buttonAlza_MouseDown;
            button4.MouseUp += button_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button4;
    }
}
