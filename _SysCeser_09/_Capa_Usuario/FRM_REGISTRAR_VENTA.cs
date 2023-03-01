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
    public partial class FRM_REGISTRAR_VENTA : Form
    {
        public FRM_REGISTRAR_VENTA()
        {
            InitializeComponent();
        }

        private void mV_BOTON1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_id_orden.Text.Trim().Length == 10)
                {
                    System.Data.DataRow _Fila1 = _Sistema._Obtener_Instancia()._Orden._Obtener_fila(this.txt_id_orden.Text.Trim());

                    _Sistema._Obtener_Instancia()._Cliente.Id_cliente = (Convert.ToString(_Fila1[19])).Trim();
                    this.txt_cliente.Text = Convert.ToString(_Fila1[8]);

                    double precio1 = Convert.ToDouble(_Fila1[13]);
                    this.txt_costo_ref.Text = String.Format("{0:0.00}", precio1);

                    System.Data.DataRow _Fila2 = _Sistema._Obtener_Instancia()._Pago_referencial._Obtener_fila(this.txt_id_orden.Text.Trim());

                    double precio2 = Convert.ToDouble(_Fila2[2]);
                    this.txt_a_cuenta.Text = String.Format("{0:0.00}", precio2);


                    System.Data.DataRow _Fila3 = _Sistema._Obtener_Instancia()._Reparacion._Obtener_reparacion(this.txt_id_orden.Text.Trim());
                    this.txt_servicio.Text = Convert.ToString(_Fila3[5]);
                    this.txt_repuesto.Text = Convert.ToString(_Fila3[6]);
                }
                else
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje("El id orden debe tener 10 carcateres ej: ORD-000001", "Mensaje");
                }

            }

            catch (Exception ex)
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("La orden " + this.txt_id_orden.Text.Trim() + " no existe o no tiene pago referencial", "Mensaje");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.gb_servicios.Enabled = false;
            this.gb_repuestos.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.gb_servicios.Enabled = true;
            this.gb_repuestos.Enabled = false;
        }

        private void FRM_REGISTRAR_VENTA_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.cbo_comprobante.SelectedIndex = 0;
            deshabilita_grupos();
            this.DTP_FECHA.MaxDate = DateTime.Now;
            try
            {
                DataTable _tabla = _Sistema._Obtener_Instancia()._Servicio._Listar();
                this.cbo_servicios.DataSource = _tabla;
                this.cbo_servicios.ValueMember = _tabla.Columns[0].ColumnName;
                this.cbo_servicios.DisplayMember = _tabla.Columns[1].ColumnName;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private void cbo_servicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbo_servicios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DataRow _fila = _Sistema._Obtener_Instancia()._Servicio._Obtener_fila(Convert.ToInt32(this.cbo_servicios.SelectedValue));
                double precio = Convert.ToDouble(_fila[2]);
                this.txt_precio_servicio.Text = String.Format("{0:0.00}", precio);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mV_BOTON2_Click(object sender, EventArgs e)
        {
            BUSQUEDA_REPUESTO FRM_BR = new BUSQUEDA_REPUESTO();
            FRM_BR.ShowDialog(this);


//            SELECT ID_REPUESTO,ID_TIPO,MARCA.MARCA,TIPO_REPUESTO.DESCRIPCION AS [TIPO DE REPUESTO],
//NOMBRE AS DESCRIPCION,
//PRECIO_VENTA,PRECIO_COMPRA,STOCK_ACTUAL,STOCKMIN,MODELO,
//SERIE,REPUESTOS.ID_MARCA,REPUESTOS.IMG

            DataRow _fila = _Sistema._Obtener_Instancia()._Repuesto.Get_Repuesto(_Sistema._Obtener_Instancia()._Repuesto.Id_repuesto);
            this.txt_marca.Text = Convert.ToString(_fila[3]);
            this.txt_tipo_repuesto.Text = Convert.ToString(_fila[2]);
            this.txt_descripcion.Text = Convert.ToString(_fila[4]);

            double precio = Convert.ToDouble(_fila[5]);
            this.txt_precio_repuesto.Text= String.Format("{0:0.00}", precio);
            this.txt_stock_actual.Text = Convert.ToString(_fila[7]);
            this.txt_stock_minimo.Text = Convert.ToString(_fila[8]);
            this.txt_modelo.Text =Convert.ToString(_fila[9]);
            this.txt_serie.Text = Convert.ToString(_fila[10]);

        }
        private void deshabilita_grupos()
        {
            this.gb_repuestos.Enabled = false;
            this.gb_servicios.Enabled = false;
        }

        private void gb_repuestos_Enter(object sender, EventArgs e)
        {

        }

        private void mV_BOTON3_Click(object sender, EventArgs e)
        {
            if (!this.txt_descripcion.Text.Trim().Equals(""))
            {
                if (Convert.ToInt32(this.nud_cantidad_repuesto.Value) > Convert.ToInt32(this.txt_stock_actual.Text))
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje("La Cantidad no Debe Superar Al Stock Disponible", "Advertencia");
                }
                else
                {
                    if (comprobar_coincidencia(this.txt_descripcion.Text.Trim()))
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje("Esta Descripcion ya ha sido asignada", "Mensaje");
                    }
                    else
                    {
                        DataGridViewRow row = (DataGridViewRow)this.dgv_detalle_venta.Rows[0].Clone();
                        row.Cells[0].Value = _Sistema._Obtener_Instancia()._Repuesto.Id_repuesto;
                        row.Cells[1].Value = this.txt_descripcion.Text.Trim();
                        row.Cells[2].Value = String.Format("{0:0.00}", Convert.ToDouble(this.txt_precio_repuesto.Text.Trim()));
                        row.Cells[3].Value = this.nud_cantidad_repuesto.Value;
                        row.Cells[4].Value = String.Format("{0:0.00}", (Convert.ToDouble(this.txt_precio_repuesto.Text.Trim()) * Convert.ToDouble(this.nud_cantidad_repuesto.Value)));
                        row.Cells[5].Value = 1;
                        this.dgv_detalle_venta.Rows.Add(row);

                        Calcular_valores();
                    }
                }
            }
            
                
            
            
            Limpia();
        }

        private void btn_agregar_tipo_qeuipo_Click(object sender, EventArgs e)
        {
            if (comprobar_coincidencia(this.cbo_servicios.Text.Trim()))
            {
                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Esta Descripcion ya ha sido asignada", "Mensaje");
            }
            else
            {
                DataGridViewRow row = (DataGridViewRow)this.dgv_detalle_venta.Rows[0].Clone();
                row.Cells[0].Value = this.cbo_servicios.SelectedValue;
                row.Cells[1].Value = this.cbo_servicios.Text;
                row.Cells[2].Value = String.Format("{0:0.00}", Convert.ToDouble(this.txt_precio_servicio.Text.Trim()));
                row.Cells[3].Value = this.nud_catidad_servicio.Value;
                row.Cells[4].Value = String.Format("{0:0.00}", (Convert.ToDouble(this.txt_precio_servicio.Text.Trim()) * Convert.ToDouble(this.nud_catidad_servicio.Value)));
                row.Cells[5].Value = 0;
                this.dgv_detalle_venta.Rows.Add(row);

                Calcular_valores(); 
            }
            Limpia();

        }
        private bool comprobar_coincidencia(string descripcion)
        {
            bool sw = false;
            if (this.dgv_detalle_venta.Rows.Count > 1)
            {
                for (int i = 0; i < this.dgv_detalle_venta.Rows.Count-1; i++)
                {
                    if ((Convert.ToString(this.dgv_detalle_venta.Rows[i].Cells[1].Value)).Trim().Equals(descripcion.Trim()))
                    {
                        sw = true;
                    }
                    else
                    {
                        sw = false;
                    }
                }
            }
            else
            {

            }

            return sw;
        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void mV_BOTON4_Click(object sender, EventArgs e)
        {
            if (this.dgv_detalle_venta.Rows.Count > 1)
            {
                int i = this.dgv_detalle_venta.CurrentRow.Index;
                this.dgv_detalle_venta.Rows.RemoveAt(i);

                Calcular_valores();
            }
            
        }
        private void Calcular_valores()
        {
            DataRow _fila = _Sistema._Obtener_Instancia()._Igv._Obtener_fila();
            double igv = Convert.ToDouble(_fila[1]);
          
            double s_subt =s_subtotales();
            double monto_igv = 0.0;
            double monto_total = 0.0;

            switch (this.cbo_comprobante.SelectedIndex)
            {
                case 0:
                    this.txt_monto.Text = String.Format("{0:0.00}", s_subt);
                    this.txt_igv.Text = String.Format("{0:0.00}", (0.0));
                    monto_total = s_subt + monto_igv;
                    this.txt_total.Text = String.Format("{0:0.00}", (monto_total));
                    break;
                case 1:
                    this.txt_monto.Text = String.Format("{0:0.00}", s_subt);
                    monto_igv = s_subt * igv;
                    this.txt_igv.Text = String.Format("{0:0.00}", (monto_igv));
                    monto_total = s_subt + monto_igv;
                    this.txt_total.Text = String.Format("{0:0.00}", (monto_total));
                    break;
                default:
                    break;
            }
        }
        private double s_subtotales()
        {
            double monto = 0.0;
            for (int i = 0; i < this.dgv_detalle_venta.Rows.Count; i++)
            {
                monto += Convert.ToDouble(this.dgv_detalle_venta.Rows[i].Cells[4].Value);
            }
            return monto;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (_Sistema._Obtener_Instancia()._Util._Call_mensaje_box("Esta seguro de Guardar La Venta", "Mensaje"))
            {
                if (this.dgv_detalle_venta.Rows.Count>1)
                {
                    _Capa_Negocios._Empleado em = new _Capa_Negocios._Empleado();
                    em.Id_empleado = _Sistema._Obtener_Instancia()._Empleado.Id_empleado.Trim();

                    _Capa_Negocios._Cliente cl = new _Capa_Negocios._Cliente();
                    cl.Id_cliente = _Sistema._Obtener_Instancia()._Cliente.Id_cliente.Trim();

                    _Capa_Negocios._Venta ven = new _Capa_Negocios._Venta();

                    ven.Cliente = cl;
                    ven.Empleado = em;

                    ven.Fecha_venta = this.DTP_FECHA.Value;
                    ven.Tipo_comprobante = this.cbo_comprobante.SelectedIndex;

                    if (_Venta._Guardar_Venta(ven,this.txt_id_orden.Text.Trim()))
                    {
                        for (int i = 0; i < dgv_detalle_venta.Rows.Count-1; i++)
                        {
                            _Detalle_Venta dv = new _Detalle_Venta();

                            _Servicio s = new _Servicio();
                            _Repuesto r = new _Repuesto();

                            if (Convert.ToInt32(this.dgv_detalle_venta.Rows[i].Cells[5].Value)==0)
                            {
                                s.Idservicio = Convert.ToInt32(this.dgv_detalle_venta.Rows[i].Cells[0].Value);

                            }
                            else
                            {
                                r.Id_repuesto = Convert.ToInt32(this.dgv_detalle_venta.Rows[i].Cells[0].Value);
                            }
                            dv.Servicio = s;
                            dv.Repuesto = r;
                            dv.Cantidad=Convert.ToInt32(this.dgv_detalle_venta.Rows[i].Cells[3].Value);

                            if ( _Detalle_Venta._Guardar_Detalle_Venta(dv))
                            {
                                _Sistema._Obtener_Instancia()._Util._Call_mensaje("Grabacion Satisfactoria", "Mensaje");
                            }
                        }
                    }
                    else
                    {
                        _Sistema._Obtener_Instancia()._Util._Call_mensaje("Error en el Registro", "Mensaje");
                    }



                }
                else
                {
                    _Sistema._Obtener_Instancia()._Util._Call_mensaje("No existe(n) elemento(s) para Guardar La Venta", "Mensaje");
                }
            }
        }

        private void cbo_comprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calcular_valores();
        }
        private void Limpia()
        {
            this.txt_descripcion.Text = "";
            this.txt_marca.Text = "";
            this.txt_modelo.Text = "";
            this.txt_serie.Text = "";
            this.txt_tipo_repuesto.Text = "";
            this.txt_precio_repuesto.Text = "";
            this.txt_modelo.Text = "";
            this.txt_stock_actual.Text = "";
            this.txt_stock_minimo.Text = "";
        }
    }
}
