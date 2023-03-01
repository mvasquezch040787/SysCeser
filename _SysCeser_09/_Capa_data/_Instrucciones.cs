using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient ;
using System.Data;


namespace _Capa_data
{
    public class _Instrucciones
    {
        private SqlConnection _Oco = null;
        private SqlDataAdapter _Oda = null;
        private DataSet _Ods;
        private DataTable _Odt = null;
        private SqlConnectionStringBuilder _OSB = null;


      public  static _Instrucciones _Obtener_Instancia()
   {
       return _Instancia_costante.instancia;
   }
   private static class _Instancia_costante
   {
       public  static  _Instrucciones instancia=new _Instrucciones();
   }

        public  string _Get_Cadena_Settings
        {
        get
            {
            return Properties.Settings.Default._Cadena;
            }
        }
       public void _Construye_Cadena(string SERVIDOR,string BASE)
       {
           try
           {
            this._OSB=new SqlConnectionStringBuilder ();
           _OSB.DataSource=SERVIDOR.Trim();
           _OSB .InitialCatalog=BASE.Trim();
           _OSB.IntegratedSecurity=true ;

           Properties.Settings.Default._Cadena=_OSB.ConnectionString;
           Properties.Settings.Default.Save();
           Properties.Settings.Default.Reload();
           Properties.Settings.Default.Save();
           }
           catch (Exception)
           {
               
               throw;
           }
           
       }
       public void _Construye_Cadena(string SERVIDOR, string BASE,
                                    string USUARIO,string PASSWORD)
       {
           try
           {
this._OSB=new SqlConnectionStringBuilder();
           _OSB.DataSource=SERVIDOR.Trim();
           _OSB.InitialCatalog=BASE.Trim();
           _OSB.UserID=USUARIO.Trim();
           _OSB.Password=PASSWORD.Trim();

           Properties.Settings.Default._Cadena = _OSB.ConnectionString;
           Properties.Settings.Default.Save();
           Properties.Settings.Default.Reload();
           Properties.Settings.Default.Save();

           }
           catch (Exception)
           {
               
               throw;
           }
           
       }
       public String _Encripta(string TEXTO)
       {
           string _Clave = "";
           for (int I = 0; I < TEXTO.Trim().Length; I++)
           {
               _Clave += Convert.ToChar(Convert.ToInt32(Convert.ToChar(TEXTO.Trim().Substring(I,1))) + 70);
           }
           return _Clave;
       }
       public String _Desencripta(string TEXTO)
       {
           string _Clave = "";
           for (int I = 0; I < TEXTO.Trim().Length; I++)
           {
               _Clave += Convert.ToChar(Convert.ToInt32(Convert.ToChar(TEXTO.Trim().Substring(I, 1)))- 70);
           }
           return _Clave;
       }
       public Boolean _Conectar()
       {
           try
           {
           _Oco=new SqlConnection(_Get_Cadena_Settings);
           if (_Oco.State.Equals(ConnectionState.Closed)==true )
            {
                _Oco.Open();
            }
           return true;
           }
           catch (Exception )
           {
               
               return false;
               throw;
           }
       }
       public Boolean _Desconectar()
       {
           try
           {
               _Oco = new SqlConnection(_Get_Cadena_Settings);
               if (_Oco.State.Equals(ConnectionState.Open) == true)
               {
                   _Oco.Close();
               }
               return true;
           }
           catch (Exception )
           {
              
               return false;
               throw;
           }
       }
       public void _Oda_Consulta(CommandType Tipo, string Consulta)
       {
           try
           {
               _Conectar();
               _Oda = new SqlDataAdapter(Consulta, _Get_Cadena_Settings);
               _Oda.SelectCommand.CommandType =Tipo;
           }
           catch (Exception)
           {
               throw;
           }
       }
       public void _Parametro(string Parametro_Entrada, object Valor,
                               SqlDbType Tipo,  int longitud)
       {
           try 
	        {	        
		    _Oda.SelectCommand.Parameters.Add(Parametro_Entrada, Tipo, longitud).Value = Valor;
	        }
	        catch (Exception)
	        {
                throw;
	        }
       }

       public void _Parametro(string Parametro_Entrada, object Valor,
                              SqlDbType Tipo)
       {
           try
           {
            _Oda.SelectCommand.Parameters.Add(Parametro_Entrada, Tipo).Value = Valor;
           }
           catch (Exception)
           {
               throw;
           }
       }

       public void _Parametro(string Parametro_salida, SqlDbType Tipo,int longitud)
       {
           try
           {
               _Oda.SelectCommand.Parameters.Add(Parametro_salida, Tipo,longitud );
               _Oda.SelectCommand.Parameters[Parametro_salida].Direction = System.Data.ParameterDirection.Output;

           }
           catch (Exception)
           {
               throw;
           }
       }
       public void _Parametro(string Parametro_salida, SqlDbType Tipo)
       {
           try
           {
               _Oda.SelectCommand.Parameters.Add(Parametro_salida, Tipo);
               _Oda.SelectCommand.Parameters[Parametro_salida].Direction = System.Data.ParameterDirection.Output;
           }
           catch (Exception)
           {
               throw;
           }
       }
       public object  _Parametro(string Parametro_Retorno)
       {
           try
           {
               return   _Oda.SelectCommand.Parameters[Parametro_Retorno].Value;

           }
           catch (Exception )
           {
           
               return null ;
               throw;
           }
       }
       public Boolean  _Oda_Ejecutar()
       {
           try
           {
               _Ods = new DataSet();
               _Oda.Fill(_Ods);
               _Ods = null;
               _Desconectar();
               return true;
           }
           catch (Exception)
           {
               throw;
               return false ;
               
           }
       }
       public DataTable _Oda_Ejecutar_Retorna_Tabla()
       {
           try
           {
               _Odt = new DataTable();
               _Oda.Fill(_Odt);
               _Desconectar();
               return _Odt;
           }
           catch (Exception)
           {
             
               return null;
               throw;
           }
       }
       public  DataRow _Oda_Ejecutar_Retorna_Fila()
       {
           try
           {
               _Ods = new DataSet(); 
               _Oda.Fill(_Ods);
               _Desconectar();
               return _Ods.Tables[0].Rows[0];
           }
           catch (Exception)
           {
               return null;
               throw;
           }
       }

                
    }
    
}
