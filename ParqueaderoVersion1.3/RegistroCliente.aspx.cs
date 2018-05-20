using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConexionBD.CapaDatos;
using System.Text.RegularExpressions;
using ParqueaderoVersion1._3.Clases;
using ConexionBD.LogicaNegocio;  

namespace ParqueaderoVersion1._3
{
    public partial class RegistroCliente : System.Web.UI.Page
    {

        int Modificar = 0;
        int Eliminar = 0;
        int Crear = 0;
        int Buscar = 0;
        
        ClaseCliente claseCliente = new ClaseCliente();

        CRUDclientes Crud = new CRUDclientes();

     

        public void Button1_Click(object sender, EventArgs e)
        {

            Crear = 1; 
            Label1.Visible = false;  
            habilitarEdicion();
          //  string vtn = "window.open('Default.aspx','Dates','scrollbars=yes,resizable=yes','height=300', 'width=300')";
           // ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", vtn, true);
        }

        public void habilitarEdicion()
        {
            txrNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCorreo.Enabled = true;
            txtNumeroIdentificacion.Enabled = true;
        }


        private bool ValidaEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void dgvCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dgvCliente.DataSource = Crud.selectedCliente();
                dgvCliente.DataBind();
            }
            
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar = 1;
            btnEliminar.Enabled = false;
            Button1.Enabled = false;
            btnModificar.Enabled = true;
            txtNumeroIdentificacion.Enabled = true;




        }

        public void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar = 1;
            btnEliminar.Enabled = false;
            Button1.Enabled = false;
            btnBuscar.Enabled = true;
            txtNumeroIdentificacion.Enabled = true;

        }
 
        public void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Crear == 1 )
            {

                if (txrNombre.Text == "")
                {
                    Label1.Visible = true;
                    Label1.Text = "Debe Ingresar un nombre valido";
                    txrNombre.Focus();
                    return;
                }

                if (txtApellido.Text == "")
                {

                    Label1.Visible = true;
                    Label1.Text = "Debe Ingresar un apellido valido";
                    txtApellido.Focus();
                    return;
                }

                if (txtNumeroIdentificacion.Text == "")
                {

                    Label1.Visible = true;
                    Label1.Text = "Debe Ingresar un numero de identificacion valido";
                    txtApellido.Focus();
                    return;
                }

                if (ValidaEmail(txtCorreo.Text) == false)
                {

                    Label1.Visible = true;
                    Label1.Text = "Debe Ingresar un numero de correo valido";
                    txtCorreo.Focus();
                    return;
                }

                var cliente = new Cliente
                {
                    NombresCliente = txrNombre.Text,
                    ApellidosCliente = txtApellido.Text,
                    CorreoCliente = txtCorreo.Text,
                    numeroIdentificacion = txtNumeroIdentificacion.Text
                };
                Crud.clienteNuevo(cliente);
                dgvCliente.DataSource = Crud.selectedCliente();
                dgvCliente.DataBind();
                Crear = 0; 
            }
           
                if (Buscar == 1)
                {

                    dgvCliente.DataSource = Crud.selectedOneCliente(txtNumeroIdentificacion.Text);
                    dgvCliente.DataBind();
                    Buscar = 0;  
                }
               
                if (Modificar == 1)
                {
                    Modificar = 0;  
                }
                
            
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
       
        
    }
}

