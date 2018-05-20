using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConexionBD.CapaDatos;

namespace ConexionBD.LogicaNegocio
{
    public class CRUDclientes
    {

        public  void clienteNuevo(Cliente objCliente)
        {
            using (var en = new Entities())
            {
                en.Clientes.Add(objCliente);
                en.SaveChanges();
            }
        }



        public void UpdateCliente(Cliente objCliente)
        {
            using (var en = new Entities())
            {
                var cliente_bd = en.Clientes.FirstOrDefault(x => x.IdCliente == objCliente.IdCliente);
                if (cliente_bd != null)
                {
                    en.Entry(cliente_bd).State = System.Data.Entity.EntityState.Modified;
                    en.Entry(cliente_bd).CurrentValues.SetValues(objCliente);
                    en.SaveChanges();
                }
            }
        }

        public void DeleteCliente(int IdCliente)
        {
            using (var en = new Entities())
            {
                var cliente_bd = en.Clientes.FirstOrDefault(x => x.IdCliente == IdCliente);
                if (cliente_bd != null)
                {
                    en.Entry(cliente_bd).State = System.Data.Entity.EntityState.Deleted;
                    en.SaveChanges();
                }
            }
        }

        public List<Cliente> selectedCliente()
        {
            using (var en = new Entities())
            {
                var query = from p in en.Clientes
                            select p;
                return query.ToList();
            }
        }


        public List<Cliente> selectedOneCliente( string numeroIdentificacion)
        {
            using (var en = new Entities())
            {
                var query = from p in en.Clientes
                            where p.numeroIdentificacion == numeroIdentificacion
                            select p;
                return query.ToList();
            }
      
        }


        public int BuscaId(string p)
        {
            using (var en = new Entities())
            {
                int IdUsuario = (from e in en.Clientes
                                      where e.numeroIdentificacion == p
                                      select e.IdCliente).First();

                return IdUsuario;
            }
        }
    }
}
