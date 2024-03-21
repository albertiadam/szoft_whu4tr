namespace kigyo
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irany_x = 1;
        int irany_y = 0;
        int hossz = 1;
        PictureBox alma = new PictureBox();
        int lepesszam;

        Random rnd = new Random();
        List<KigyoElem> kigyo = new List<KigyoElem>();
        public Form1()
        {
            InitializeComponent();
            AlmaLerakas();
            alma.Width = 20;
            alma.Height = 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lepesszam++;
            fej_x += irany_x * KigyoElem.méret;
            fej_y += irany_y * KigyoElem.méret;

            foreach (object item in Controls)
            {
                if (item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;
                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        Lose();
                        Restart();
                        return;
                    }
                }
            }

            KigyoElem ke = new();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);
            kigyo.Add(ke);

            if (kigyo.Last().Bounds.IntersectsWith(alma.Bounds))
            {
                hossz++;
                AlmaLerakas();
            }

            if (kigyo.Count > hossz)
            {
                KigyoElem levagando = kigyo[0];
                Controls.Remove(levagando);
                kigyo.Remove(levagando);
            }
            if (lepesszam % 2 == 0)
            {
                ke.BackColor = Color.Yellow;
            }
            Coll();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irany_y = -1;
                irany_x = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                irany_y = 1;
                irany_x = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                irany_y = 0;
                irany_x = -1;
            }
            if (e.KeyCode == Keys.Right)
            {
                irany_y = 0;
                irany_x = 1;
            }

        }
        private void AlmaLerakas()
        {
            bool johely = true;
            alma.BackColor = Color.Black;
            int alma_x = rnd.Next(ClientRectangle.Width/KigyoElem.méret)*KigyoElem.méret;
            int alma_y = rnd.Next(ClientRectangle.Height/KigyoElem.méret)*KigyoElem.méret;
            alma.Left = alma_x;
            alma.Top = alma_y;
            foreach (KigyoElem ke in kigyo)
            {
                if (alma.Bounds.IntersectsWith(ke.Bounds))
                {
                    johely = false;
                    break;
                }
            }
            if (johely)
            {
                Controls.Add(alma);
            }
            else
            {
                AlmaLerakas();
            }

        }
        private void Coll()
        {
            KigyoElem nezendo = kigyo.Last();
            if (nezendo.Top==0)
            {
                timer1.Enabled = false;
                Lose();
                Restart();
            }
            if (nezendo.Left==0)
            {
                timer1.Enabled = false;
                Lose();
                Restart();
            }
            if (nezendo.Left > ClientRectangle.Width-KigyoElem.méret)
            {
                timer1.Enabled = false;
                Lose();
                Restart();
            }
            if (nezendo.Top>ClientRectangle.Height-KigyoElem.méret)
            {
                timer1.Enabled = false;
                Lose();
                Restart();
            }
        }
        private void Lose()
        {
            MessageBox.Show("vesztettél öcsipók");
        }
        private void Restart()
        {
            List<object> torlendok = new List<object>();

            foreach (object item in Controls)
            {
                if (item != timer1)
                {
                    torlendok.Add(item);
                }
            }
            foreach (object item in torlendok)
            {
                if (item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;
                    Controls.Remove(k);
                }
                if (item is PictureBox)
                {
                    PictureBox k = (PictureBox)item;
                    Controls.Remove(k);
                }
            }
            //foreach (object item in Controls) {
            //    if(item is KigyoElem)
            //    {
            //        KigyoElem k = (KigyoElem)item;
            //        Controls.Remove(k);
            //    }
            //}
            //Controls.Remove(alma);
            hossz = 1;
            kigyo.Clear();
            ujalma();
            fej_x = 100;
            fej_y = 100;
            timer1.Enabled = true;
            timer1.Start();
            AlmaLerakas();
        }
        private void ujalma()
        {
            PictureBox alma = new PictureBox();
            alma.Width = 20;
            alma.Height = 20;
        }
    }
}