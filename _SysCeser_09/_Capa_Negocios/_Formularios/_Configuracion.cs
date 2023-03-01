using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _Capa_data;

namespace _Capa_Negocios
{
    public partial class _Configuracion : Form
    {
        public _Configuracion()
        {
            InitializeComponent();
        }

        private void CBO_AUTENTICACION_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.CBO_AUTENTICACION.SelectedIndex)
            {
                case 0:
                    this.Label4.Enabled = false;
                    this.Label5.Enabled = false;
                    this.TXT_USUARIO.Enabled = false;
                    this.TXT_PASSWORD.Enabled = false;
                    break;
                case 1:
                    this.Label4.Enabled = true;
                    this.Label5.Enabled = true;
                    this.TXT_USUARIO.Enabled = true;
                    this.TXT_PASSWORD.Enabled = true;
                    break;
            }
        }

        private void BTN_ACEPTAR_Click(object sender, EventArgs e)
        {
            _toools _t = new _toools();
            if (this.TXT_SERVIDOR .Text .Trim ().Equals("")||this.TXT_BASE.Text.Trim().Equals(""))
            {
                _t._Call_mensaje("Alguno campo esta vacio", "Advertencia");
                return;
            }
            else
            {
                if (this.CBO_AUTENTICACION.Text.Trim().Equals("AUTENTICACION DE SQLSERVER"))
                {
                    if (this.TXT_USUARIO.Text .Trim().Equals("") || this.TXT_PASSWORD .Text .Trim().Equals(""))
                    {
                        _t._Call_mensaje("Alguno campo esta vacio", "Advertencia");
                        return;
                    }
                    else
                    {
                        _Instrucciones._Obtener_Instancia()._Construye_Cadena(this.TXT_SERVIDOR.Text, this.TXT_BASE.Text, this.TXT_USUARIO.Text, this.TXT_PASSWORD.Text);
                        if (_Instrucciones._Obtener_Instancia()._Conectar())
                        {
                            _t._Call_mensaje("Configuracion satisfactoria", "Mensaje");
                            this.Close();
                        }
                        else
                        {
                            _t._Call_mensaje("Configuracion incorrecta , establecerla nuevamente", "Mensaje");
                            return;
                        }
                    }
                }
                else
                {
                    if (this.TXT_SERVIDOR.Text.Trim().Equals("") || this.TXT_BASE.Text.Trim().Equals(""))
                    {
                        _t._Call_mensaje("Alguno campo esta vacio", "Advertencia");
                        return;
                    }
                    else
                    {
                        _Instrucciones._Obtener_Instancia()._Construye_Cadena(this.TXT_SERVIDOR.Text, this.TXT_BASE.Text);
                        if (_Instrucciones._Obtener_Instancia()._Conectar())
                        {
                            _t._Call_mensaje("Configuracion satisfactoria", "Mensaje");
                            this.Close();
                        }
                        else
                        {
                            _t._Call_mensaje("Configuracion incorrecta , establecerla nuevamente", "Mensaje");
                            return;
                        }
                    }
                }
            }
        }

        private void _Configuracion_Load(object sender, EventArgs e)
        {
            this.CBO_AUTENTICACION.SelectedIndex = 0;
        }

        private void _Configuracion_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            Application .Exit ();
            this.Dispose();
            this.Close();
        }
    }
}
