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
    public partial class FRM_BUSCA_MARCA : Form
    {
        public FRM_BUSCA_MARCA()
        {
            InitializeComponent();
        }

        private void TXT_MARCA_TextChanged(object sender, EventArgs e)
        {
            System.Data.DataTable _Tabla = _Sistema._Obtener_Instancia()._Marca._Filtrar(this.TXT_MARCA.Text.Trim());
            this.GRID_MARCA.DataSource = _Tabla;
        }

        private void BTN_NUEVO_Click(object sender, EventArgs e)
        {
            FRM_MARCA _Marca = new FRM_MARCA();
            _Marca.Show();
        }

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GRID_MARCA.Rows.Count > 0)
                {
                    _Sistema._Obtener_Instancia()._Marca.Id_marca  = Convert.ToString(this.GRID_MARCA.CurrentRow.Cells[0].Value);

                    FRM_ACTUALIZA_MARCA _Ac_Marca = new FRM_ACTUALIZA_MARCA();
                    _Ac_Marca.Show();
                }

            }
            catch (Exception ex)
            {

                _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
            }
        }

        private void GRID_MARCA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _Sistema._Obtener_Instancia()._Marca.Id_marca = Convert.ToString(this.GRID_MARCA.CurrentRow.Cells[0].Value);

            FRM_ACTUALIZA_MARCA _Ac_Marca = new FRM_ACTUALIZA_MARCA();
            _Ac_Marca.Show();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
