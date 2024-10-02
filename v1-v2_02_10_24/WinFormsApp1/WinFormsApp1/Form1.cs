namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = true ;
        }
        
        private bool pulsanteSchiacciato = false;

        private void buttonAbbassa_MouseDown(object sender, MouseEventArgs e)
        {
            alzaAbbassa(1);
        }

        private void buttonAlza_MouseDown(object sender, MouseEventArgs e)
        {
            alzaAbbassa(-1);
        }


        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            pulsanteSchiacciato = false;
        }

        private async void alzaAbbassa(int distanza)
        {
            pulsanteSchiacciato = true;
            while (pulsanteSchiacciato&&(pictureBox1.Top+distanza>=0&&pictureBox1.Bottom+distanza<=this.ClientSize.Height)&&(pictureBox2.Top+distanza>=0 && pictureBox2.Bottom+distanza<=this.ClientSize.Height))
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + distanza);
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + distanza);
                await Task.Delay(102);
            }
        }
    }
}
