namespace Veletlen
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Button gomb = new Button();
                Controls.Add(gomb);
                gomb.Width = rnd.Next(10, 100);
                gomb.Height = rnd.Next(10, 100);
                gomb.BackColor= Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));    
                gomb.Left = rnd.Next(0,ClientRectangle.Width-gomb.Width);
                gomb.Top = rnd.Next(0,ClientRectangle.Height-gomb.Height);
            }
        }
    }
}