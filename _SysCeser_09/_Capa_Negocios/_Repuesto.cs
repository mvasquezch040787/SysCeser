using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;
namespace _Capa_Negocios
{
   public  class _Repuesto
    {
        private int _id_repuesto;

        public int Id_repuesto
        {
            get { return _id_repuesto; }
            set { _id_repuesto = value; }
        }
       public System.Data.DataTable Listar_per(string id_marca, int id_tipo_repuesto)
       {

           try
           {
               _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_LISTAR_REPUESTOS_PER");
               _Instrucciones._Obtener_Instancia()._Parametro("@ID_MARCA", id_marca.Trim(), System.Data.SqlDbType.Char, 5);
               _Instrucciones._Obtener_Instancia()._Parametro("@ID_TIPO_REPUESTO", id_tipo_repuesto, System.Data.SqlDbType.Int);
               return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
           }
           catch (Exception)
           {
               
               throw;
           }
       }

       public System.Data.DataRow Get_Repuesto(int id_repuesto)
       {

           try
           {
               _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_GET_REPUESTO");
               _Instrucciones._Obtener_Instancia()._Parametro("@ID_REPUESTO", id_repuesto, System.Data.SqlDbType.Int);
               return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Fila();
           }
           catch (Exception)
           {

               throw;
           }
       }

       public System.Data.DataTable Listar_desc(string descripcion)
       {

           try
           {
               _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_LISTAR_REPUESTOS_DES");
               _Instrucciones._Obtener_Instancia()._Parametro("@DESC", descripcion.Trim(), System.Data.SqlDbType.VarChar, 100);
               return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
           }
           catch (Exception)
           {

               throw;
           }
       }

       public System.Data.DataTable Listar()
       {

           try
           {
               _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_LISTAR_REPUESTOS");
               return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
           }
           catch (Exception)
           {

               throw;
           }
       }
    }
}
