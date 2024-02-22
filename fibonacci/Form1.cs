using System.Diagnostics.Eventing.Reader;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return fibonacci(n - 2) + fibonacci(n - 1);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();
            for (int i = 0; i < 20; i++)
            {
                Sor újsor = new Sor();
                újsor.Sorszám = i;
                újsor.Érték = fibonacci(i);
                sorok.Add(újsor);

                Button button = new Button();
                Controls.Add(button);
                button.Text = fibonacci(i).ToString();
                button.Size = new Size(60, 20);
                button.Top = i * 20;

            }
            dataGridView1.DataSource = sorok;
        }
    }
}