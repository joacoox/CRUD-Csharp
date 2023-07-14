using biblioteca;
using biblioteca.Archivos;
using biblioteca.Logica_Usuarios;

namespace parcialUno
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Estas seguro de que queres salir?", "Abandonando el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }  
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtContraseña.Text))
                {
                    if (Sistema.EstaRegistrado(txtNombre.Text, () => Sistema.GetLista()))
                    {
                        User nuevoUsuario = Sistema.getUsuario(txtNombre.Text);
                        this.Hide();
                        if (nuevoUsuario is not null)
                        {
                            MainMenu menu = new MainMenu(nuevoUsuario);
                            menu.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error, ingrese bien sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese su nombre y su contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Ticket.GeneradorDeErrores(ex.Message, "private void btnAcceder_Click(object sender, EventArgs e)");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar form = new Registrar();
            this.Hide();
            form.Show();
        }

        private void InicioDeSesion_Load(object sender, EventArgs e)
        {
            txtNombre.AutoCompleteCustomSource = CargarDatos();
            txtNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        /// <summary>
        /// Cargo una lista de nombre de usuarios en una lista de AutoCompleteStringCollection
        /// </summary>
        /// <returns> lista de nombres</returns>
        private AutoCompleteStringCollection CargarDatos()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            List<User> listaUser = Sistema.GetLista();

            foreach (var item in listaUser)
            {
                lista.Add(item.Nombre);
            }

            return lista;
        }
    }
}
