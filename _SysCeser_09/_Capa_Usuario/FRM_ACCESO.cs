using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _Capa_Negocios;

namespace _PROYECTO_FINAL_LPV
{
    public partial class FRM_ACCESO : Form
    {
        public FRM_ACCESO()
        {
            InitializeComponent();
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
                _Capa_Negocios._Sistema._Obtener_Instancia()._Util._Call_mensaje("Salida", "Mensaje");
                Application.Exit();
                this.Dispose();
                this.Close();
        }

        private void FRM_ACCESO_Load(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable _Tabla = _Sistema._Obtener_Instancia()._Empleado._Obtener_empleados_acceso();
                this.CBO_NICKS.DataSource = _Tabla;
                this.CBO_NICKS.ValueMember = _Tabla.Columns[0].ColumnName;
                this.CBO_NICKS.DisplayMember = _Tabla.Columns[1].ColumnName;
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message , "Error");
            }
        }
        private void BNT_ACEPTAR_Click(object sender, EventArgs e)
        {
            this._tm_barra.Enabled = true;
            this._tm_barra.Interval = 250;
            this._tm_barra.Start();
            
        }
            private void _tm_barra_Tick(object sender, EventArgs e)
        {
            this._tsp_barra_progreso.Increment(20);
            this._st_autenticacion.Text = _tsp_barra_progreso.Value.ToString() + " %  Autentificando usuario...";
            if (this._tsp_barra_progreso.Value == this._tsp_barra_progreso.Maximum)
            {
                this._tm_barra.Stop();
                if (_Sistema._Obtener_Instancia()._Empleado._Comprobar_clave(this.CBO_NICKS.SelectedValue.ToString(), this.TXT_PASSWORD.Text.Trim()))
                {
                    _Sistema._Obtener_Instancia()._Empleado.Id_empleado = this.CBO_NICKS.SelectedValue.ToString().Trim();
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje("Usuario y clave correctos", "BIENVENIDO");

                    _Sistema._Obtener_Instancia()._Empleado.Id_empleado = Convert.ToString(this.CBO_NICKS.SelectedValue);
                    this.Close();
                }
                else
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje("Usuario o clave incorrectos", "ADVERTENCIA");
                }
                this._tsp_barra_progreso.Value = 0;
                this._st_autenticacion.Text = "";
            }
         
        }
    }
}
