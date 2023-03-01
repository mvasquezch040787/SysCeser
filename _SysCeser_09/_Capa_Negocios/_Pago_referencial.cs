using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
  public  class _Pago_referencial
    {
      public System.Data.DataRow _Obtener_fila(string id)
      {
          try
          {
              _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM PAGO_REFERENCIAL WHERE ID_ORDEN=@ID_ORDEN");
              _Instrucciones._Obtener_Instancia()._Parametro("@ID_ORDEN", id.Trim(), System.Data.SqlDbType.VarChar, 10);
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
