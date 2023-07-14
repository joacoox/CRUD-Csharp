using biblioteca;
using biblioteca.Logica_Usuarios;
using System.Runtime.InteropServices;
using biblioteca.Archivos;
using System.Security.Cryptography;


namespace parcialUno
{
    public partial class MainMenu : Form
    {
        private User user;
        private int diaAnterior;
        ConfiguracionInicio config;

        public delegate void CambioDiaEventHandler();
        public event CambioDiaEventHandler CambioDia;

        public MainMenu(User user)
        {
            InitializeComponent();
            personalizarDiseño();
            this.Padding = new Padding(borderSize);
            this.BackColor = System.Drawing.Color.FromArgb(34, 33, 72);
            this.user = user;
            diaAnterior = ConseguirDiaAnterior();
            CambioDia += GenerarRegistroVentasDiarias; 
        }

        private int ConseguirDiaAnterior()
        {
            if (int.TryParse(Ticket.LeerTicket("DiaAnterior"), out int retorno))
            {
                return retorno;
            }
            return -1;
        }
        
        private async void MainMenu_Load(object sender, EventArgs e)
        {
            pnlDatoss.Visible = true;
            pnlProductosBajoStock.Visible = true;

            if (user is Admin)
            {
                btnClientes.Visible = true;
                lblBienvenido.Text = "Bienvenido Admin!";
                btnNombre.Text = user.Nombre;

                try
                {
                    InformacionPersonal menu = new(user);
                    menu.pasado += new InformacionPersonal.pasar(LeerConfiguracion);
                    menu.Show();
                    menu.Hide();

                    await LoadProductosBajoStockAsync();                 
                    lblAdmins.Text = await GetCantidadClientesAsync(usuario => usuario is Admin);
                    lblClientes.Text = await GetCantidadClientesAsync(usuario => usuario is not Admin);
                    lblVentas.Text = await GetCantidadVentasAsync();
                    lblGanancias.Text = await GetGananciasBrutasAsync();

                }
                catch (Exception ex)
                {
                    Ticket.GeneradorDeErrores(ex.Message, "private async void MainMenu_Load(object sender, EventArgs e)");
                }
            }
            else
            {
                pnlProductosBajoStock.Visible = false;
                pnlDatoss.Visible = false;
                lblBienvenido.Text = "Bienvenido Cliente!";
                btnClientes.Visible = false;
            }
        }
        private void LeerConfiguracion(ConfiguracionInicio inicio) 
        { 
            if(inicio is not null) 
            { 
              config = inicio;
            }
        }
  
        private async Task LoadProductosBajoStockAsync()
        {
            var componentes = await Task.Run(() => SistemaComp.ComponentesEnBajoStock());
           
            dtgvProductosBajoStock.Rows.Clear();
            dtgvProductosBajoStock.Refresh();
            dtgvProductosBajoStock.DataSource = componentes;
        }

        private async Task<string> GetCantidadClientesAsync(Predicate<User> condicion)
        {
            var cantidad = await Task.Run(() => Sistema.DevolverCantidadPorParametros(condicion));
            return cantidad.ToString();
        }

        private async Task<string> GetCantidadVentasAsync()
        {
            var ventas = await Task.Run(() => SistemaCompras.VerHistorial());
            return ventas.Count().ToString();
        }

        private async Task<string> GetGananciasBrutasAsync()
        {
            var ganancias = await Task.Run(() => SistemaCompras.RetornarGananciasBrutas());
            return ganancias.ToString();
        }

        private int borderSize = 2;

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void personalizarDiseño()
        {
            pnlComponentes.Visible = false;
        }

        private void esconderSubMenu()
        {
            if (pnlComponentes.Visible == true)
                pnlComponentes.Visible = false;
        }
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region SubMenu

        private void btnComponentes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlComponentes);
        }

        private void btnPlacaVideo_Click(object sender, EventArgs e)
        {
            MostrarProductos form = new MostrarProductos(TipoDeComponente.PlacaDeVideo, this.user);
            AbrirFormularioHijo(form);
            esconderSubMenu();
        }

        private void btnPlacaMadre_Click(object sender, EventArgs e)
        {
            MostrarProductos form = new MostrarProductos(TipoDeComponente.PlacaMadre, this.user);
            AbrirFormularioHijo(form);
            esconderSubMenu();
        }

        private void btnProcesador_Click(object sender, EventArgs e)
        {
            MostrarProductos form = new MostrarProductos(TipoDeComponente.Procesador, this.user);
            AbrirFormularioHijo(form);
            esconderSubMenu();
        }

        private void btnRam_Click(object sender, EventArgs e)
        {
            MostrarProductos form = new MostrarProductos(TipoDeComponente.MemoriaRam, this.user);
            AbrirFormularioHijo(form);
            esconderSubMenu();
        }

        private void btnDisco_Click(object sender, EventArgs e)
        {
            MostrarProductos form = new MostrarProductos(TipoDeComponente.Disco, this.user);
            AbrirFormularioHijo(form);
            esconderSubMenu();
        }

        private void btnFuenteAlimentacion_Click(object sender, EventArgs e)
        {
            MostrarProductos form = new MostrarProductos(TipoDeComponente.FuenteDeAlimentacion, this.user);
            AbrirFormularioHijo(form);
            esconderSubMenu();
        }

        private void btnGabinete_Click(object sender, EventArgs e)
        {
            MostrarProductos form = new MostrarProductos(TipoDeComponente.Gabinete, this.user);
            AbrirFormularioHijo(form);
            esconderSubMenu();
        }


        #endregion

        private void btnArmarCompu_Click(object sender, EventArgs e)
        {
            RegistroCompras form = new RegistroCompras(this.user);
            AbrirFormularioHijo(form);
            esconderSubMenu();
        }

        private void btnMisDatos_Click(object sender, EventArgs e) 
        {                           
            InformacionPersonal form = new InformacionPersonal(this.user);  
            AbrirFormularioHijo(form);
            esconderSubMenu();
        }
   
        private void btnClientes_Click(object sender, EventArgs e)
        {
            ListaUsuarios form = new ListaUsuarios();
            AbrirFormularioHijo(form);
            esconderSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Estas seguro de que quiere salir?", "Abandonando Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dg == DialogResult.Yes)
            {
                InicioDeSesion form = new InicioDeSesion();
                form.Show();
                this.Close();
            }
            esconderSubMenu();
        }

        private Form formActivo = null;
        /// <summary>
        /// abro un formulario hijo en el panel 
        /// </summary>
        /// <param name="formularioHijo"></param>
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlDatoss.Visible = false;
            pnlProductosBajoStock.Visible = false;
            pnlFormulario.Controls.Add(formularioHijo);
            pnlFormulario.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felicidades encontraste el mensaje oculto!");
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dddd MMMM yyy");
            int diaActual = DateTime.Now.Day;

            
            if (config is not null && config.GeneradorAutomaticoDeVentas && user is Admin)
            {             
                if (diaActual != diaAnterior)
                {
                    diaAnterior = diaActual;
                    CambioDia?.Invoke();
                }
            }
        }
        private async void GenerarRegistroVentasDiarias()
        {
            try
            {
                int diaActual = DateTime.Now.Day;
                Ticket.EscribirDia("DiaAnterior", diaActual);
                SerializadorXML<CompraUsuario> xml = new();
                string nombreArchivo = "VentasDel" + DateTime.Now.Day;

                var list = await VerHistorialDelDiaAsync();
                await EscribirVentasAsync(list, nombreArchivo, () =>
                {
                    MessageBox.Show("Se genero con exito el registro de ventas diarias");                   
                });
            }
            catch (Exception ex)
            {
                new Exception("No se pudo crear el registro diario de ventas");
                Ticket.GeneradorDeErrores(ex.Message, "public List<Cliente> TraerAsync()");
            }
        }

        private async Task EscribirVentasAsync(List<CompraUsuario> ventas, string nombreArchivo, Action callback)
        {
            await Task.Run(() =>
            {
                SerializadorXML<CompraUsuario> xml = new SerializadorXML<CompraUsuario>();
                xml.EscribirVentas(ventas, nombreArchivo);

                callback?.Invoke();
            });
        }      
        private async Task<List<CompraUsuario>> VerHistorialDelDiaAsync()
        {
            return await Task.Run(() => SistemaCompras.VerHistorialDelDia());
        }

        

        private void btnDatosSucursal_Click(object sender, EventArgs e)
        {
            InformacionSucursal form = new();
            AbrirFormularioHijo(form);
            esconderSubMenu();

        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;

        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (formActivo != null)
                formActivo.Close();

            if (user is Admin)
            {
                pnlDatoss.Visible = true;
                pnlProductosBajoStock.Visible = true;
            }
            esconderSubMenu();
        }
    }

}
