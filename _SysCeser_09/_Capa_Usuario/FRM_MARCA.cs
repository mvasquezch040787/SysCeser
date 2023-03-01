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
    public partial class FRM_MARCA : Form
    {
        public FRM_MARCA()
        {
            InitializeComponent();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Sistema._Obtener_Instancia()._Util._verificar_cajas(this._txt_marca ))
                {
                    //Cargamos los atributos de marca

                    _Sistema._Obtener_Instancia()._Marca.Marca  = this._txt_marca.Text.Trim();

                    if (_Sistema._Obtener_Instancia()._Marca._Guardar_marca().Equals("SI"))
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje("Grabacion satisfactoria", "Mensaje");

                        this._txt_id_marca.Text   = _Sistema._Obtener_Instancia()._Marca.Id_marca ;
                    }

                }

                else
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje("Debe ingresar el campo " + _Sistema._Obtener_Instancia()._Util._get_cajas_vacias, "Advertencia");

                }




            }
            catch (Exception ex)
            {

                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
            }
        }

        private void BTN_NUEVO_Click(object sender, EventArgs e)
        {
            _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this._txt_marca, this._txt_marca);
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            if (_Sistema._Obtener_Instancia()._Util._Call_mensaje_box("Operacion cancelada,Desea salir", "Advertencia"))
            {
                _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this._txt_marca );
                this.Close();
            }
            else
            {
                _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this._txt_marca);
            }
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
