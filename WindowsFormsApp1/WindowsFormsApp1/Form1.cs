using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double bilietai10;
        private double bilietai15;
        private double bilietai20;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsukurti_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(tb_skaicius.Text) == 1)
            {
                bilietai10++;
                kiekis_po10.Text = bilietai10.ToString();
            }
            if (Convert.ToDouble(tb_skaicius.Text) == 2)
            {
                bilietai15++;
                kiekis_po15.Text = bilietai15.ToString();
            }
            if (Convert.ToDouble(tb_skaicius.Text) == 3)
            {
                bilietai20++;
                kiekis_po20.Text = bilietai20.ToString();
            }
        }
    }
}
