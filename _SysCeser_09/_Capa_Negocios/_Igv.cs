using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
 public   class _Igv
    {
     public System.Data.DataRow _Obtener_fila()
     {
         try
         {
             _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM IGV WHERE ID_IGV=1");
             return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Fila();
         }
         catch (Exception ex)
         {
             _Sistema._Obtener_Instancia()._Util._Call_mensaje(ex.Message, "Error");
             throw;
         }
     }
    }
}
