using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class VillogoGomb : Button
    {
        public VillogoGomb()
        {
            MouseEnter += VillogoGomb_MouseEnter;
            MouseLeave += VillogoGomb_MouseLeave;
            BackColor= Color.White;
            MouseClick += VillogoGomb_MouseClick;
        }
        int szamolo = 0;
        private void VillogoGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szamolo == 5)
            {
                szamolo = 1;
                Text=szamolo.ToString();
            }
            else
            {
                szamolo++;
                Text = szamolo.ToString();
            }

        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
