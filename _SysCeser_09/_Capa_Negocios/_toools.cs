using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Capa_Negocios
{
     public  class _toools
    {
         private  string _cajas_vacias;

        public _toools()
        {
            _cajas_vacias = "";
        }
        //public static  bool _Verificar_cajas_vacias(System.Windows.Forms.TabPage .ControlCollection  _Controles)
        //{
        //    bool sw = true;
        //    _cajas_vacias = "";
        //    foreach (System.Windows.Forms.Control _Control in _Controles )
        //    {
        //        if (_Control is System.Windows.Forms.TextBox)
        //        {
        //            if (_Control.Text.Trim().Equals(""))
        //            {
        //                sw = false;
        //                _cajas_vacias += _Control.Tag + " , ";
        //            }
        //        }
        //    }
        //    return sw;
        //}

        //public static Util_mensajes _Obtener_Instancia()
        //{
        //    return _Instancia_costante.instancia;
        //}
        //private static class _Instancia_costante
        //{
        //    public static Util_mensajes instancia = new Util_mensajes();
        //}

        public  bool  _verificar_cajas(params System .Windows .Forms .TextBox [] _Texboxt)
        {

            bool sw = true;
            _cajas_vacias = "";

            foreach (System .Windows .Forms .TextBox _Textb in _Texboxt )
            {
                if (_Textb.Text.Trim().Equals("") == true)
                {
                    sw = false;
                    _cajas_vacias += _Textb.Tag + " , ";
                }
            }
            return sw;
        }
        public  void _Limpar_cajas( System .Windows .Forms .TextBox _textbox_focus, params System.Windows.Forms.TextBox[] _Texboxt)
        {
            foreach (System.Windows.Forms.TextBox _textb in _Texboxt)
            {
                _textb.Text = "";
                _textbox_focus.Focus();
            }
        }

        public string _get_cajas_vacias
        {
            get { return _cajas_vacias; }
        }

        public    void _Call_mensaje(string mensaje,string titulo)
        {
            _Mi_mensaje _form_mensaje = new _Mi_mensaje();
            _form_mensaje._Mensaje(mensaje,titulo );
            _form_mensaje.ShowDialog();
        }
        public  bool _Call_mensaje_box(string mensaje, string titulo)
        {
            _Mi_mensaje_box _form_mensaje_box = new _Mi_mensaje_box();
            _form_mensaje_box._Mensaje(mensaje, titulo);
            _form_mensaje_box.ShowDialog();
            return _form_mensaje_box._Respuesta_mensaje;
        }

        public String _Encripta(string TEXTO)
        {
            string _Clave = "";
            for (int I = 0; I < TEXTO.Trim().Length; I++)
            {
                _Clave += Convert.ToChar(Convert.ToInt32(Convert.ToChar(TEXTO.Trim().Substring(I, 1))) + 70);
            }
            return _Clave;
        }
        public String _Desencripta(string TEXTO)
        {
            string _Clave = "";
            for (int I = 0; I < TEXTO.Trim().Length; I++)
            {
                _Clave += Convert.ToChar(Convert.ToInt32(Convert.ToChar(TEXTO.Trim().Substring(I, 1))) - 70);
            }
            return _Clave;
        }
        public bool _Verificar_dni_ruc(string dni, string ruc)
        {
            bool sw = true;

            if (dni.Trim().Equals(ruc.Trim().Substring(2, 8)))
            {
                sw = true;
            }
            else
            {
                sw = false;
            }
            return sw;
        }
        
    }
}
