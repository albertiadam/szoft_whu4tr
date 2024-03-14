namespace kviz
{
    public partial class Form1 : Form
    {
        int ClickCount = 0;
        List<Kerdes> OsszesKerdes;
        List<Kerdes> AktualisKerdesek = new();
        int MegjelenitettKerdesSzama = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OsszesKerdes = KerdesekBeolvasas();
            for (int i = 0; i < 7; i++)
            {
                AktualisKerdesek.Add(OsszesKerdes[0]);
                OsszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisKerdesek;
            KerdesMegjelenitese(AktualisKerdesek[MegjelenitettKerdesSzama]);
        }

        void KerdesMegjelenitese(Kerdes k�rd�s)
        {
            label1.Text = k�rd�s.KerdesSzoveg;
            textBox1.Text = k�rd�s.Valasz1;
            textBox2.Text = k�rd�s.Valasz2;
            textBox3.Text = k�rd�s.Valasz3;
         
            if (string.IsNullOrEmpty(k�rd�s.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + k�rd�s.URL);
            }

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            ClickCount = 0;
        }

        List<Kerdes> KerdesekBeolvasas()
        {
            List<Kerdes> k�rd�sek = new List<Kerdes>();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? "n/a";
                string[] tomb = sor.Split("\t");

                if (tomb.Length != 7) continue;
                Kerdes k = new();
                k.KerdesSzoveg = tomb[1].Trim('"').ToUpper();
                k.Valasz1 = tomb[2].Trim('"');
                k.Valasz2 = tomb[3].Trim('"');
                k.Valasz3 = tomb[4].Trim('"');
                k.URL = tomb[5];

                int x = 0;
                int.TryParse(tomb[6], out x);
                k.HelyesValasz = x;

                k�rd�sek.Add(k);
            }
            sr.Close();
            return k�rd�sek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MegjelenitettKerdesSzama++;
            if (MegjelenitettKerdesSzama == AktualisKerdesek.Count)
            {
                MegjelenitettKerdesSzama = 0;
            }
            KerdesMegjelenitese(AktualisKerdesek[MegjelenitettKerdesSzama]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (ClickCount==0)
            {
                textBox1.BackColor = Color.Salmon;
                if (AktualisKerdesek[MegjelenitettKerdesSzama].HelyesValasz == 1)
                {
                    textBox1.BackColor = Color.Green;
                    AktualisKerdesek[MegjelenitettKerdesSzama].HelyesValaszokSzama++;
                }
                else
                {
                    AktualisKerdesek[MegjelenitettKerdesSzama].HelyesValaszokSzama = 0;
                }
                ClickCount++;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (ClickCount==0)
            {
                textBox2.BackColor = Color.Salmon;
                if (AktualisKerdesek[MegjelenitettKerdesSzama].HelyesValasz == 2)
                {
                    textBox2.BackColor = Color.Green;
                    AktualisKerdesek[MegjelenitettKerdesSzama].HelyesValaszokSzama++;
                }
                else
                {
                    AktualisKerdesek[MegjelenitettKerdesSzama].HelyesValaszokSzama = 0;
                }
                ClickCount++;
            }

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (ClickCount==0)
            {
                textBox3.BackColor = Color.Salmon;
                if (AktualisKerdesek[MegjelenitettKerdesSzama].HelyesValasz == 3)
                {
                    textBox3.BackColor = Color.Green;
                    AktualisKerdesek[MegjelenitettKerdesSzama].HelyesValaszokSzama++;
                }
                else
                {
                    AktualisKerdesek[MegjelenitettKerdesSzama].HelyesValaszokSzama = 0;
                }
                ClickCount++;
            }

        }
    }
}