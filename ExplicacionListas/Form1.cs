using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplicacionListas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaTexto.Items.Add("mouse negativo");
        }

        private void ListaTexto_MouseEnter(object sender, EventArgs e)
        {
            ListaTexto.Items.Clear();
            ListaTexto.Items.Add("mouse positivo");
        }

        private void ListaTexto_MouseLeave(object sender, EventArgs e)
        {
            ListaTexto.Items.Clear();
            ListaTexto.Items.Add("mouse negativo");
        }

        private void ListaTexto_MouseMove(object sender, MouseEventArgs e)
        {
            Point coordenadasMouse = e.Location;

            if (ListaTexto.Items.Count > 1) {
                ListaTexto.Items.RemoveAt(ListaTexto.Items.Count - 1);
            }
            ListaTexto.Items.Add($"X: {coordenadasMouse.X}, Y: {coordenadasMouse.Y}");
        }
    }
}
