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
    public partial class BUSQUEDA_REPUESTO : Form
    {
        Boolean sw = false;
        public BUSQUEDA_REPUESTO()
        {
            InitializeComponent();
        }

        private void cbo_tipo_repuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mV_LABEL2_Click(object sender, EventArgs e)
        {

        }

        private void BUSQUEDA_REPUESTO_Load(object sender, EventArgs e)
        {
            try
            {
                cargar();

               ocultarColumnas();
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void ocultarColumnas()
        {
            this.GRID_REPUESTOS.Columns[0].Visible = false;
            this.GRID_REPUESTOS.Columns[1].Visible = false;
            this.GRID_REPUESTOS.Columns[6].Visible = false;
            this.GRID_REPUESTOS.Columns[7].Visible = false;
            this.GRID_REPUESTOS.Columns[8].Visible = false;
            this.GRID_REPUESTOS.Columns[11].Visible = false;
            this.GRID_REPUESTOS.Columns[12].Visible = false;

        }
        private void cargar()
        {
            DataTable t1 = _Sistema._Obtener_Instancia()._Marca._Listar();
            this.cbo_marca.DataSource = t1;
            this.cbo_marca.ValueMember = t1.Columns[0].ColumnName;
            this.cbo_marca.DisplayMember = t1.Columns[1].ColumnName;

            DataTable t2 = _Sistema._Obtener_Instancia()._Tipo_repuesto._Listar();
            this.cbo_tipo_repuesto.DataSource = t2;
            this.cbo_tipo_repuesto.ValueMember = t2.Columns[0].ColumnName;
            this.cbo_tipo_repuesto.DisplayMember = t2.Columns[1].ColumnName;

            DataTable _tabla = _Sistema._Obtener_Instancia()._Repuesto.Listar();
            this.GRID_REPUESTOS.DataSource = _tabla;
        }

        private void mV_BOTON1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable _tabla = _Sistema._Obtener_Instancia()._Repuesto.Listar_per(Convert.ToString(this.cbo_marca.SelectedValue).Trim(), Convert.ToInt32(this.cbo_tipo_repuesto.SelectedValue));
                this.GRID_REPUESTOS.DataSource = _tabla;

                ocultarColumnas();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        private void GRID_REPUESTOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.pb_repuesto.ImageLocation = Convert.ToString(this.GRID_REPUESTOS.CurrentRow.Cells[12].Value);
        }

        private void mV_BOTON2_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void txt_desc_TextChanged(object sender, EventArgs e)
        {
            DataTable _tabla = _Sistema._Obtener_Instancia()._Repuesto.Listar_desc(this.txt_desc.Text.Trim());
            this.GRID_REPUESTOS.DataSource = _tabla;
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (this.GRID_REPUESTOS.Rows.Count > 0)
            {
               _Sistema._Obtener_Instancia()._Repuesto.Id_repuesto= Convert.ToInt32(this.GRID_REPUESTOS.CurrentRow.Cells[0].Value);
                this.Close();
            }
        }
    }
}
