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
    public partial class FMR_ACTUALIZA_CLIENTE : Form
    {
        public FMR_ACTUALIZA_CLIENTE()
        {
            InitializeComponent();
        }

        private void FMR_ACTUALIZA_ALUMNO_Load(object sender, EventArgs e)
        {

            //   C.ID_CLIENTE ,
            //   P.APELLIDO_PATERNO,
            //P.APELLIDO_MATERNO,
            //   P.NOMBRES,
            //P.DIRECCION
            //,  P.DNI,
            //P.E_MAIL,
            //   P.FECHA_NACIMIENTO,
            //P.SEXO 
            //,  P.ESTADO ,
            //C.TELEFONO
            // , C.CELULAR ,
            //C.RUC  
            try
            {
                this.DTP_FECHA_NACIMIENTO.MaxDate = DateTime.Now;


                System.Data.DataRow _Fila = _Sistema._Obtener_Instancia()._Cliente._Obtener(_Sistema._Obtener_Instancia()._Cliente.Id_cliente);
            
                _Sistema ._Obtener_Instancia ()._Cliente .Id_cliente = Convert.ToString(_Fila[0]);

                this.TXT_COD_CLIENTE.Text = Convert.ToString(_Fila[0]);
                this.TXT_APE_PATERNO.Text = Convert.ToString(_Fila[1]);
                this.TXT_APE_MATERNO.Text = Convert.ToString(_Fila[2]);
                this.TXT_NOMBRES.Text = Convert.ToString(_Fila[3]);
                this.TXT_DIRECCION.Text = Convert.ToString(_Fila[4]);
                this.TXT_DNI.Text = Convert.ToString(_Fila[5]);
                this.TXT_E_MAIL.Text = Convert.ToString(_Fila[6]);
                this.DTP_FECHA_NACIMIENTO.Value = Convert.ToDateTime(_Fila[7]);
                int _sexo = Convert.ToInt32(_Fila[8]);
                int _estado = Convert.ToInt32(_Fila[9]);
                this.TXT_TELEFONO.Text = Convert.ToString(_Fila[10]);
                this.TXT_CELULAR.Text = Convert.ToString(_Fila[11]);
                this.TXT_RUC.Text = Convert.ToString(_Fila[12]);
                

                switch (_sexo )
                {
                    case 1:this.CBO_SEXO.SelectedIndex = 0;break;
                    case 0: this.CBO_SEXO.SelectedIndex = 1; break;
                    default: break;
                }
                switch (_estado)
                {
                    case 1:this.CBO_ESTADO.SelectedIndex = 0;break;
                    case 0: this.CBO_ESTADO.SelectedIndex = 1; break;
                    default : break;
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
                         _Sistema._Obtener_Instancia()._Cliente.Ape_paterno = this.TXT_APE_PATERNO.Text.Trim();
                         _Sistema._Obtener_Instancia()._Cliente.Ape_materno = this.TXT_APE_MATERNO.Text.Trim();
                         _Sistema._Obtener_Instancia()._Cliente.Nombres = this.TXT_NOMBRES.Text.Trim();
                         _Sistema._Obtener_Instancia()._Cliente.Direccion = this.TXT_DIRECCION.Text.Trim();
                         _Sistema._Obtener_Instancia()._Cliente.Dni = this.TXT_DNI.Text.Trim();
                         _Sistema._Obtener_Instancia()._Cliente.E_mail = this.TXT_E_MAIL.Text.Trim();
                         _Sistema._Obtener_Instancia()._Cliente.Fecha_nacimiento = this.DTP_FECHA_NACIMIENTO.Value;
                         _Sistema ._Obtener_Instancia()._Cliente .Sexo =this.CBO_SEXO .SelectedIndex ;
                         _Sistema ._Obtener_Instancia()._Cliente .Estado  =this.CBO_ESTADO .SelectedIndex ;
                         _Sistema._Obtener_Instancia()._Cliente.Telefono = this.TXT_TELEFONO.Text.Trim();
                         _Sistema._Obtener_Instancia()._Cliente.Celular =this.TXT_CELULAR .Text .Trim ();
                         _Sistema._Obtener_Instancia()._Cliente.Ruc = this.TXT_RUC.Text.Trim();
                         if (Convert.ToString(_Sistema._Obtener_Instancia()._Cliente._Actualiza_cliente(_Sistema._Obtener_Instancia()._Cliente .Id_cliente )).Equals("SI"))
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
            else
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Operacion cancelada", "Mensaje");
            }
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            if (_Sistema._Obtener_Instancia()._Util ._Call_mensaje_box ("¿Esta seguro de cancelar la edicion?","Advertencia"))
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Operacion cancelada", "Mensaje");
                _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.TXT_APE_PATERNO, this.TXT_APE_PATERNO, this.TXT_APE_MATERNO,
                                                              this.TXT_DIRECCION, this.TXT_DNI, this.TXT_E_MAIL, this.TXT_NOMBRES,
                                                              this.TXT_TELEFONO,this .TXT_RUC );
                this .Close ();
            }
            else
	        {

	        }
            
        }
    }
}
