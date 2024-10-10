namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool pulsanteSchiacciato = false;
        private Lampadina lampadina;
        public Form1()
        {
            InitializeComponent();
            lampadina = new Lampadina();
            lampadina.posizione = 123;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lampadina.accendi()
            accesaspenta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lampadina.spegni()
            accesaspenta();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accesaspenta();
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
            while (pulsanteSchiacciato)
            {
                lampadina.abbassa();
                accesaspenta();
                await Task.Delay(100);
            }
        }
    }
}
