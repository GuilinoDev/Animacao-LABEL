using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiscandoLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // condicão ? consequencia : alternativa

            labelOpenbar.ForeColor = labelOpenbar.ForeColor == Color.Transparent ? Color.Red : Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelVisitar.ForeColor = labelVisitar.ForeColor == Color.Transparent ? Color.Yellow : Color.Transparent;
        }
    }
}
