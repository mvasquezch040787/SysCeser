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
    public partial class FRM_AREA : Form
    {
        public FRM_AREA()
        {
            InitializeComponent();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Sistema._Obtener_Instancia()._Util._verificar_cajas(this.txt_area ))
                {
                    //Cargamos los atributos de area

                    _Sistema._Obtener_Instancia()._Area.Area = this.txt_area.Text.Trim();

                    if (_Sistema._Obtener_Instancia()._Area._Guardar_area().Equals("SI"))
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje("Grabacion satisfactoria","Mensaje");
                        this.__txt_area.Text = _Sistema._Obtener_Instancia()._Area.Id_area;
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
            _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.txt_area, this.txt_area);
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            if(_Sistema ._Obtener_Instancia ()._Util ._Call_mensaje_box("Operacion cancelada,Desea salir","Advertencia"))
            {
                _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.txt_area);
                this.Close();
            }
            else
            {
                _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.txt_area);
            }
        }
    }
}
