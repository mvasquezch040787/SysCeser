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
    public partial class FRM_CARGO : Form
    {
        public FRM_CARGO()
        {
            InitializeComponent();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Sistema._Obtener_Instancia()._Util._verificar_cajas(this._txt_cargo))
                {
                    //Cargamos los atributos de cargo

                    _Sistema._Obtener_Instancia()._Cargo.Cargo  = this._txt_cargo.Text.Trim();

                    if (_Sistema._Obtener_Instancia()._Cargo ._Guardar_cargo ().Equals ("SI"))
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje("Grabacion satisfactoria", "Mensaje");
                        this._txt_id_cargo.Text = _Sistema._Obtener_Instancia()._Cargo.Id_cargo;
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
            _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this._txt_cargo, this._txt_cargo);
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {

            if (_Sistema._Obtener_Instancia()._Util._Call_mensaje_box("Operacion cancelada,Desea salir", "Advertencia"))
            {
                _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this._txt_cargo);
                this.Close();
            }
            else
            {
                _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this._txt_cargo);
            }
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
