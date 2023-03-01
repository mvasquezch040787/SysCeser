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
    public partial class FRM_TIPO_EQUIPO : Form
    {
        public FRM_TIPO_EQUIPO()
        {
            InitializeComponent();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Sistema._Obtener_Instancia()._Util._verificar_cajas(this.txt_tipo ))
                {
                    //Cargamos los atributos de area

                    _Sistema._Obtener_Instancia()._Tipo_equipo .Tipo  = this.txt_tipo.Text.Trim();

                    if (_Sistema._Obtener_Instancia()._Tipo_equipo._Guarda_tipo_equipo ().Equals ("SI"))
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje("Grabacion satisfactoria", "Mensaje");
                        this._txt_id_tipo_equipo .Text  = _Sistema._Obtener_Instancia()._Tipo_equipo .Id_tipo_equipo ;
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
            _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.txt_tipo, this._txt_id_tipo_equipo, this.txt_tipo);
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            if (_Sistema._Obtener_Instancia()._Util._Call_mensaje_box("Operacion cancelada,Desea salir", "Advertencia"))
            {
                _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.txt_tipo);
                this.Close();
            }
            else
            {
                _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.txt_tipo);
            }
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
