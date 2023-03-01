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
    public partial class FRM_BUSCA_CARGO : Form
    {
        public FRM_BUSCA_CARGO()
        {
            InitializeComponent();
        }

        private void BTN_NUEVO_Click(object sender, EventArgs e)
        {
            FRM_CARGO _c = new FRM_CARGO();
            _c.Show();
        }

        private void GRID_CARGO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _Sistema._Obtener_Instancia()._Cargo.Id_cargo = Convert.ToString(this.GRID_CARGO.CurrentRow.Cells[0].Value );
            FRM_ACTUALIZA_CARGO _Ac_cargo = new FRM_ACTUALIZA_CARGO();
            _Ac_cargo.Show();
        }

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {

        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void BTN_SALIR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_CARGO_TextChanged_1(object sender, EventArgs e)
        {
            System.Data.DataTable _Tabla = _Sistema._Obtener_Instancia()._Cargo._Filtrar(this.TXT_CARGO.Text.Trim());
            this.GRID_CARGO.DataSource = _Tabla;
        }

     

        private void FRM_BUSCA_CARGO_Load(object sender, EventArgs e)
        {

        }

        private void BTN_ACTUALIZAR_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.GRID_CARGO.Rows.Count > 0)
                {
                    _Sistema._Obtener_Instancia()._Cargo.Id_cargo = Convert.ToString(this.GRID_CARGO.CurrentRow.Cells[0].Value);

                    FRM_ACTUALIZA_CARGO _Ac_Cargo = new FRM_ACTUALIZA_CARGO();
                    _Ac_Cargo.Show();
                }

            }
            catch (Exception ex)
            {

                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
            }
        }

       
        
    }
}
