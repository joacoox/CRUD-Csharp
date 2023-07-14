using biblioteca;
using biblioteca.Archivos;
using biblioteca.Logica_Usuarios;
using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;
using System.Drawing.Printing;
using User = biblioteca.User;

namespace parcialUno
{
    public partial class InformacionPersonal : Form
    {
        private User usuario;
        ConfiguracionInicio configuracion;

        public delegate void pasar(ConfiguracionInicio configuracion);
        public event pasar pasado;

        public InformacionPersonal(User usuario)
        {
            InitializeComponent();
           this.usuario = usuario;
        }

        private async void InformacionPersonal_Load(object sender, EventArgs e)
        {
             var config = await leerConfiguracionAsync();
        
            if (config is not null)
            {
                configuracion = config;
                pasado?.Invoke(configuracion);
            }
            pnlConfiguraciones.Visible = false;
            txtNombre.Text = this.usuario.Nombre;
            txtContraseña.Text = this.usuario.Contraseña;
            btnNoVer.Visible = false;
            pnlDatosBancarios.Visible = false;                     
            InicializarComboBox();
            CargarDatos();
            if (usuario is Admin)
            {
                pnlConfiguraciones.Visible = true;
                btnMostrarDatos.Visible = false;
                btnEsconderDatos.Visible = false;
                btnAceptar.Visible = false;
                txtSaldo.Visible = false;
                lblSaldo.Visible = false;
                CargarConfiguracion(configuracion);
            }
        }
        private async Task<ConfiguracionInicio> leerConfiguracionAsync()
        {
            var retono = await Task.Run(() =>
            {
                SerializadoraJSON<ConfiguracionInicio> leerConfiguracion = new();
                var retono = leerConfiguracion.Leer(usuario.Id.ToString());
                return retono;
            });

            return retono;
        }

        public void CargarConfiguracion(ConfiguracionInicio configuracion)
        {
            
            if (configuracion is not null)
            {
                if (configuracion.BaseDatosFireBase)
                    cmbBaseDeDatos.SelectedItem = "FireBase";
                else if (configuracion.BaseDatosSql)
                    cmbBaseDeDatos.SelectedItem = "SQL";

                if (configuracion.GeneradorAutomaticoDeVentas)
                    cmbVentas.SelectedItem = "ON";
                else
                    cmbVentas.SelectedItem = "OFF";
            }


        }

     
        private void CargarDatos()
        {
            pnlSaldo.Visible = false;

            if (usuario is not Admin)
            {
                try
                {
                    var cliente = Sistema.GetCliente(usuario.Id);
                    txtNumeroTarjeta.Text = cliente.Datos.NumeroTarjeta;
                    txtCodigoSeguridad.Text = cliente.Datos.CodigoSeguridad.ToString();
                    txtFechaVencimiento.Text = cliente.Datos.FechaVencimiento.ToString();
                    lsbBanco.SelectedIndex = (int)cliente.Datos.Banco;
                    txtSaldo.Text = cliente.Datos.Saldo.ToString();
                    pnlSaldo.Visible = true;

                }
                catch (Exception ex)
                {
                    Ticket.GeneradorDeErrores(ex.Message, "private void CargarDatos()");
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            btnVer.Visible = false;
            btnNoVer.Visible = true;
        }

        private void btnNoVer_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            btnVer.Visible = true;
            btnNoVer.Visible = false;
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            pnlDatosBancarios.Visible = true;
        }

        private void btnEsconderDatos_Click(object sender, EventArgs e)
        {
            pnlDatosBancarios.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtNumeroTarjeta.Text, out float num) && int.TryParse(txtCodigoSeguridad.Text, out int codigoSeguridad) &&
                !string.IsNullOrEmpty(txtFechaVencimiento.Text) && lsbBanco.SelectedIndex != -1)
            {
                try
                {
                    Banco banco = (Banco)lsbBanco.SelectedIndex;
                    string fechaVencimiento = txtFechaVencimiento.Text;

                    ValidacionException.ValidarNumeroTarjetaCredito(num);
                    ValidacionException.EsFechaVencimientoValida(fechaVencimiento);
                    ValidacionException.ValidarNumeroSeguridad(codigoSeguridad);
                    DatosParaPagar datos = new(txtNumeroTarjeta.Text, codigoSeguridad, fechaVencimiento, banco, 0);

                    Sistema.CrearCliente(new(datos, usuario.Id, usuario.Nombre, usuario.Contraseña));

                    pnlSaldo.Visible = true;
                    MessageBox.Show("Datos guardados");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Ticket.GeneradorDeErrores(ex.Message, " private void btnAceptar_Click(object sender, EventArgs e)");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos porfavor");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = Sistema.GetCliente(usuario.Id);

                if (int.TryParse(txtAgregarSaldo.Text, out int dinero))
                {
                    DialogResult dg = MessageBox.Show($"Estas seguro de que queres cargar {dinero} pesos?", "Transaccion en proceso", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        cliente.Datos.Depositar(dinero);
                        Sistema.EditarCliente(cliente);
                        txtSaldo.Text = cliente.Datos.Saldo.ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                Ticket.GeneradorDeErrores(ex.Message, "private void btnCargar_Click(object sender, EventArgs e)");
            }

        }

        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            if (cmbVentas.SelectedIndex != -1 && cmbBaseDeDatos.SelectedIndex != -1)
            {
                bool sql = false;
                bool fireBase = false;

                if (cmbBaseDeDatos.SelectedIndex == 0)
                    sql = true;
                if (cmbBaseDeDatos.SelectedIndex == 1)
                    fireBase = true;

                bool generadorVentas = cmbVentas.SelectedIndex == 0;


                ConfiguracionInicio config = new(usuario.Id, sql, fireBase, generadorVentas);
                ConfiguracionInicio.SerializarConfiguracion(config);
                MessageBox.Show("Cambios Guardados");
            }
        }

        private void InicializarComboBox()
        {
            lsbBanco.Items.Add("Santander");
            lsbBanco.Items.Add("MasterCard");
            lsbBanco.Items.Add("Visa");
            lsbBanco.Items.Add("MercadoPago");
            cmbBaseDeDatos.Items.Add("SQL");
            cmbBaseDeDatos.Items.Add("FireBase");
            cmbVentas.Items.Add("ON");
            cmbVentas.Items.Add("OFF");
        }   
    }
}
