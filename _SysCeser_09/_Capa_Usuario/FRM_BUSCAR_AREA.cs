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
    public partial class FRM_BUSCAR_AREA : Form
    {
        public FRM_BUSCAR_AREA()
        {
            InitializeComponent();
        }

        private void TXT_AREA_TextChanged(object sender, EventArgs e)
        {
            System.Data.DataTable _Tabla = _Sistema._Obtener_Instancia()._Area._Filtrar(this.TXT_AREA.Text.Trim());
            this.GRID_AREA.DataSource = _Tabla;
        }

        private void BTN_NUEVO_Click(object sender, EventArgs e)
        {
            FRM_AREA _Area = new FRM_AREA();
            _Area.Show();
        }

        private void GRID_AREA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
	        {
                _Sistema._Obtener_Instancia()._Area.Id_area = Convert.ToString(this.GRID_AREA.CurrentRow.Cells[0].Value);

                FRM_ACTUALIZA_AREA _Ac_Area = new FRM_ACTUALIZA_AREA();
                _Ac_Area .Show ();
	        }
	        catch (Exception)
	        {
		
		        throw;
	        }
            
        }

        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.GRID_AREA .Rows .Count >0)
                {
                    _Sistema._Obtener_Instancia()._Area.Id_area = Convert.ToString(this.GRID_AREA.CurrentRow.Cells[0].Value);

                    FRM_ACTUALIZA_AREA _Ac_Area=new FRM_ACTUALIZA_AREA();
                    _Ac_Area.Show();
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

        private void FRM_BUSCAR_AREA_Load(object sender, EventArgs e)
        {

        }
    }
}
