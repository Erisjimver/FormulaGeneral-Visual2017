using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlador.matematicas m = new controlador.matematicas();

            m.A = Convert.ToDouble(A.Text);
            m.B = Convert.ToDouble(B.Text);
            m.C = Convert.ToDouble(C.Text);
            m.formulaGeneral();

            x.Text = Convert.ToString(m.X);
            x1.Text = Convert.ToString(m.X1);
            //MessageBox.Show("El resultado es: " + m.A);

        }
    }
}
