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
    public partial class _Mi_mensaje : Form
    {
        public _Mi_mensaje()
        {
            InitializeComponent();
        }

             public void _Mensaje(string mensaje,string titulo)
        {
            this.lbl_mensaje.Text = mensaje.Trim();
            this.Text = titulo.Trim();
        }

             private void btn_aceptar_Click(object sender, EventArgs e)
             {
                 this.Close();
             }
    }
}
