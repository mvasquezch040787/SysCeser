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
    public partial class FRM_CLIENTE : Form
    {
        public FRM_CLIENTE()
        {
            InitializeComponent();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.TXT_APE_PATERNO, this.TXT_ID_CLIENTE, this.TXT_APE_PATERNO,
                                                              this.TXT_APE_MATERNO, this.TXT_NOMBRES, this.TXT_DIRECCION,
                                                              this.TXT_DNI, this.TXT_E_MAIL, this.TXT_TELEFONO);
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            if (_Sistema._Obtener_Instancia()._Util._verificar_cajas(this.TXT_APE_PATERNO, this.TXT_APE_MATERNO,  this.TXT_NOMBRES, this.TXT_DIRECCION,this.TXT_DNI))
            {
                try
                {
                    int _sexo = -1;

                    switch (this.CBO_SEXO .SelectedIndex )
                    {
                        case 0: _sexo = 1; break;
                        case 1:_sexo =0;break ;
                        default: _sexo=-1;  break; 
                            
                    }

                    if (_sexo ==-1)
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje("Debe elegir un sexo", "Advertencia");
                    }
                    else
                    {
                        this.DTP_FECHA_NACIMIENTO.MaxDate = DateTime.Now;

                    _Sistema._Obtener_Instancia()._Cliente.Ape_paterno = this.TXT_APE_PATERNO.Text.Trim();
                    _Sistema._Obtener_Instancia()._Cliente.Ape_materno = this.TXT_APE_MATERNO.Text.Trim();
                    _Sistema._Obtener_Instancia()._Cliente.Nombres = this.TXT_NOMBRES.Text.Trim();
                    _Sistema._Obtener_Instancia()._Cliente.Direccion = this.TXT_DIRECCION.Text.Trim();
                    _Sistema._Obtener_Instancia()._Cliente.Dni = this.TXT_DNI.Text.Trim();
                    _Sistema._Obtener_Instancia()._Cliente.E_mail = this.TXT_E_MAIL.Text.Trim();
                    _Sistema._Obtener_Instancia()._Cliente.Fecha_nacimiento = this.DTP_FECHA_NACIMIENTO.Value;
                    _Sistema._Obtener_Instancia()._Cliente.Sexo = _sexo;
                    _Sistema._Obtener_Instancia()._Cliente.Telefono = this.TXT_TELEFONO.Text.Trim();
                    _Sistema._Obtener_Instancia()._Cliente.Celular = this.TXT_CELULAR.Text.Trim();
                    _Sistema._Obtener_Instancia()._Cliente.Ruc = this.TXT_RUC.Text.Trim();

                    if (this.TXT_DNI.Text.Trim().Length == 8 && this.TXT_RUC.Text.Trim().Length == 11)
                    {
                        if(_Sistema ._Obtener_Instancia ()._Util._Verificar_dni_ruc (this.TXT_DNI .Text .Trim (),this.TXT_RUC .Text .Trim ()))
                        {
                            if (this.DTP_FECHA_NACIMIENTO .Value > DateTime .Now)
                            {
                                 _Sistema._Obtener_Instancia()._Util._Call_mensaje(" Corrija la fecha de nacimiento", "Advertencia");
                            }
                            else
                            {
                                    if (Convert.ToString(_Sistema._Obtener_Instancia()._Cliente._Guardar_cliente()).Equals("SI"))
                                {
                                this.TXT_ID_CLIENTE.Text  = _Sistema._Obtener_Instancia()._Cliente.Id_cliente ;
                                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Grabación satisfactoria", "Mensaje");

                                _Sistema._Obtener_Instancia()._Cliente.Id_cliente = this.TXT_ID_CLIENTE.Text;
                                }
                             else
                                 {
                                _Sistema._Obtener_Instancia()._Util._Call_mensaje(" Dni o Ruc ya existen", "Advertencia");
                                 }
                            }
                            
                        }
                        else
                        {
                            _Sistema._Obtener_Instancia()._Util._Call_mensaje(" Ruc con coincide con dni", "Advertencia");
                        }
                    }
                    else
                    {
                        if (this.TXT_DNI .Text .Trim ().Length ==8)
                    
                    {
                        if (this.DTP_FECHA_NACIMIENTO .Value >DateTime .Now )
                        {
                            _Sistema._Obtener_Instancia()._Util._Call_mensaje(" Corrija la fecha de nacimiento", "Advertencia");
                        }
                        else
                        {
                            if (Convert.ToString(_Sistema._Obtener_Instancia()._Cliente._Guardar_cliente()).Equals("SI"))
                            {
                            this.TXT_ID_CLIENTE.Text = _Sistema._Obtener_Instancia()._Cliente.Id_cliente;
                            _Sistema._Obtener_Instancia()._Util._Call_mensaje("Grabación satisfactoria", "Mensaje");

                            _Sistema._Obtener_Instancia()._Cliente.Id_cliente = this.TXT_ID_CLIENTE.Text;
                            }
                        else
                            {
                            _Sistema._Obtener_Instancia()._Util._Call_mensaje(" Dni o Ruc ya existen", "Advertencia");
                            }
                        }
                      }
                        
                    else
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje(" El dni debe tener 8 numeros", "Advertencia");
                    }
                   }
               }

               }
                catch (Exception ex)
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error"); 
                }
            }
            else
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Debe llenar los campos :"+_Sistema._Obtener_Instancia()._Util._get_cajas_vacias, "Mensaje");
            }
        }

        private void FRM_ALUMNO_Load(object sender, EventArgs e)
        {
            this.DTP_FECHA_NACIMIENTO.MaxDate = DateTime.Now;
        }

        private void BTN_NUEVO_Click(object sender, EventArgs e)
        {
            _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.TXT_APE_PATERNO, this.TXT_ID_CLIENTE, this.TXT_APE_PATERNO,
                                                              this.TXT_APE_MATERNO, this.TXT_NOMBRES, this.TXT_DIRECCION,
                                                              this.TXT_DNI, this.TXT_E_MAIL, this.TXT_TELEFONO,TXT_RUC );
        }

        private void mV_LABEL_ESPEJO1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
