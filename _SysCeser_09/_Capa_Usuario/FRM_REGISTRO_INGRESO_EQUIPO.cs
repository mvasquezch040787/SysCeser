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
    public partial class FRM_REGISTRO_INGRESO_EQUIPO : Form
    {
        public FRM_REGISTRO_INGRESO_EQUIPO()
        {
            InitializeComponent();
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

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FRM_CLIENTE _n_C = new FRM_CLIENTE();

            _n_C.ShowDialog();
        }

        private void FRM_REGISTRO_INGRESO_EQUIPO_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.txt_costo_reaparcion.Text = Convert.ToString(0);
            this.txt_costo_reaparcion.ReadOnly = true;
            try
            {
                this.DTP_FECHA_NACIMIENTO.MaxDate = DateTime.Now;

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

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            if (_Sistema._Obtener_Instancia()._Util._Call_mensaje_box("Esta seguro de guardar esta orden", "Mensaje"))
            {
                if (_Sistema._Obtener_Instancia()._Util._verificar_cajas(this.txt_cliente, this.txt_costo_reaparcion, this.txt_dni, this.txt_equipo,
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
                        _Sistema._Obtener_Instancia()._Orden.Fecha_ingreso = this.DTP_FECHA_NACIMIENTO.Value;
                        _Sistema._Obtener_Instancia()._Orden.Falla_reportada_cliente = this.txt_falla_reportada.Text.Trim();
                        _Sistema._Obtener_Instancia()._Orden.Equipo = this.txt_equipo.Text.Trim();
                        _Sistema._Obtener_Instancia()._Orden.Modelo_equpipo = this.txt_modelo.Text.Trim();
                        _Sistema._Obtener_Instancia()._Orden.Serie_equipo = this.txt_serie.Text.Trim();

                        _Sistema._Obtener_Instancia()._Orden.Tipo_equipo = (_Tipo_equipo)(_Sistema._Obtener_Instancia()._Tipo_equipo._Obtener_objeto());
                        _Sistema._Obtener_Instancia()._Orden.Marca = (_Marca)(_Sistema._Obtener_Instancia()._Marca._Obtener_objeto());
                        _Sistema._Obtener_Instancia()._Orden.Observaciones_equipo = this.txt_observaciones.Text.Trim();
                        _Sistema._Obtener_Instancia()._Orden.Accesorios_adicionsles_equipo = this.txt_accesorios.Text.Trim();
                        _Sistema._Obtener_Instancia()._Orden.Tipo_garantia = (_Tipo_garantia)(_Sistema._Obtener_Instancia()._Tipo_garantia._Obtener_objeto());
                        _Sistema._Obtener_Instancia()._Orden.Empelado = (_Empleado)(_Sistema._Obtener_Instancia()._Empleado._Obtener_objeto());
                        _Sistema._Obtener_Instancia()._Orden.Costo_reparacion = Convert.ToInt32(this.txt_costo_reaparcion.Text.Trim());
                        _Sistema._Obtener_Instancia()._Orden.Adelanto = Convert.ToDouble(this.txtadelanto.Text.Trim());

                        if (_Sistema._Obtener_Instancia()._Orden._Guardar_ingreso().Equals("SI"))
                        {
                            _Sistema._Obtener_Instancia()._Util._Call_mensaje("Grabacion satisafactoria", "Mensaje");
                            this.txt_id_orden.Text = _Sistema._Obtener_Instancia()._Orden.Id_orden;
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

        private void BTN_NUEVO_Click_1(object sender, EventArgs e)
        {
            _Sistema._Obtener_Instancia()._Util._Limpar_cajas(this.txt_accesorios, this.txt_cliente, this.txt_direccion, this.txt_equipo,
                                                                   this.txt_falla_reportada, this.txt_id_orden, this.txt_dni, this.txt_modelo, this.txt_accesorios);
        }
        // Dim REPORTE_F As New CR_FICHA_MATRICULA
        //REPORTE_F.SetDataSource(_SISTEMA._MATRICULA._PRINT_FICHA_MATRICULA(_SISTEMA._ALUMNO._PROPIEDAD_GLOBAL))
        //MDI_REPORTES.SHOW_MDI_REPORTES(SISTEMA_INCLAN, REPORTE_F)
        private void BTN_IMPRIMIR_Click(object sender, EventArgs e)
        {
            if (this.txt_id_orden.Text.Trim().Length > 0)
            {
                try
                {
                    CR_FORMATO_INGRESO Report = new CR_FORMATO_INGRESO();
                    Report.SetDataSource(_Sistema._Obtener_Instancia()._Orden._imprimir_orden_ingreso(this.txt_id_orden.Text.Trim()));

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

        private void btn_agregar_tipo_qeuipo_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_TIPO_EQUIPO _Te = new FRM_TIPO_EQUIPO();
                _Te.ShowDialog();
                this.FRM_REGISTRO_INGRESO_EQUIPO_Load(sender, e);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_agregar_marca_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_MARCA _m = new FRM_MARCA();
                _m.ShowDialog();
                this.FRM_REGISTRO_INGRESO_EQUIPO_Load(sender, e);
            }
            catch (Exception)
            {
                throw;
            }
            ;
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

        private void CBO_TIPO_EQUIPO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
