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
    public partial class FRM_ACTUALIZA_EMPLEADO : Form
    {
        public FRM_ACTUALIZA_EMPLEADO()
        {
            InitializeComponent();
        }

        private void FRM_ACTUALIZA_EMPLEADO_Load(object sender, EventArgs e)
        {
            this.DTP_FECHA_NACIMIENTO.MaxDate = DateTime.Now;

            System.Data.DataTable _Tabla = _Sistema._Obtener_Instancia()._Area._Listar();

            this.CBO_AREA.DataSource = _Tabla;

            this.CBO_AREA.ValueMember = _Tabla.Columns[0].ColumnName;
            this.CBO_AREA.DisplayMember = _Tabla.Columns[1].ColumnName;

            System.Data.DataTable _Tabla_ = _Sistema._Obtener_Instancia()._Cargo._Listar();

            this.CBO_CARGO.DataSource = _Tabla_;

            this.CBO_CARGO.ValueMember = _Tabla_.Columns[0].ColumnName;
            this.CBO_CARGO.DisplayMember = _Tabla_.Columns[1].ColumnName;

            try
            {

                //   SELECT	E.ID_EMPLEADO ,
                //   P.APELLIDO_PATERNO,
                //P.APELLIDO_MATERNO,
                //   P.NOMBRES,
                //P.DIRECCION,
                //P.DNI,
                //P.E_MAIL,
                //   P.FECHA_NACIMIENTO,
                //P.SEXO ,
                //P.ESTADO ,
                //   E.NICK ,
                //   E.ID_CARGO ,
                //E.ID_AREA 

                this.DTP_FECHA_NACIMIENTO.MaxDate = DateTime.Now;


                System.Data.DataRow _Fila = _Sistema._Obtener_Instancia()._Empleado._Obtener(_Sistema._Obtener_Instancia()._Empleado.Id_empleado);

                _Sistema._Obtener_Instancia()._Empleado.Id_empleado = Convert.ToString(_Fila[0]);

                this.TXT_ID_EMPLEADO.Text = Convert.ToString(_Fila[0]);
                this.TXT_APE_PATERNO.Text = Convert.ToString(_Fila[1]);
                this.TXT_APE_MATERNO.Text = Convert.ToString(_Fila[2]);
                this.TXT_NOMBRES.Text = Convert.ToString(_Fila[3]);
                this.TXT_DIRECCION.Text = Convert.ToString(_Fila[4]);
                this.TXT_DNI.Text = Convert.ToString(_Fila[5]);
                this.TXT_E_MAIL.Text = Convert.ToString(_Fila[6]);
                this.DTP_FECHA_NACIMIENTO.Value = Convert.ToDateTime(_Fila[7]);
                int _sexo = Convert.ToInt32(_Fila[8]);
                int _estado = Convert.ToInt32(_Fila[9]);
                this.TXT_NICK.Text = Convert.ToString(_Fila[10]);
                this.TXT_PASSWORD.Text = _Sistema._Obtener_Instancia()._Util._Desencripta(Convert.ToString(_Fila[11]));



                switch (_sexo)
                {
                    case 1: this.CBO_SEXO.SelectedIndex = 0; break;
                    case 0: this.CBO_SEXO.SelectedIndex = 1; break;
                    default: break;
                }
                switch (_estado)
                {
                    case 1: this.CBO_ESTADO.SelectedIndex = 0; break;
                    case 0: this.CBO_ESTADO.SelectedIndex = 1; break;
                    default: break;
                }

            }

            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
            }
        }
        

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            if (_Sistema._Obtener_Instancia()._Util._Call_mensaje_box("Desea guardar los cambios", "Advertencia"))
            {
                if (_Sistema._Obtener_Instancia()._Util._verificar_cajas(this.TXT_APE_PATERNO, this.TXT_APE_MATERNO, this.TXT_DIRECCION,
                                                                    this.TXT_DNI, this.TXT_NOMBRES))
                {
                    try
                    {
                        _Sistema._Obtener_Instancia()._Area.Id_area = Convert.ToString(this.CBO_AREA.SelectedValue);
                        _Sistema._Obtener_Instancia()._Cargo.Id_cargo = Convert.ToString(this.CBO_CARGO.SelectedValue);

                        _Sistema._Obtener_Instancia()._Empleado.Ape_paterno = this.TXT_APE_PATERNO.Text.Trim();
                        _Sistema._Obtener_Instancia()._Empleado.Ape_materno = this.TXT_APE_MATERNO.Text.Trim();
                        _Sistema._Obtener_Instancia()._Empleado.Nombres = this.TXT_NOMBRES.Text.Trim();
                        _Sistema._Obtener_Instancia()._Empleado.Direccion = this.TXT_DIRECCION.Text.Trim();
                        _Sistema._Obtener_Instancia()._Empleado.Dni = this.TXT_DNI.Text.Trim();
                        _Sistema._Obtener_Instancia()._Empleado.E_mail = this.TXT_E_MAIL.Text.Trim();
                        _Sistema._Obtener_Instancia()._Empleado.Fecha_nacimiento = this.DTP_FECHA_NACIMIENTO.Value;
                        _Sistema._Obtener_Instancia()._Empleado.Sexo = this.CBO_SEXO.SelectedIndex;
                        _Sistema._Obtener_Instancia()._Empleado.Estado = this.CBO_ESTADO.SelectedIndex;

                        _Sistema._Obtener_Instancia()._Empleado.Nick = this.TXT_NICK.Text.Trim();
                        _Sistema._Obtener_Instancia()._Empleado.Password = this.TXT_PASSWORD.Text.Trim();
                        _Sistema._Obtener_Instancia()._Empleado .Cargo =(_Cargo )(_Sistema ._Obtener_Instancia ()._Cargo ._Obtener_objeto ());
                        _Sistema._Obtener_Instancia()._Empleado .Area =(_Area )(_Sistema ._Obtener_Instancia ()._Area ._Obtener_objeto ());
                        


                        if (Convert.ToString(_Sistema._Obtener_Instancia()._Empleado._Actualiza_empleado(_Sistema._Obtener_Instancia()._Empleado.Id_empleado)).Equals("SI"))
                        {
                            _Sistema._Obtener_Instancia()._Util._Call_mensaje("Actualización satisfactoria", "Mensaje");
                            this.Close();
                        }
                        else
                        {
                            _Sistema._Obtener_Instancia()._Util._Call_mensaje("Revisar Dni o E-mail", "Mensaje");
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
        }
    }
}
