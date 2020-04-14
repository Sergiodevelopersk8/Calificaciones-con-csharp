using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classcalificaciones;
using Validaciones;
namespace Formcalificaciones
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            btnnombre.Visible = false;
        }
        
        Classcalificacion calis = new Classcalificacion();
        Validacion vals = new Validacion();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            calis.nombrealumno(textBox1.Text);
            calis.operaciones(textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void btnnombre_Click(object sender, EventArgs e)
        {
            btnnombre.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(vals.validadoletra(e.KeyChar));
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(vals.validadornum(e.KeyChar));
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(vals.validadornum(e.KeyChar));
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(vals.validadornum(e.KeyChar));
        }
    }
}
