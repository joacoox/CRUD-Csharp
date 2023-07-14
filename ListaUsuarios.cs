using biblioteca;
using biblioteca.Archivos;
using biblioteca.Base_de_datos_SQL;
using biblioteca.Logica_Usuarios;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;

namespace parcialUno
{
    public partial class ListaUsuarios : Form
    {
        public ListaUsuarios()
        {
            InitializeComponent();
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarDtgvUsuarios();
            cbAdmin.Items.Add("Si");
            cbAdmin.Items.Add("No");
            btnBaja.Enabled = false;
            btnEditar.Enabled = false;         
        }
        /// <summary>
        /// actualizo el data grid view
        /// </summary>
        private void ActualizarDtgvUsuarios()
        {
            dtgvListaUsuarios.Rows.Clear();

            try
            {
                foreach (biblioteca.User usuario in Sistema.GetLista())
                {
                    string texto = "No";
                    if (usuario is Admin)
                        texto = "Si";
                    dtgvListaUsuarios.Rows.Add(
                        usuario.Id,
                        usuario.Nombre,
                        usuario.Contraseña,
                        texto
                        );
                }
            }
            catch (Exception ex)
            {
                Ticket.GeneradorDeErrores(ex.Message, "private void ActualizarDtgvUsuarios()");
            }

            dtgvListaUsuarios.Refresh();
        }
        private void ActualizarDtgvUsuarios(List<biblioteca.User> list)
        {
            dtgvListaUsuarios.Rows.Clear();

            try
            {
                foreach (biblioteca.User usuario in list)
                {
                    string texto = "No";
                    if (usuario is Admin)
                        texto = "Si";
                    dtgvListaUsuarios.Rows.Add(
                        usuario.Id,
                        usuario.Nombre,
                        usuario.Contraseña,
                        texto
                        );
                }
            }
            catch (Exception ex)
            {
                Ticket.GeneradorDeErrores(ex.Message, "private void ActualizarDtgvUsuarios()");
            }

            dtgvListaUsuarios.Refresh();
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string contra = txtContra.Text;

            try
            {
                ValidacionException.ValidarNombreUsuario(nombre);
                ValidacionException.ValidarContraseña(contra);
                if (cbAdmin.SelectedIndex != -1)
                {
                    bool esAdmin = (cbAdmin.SelectedIndex == 0);

                    if (Sistema.Registrar(nombre, contra, esAdmin))
                    {
                        ActualizarDtgvUsuarios();
                        LimpiarTextBoxs();
                        MessageBox.Show("Usuario creado");
                    }
                    else
                    {
                        MessageBox.Show("Nombre en uso");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre y la contraseña tienen que tener al menos 5 caracteres\nAdmin se completa con si/no");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Ticket.GeneradorDeErrores(ex.Message, "private void btnAcceder_Click(object sender, EventArgs e)");
            }

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (celdaClickeada >= 0 && celdaClickeada < dtgvListaUsuarios.Rows.Count)
            {
                try
                {
                    var nombre = dtgvListaUsuarios.Rows[celdaClickeada].Cells[1].Value?.ToString();
                    var contra = dtgvListaUsuarios.Rows[celdaClickeada].Cells[2].Value?.ToString();

                    if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(contra))
                    {
                        DialogResult dg = MessageBox.Show($"¿Estás seguro de que deseas borrar a {nombre}?", "Advertencia", MessageBoxButtons.YesNo);

                        if (dg == DialogResult.Yes)
                        {
                            biblioteca.User user = Sistema.getUsuario(nombre);
                            if (Sistema.EliminarUser(user))
                            {
                                ActualizarDtgvUsuarios();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una celda que corresponda a un usuario válido");
                    }
                }
                catch (Exception ex)
                {
                    Ticket.GeneradorDeErrores(ex.Message, "private void btnBaja_Click(object sender, EventArgs e)");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una celda válida");
            }
        }


        string nombreTextBox;
        string contraTextBox;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (celdaClickeada >= 0 && celdaClickeada < dtgvListaUsuarios.Rows.Count)
            {
                txtId.Text = dtgvListaUsuarios.Rows[celdaClickeada].Cells[0].Value.ToString();
                txtNombre.Text = dtgvListaUsuarios.Rows[celdaClickeada].Cells[1].Value.ToString();
                txtContra.Text = dtgvListaUsuarios.Rows[celdaClickeada].Cells[2].Value.ToString();
                var admin = dtgvListaUsuarios.Rows[celdaClickeada].Cells[3].Value.ToString();

                nombreTextBox = txtNombre.Text;
                contraTextBox = txtContra.Text;
                if (admin == "Si")
                {
                    cbAdmin.SelectedIndex = 1;
                }
                else if (admin == "No")
                {
                    cbAdmin.SelectedIndex = 0;
                }
                this.btnEditar.Click -= btnEditar_Click;
                this.btnEditar.Text = "Confirmar";
                this.btnEditar.Click += ConfirmarEdicion;
            }
        }
        private void ConfirmarEdicion(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nombreTextBox) && !string.IsNullOrEmpty(contraTextBox) && cbAdmin.SelectedIndex != -1)
            {
                try
                {
                    biblioteca.User usuario = Sistema.getUsuario(nombreTextBox);

                    if (usuario is not null)
                    {
                        string nombre = txtNombre.Text;
                        string contra = txtContra.Text;
                        bool esAdmin = (cbAdmin.SelectedIndex == 0);
                        Sistema sistema = new Sistema();

                        if (esAdmin)
                        {
                            sistema.Editar(new Admin(usuario.Id, nombre, contra, esAdmin));
                        }
                        else
                        {
                            sistema.Editar(new biblioteca.User(usuario.Id, nombre, contra));
                        }

                        this.btnEditar.Click -= ConfirmarEdicion;
                        this.btnEditar.Click += btnEditar_Click;
                        this.btnEditar.Text = "Editar";
                        ActualizarDtgvUsuarios();
                        LimpiarTextBoxs();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un usuario con ese nombre");
                    }
                }
                catch (Exception ex)
                {
                    Ticket.GeneradorDeErrores(ex.Message, "private void ConfirmarEdicion(object sender, EventArgs e)");
                }
            }
            else
            {
                MessageBox.Show("Tiene que elegir un usuario antes de poder editarlo");
            }
        }
        int celdaClickeada;
        private void dtgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celdaClickeada = e.RowIndex;
            if (dtgvListaUsuarios.Rows[celdaClickeada].Cells[1].Value != null)
            {
                btnBaja.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelarEdicion.Enabled = true;
            }
            else
            {
                btnBaja.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelarEdicion.Enabled = false;
            }
        }
        /// <summary>
        /// limpio los texts boxs
        /// </summary>
        private void LimpiarTextBoxs()
        {
            txtContra.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            this.btnEditar.Click -= ConfirmarEdicion;
            this.btnEditar.Click -= btnEditar_Click;
            this.btnEditar.Click += btnEditar_Click;
            this.btnEditar.Text = "Editar";
            LimpiarTextBoxs();
        }
        
        private void btnOrdenarNombre_Click(object sender, EventArgs e)
        {
            var list = Sistema.GetLista();
            list.Sort((usuario1, usuario2) => usuario1.Nombre.CompareTo(usuario2.Nombre));
            ActualizarDtgvUsuarios(list);
        }

        private void btnOrdenarNumero_Click(object sender, EventArgs e)
        {
            var list = Sistema.GetLista();
            list.Sort((usuario1, usuario2) => usuario1.Id.CompareTo(usuario2.Id));
            ActualizarDtgvUsuarios(list);
        }              
    }
}
