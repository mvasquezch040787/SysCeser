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
    public partial class FRM_EMPLEADO : Form
    {
        public FRM_EMPLEADO()
        {
            InitializeComponent();
        }

        private void FRM_EMPLEADO_Load(object sender, EventArgs e)
        {
            this.DTP_FECHA_NACIMIENTO.MaxDate = DateTime.Now;

            System.Data.DataTable _Tabla = _Sistema._Obtener_Instancia()._Area._Listar();

            this.CBO_AREA.DataSource = _Tabla;

            this.CBO_AREA .ValueMember= _Tabla .Columns [0].ColumnName ;
            this.CBO_AREA.DisplayMember = _Tabla.Columns[1].ColumnName;

            System.Data.DataTable _Tabla_ = _Sistema._Obtener_Instancia()._Cargo._Listar();

            this.CBO_CARGO.DataSource = _Tabla_;

            this.CBO_CARGO.ValueMember = _Tabla_.Columns[0].ColumnName;
            this.CBO_CARGO.DisplayMember = _Tabla_.Columns[1].ColumnName;

        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            if (_Sistema._Obtener_Instancia()._Util._verificar_cajas(this.TXT_APE_PATERNO,this .TXT_APE_MATERNO,this.TXT_DIRECCION,
                                                                     this.TXT_DNI,this.TXT_NOMBRES ,this.TXT_NICK ,this.TXT_PASSWORD))
            {
               try
                {
                //Cargamos la clase Area

                    _Sistema._Obtener_Instancia()._Area.Id_area = Convert.ToString(this.CBO_AREA.SelectedValue);
                    _Sistema._Obtener_Instancia()._Cargo.Id_cargo = Convert.ToString(this.CBO_CARGO.SelectedValue);

                //Cargamos la clase empleado

                _Sistema._Obtener_Instancia()._Empleado.Ape_paterno = this.TXT_APE_PATERNO.Text.Trim();
                _Sistema._Obtener_Instancia()._Empleado.Ape_materno = this.TXT_APE_MATERNO.Text.Trim();
                _Sistema._Obtener_Instancia()._Empleado.Nombres = this.TXT_NOMBRES.Text.Trim();
                _Sistema._Obtener_Instancia()._Empleado.Direccion = this.TXT_DIRECCION.Text.Trim();
                _Sistema._Obtener_Instancia()._Empleado.Dni = this.TXT_DNI.Text.Trim();
                _Sistema._Obtener_Instancia()._Empleado.E_mail = this.TXT_E_MAIL.Text.Trim();
                _Sistema._Obtener_Instancia()._Empleado.Fecha_nacimiento = this.DTP_FECHA_NACIMIENTO.Value;
                _Sistema._Obtener_Instancia()._Empleado.Sexo = this.CBO_SEXO.SelectedIndex;
                _Sistema._Obtener_Instancia()._Empleado.Nick = this.TXT_NICK.Text.Trim();
                _Sistema._Obtener_Instancia()._Empleado.Password = this.TXT_PASSWORD.Text.Trim();

                _Sistema._Obtener_Instancia()._Empleado .Cargo=(_Cargo)(_Sistema ._Obtener_Instancia ()._Cargo ._Obtener_objeto ());
                _Sistema._Obtener_Instancia()._Empleado.Area = (_Area)(_Sistema._Obtener_Instancia()._Area._Obtener_objeto());

                     if (_Sistema._Obtener_Instancia()._Empleado._Guardar_empleado().Equals("SI"))
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje("Grabacion satisfactoria", "Mensaje");
                        this.TXT_ID_EMPLEADO.Text = _Sistema._Obtener_Instancia()._Empleado.Id_empleado;
                    }
                     else
                    {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje("Verificar Dni o Email", "Advertencia");
                     }
               }
                catch (Exception ex)
                {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                }                                                      
           }
            else
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Debe llenar los campos : " + _Sistema._Obtener_Instancia()._Util._get_cajas_vacias, "Advertencia");
            }
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.TXT_APE_PATERNO, this.TXT_APE_PATERNO, this.TXT_ID_EMPLEADO, this.TXT_APE_PATERNO,
                                                             this.TXT_APE_MATERNO, this.TXT_NOMBRES, this.TXT_DIRECCION,
                                                             this.TXT_DNI, this.TXT_E_MAIL, this.TXT_TELEFONO, this.TXT_NICK, this.TXT_PASSWORD);
        }

        private void BTN_NUEVO_Click(object sender, EventArgs e)
        {
            _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.TXT_APE_PATERNO, this.TXT_APE_PATERNO, this.TXT_ID_EMPLEADO, this.TXT_APE_PATERNO,
                                                             this.TXT_APE_MATERNO, this.TXT_NOMBRES, this.TXT_DIRECCION,
                                                             this.TXT_DNI, this.TXT_E_MAIL, this.TXT_TELEFONO,this .TXT_NICK ,this.TXT_PASSWORD );
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
