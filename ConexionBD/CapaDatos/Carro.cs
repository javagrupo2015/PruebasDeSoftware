//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConexionBD.CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Carro
    {
        public int IdCarro { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }
        public int IdColor { get; set; }
        public string NumeroPlaca { get; set; }
        public int idTipoVehiculo { get; set; }
        public string Observaciones { get; set; }
        public int idUsuario { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Color Color { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual TipoVehiculo TipoVehiculo { get; set; }
    }
}
