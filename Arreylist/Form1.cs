using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreylist
{
    public partial class Form1 : Form
    {
        ArrayList listaAutomobila = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            txtUnesi.Enabled = true;
            btnUnesi.Enabled = true;

        }

        private void btnNoviauto_Click(object sender, EventArgs e)
        {
            txtUnesi.Enabled = true;
            btnUnesi.Enabled = true;
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            ArrayList listaAutomobila = new ArrayList();
            Automobil a = new Automobil(txtUnesi.Text);
            listaAutomobila.Add(a);
            richTextBox1.AppendText((listaAutomobila.IndexOf(a) + 1) + ". " + a.DajMarku() + "\n");
           
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            listaAutomobila.Clear();
            richTextBox1.Clear();
        }
    }
}
