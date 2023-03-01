using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
   public  class _Tipo_garantia
    {
       private string _id_tipo_garantia;
        private string _tipo_garantia;
        private int _estado;

        public string Id_tipo_garantia { get { return _id_tipo_garantia; } set { _id_tipo_garantia = value; } }
        public string tipo_garantia { get { return _tipo_garantia; } set { _tipo_garantia = value; } }
        public int Estado { get { return _estado; } set { _estado = value; } }




        public object _Obtener_objeto()
        {
            try
            {
                _Tipo_garantia tipo_garantia = new _Tipo_garantia();

                tipo_garantia.Id_tipo_garantia = this.Id_tipo_garantia;
                tipo_garantia.tipo_garantia = this.tipo_garantia;
                return tipo_garantia;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public System.Data.DataTable _Listar()
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [TIPO_GARANTIA]");
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
