namespace szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int oszlop = 0; oszlop <10; oszlop++)
            {
                for (int sor = 0; sor <10; sor++)
                {
                    Button button = new Button();
                    Controls.Add(button);
                    button.Size = new Size(40, 40);
                    button.Left = oszlop * 40;
                    button.Top = sor * 40;
                    button.BackColor = Color.Azure;
                    button.Text = ((oszlop + 1) * (sor + 1)).ToString();
                }
            }


        }
    }
}