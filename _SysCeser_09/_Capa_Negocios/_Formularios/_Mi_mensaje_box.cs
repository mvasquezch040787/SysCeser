using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _Capa_Negocios
{
    public partial class _Mi_mensaje_box : Form
    {
        private bool sw = false;
        public _Mi_mensaje_box()
        {
            InitializeComponent();
        }
        public bool _Respuesta_mensaje { get { return this.sw; } }

        public void _Mensaje(string mensaje, string titulo)
        {
            this.lbl_mensaje.Text = mensaje.Trim();
            this.Text = titulo.Trim();
        }
        private void btn_si_Click_1(object sender, EventArgs e)
        {
            this.sw = true;
            this.Close();
        }
        private void btn_no_Click_1(object sender, EventArgs e)
        {
            this.sw = false;
            this.Close();
        }
    }
}
