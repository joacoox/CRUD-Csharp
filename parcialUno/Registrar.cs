using biblioteca;
using biblioteca.Archivos;

namespace parcialUno
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioDeSesion form = new InicioDeSesion();
            form.ShowDialog();
        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionException.ValidarNombreUsuario(txtNombre.Text);
                ValidacionException.ValidarNombreUsuario(txtContraseña.Text);

                if (txtContraseña.Text == txtContraseña2.Text)
                {
                    if (Sistema.Registrar(txtNombre.Text, txtContraseña.Text, false))
                    {
                        MessageBox.Show($"Cuenta creada bienvenido, {txtNombre.Text}!");
                        this.Hide();
                        InicioDeSesion form = new InicioDeSesion();
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else 
                { 
                    MessageBox.Show("Las contraseñas tienen que coincidir"); 
                }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Ticket.GeneradorDeErrores(ex.Message, "private void btnAcceder_Click(object sender, EventArgs e)");
            }
        }

    }
}
