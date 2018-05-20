using ConexionBD.CapaDatos;
using ConexionBD.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParqueaderoVersion1._3
{
    public partial class RegistroCarro : System.Web.UI.Page
    {
         CrudCarro carro = new CrudCarro(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNombre.Enabled = false; 
            selectedOneMarca();
            selectedOneModelo();
            selectedOneColor();
            selectedOneTipoVehiculo();
        }




        #region LlenaListas


        private void selectedOneMarca( )
        {
            using (var en = new Entities())
            {
                foreach (var variable in en.Marca)
                {
                    ddMarca.Items.Add(variable.NombreMarca.ToString()); 
                }
                
            }
        }


        private void selectedOneModelo()
        {
            using (var en = new Entities())
            {
                foreach (var variable in en.Modelo)
                {
                    ddModelo.Items.Add(variable.NumeroModelo.ToString());
                }

            }
        }

        private void selectedOneColor()
        {
            using (var en = new Entities())
            {
                foreach (var variable in en.Color)
                {
                    ddColor.Items.Add(variable.NombreColor.ToString());
                }

            }
        }



        private void selectedOneTipoVehiculo()
        {
            using (var en = new Entities())
            {
                foreach (var variable in en.TipoVehiculo)
                {
                    ddtipoVehiculo.Items.Add(variable.NombreVehiculo.ToString());
                }

            }
        }

        #endregion 

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
           txtNombre.Text =   carro.BuscarNombre(TxtNumeroIdentificacion.Text); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var carro = new Cliente
            {
                txt = txrNombre.Text,
                ApellidosCliente = txtApellido.Text,
                CorreoCliente = txtCorreo.Text,
                numeroIdentificacion = txtNumeroIdentificacion.Text
            };
            Crud.clienteNuevo(cliente);
            dgvCliente.DataSource = Crud.selectedCliente();
            dgvCliente.DataBind();
            Crear = 0; 
        }


    


    }
}