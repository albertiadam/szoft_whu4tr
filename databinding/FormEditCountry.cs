using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databinding
{
    public partial class FormEditCountry : Form
    {
        public CountryData EditedCountryData;
        public FormEditCountry()
        {
            InitializeComponent();
        }

        private void FormEditCountry_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = EditedCountryData;
        }
    }
}
