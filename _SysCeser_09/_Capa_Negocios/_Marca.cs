using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Capa_data;

namespace _Capa_Negocios
{
    public  class _Marca:_Interfaces_polimorfismo ._Obtener_objeto_clase ,_Interfaces_polimorfismo ._Listar_general ,
                            _Interfaces_polimorfismo ._Filtrar_general ,_Interfaces_polimorfismo ._Fila_general 
    {

        private string _id_marca;
        private string _marca;
        private int _estado;

        public string Id_marca { get { return _id_marca; } set { _id_marca = value; } }
        public string Marca { get { return _marca; } set { _marca = value; } }
        public int Estado { get { return _estado; } set { _estado = value; } }




        public object _Obtener_objeto()
        {
            try
            {
                _Marca _marca = new _Marca();

                _marca.Id_marca = this.Id_marca;
                _marca.Marca = this.Marca;
                _marca.Estado = this.Estado;


                return _marca;
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
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [MARCA] WHERE ESTADO=1 ");
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Tabla();
            }
            catch (Exception)
            {
                return null;
            }

        }

        public System.Data.DataRow _Obtener_fila(string id)
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT * FROM [MARCA] WHERE ID_MARCA=@ID_MARCA");
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_MARCA", id.Trim(), System.Data.SqlDbType.Char, 5);
                return _Instrucciones._Obtener_Instancia()._Oda_Ejecutar_Retorna_Fila();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string _Guardar_marca()
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.StoredProcedure, "SP_INSERTA_MARCA");
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_MARCA", System.Data.SqlDbType.Char, 5);
                _Instrucciones._Obtener_Instancia()._Parametro("@S", System.Data.SqlDbType.Char, 2);

                _Instrucciones._Obtener_Instancia()._Parametro("@MARCA", this.Marca.Trim(), System.Data.SqlDbType.VarChar, 50);

                _Instrucciones._Obtener_Instancia()._Oda_Ejecutar();

                this.Id_marca = Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@ID_MARCA"));
                return Convert.ToString(_Instrucciones._Obtener_Instancia()._Parametro("@S"));
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool _Actualiza_marca(string id_area)
        {
            try
            {
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "UPDATE [MARCA]SET MARCA=@MARCA,ESTADO=@ESTADO WHERE ID_MARCA=@ID_MARCA");
                _Instrucciones._Obtener_Instancia()._Parametro("@MARCA", this.Marca .Trim(), System.Data.SqlDbType.VarChar, 50);
                _Instrucciones._Obtener_Instancia()._Parametro("@ESTADO", this.Estado, System.Data.SqlDbType.Int);
                _Instrucciones._Obtener_Instancia()._Parametro("@ID_MARCA", id_area.Trim(), System.Data.SqlDbType.Char, 5);
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
                _Instrucciones._Obtener_Instancia()._Oda_Consulta(System.Data.CommandType.Text, "SELECT ID_MARCA ,MARCA FROM [MARCA] WHERE MARCA LIKE '%'+@TEXTO+'%'");
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
