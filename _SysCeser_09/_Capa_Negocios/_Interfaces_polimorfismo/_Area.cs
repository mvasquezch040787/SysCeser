using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
  public   class _Area:_Interfaces_polimorfismo ._Obtener_objeto_clase,_Interfaces_polimorfismo ._Listar_general,_Interfaces_polimorfismo ._Fila_general,
                       _Interfaces_polimorfismo ._Filtrar_general

    {
        private string _id_area;
        private string _area;
        private int _estado;

        public string Id_area {get { return _id_area; }set { _id_area = value; }}
        public string Area {get { return _area; }set { _area = value; } }
        public int Estado { get { return _estado; }set { _estado = value; }}



    
 public  object _Obtener_objeto()
{
    try
    {
        _Area Area = new _Area();

        Area.Id_area  = this.Id_area ;
        Area.Area  = this.Area;
        return Area;
    }
    catch (Exception)
    {
        return null;
    }
}

  public  System.Data.DataTable _Listar()
{
    try
    {
    _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [AREA] WHERE ESTADO=1 ");
    return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
    }
    catch (Exception)
    {
        return null;
    }
    
}

public   System.Data.DataRow _Obtener_fila(string id)
{
    try
    {
        _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [AREA] WHERE ID_AREA=@ID_AREA");
        _Instrucciones._Obtener_Instancia()._Parametro("@ID_AREA", id.Trim(), System.Data.SqlDbType.Char, 5);
        return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Fila();
    }
    catch (Exception)
    {
        return null;
    }
}

public string _Guardar_area()
{
    try
    {
        _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_INSERTA_AREA");
        _Instrucciones._Obtener_Instancia()._Parametro("@ID_AREA", System.Data.SqlDbType.Char, 5);
        _Instrucciones._Obtener_Instancia()._Parametro("@S", System.Data.SqlDbType.Char, 2);

        _Instrucciones._Obtener_Instancia()._Parametro("@AREA", this.Area.Trim(), System.Data.SqlDbType.VarChar  , 50);

        _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();

        this.Id_area = Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@ID_AREA"));
        return Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@S"));
    }
    catch (Exception)
    {
        return null;
    }
}

public bool _Actualiza_area(string id_area)
{
    try
    {
        _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "UPDATE [AREA]SET AREA=@AREA,ESTADO=@ESTADO WHERE ID_AREA=@ID_AREA");
        _Instrucciones._Obtener_Instancia()._Parametro("@AREA", this.Area.Trim(), System.Data.SqlDbType.VarChar, 50);
        _Instrucciones._Obtener_Instancia()._Parametro("@ESTADO", this.Estado, System.Data.SqlDbType.Int);
        _Instrucciones._Obtener_Instancia()._Parametro("@ID_AREA", id_area.Trim(), System.Data.SqlDbType.Char, 5);
        return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();
    }
    catch (Exception)
    {
        return false;
    }

}

  public  System.Data.DataTable _Filtrar(string texto)
{
    try
    {
        _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT ID_AREA ,AREA FROM [AREA] WHERE AREA LIKE '%'+@TEXTO+'%'");
        _Instrucciones._Obtener_Instancia()._Parametro("@TEXTO", texto.Trim(), System.Data.SqlDbType.VarChar, 50);
        return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
    }
    catch (Exception)
    {
        return null;
    }
}
    }
}
