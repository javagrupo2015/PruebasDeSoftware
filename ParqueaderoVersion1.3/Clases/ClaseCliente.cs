using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParqueaderoVersion1._3.Clases
{
    public class ClaseCliente
    {
        private int idCliente;
        private string correoCliente;
        private string nombreCliente;
        private string apellidoCliente;
        private string numeroIdentificacion;

        public string NumeroIdentificacion
        {
            get { return numeroIdentificacion; }
            set { numeroIdentificacion = value; }
        } 
        
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        
        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }

        public string ApellidoCliente
        {
            get { return ApellidoCliente; }
            set { ApellidoCliente = value; }
        }
      
        public string CorreoCliente
        {
            get { return correoCliente; }
            set { correoCliente = value; }
        } 
   

    }
}