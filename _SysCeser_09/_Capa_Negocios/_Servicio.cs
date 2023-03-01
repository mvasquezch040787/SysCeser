using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
  public  class _Servicio
    {
        private int _idservicio;
        private String _descripcion;
        private double _precio;

        public int Idservicio
        {
            get { return _idservicio; }
            set { _idservicio = value; }
        }
       

        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
      

      public double Precio
      {
          get { return _precio; }
          set { _precio = value; }
      }

      public System.Data.DataTable _Listar()
      {
          try
          {
              _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [SERVICIOS] WHERE ESTADO=1 ");
              return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
          }
          catch (Exception)
          {
              return null;
          }

      }
      public System.Data.DataRow _Obtener_fila(int id)
      {
          try
          {
              _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [SERVICIOS] WHERE ID_SERVICIO=@ID_SERVCIO");
              _Instrucciones._Obtener_Instancia()._Parametro("@ID_SERVCIO", id, System.Data.SqlDbType.Int);
              return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Fila();
          }
          catch (Exception)
          {
              return null;
          }
      }
    }
}
