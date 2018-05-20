using ConexionBD.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD.LogicaNegocio
{
    public class CrudCarro
    {


        public List<Cliente> selectedOneCliente(string numeroIdentificacion)
        {
            using (var en = new Entities())
            {
                return (from e in en.Clientes
                        select e).ToList();
            }

        }


        public string  BuscarNombre(string numeroIdentificacion)
        {
            using (var en = new Entities())
            {

                string nombre = (from e in en.Clientes
                                  where e.numeroIdentificacion == numeroIdentificacion
                                  select e.NombresCliente).First();

                return nombre; 
            }

        }

        public void carroNuevo(Carro objCarro)
        {
            using (var en = new Entities())
            {
                en.Carroes.Add(objCarro);
                en.SaveChanges();
            }
        }

        public int BuscaModelo(int nombreDelModelo)
        {
            using (var en = new Entities())
            {

                int idModelo = (from e in en.Modeloes
                                 where e.NumeroModelo == nombreDelModelo
                                 select e.IdModelo).First();

                return idModelo;
            }

        }

        public int BuscaColor(string p)
        {
            using (var en = new Entities())
            {
                int IdColor = (from e in en.Colors
                                      where e.NombreColor == p
                                      select e.IdColor).First();

                return IdColor;
            }
        
        }

        public int BuscaTipoVehiculo(string p)
        {
            using (var en = new Entities())
            {
                int IdtipoVehiculo = (from e in en.TipoVehiculoes
                               where e.NombreVehiculo == p
                               select e.idTipoVehiculo).First();

                return IdtipoVehiculo;
            }
        }
    }
}
