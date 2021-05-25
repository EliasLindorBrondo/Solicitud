using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (combo1.Text == "Elegir" && combo2.Text == "Elegir")
            {
                lbmensaje.Text = "Solicitud dio error";
            }
            else
            {
                lbmensaje.Text = "Solicitud en proceso: Profesion- " + combo1.Text + "| Horario- " + combo2.Text;
            }
           
        }
    }
}
