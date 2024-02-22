namespace pascal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Faktorialis(int n)
        {
            if (n == 0) return 1;
            return n * Faktorialis(n - 1);
        }
        int kombinacio(int n,int k)
        {
            return Faktorialis(n) / (Faktorialis(k) * Faktorialis(n - k));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int m = 40;
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop <10; oszlop++)
                {
                    if (sor >= oszlop)
                    {
                        Button button = new Button();
                        Controls.Add(button);
                        button.Size = new Size(40, 40);
                        button.Top = sor * m;
                        button.Left = Width/2+oszlop * m-sor*m/2-m/2;
                        button.Text = kombinacio(sor, oszlop).ToString();
                        ///
                    }


                }
            }
        }
    }

}