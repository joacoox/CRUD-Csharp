using biblioteca;
using biblioteca.Archivos;
using biblioteca.Logica_Usuarios;

namespace parcialUno
{
    public partial class RegistroCompras : Form
    {
        User user;
        public RegistroCompras(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void RegistroCompras_Load(object sender, EventArgs e)
        {
            if (user is Admin == true)
            {
                List<CompraUsuario> compras = SistemaCompras.VerHistorial();

                if (compras != null)
                {
                    AgregarColumnasListaAdmin(compras);
                }
            }
            else
            {
                List<CompraUsuario> compraUsuario = SistemaCompras.VerHistorialComprasUser(user);
                if (compraUsuario != null)
                {
                    AgregarColumnasListaUsuario(compraUsuario);
                }
            }

        }
        private void AgregarColumnasListaUsuario(List<CompraUsuario> comprasUsuario)
        {
            dtgvHistorialCompras.Rows.Clear();
            dtgvHistorialCompras.Columns.Add("Componente", "Componente");
            dtgvHistorialCompras.Columns.Add("Cantidad", "Cantidad");
            dtgvHistorialCompras.Columns.Add("Fecha", "Fecha");

            foreach (var compra in comprasUsuario)
            {
                dtgvHistorialCompras.Rows.Add(
                    compra.Componente.Nombre,
                    compra.Cantidad,
                    compra.Fecha.ToString("dd/MM/yyyy")
                );
            }
            dtgvHistorialCompras.Refresh();
        }
        private void AgregarColumnasListaAdmin(List<CompraUsuario> comprasUsuario)
        {
            dtgvHistorialCompras.Rows.Clear();
            dtgvHistorialCompras.Columns.Add("IdCompra", "IdCompra");
            dtgvHistorialCompras.Columns.Add("Usuario", "Usuario");
            dtgvHistorialCompras.Columns.Add("Componente", "Componente");
            dtgvHistorialCompras.Columns.Add("Cantidad", "Cantidad");
            dtgvHistorialCompras.Columns.Add("Fecha", "Fecha");
            dtgvHistorialCompras.Columns.Add("Precio", "Precio");

            foreach (var compra in comprasUsuario)
            {
                dtgvHistorialCompras.Rows.Add(
                    compra.Id.ToString(),
                    compra.Usuario.Nombre,
                    compra.Componente.Nombre,
                    compra.Cantidad,
                    compra.Fecha.ToString("dd/MM/yyyy"),
                    compra.Componente.Precio.ToString()
                );
            }
            dtgvHistorialCompras.Refresh();

        }

        private void btnGenerarPdf_Click(object sender, EventArgs e)
        {
            var dg = MessageBox.Show("Esta seguro de que desea generar el registro en PDF?", "Registro Ventas", MessageBoxButtons.YesNo);

            try 
            { 
                if (dg == DialogResult.Yes)
                {            
                    string productoMasVendido = SistemaCompras.ObtenerProductoMasVendidoYRecaudacion();
                    List<string> topTresUsuarios = SistemaCompras.ObtenerTopTresUsuariosYGasto();
                    List<CompraUsuario> todasLasVentas = SistemaCompras.VerHistorial();

                    Ticket.GenerarPDF(productoMasVendido, topTresUsuarios, todasLasVentas);

                }
            }
            catch (Exception ex) 
            {
                Ticket.GeneradorDeErrores(ex.Message, "private void btnGenerarPdf_Click(object sender, EventArgs e)");
            }
            
        }
    }
}
