using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
   public  class _Cargo:_Interfaces_polimorfismo ._Filtrar_general ,_Interfaces_polimorfismo ._Fila_general ,
                        _Interfaces_polimorfismo ._Listar_general ,_Interfaces_polimorfismo ._Obtener_objeto_clase 
    {
        private string _id_cargo;
        private string _cargo;
        private int _estado;

        public string Id_cargo {get { return _id_cargo; }set { _id_cargo = value; }}
        public string Cargo {get { return _cargo; }set { _cargo = value; } }
        public int Estado { get { return _estado; }set { _estado = value; }}



    
 public  object _Obtener_objeto()
{
    try
    {
        _Cargo _cargo = new _Cargo();
        _cargo.Id_cargo  = this.Id_cargo ;
        _cargo.Cargo  = this.Cargo;
        _cargo.Estado = this.Estado;

        return _cargo;
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
    _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [CARGO] WHERE ESTADO=1 ");
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
        _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [CARGO] WHERE ID_CARGO=@ID_CARGO");
        _Instrucciones._Obtener_Instancia()._Parametro("@ID_CARGO", id.Trim(), System.Data.SqlDbType.Char, 5);
        return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Fila();
    }
    catch (Exception)
    {
        return null;
    }
}

public string _Guardar_cargo()
{
    try
    {
        _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_INSERTA_CARGO");
        _Instrucciones._Obtener_Instancia()._Parametro("@ID_CARGO", System.Data.SqlDbType.Char, 5);
        _Instrucciones._Obtener_Instancia()._Parametro("@S", System.Data.SqlDbType.Char, 2);

        _Instrucciones._Obtener_Instancia()._Parametro("@CARGO", this.Cargo.Trim(), System.Data.SqlDbType.VarChar, 50);

        _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();

        this.Id_cargo = Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@ID_CARGO"));
        return Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@S"));
    }
    catch (Exception)
    {
        return null;
    }
}
public bool _Actualiza_cargo(string id_cargo)
{
    try
    {
        _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "UPDATE [CARGO]SET CARGO=@CARGO,ESTADO=@ESTADO WHERE ID_CARGO=@ID_CARGO");
        _Instrucciones._Obtener_Instancia()._Parametro("@CARGO", this.Cargo .Trim(), System.Data.SqlDbType.VarChar, 50);
        _Instrucciones._Obtener_Instancia()._Parametro("@ESTADO", this.Estado, System.Data.SqlDbType.Int);
        _Instrucciones._Obtener_Instancia()._Parametro("@ID_CARGO", id_cargo.Trim(), System.Data.SqlDbType.Char, 5);
        return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();
    }
    catch (Exception)
    {
        return false;
    }

}

public System.Data.DataTable _Filtrar(string texto)
{
    try
    {
        _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT ID_CARGO ,CARGO FROM [CARGO] WHERE CARGO LIKE '%'+@TEXTO+'%'");
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
