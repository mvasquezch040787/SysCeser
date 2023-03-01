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
    public partial class FRM_REGISTRO_REPARACIONES : Form
    {
        public FRM_REGISTRO_REPARACIONES()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            //SELECT     dbo.ORDENES.ID_ORDEN, dbo.ORDENES.FECHA_INGRESO_EQUIPO, dbo.ORDENES.FALLA_REPORTADA_CLIENTE, dbo.ORDENES.EQUIPO, 
            //          dbo.ORDENES.MODELO_EQUIPO, dbo.ORDENES.SERIE_EQUIPO, dbo.ORDENES.OBSERVACIONES_EQUIPO, dbo.ORDENES.ACCESORIOS_ADICIONALES_EQUIPO, 
            //          dbo.PERSONA.APELLIDO_PATERNO +' '+ dbo.PERSONA.APELLIDO_MATERNO + ' '+ dbo.PERSONA.NOMBRES AS 'CLIENTE', dbo.PERSONA.DNI, dbo.CLIENTE.RUC, 
            //          dbo.TIPO_GARANTIA.TIPO_GARANTIA, dbo.TIPO_EQUIPO.TIPO, dbo.ORDENES.COSTO_REPARACION, dbo.MARCA.MARCA

            try
            {
                if (this.txt_id_orden.Text.Trim().Length == 10)
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
                    this.txt_estado_orden.Text = Convert.ToString(_Fila[18]);

                }
                else
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje("El id orden debe tener 10 carcateres ej: ORD-000001", "Mensaje");
                }

            }

            catch (Exception)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("La orden "+ this.txt_id_orden .Text .Trim ()+" no existe","Mensaje");
            }
        }

        private void FRM_REGISTRO_REPARACIONES_Load(object sender, EventArgs e)
        {
            DataTable _tabla = _Sistema._Obtener_Instancia()._Servicio._Listar();
            this.cbo_servicios.DataSource = _tabla;
            this.cbo_servicios.ValueMember = _tabla.Columns[0].ColumnName;
            this.cbo_servicios.DisplayMember = _tabla.Columns[1].ColumnName;

            this.WindowState = FormWindowState.Maximized;
            try
            {
                System.Data.DataTable _Tabla = _Sistema._Obtener_Instancia()._Empleado._Listar_empleados_tecnicos();
                this.CBO_EMPLEADOS_TECNICOS.DataSource = _Tabla;
                this.CBO_EMPLEADOS_TECNICOS.ValueMember = _Tabla.Columns[0].ColumnName;
                this.CBO_EMPLEADOS_TECNICOS.DisplayMember = _Tabla.Columns[1].ColumnName;

                System.Data.DataTable _Tabla_B = _Sistema._Obtener_Instancia()._Estado_equipo._Listar();
                this.CBO_ESTADO_EQUIPO.DataSource = _Tabla_B;
                this.CBO_ESTADO_EQUIPO.ValueMember = _Tabla_B.Columns[0].ColumnName;
                this.CBO_ESTADO_EQUIPO.DisplayMember = _Tabla_B.Columns[1].ColumnName;
            }
            catch (Exception ex)
            {
                
               _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
            }
        }

        private void CBO_EMPLEADOS_TECNICOS_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void CBO_EMPLEADOS_TECNICOS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
              this.txt_id_empleado.Text = Convert.ToString(this.CBO_EMPLEADOS_TECNICOS.SelectedValue);
            }
            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
            }
          
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            if (this.txt_estado_orden .Text .Trim ().Equals("ORDEN ABIERTA"))
            {
                try
                {

                    _Sistema._Obtener_Instancia()._Estado_equipo.Id_estado_equipo = Convert.ToString(this.CBO_ESTADO_EQUIPO.SelectedValue);

                    _Sistema._Obtener_Instancia()._Orden.Id_orden = this.txt_id_orden.Text.Trim();
                    _Sistema._Obtener_Instancia()._Empleado.Id_empleado = this.txt_id_empleado.Text.Trim();

                    _Sistema._Obtener_Instancia()._Reparacion.Orden = (_Orden)_Sistema._Obtener_Instancia()._Orden._Obtener_objeto();
                    _Sistema._Obtener_Instancia()._Reparacion.Empleado = (_Empleado)_Sistema._Obtener_Instancia()._Empleado._Obtener_objeto();
                    _Sistema._Obtener_Instancia()._Reparacion.Falla_reportada_tecnico = this.txt_falla_reportada_tecnico.Text.Trim();
                    _Sistema._Obtener_Instancia()._Reparacion.Solucion_reportada = this.txt_solucion_reportada_tecnico.Text.Trim();
                    _Sistema._Obtener_Instancia()._Reparacion.Observaciones_reparacion = this.txt_observaciones_reparacion.Text.Trim();
                    _Sistema._Obtener_Instancia()._Reparacion.Estado_equipo = (_Estado_equipo)_Sistema._Obtener_Instancia()._Estado_equipo._Obtener_objeto();

                    if (this.txt_id_empleado.Text.Trim().Length == 10)
                    {
                        if (_Sistema._Obtener_Instancia()._Util._verificar_cajas(this.txt_id_empleado) == false)
                        {
                            _Sistema._Obtener_Instancia()._Util._Call_mensaje("Estos campos son obligatorios para el registro " + _Sistema._Obtener_Instancia()._Util._get_cajas_vacias, "Mensaje");
                        }
                        else
                        {
                            if (_Sistema._Obtener_Instancia()._Util._Call_mensaje_box("Esta seguro de realizar este registro", "Advertencia"))
                            {
                                if (_Sistema._Obtener_Instancia()._Reparacion._Guardar_reparacion().Equals("SI"))
                                {
                                    _Sistema._Obtener_Instancia()._Util._Call_mensaje("Grabacion satisfactoria", "Mensaje");
                                }
                            }
                            else
                            {
                                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Operacion cancelada", "Mensaje");
                            }

                        }
                    }
                    else
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje("El id de empleado no es correcto ej:EMP-000001", "Mensaje");
                    }

                }
                catch (Exception ex)
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                }
            }
            else
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("La orden " + this.txt_id_orden.Text.Trim() + " ya está cerrrada , no se puede registrar nuevamnete","Mensaje");
            }
            }
           

        private void BTN_NUEVO_Click(object sender, EventArgs e)
        {
            _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.txt_id_orden, this.txt_marca_equipo, this.txt_id_empleado,
                                                                  this.txt_modelo, this.txt_observaciones, this.txt_observaciones_reparacion,
                                                                  this.txt_ruc, this.txt_serie, this.txt_solucion_reportada_tecnico,
                                                                  this.txt_tipo_equipo, this.txt_tipo_garantia, this.txt_fecha_ingreso_equipo,
                                                                  this.txt_dni, this.txt_id_orden, this.txt_equipo, this.txt_costo_inicial,
                                                                  this.txt_direccion, this.txt_cliente, this.txt_falla_reportada);
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            if (_Sistema ._Obtener_Instancia ()._Util ._Call_mensaje_box ("Esta seguro de cancelar los datos de registro tecnico","Mensaje"))
            {
                _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.txt_id_empleado, this.txt_id_empleado, this.txt_falla_reportada_tecnico,
                                                                      this.txt_solucion_reportada_tecnico, this.txt_observaciones_reparacion);
            }
            else
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Operacion cancelada", "Mensaje");
            }
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_IMPRIMIR_Click(object sender, EventArgs e)
        {
            try
            {
                CR_FORMATO_INFORME_TECNICO  Report = new CR_FORMATO_INFORME_TECNICO();
                    Report.SetDataSource(_Sistema._Obtener_Instancia()._Reparacion ._Imprimir_informe_reparacion (this.txt_id_orden.Text.Trim()));

                    FRM_MDI_IMPRESIONES dmi_o = new FRM_MDI_IMPRESIONES();
                    dmi_o.MDI_SHOW(Report);
            }
            catch (Exception ex)
            {
                
                 _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message , "Mensaje");
            }
            }

        private void mV_BOTON1_Click(object sender, EventArgs e)
        {
            BUSQUEDA_REPUESTO FRM_BR = new BUSQUEDA_REPUESTO();
            FRM_BR.ShowDialog(this);


            //            SELECT ID_REPUESTO,ID_TIPO,MARCA.MARCA,TIPO_REPUESTO.DESCRIPCION AS [TIPO DE REPUESTO],
            //NOMBRE AS DESCRIPCION,
            //PRECIO_VENTA,PRECIO_COMPRA,STOCK_ACTUAL,STOCKMIN,MODELO,
            //SERIE,REPUESTOS.ID_MARCA,REPUESTOS.IMG

            DataRow _fila = _Sistema._Obtener_Instancia()._Repuesto.Get_Repuesto(_Sistema._Obtener_Instancia()._Repuesto.Id_repuesto);
            this.txt_observaciones_reparacion.Text = this.txt_observaciones_reparacion.Text.Trim() + _Sistema._Obtener_Instancia()._Repuesto.Id_repuesto + " - " + Convert.ToString(_fila[4]);

        }

        private void btn_agregar_tipo_qeuipo_Click(object sender, EventArgs e)
        {
           this.txt_solucion_reportada_tecnico.Text=this.txt_solucion_reportada_tecnico.Text+ "- "+this.cbo_servicios.Text;
        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }
        }
    
}
