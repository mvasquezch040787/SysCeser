using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
  public  class _Tipo_repuesto
    {
        private int _id_tipo_repuesto;
        private String _descripcion;
        public int Id_tipo_repuesto
        {
            get { return _id_tipo_repuesto; }
            set { _id_tipo_repuesto = value; }
        }

        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public System.Data.DataTable _Listar()
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [TIPO_REPUESTO] WHERE ESTADO=1 ");
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
