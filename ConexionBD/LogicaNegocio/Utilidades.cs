using ConexionBD.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD.LogicaNegocio
{
    class Utilidades
    {
        public List<Marca> selectedCliente()
        {
            using (var en = new Entities())
            {
                var query = from p in en.Marcas
                            select p;
                return query.ToList();
            }
        }









    }
}
