namespace WinFormsApp1
{
    public class Lampadina
    {
        private int posizione;
        private bool accesa;

        public int posizione
        {
            get { return posizione; }
            set { posizione = value; }
        }
        public bool accesa
        {
            get { return accesa; }
            set { accesa = value; }
        }
        public void spegni()
        {
            accesa=false;
        }
        public void accendi()
        {
            accesa = true;
        }
        public void alza ()
        {
            posizione -= 5;
        }
        public void abbassa()
        {
            posizione += 5;
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}