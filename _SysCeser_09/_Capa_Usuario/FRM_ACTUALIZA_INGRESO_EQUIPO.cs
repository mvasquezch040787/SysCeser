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
    public partial class FRM_ACTUALIZA_INGRESO_EQUIPO : Form
    {
        public FRM_ACTUALIZA_INGRESO_EQUIPO()
        {
            InitializeComponent();
        }

        private void FRM_ACTUALIZA_INGRESO_EQUIPO_Load(object sender, EventArgs e)
        {
            this.txt_costo_reaparcion.Text = Convert.ToString(0);
            this.txt_costo_reaparcion.ReadOnly = true;
            try
            {

                System.Data.DataTable _Tabla_a = _Sistema._Obtener_Instancia()._Tipo_garantia._Listar();

                this.CBO_TIPO_GARANTIA.DataSource = _Tabla_a;
                this.CBO_TIPO_GARANTIA.ValueMember = _Tabla_a.Columns[0].ColumnName;
                this.CBO_TIPO_GARANTIA.DisplayMember = _Tabla_a.Columns[1].ColumnName;

                System.Data.DataTable _Tabla_b = _Sistema._Obtener_Instancia()._Marca._Listar();
                this.CBO_MARCA.DataSource = _Tabla_b;
                this.CBO_MARCA.ValueMember = _Tabla_b.Columns[0].ColumnName;
                this.CBO_MARCA.DisplayMember = _Tabla_b.Columns[1].ColumnName;

                System.Data.DataTable _Tabla_c = _Sistema._Obtener_Instancia()._Tipo_equipo._Listar();
                this.CBO_TIPO_EQUIPO.DataSource = _Tabla_c;
                this.CBO_TIPO_EQUIPO.ValueMember = _Tabla_c.Columns[0].ColumnName;
                this.CBO_TIPO_EQUIPO.DisplayMember = _Tabla_c.Columns[1].ColumnName;
            }
            catch (Exception ex)
            {

                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //SELECT     dbo.ORDENES.ID_ORDEN, dbo.ORDENES.FECHA_INGRESO_EQUIPO, dbo.ORDENES.FALLA_REPORTADA_CLIENTE, dbo.ORDENES.EQUIPO, 
            //              dbo.ORDENES.MODELO_EQUIPO, dbo.ORDENES.SERIE_EQUIPO, dbo.ORDENES.OBSERVACIONES_EQUIPO, dbo.ORDENES.ACCESORIOS_ADICIONALES_EQUIPO, 
            //              dbo.PERSONA.APELLIDO_PATERNO + ' ' + dbo.PERSONA.APELLIDO_MATERNO + ' ' + dbo.PERSONA.NOMBRES AS 'CLIENTE', dbo.PERSONA.DNI, dbo.CLIENTE.RUC, 
            //              dbo.TIPO_GARANTIA.TIPO_GARANTIA, dbo.TIPO_EQUIPO.TIPO, dbo.ORDENES.COSTO_REPARACION, dbo.MARCA.MARCA, dbo.PERSONA.DIRECCION, 
            //              dbo.ESTADO_EQUIPO.ID_ESTADO_EQUIPO, dbo.ESTADO_EQUIPO.ESTADO_EQUIPO

            try
            {
                if (this.txt_id_orden.Text.Trim().Length == 10)
                {
                    System.Data.DataRow _Fila = _Sistema._Obtener_Instancia()._Orden._Obtener_fila(this.txt_id_orden.Text.Trim());

                    _Sistema._Obtener_Instancia()._Cliente.Id_cliente = Convert.ToString(_Sistema._Obtener_Instancia()._Orden._Obtener_fila(this .txt_id_orden .Text .Trim ())[19]);

                    this.txt_falla_reportada.Text = Convert.ToString(_Fila[2]);
                    this.txt_equipo.Text = Convert.ToString(_Fila[3]);
                    this.txt_modelo.Text = Convert.ToString(_Fila[4]);
                    this.txt_serie.Text = Convert.ToString(_Fila[5]);
                    this.txt_observaciones.Text = Convert.ToString(_Fila[6]);
                    this.txt_accesorios.Text = Convert.ToString(_Fila[7]);
                    this.txt_cliente.Text = Convert.ToString(_Fila[8]);
                    this.txt_dni.Text = Convert.ToString(_Fila[9]);
                    this.txt_ruc.Text = Convert.ToString(_Fila[10]);
                    this.txt_costo_reaparcion .Text = Convert.ToString(_Fila[13]);
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
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("La orden " + this.txt_id_orden.Text.Trim() + " está pendiente", "Mensaje");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_BUSQUEDA_CLIENTE _b_C = new FRM_BUSQUEDA_CLIENTE();

                _b_C.ShowDialog();

                System.Data.DataRow _Fila = _Sistema._Obtener_Instancia()._Cliente._Obtener(_Sistema._Obtener_Instancia()._Cliente.Id_cliente);

                this.txt_cliente.Text = Convert.ToString(_Fila[1]) + " " + Convert.ToString(_Fila[2]) + " " + Convert.ToString(_Fila[3]);
                this.txt_direccion.Text = Convert.ToString(_Fila[4]);
                this.txt_dni.Text = Convert.ToString(_Fila[5]);
                this.txt_ruc.Text = Convert.ToString(_Fila[12]);
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

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            //"UPDATE [ORDENES] SET ID_CLIENTE=@ID_CLIENTE," +
            //         "FALLA_REPORTADA_CLIENTE=@FALLA_REPORTADA_CLIENTE,EQUIPO=@EQUIPO,MODELO_EQUIPO=@MODELO_EQUIPO,SERIE_EQUIPO=@SERIE_EQUIPO," +
            //         "ID_TIPO_EQUIPO=@ID_TIPO_EQUIPO,ID_MARCA=@ID_MARCA,OBSERVACIONES_EQUIPO=@OBSERVACIONES_EQUIPO,ACCESORIOS_ADICIONALES_EQUIPO=@ACCESORIOS_ADICIONALES_EQUIPO," +
            //         "ID_TIPO_GARANTIA=@ID_TIPO_GARANTIA,COSTO_REPARACION=@COSTO_REPARACION WHERE ID_ORDEN=@ID_ORDEN");
            if (this.txt_estado_orden .Text .Trim ().Equals("ORDEN ABIERTA"))
            {
               if (_Sistema._Obtener_Instancia()._Util._Call_mensaje_box("Esta seguro de guardar esta orden", "Mensaje"))
            {
                if (_Sistema._Obtener_Instancia()._Util._verificar_cajas(this.txt_cliente,this.txt_id_orden , this.txt_costo_reaparcion, this.txt_dni, this.txt_equipo,
                                                                        this.txt_modelo, this.txt_serie, this.txt_direccion) == false)
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje("No dejar los campos " + _Sistema._Obtener_Instancia()._Util._get_cajas_vacias + " vacios", "Advertencia");
                }
                else
                {
                    try
                    {
                        _Sistema._Obtener_Instancia()._Tipo_equipo.Id_tipo_equipo = Convert.ToString(this.CBO_TIPO_EQUIPO.SelectedValue);
                        _Sistema._Obtener_Instancia()._Tipo_garantia.Id_tipo_garantia = Convert.ToString(this.CBO_TIPO_GARANTIA.SelectedValue);
                        _Sistema._Obtener_Instancia()._Marca.Id_marca = Convert.ToString(this.CBO_MARCA.SelectedValue);

                        _Sistema._Obtener_Instancia()._Orden.Cliente = (_Cliente)(_Sistema._Obtener_Instancia()._Cliente._Obtener_objeto());
                        _Sistema._Obtener_Instancia()._Orden.Falla_reportada_cliente = this.txt_falla_reportada.Text.Trim();
                        _Sistema._Obtener_Instancia()._Orden.Equipo = this.txt_equipo.Text.Trim();
                        _Sistema._Obtener_Instancia()._Orden.Modelo_equpipo = this.txt_modelo.Text.Trim();
                        _Sistema._Obtener_Instancia()._Orden.Serie_equipo = this.txt_serie.Text.Trim();

                        _Sistema._Obtener_Instancia()._Orden.Tipo_equipo = (_Tipo_equipo)(_Sistema._Obtener_Instancia()._Tipo_equipo._Obtener_objeto());
                        _Sistema._Obtener_Instancia()._Orden.Marca = (_Marca)(_Sistema._Obtener_Instancia()._Marca._Obtener_objeto());
                        _Sistema._Obtener_Instancia()._Orden.Observaciones_equipo = this.txt_observaciones.Text.Trim();
                        _Sistema._Obtener_Instancia()._Orden.Accesorios_adicionsles_equipo = this.txt_accesorios.Text.Trim();
                        _Sistema._Obtener_Instancia()._Orden.Tipo_garantia = (_Tipo_garantia)(_Sistema._Obtener_Instancia()._Tipo_garantia._Obtener_objeto());
                        _Sistema._Obtener_Instancia()._Orden.Costo_reparacion = Convert.ToInt32(this.txt_costo_reaparcion.Text.Trim());

                        if (_Sistema._Obtener_Instancia()._Orden._Actualizar_ingreso_equipo(this.txt_id_orden .Text .Trim ()))
                        {
                            _Sistema._Obtener_Instancia()._Util._Call_mensaje("Actualizacion satisfactoria", "Mensaje");
                        }
                        else
                        {
                            _Sistema._Obtener_Instancia()._Util._Call_mensaje("La actualizacion fracazo", "Mensaje");
                        }
                    }
                    catch (Exception ex)
                    {

                        _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
                    }
                }
            }
            else
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Operacion anulada por el usuario", "Mensaje");
            }
        }
            else
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("La orden "+this .txt_id_orden .Text .Trim ()+ " no puede ser actualizada por que ya esta cerrada", "Mensaje");
            }
            }

        private void CBO_TIPO_GARANTIA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (this.CBO_TIPO_GARANTIA.SelectedIndex)
            {
                case 0: this.txt_costo_reaparcion.Text = Convert.ToString(0); this.txt_costo_reaparcion.ReadOnly = true; break;
                case 1: this.txt_costo_reaparcion.Text = ""; this.txt_costo_reaparcion.ReadOnly = false; break;
                default: this.txt_costo_reaparcion.Text = Convert.ToString(0); this.txt_costo_reaparcion.ReadOnly = true; break;
            }
        }
        }
     
    
}
