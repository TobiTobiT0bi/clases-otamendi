using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace explicacionTutorial
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            //DialogResult resultado = MessageBox.Show("seguro que queres salir?", "estas seguro pana?", MessageBoxButtons.YesNo);

            //if (resultado == DialogResult.Yes) {
            //    Application.Exit();
            //}

            //cerrar.Location = new Point(rnd.Next(0, 100), rnd.Next(1002, 1092));
        }
    }
}
