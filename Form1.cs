using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Views;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pais frm_Pais = new frm_Pais();
            frm_Pais.Show();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
