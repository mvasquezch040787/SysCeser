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
    public partial class FRM_ACTUALIZA_MARCA : Form
    {
        public FRM_ACTUALIZA_MARCA()
        {
            InitializeComponent();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                int _estado = 1;
                
                switch (this._cbo_estado.SelectedIndex)
                {
                    case 0: _estado = 1; break;
                    case 1: _estado = 0; break;
                    default: _estado = 1; break;
                }

                if (_Sistema._Obtener_Instancia()._Util._verificar_cajas(this._txt_marca))
                {
                    _Sistema._Obtener_Instancia()._Marca.Marca  = this._txt_marca.Text.Trim();
                    _Sistema._Obtener_Instancia()._Marca.Estado = _estado;

                    if (_Sistema._Obtener_Instancia()._Marca._Actualiza_marca(_Sistema._Obtener_Instancia()._Marca.Id_marca))
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje("Actualización satisfactoria", "Mensaje");
                        this.Close();
                    }
                    else
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje("Actualización Fracaso "+this._txt_marca .Text +" ya existe", "Mensaje");
                    }
                }
                else
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje("Debe llenar el campo " + _Sistema._Obtener_Instancia()._Util._get_cajas_vacias, "Advertencia");
                }
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
            }
        }

        private void FRM_ACTUALIZA_MARCA_Load(object sender, EventArgs e)
        {
            System.Data.DataRow _Fila = _Sistema._Obtener_Instancia()._Marca._Obtener_fila(_Sistema._Obtener_Instancia()._Marca.Id_marca);
            this._txt_id_marca.Text = Convert.ToString(_Fila[0]);
            this._txt_marca.Text = Convert.ToString(_Fila[1]);
         }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
