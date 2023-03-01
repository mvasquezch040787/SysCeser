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
    public partial class FRM_REGISTRO_SALIDA_EQUIPO : Form
    {
        public FRM_REGISTRO_SALIDA_EQUIPO()
        {
            InitializeComponent();
        }

        private void FRM_REGISTRO_SALIDA_EQUIPO_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            System.Data.DataTable _Tabla_B = _Sistema._Obtener_Instancia()._Estado_equipo._Listar();
            this.CBO_ESTADO_EQUIPO.DataSource = _Tabla_B;
            this.CBO_ESTADO_EQUIPO.ValueMember = _Tabla_B.Columns[0].ColumnName;
            this.CBO_ESTADO_EQUIPO.DisplayMember = _Tabla_B.Columns[1].ColumnName;

            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.txt_id_orden, this.txt_empleado, this.txt_area, this.txt_falla_reportada_tecnico,
                                                                this.txt_fecha_reparacion, this.txt_observacion_reparacion, this.txt_solucion_reportada_tecnico);
        //SELECT     dbo.ORDENES.ID_ORDEN, dbo.ORDENES.FECHA_INGRESO_EQUIPO, dbo.ORDENES.FALLA_REPORTADA_CLIENTE, dbo.ORDENES.EQUIPO, 
        //              dbo.ORDENES.MODELO_EQUIPO, dbo.ORDENES.SERIE_EQUIPO, dbo.ORDENES.OBSERVACIONES_EQUIPO, dbo.ORDENES.ACCESORIOS_ADICIONALES_EQUIPO, 
        //              dbo.PERSONA.APELLIDO_PATERNO + ' ' + dbo.PERSONA.APELLIDO_MATERNO + ' ' + dbo.PERSONA.NOMBRES AS 'CLIENTE', dbo.PERSONA.DNI, dbo.CLIENTE.RUC, 
        //              dbo.TIPO_GARANTIA.TIPO_GARANTIA, dbo.TIPO_EQUIPO.TIPO, dbo.ORDENES.COSTO_REPARACION, dbo.MARCA.MARCA, dbo.PERSONA.DIRECCION, 
        //              dbo.ESTADO_EQUIPO.ID_ESTADO_EQUIPO, dbo.ESTADO_EQUIPO.ESTADO_EQUIPO
          
            try
            {
                if(this.txt_id_orden .Text .Trim ().Length ==10)
                {
                    System.Data.DataRow _Fila = _Sistema._Obtener_Instancia()._Orden._Obtener_fila(this.txt_id_orden.Text.Trim());

                    this.txt_fecha_ingreso_equipo.Text = Convert.ToString(_Fila[1]);
                    this.txt_falla_reportada.Text = Convert.ToString(_Fila[2]);
                    this.txt_equipo.Text = Convert.ToString(_Fila[3]);
                    this.txt_modelo.Text = Convert.ToString(_Fila[4]);
                    this.txt_serie.Text = Convert.ToString(_Fila[5]);
                    this.txt_observaciones.Text = Convert.ToString(_Fila[6]);
                    this.txt_accesorios.Text = Convert.ToString(_Fila[7]);
                    this.txt_cliente.Text = Convert.ToString(_Fila[8]);
                    this.txt_dni.Text = Convert.ToString(_Fila[9]);
                    this.txt_ruc.Text = Convert.ToString(_Fila[10]);
                    this.txt_tipo_garantia.Text = Convert.ToString(_Fila[11]);
                    this.txt_tipo_equipo.Text = Convert.ToString(_Fila[12]);
                    this.txt_costo_inicial.Text = Convert.ToString(_Fila[13]);
                    this.txt_marca_equipo.Text = Convert.ToString(_Fila[14]);
                    this.txt_direccion.Text = Convert.ToString(_Fila[15]);
                    _Sistema ._Obtener_Instancia ()._Estado_equipo .Id_estado_equipo =Convert .ToString (_Fila [16]);
                    this.txt_estado_equipo.Text = Convert.ToString(_Fila[17]);
                    this .txt_estado_orden.Text =Convert .ToString(_Fila [18]);

                    _Fila = null;

                    //if (_Sistema ._Obtener_Instancia ()._Estado_equipo .Id_estado_equipo .Trim ().Equals("ES-01"))
                    //{
                        
                    //}
                    //else
                    //{
                    _Fila = _Sistema._Obtener_Instancia()._Reparacion._Obtener_reparacion(this.txt_id_orden.Text.Trim());
    
                    this.txt_empleado.Text = Convert.ToString(_Fila[1]);
                    this.txt_fecha_reparacion.Text = Convert.ToString(_Fila[3]);
                    this.txt_area.Text = Convert.ToString(_Fila[7]);
                    this.txt_falla_reportada_tecnico.Text = Convert.ToString(_Fila[4]);
                    this.txt_solucion_reportada_tecnico.Text = Convert.ToString(_Fila[5]);
                    this.txt_observacion_reparacion.Text = Convert.ToString(_Fila[6]);
                    //}
                   
                    //SELECT     dbo.REPARACIONES.ID_REPARACION, dbo.PERSONA.APELLIDO_PATERNO +' '+ dbo.PERSONA.APELLIDO_MATERNO + ' '+ dbo.PERSONA.NOMBRES AS 'EMPLEADO', 
                    //            dbo.EMPLEADO.ID_EMPLEADO, dbo.REPARACIONES.FECHA_REPARACION, dbo.REPARACIONES.FALLA_REPORTADA_TECNICO, 
                    //            dbo.REPARACIONES.SOLUCION_REPORTADA_TECNICO, dbo.REPARACIONES.OBSERVACIONES_REPARACION_EQUIPO, dbo.AREA.AREA

                   
                 }
                else
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje("El id orden debe tener 10 carcateres ej: ORD-000001", "Mensaje");
                }
                
            }
               
            catch (Exception)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("La orden "+this.txt_id_orden .Text .Trim ()+" está pendiente", "Mensaje");
            }
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            if (this.txt_id_orden .Text .Trim ().Length <10)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("El id orden debe tener 10 carcateres ej: ORD-000001", "Mensaje");
            }
            else
            {
                try
                {
                    if (this.txt_estado_orden.Text.Trim().Equals("ORDEN ABIERTA"))
                    {
                        if (_Sistema._Obtener_Instancia()._Util._verificar_cajas(this.txt_costo_final) == false)
                        {
                            _Sistema._Obtener_Instancia()._Util._Call_mensaje("Debe asignar el costo final", "Mensaje");
                        }
                        else
                        {
                            if (_Sistema._Obtener_Instancia()._Estado_equipo.Id_estado_equipo.Trim().Equals("ES-02"))
                            {
                                _Sistema._Obtener_Instancia()._Estado_equipo.Id_estado_equipo = Convert.ToString(this.CBO_ESTADO_EQUIPO.SelectedValue);
                            }
                            _Sistema._Obtener_Instancia()._Orden.Fecha_salida = DateTime.Now;
                            _Sistema._Obtener_Instancia()._Orden.Estado_equipo = (_Estado_equipo)_Sistema._Obtener_Instancia()._Estado_equipo._Obtener_objeto();
                            _Sistema._Obtener_Instancia()._Orden.Costo_reparacion = Convert.ToInt32(this.txt_costo_final.Text.Trim());

                            if (_Sistema._Obtener_Instancia()._Orden._Guardar_salida(this.txt_id_orden.Text.Trim()))
                            {
                                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Grabacion satisfactoria", "Mensaje");
                            }
                            else
                            {
                                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Grabacion erronea", "Mensaje");
                            }
                        }
                    }
                    else
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje("Esta Orden " + this.txt_id_orden.Text.Trim() + " ya esta cerrada no se puede registrar la salida nuevamente", "Mensaje");
                    }
                }
                catch (Exception ex)
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                }
            }
            
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_IMPRIMIR_Click(object sender, EventArgs e)
        {
            if (this.txt_id_orden.Text.Trim().Length > 0)
            {
                try
                {
                    CR_FORMATO_SALIDA Report = new CR_FORMATO_SALIDA();
                    Report.SetDataSource(_Sistema._Obtener_Instancia()._Orden._imprimir_orden_salida(this.txt_id_orden.Text.Trim()));

                    FRM_MDI_IMPRESIONES dmi_o = new FRM_MDI_IMPRESIONES();
                    dmi_o.MDI_SHOW(Report);

                }
                catch (Exception ex)
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                }

            }
            else
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Debe guardar la orden", "Mensaje");
            }
        }

        private void mV_LABEL8_Click(object sender, EventArgs e)
        {

        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            if (_Sistema ._Obtener_Instancia ()._Util ._Call_mensaje_box ("Esta seguro de cancelar esta operación","Advertencia"))
            {
                _Sistema._Obtener_Instancia()._Util._Limpar_cajas(  this.txt_id_orden, this.txt_id_orden, this.txt_accesorios, this.txt_area,
                                                                    this.txt_cliente, this.txt_costo_final, this.txt_costo_inicial, this.txt_direccion,
                                                                    this.txt_dni, this.txt_empleado, this.txt_equipo, this.txt_estado_equipo,
                                                                    this.txt_estado_orden, this.txt_falla_reportada, this.txt_falla_reportada_tecnico,
                                                                    this.txt_fecha_ingreso_equipo, this.txt_fecha_reparacion, this.txt_id_orden,
                                                                    this.txt_marca_equipo, this.txt_modelo, this.txt_observacion_reparacion,
                                                                    this.txt_observaciones, this.txt_ruc, this.txt_serie, this.txt_solucion_reportada_tecnico,
                                                                    this.txt_tipo_equipo, this.txt_tipo_garantia);
            }
        }
    }
}
