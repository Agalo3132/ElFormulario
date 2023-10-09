using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ElFormulario
{
    public partial class fmElFormulario : Form
    {
        public fmElFormulario()
        {
            InitializeComponent();
        }

        private void fmElFormulario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
        }


        private void btArriba_Click(object sender, EventArgs e)
        {
            if (laMover.Top <= -laMover.Height)
 {
                laMover.Top = Height - 44; 
            }
            laMover.Top = laMover.Top - 2; 
        }

        private void btDerecha_Click(object sender, EventArgs e)
        {
            if (laMover.Right >= Width) 
            {
                laMover.Left = -laMover.Width; 
 }
            laMover.Left = laMover.Right - 20;
        }

        private void fmElFormulario_Load(object sender, EventArgs e)
        {
            btVisible.Text = "Pon no Visible";
            btVisible.ForeColor = Color.Green;
            MessageBox.Show("Hola buenas");
        }

        private void btVisible_Click(object sender, EventArgs e)
        {
            btBotones.Visible = !btBotones.Visible;
            if (btBotones.Visible)
            {
                btVisible.Text = "Pon No Visible";
                btVisible.ForeColor = Color.Green;
            }
            else
            {
                btVisible.Text = "Pon Visible";
                btVisible.ForeColor = Color.Red;
            }
        }

        private void btAumenta_Click(object sender, EventArgs e)
        {
            float Aumenta = laMover.Font.Size; 
             Aumenta++;
            if (Aumenta <= 100) 
            {
                laTamanyo.Text = Convert.ToString(Aumenta);
            btAumenta.Text = "Suma: " + Convert.ToString(Aumenta);
            btDisminuye.Text = "Resta: " + Convert.ToString(Aumenta);
            laMover.Font = new Font("", Aumenta, FontStyle.Regular,GraphicsUnit.Point);
 }

        }

        private void btDisminuye_Click(object sender, EventArgs e)
        {
            float Disminuye = laMover.Font.Size;
            Disminuye--;
            if (Disminuye >= 0)
            {
                laTamanyo.Text = Convert.ToString(Disminuye);
                btAumenta.Text = "Suma: " + Convert.ToString(Disminuye);
                btDisminuye.Text = "Resta: " + Convert.ToString(Disminuye);
                laMover.Font = new Font("", Disminuye, FontStyle.Regular, GraphicsUnit.Point);
            }
        }

        private void btDelante_Click(object sender, EventArgs e)
        {
            laMover.BringToFront();
        }

        private void btDetrás_Click(object sender, EventArgs e)
        {
            laMover.SendToBack();
        }

        private void btUno_Click(object sender, EventArgs e)
        {
            if (sender == btUno)
            {
                MessageBox.Show("es el uno");
            }
            if (sender == btDos)
            {
                MessageBox.Show("es el dos");
            }
            if (sender == btTres)
            {
                MessageBox.Show("es el tres");
            }

            (sender as Button).BackColor = Color.Red;
            Button miBoton = (Button)sender; 
            MessageBox.Show("Es el boton " + miBoton.Text);

        }

        private void btAbajo_Click(object sender, EventArgs e)
        {
            if (laMover.Bottom <= -laMover.Height)

            {
                laMover.Top = Height - 44;
            }
            laMover.Top = laMover.Top + 20;
        }

        private void btIzquierda_Click(object sender, EventArgs e)
        {
            if (laMover.Left >= Width) 
            {
                laMover.Left = +laMover.Width;
            }
            laMover.Left = laMover.Left - 20;

        }
    }
}
