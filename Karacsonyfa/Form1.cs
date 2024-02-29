namespace Karacsonyfa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    if (sor <= oszlop)
                    {
                        Button gomb = new Button();
                        Controls.Add(gomb);
                        gomb.Size = new Size(20, 20);
                        gomb.Left = ClientRectangle.Width / 2 + sor * 20 - oszlop * 20 / 2;
                        gomb.Top = oszlop * 20;

                    }
                }
            }
        }
    }
}