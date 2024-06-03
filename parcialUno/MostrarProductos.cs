using biblioteca;
using biblioteca.Archivos;
using biblioteca.Base_de_datos_SQL;
using biblioteca.Logica_Usuarios;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Drawing;

namespace parcialUno
{
    public partial class MostrarProductos : Form
    {
        biblioteca.User user;
        TipoDeComponente tipoDeComponente;
        public MostrarProductos(TipoDeComponente tipoDeComponente, biblioteca.User user)
        {
            InitializeComponent();
            this.tipoDeComponente = tipoDeComponente;
            this.user = user;
        }

        private void MostrarProductos_Load(object sender, EventArgs e)
        {
            AgregarElementos();
            ActualizarDtgvProductos();
        }
        private void ActualizarDtgvProductos()
        {          
            try 
            {
                dtgvMostrarProductos.Rows.Clear();
                foreach (var item in SistemaComp.GetLista())
                {
                    if (item.TipoProducto == tipoDeComponente)
                    {
                        string rgb = "No";
                        if (item.Rgb)
                            rgb = "Si";
                        dtgvMostrarProductos.Rows.Add(
                            item.Id,
                            item.TipoProducto.ToString(),
                            item.Nombre,
                            item.Marca,
                            item.Precio.ToString(),
                            rgb,
                            item.DescripcionProducto,
                            item.Color.ToString(),
                            item.Stock.ToString()
                            );
                    }
                }
                dtgvMostrarProductos.Refresh();
            } 
            catch (Exception ex) 
            {
                Ticket.GeneradorDeErrores(ex.Message, "private void ActualizarDtgvProductos()");
            }
            
            
        }
        private void ActualizarDtgvProductos(List<Componente> lista)
        {
            try 
            { 
                 dtgvMostrarProductos.Rows.Clear();

                foreach (var item in lista)
                {
                    if (item.TipoProducto == tipoDeComponente)
                    {
                        string rgb = "No";
                        if (item.Rgb)
                            rgb = "Si";
                        dtgvMostrarProductos.Rows.Add(
                            item.Id,
                            item.TipoProducto.ToString(),
                            item.Nombre,
                            item.Marca,
                            item.Precio.ToString(),
                            rgb,
                            item.DescripcionProducto,
                            item.Color.ToString(),
                            item.Stock.ToString()
                            );
                    }
                }
                dtgvMostrarProductos.Refresh();
            } 
            catch (Exception ex) 
            {
                Ticket.GeneradorDeErrores(ex.Message, "private void ActualizarDtgvProductos()");
            }
           
        }
        private void btnMenuProductos_Click(object sender, EventArgs e)
        {
            pnlMenuProductos.Visible = true;
            btnEsconder.Visible = true;
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            pnlMenuProductos.Visible = false;
            btnEsconder.Visible = false;
            btnComprar.Visible = false;
        }

        int celdaClickeada;
        string nombreTxt;
        string marcaTxt;

        private void dtgvMostrarProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            celdaClickeada = e.RowIndex;
            if (celdaClickeada != -1)
            {
                if (dtgvMostrarProductos.Rows[celdaClickeada].Cells[1].Value != null)
                {
                    if (user is not Admin)
                    {
                        btnComprar.Visible = true;
                    }
                    btnEditar.Enabled = true;
                    btnBaja.Enabled = true;
                }
                else
                {
                    btnComprar.Enabled = false;
                    btnBaja.Enabled = false;
                    btnEditar.Enabled = false;
                }
            }
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                TipoDeComponente componente = (TipoDeComponente)lsbComponente.SelectedIndex;
                string rgb = listbRgb.Text.ToLower();
                biblioteca.Color color = (biblioteca.Color)lsbColor.SelectedIndex;
                bool tieneRgb = (rgb == "si");
                string nombre = txtNombre.Text;
                string marca = txtMarca.Text;
                string descripcion = txtDescripcion.Text;
                int stock = int.Parse(txtStock.Text);
                float precio = float.Parse(txtPrecio.Text);

                if (stock > 0 && precio > 0)
                {
                    SistemaComp comp = new();
                    if (comp.Agregar(new Componente(componente, nombre, marca, tieneRgb, precio, descripcion, stock, color)))
                    {
                        MessageBox.Show("Producto Agregado");
                        LimpiarTextBoxs();
                        ActualizarDtgvProductos();
                    }
                }
                else
                {
                    MessageBox.Show("El stock y el precio tienen que ser mayores a 0");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los espacios antes de cargar un producto");
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (celdaClickeada >= 0 && celdaClickeada < dtgvMostrarProductos.Rows.Count)
                {
                    TipoDeComponente tipo = this.tipoDeComponente;
                    var nombre = dtgvMostrarProductos.Rows[celdaClickeada].Cells[2].Value.ToString();
                    var marca = dtgvMostrarProductos.Rows[celdaClickeada].Cells[3].Value.ToString();

                    DialogResult dg = MessageBox.Show($"Estás seguro de que desea borrar a {nombre}?", "Advertencia", MessageBoxButtons.YesNo);

                    if (dg == DialogResult.Yes)
                    {
                        Componente componente = SistemaComp.GetComponente(tipo, nombre, marca);
                        SistemaComp comp = new();
                        if (componente is not null)
                        {
                            comp.Borrar(componente.Id);
                            dtgvMostrarProductos.Rows.RemoveAt(celdaClickeada);
                        }
                    }
                }
                else { MessageBox.Show("Seleccione una celda que corresponda a un producto"); }
            }
            catch (Exception ex)
            {
                Ticket.GeneradorDeErrores(ex.Message, "private void btnBaja_Click(object sender, EventArgs e)");
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (celdaClickeada != -1)
            {
                if (dtgvMostrarProductos.Rows[celdaClickeada].Cells[1].Value != null)
                {
                    btnBaja.Enabled = true;
                    btnEditar.Enabled = true;
                    lsbComponente.Text = dtgvMostrarProductos.Rows[celdaClickeada].Cells[1].Value.ToString();
                    txtNombre.Text = dtgvMostrarProductos.Rows[celdaClickeada].Cells[2].Value.ToString();
                    txtMarca.Text = dtgvMostrarProductos.Rows[celdaClickeada].Cells[3].Value.ToString();
                    txtPrecio.Text = dtgvMostrarProductos.Rows[celdaClickeada].Cells[4].Value.ToString();
                    listbRgb.Text = dtgvMostrarProductos.Rows[celdaClickeada].Cells[5].Value.ToString();
                    txtDescripcion.Text = dtgvMostrarProductos.Rows[celdaClickeada].Cells[6].Value.ToString();
                    lsbColor.Text = dtgvMostrarProductos.Rows[celdaClickeada].Cells[7].Value.ToString();
                    txtStock.Text = dtgvMostrarProductos.Rows[celdaClickeada].Cells[8].Value.ToString();


                    nombreTxt = txtNombre.Text;
                    marcaTxt = txtMarca.Text;

                    this.btnEditar.Click -= btnEditar_Click;
                    this.btnEditar.Text = "Confirmar";
                    this.btnEditar.Click += ConfirmarEdicion;
                }
            }
        }
        private void ConfirmarEdicion(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    TipoDeComponente componente = (TipoDeComponente)lsbComponente.SelectedIndex;
                    Componente componenteExistente = SistemaComp.GetComponente(componente, nombreTxt, marcaTxt);

                    string nombre = txtNombre.Text;
                    string marca = txtMarca.Text;
                    float precio;
                    float.TryParse(txtPrecio.Text, out precio);
                    string descripcion = txtDescripcion.Text;
                    string rgb = listbRgb.Text;
                    biblioteca.Color color = (biblioteca.Color)lsbColor.SelectedIndex;
                    int stock;
                    int.TryParse(txtStock.Text, out stock);

                    if (precio > 0 && stock > 0)
                    {
                        bool tieneRgb = rgb.ToLower() == "si";

                        if (componenteExistente is not null)
                        {
                            SistemaComp comp = new();
                            comp.Editar(new Componente(componenteExistente.Id, componente, nombre, marca, tieneRgb, precio, descripcion, stock, color));
                            MessageBox.Show("Componente actualizado");

                            this.btnEditar.Click -= ConfirmarEdicion;
                            this.btnEditar.Click += btnEditar_Click;
                            this.btnEditar.Text = "Editar";
                            LimpiarTextBoxs();
                            ActualizarDtgvProductos();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("El precio y el stock deben ser mayores a 0");
                    }

                }
                catch (Exception ex)
                {
                    Ticket.GeneradorDeErrores(ex.Message, "private void ConfirmarEdicion(object sender, EventArgs e)");
                }

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos antes de realizar la edición");
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {


            string precioTexto = dtgvMostrarProductos.Rows[celdaClickeada].Cells[4].Value.ToString();
            string nombre = dtgvMostrarProductos.Rows[celdaClickeada].Cells[2].Value.ToString();
            string marca = dtgvMostrarProductos.Rows[celdaClickeada].Cells[3].Value.ToString();

            if (!string.IsNullOrEmpty(precioTexto) && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(marca))
            {
                try
                {
                    var cliente = Sistema.GetCliente(user.Id);
                    TipoDeComponente tipo = this.tipoDeComponente;
                    if (int.TryParse(precioTexto, out int precio))
                    {
                        DialogResult dg = MessageBox.Show($"Estas seguro de que queres comprar {nombre}?", "Compra", MessageBoxButtons.YesNo);
                        if (dg == DialogResult.Yes)
                        {

                            if (cliente.Datos.Pagar(precio))
                            {
                                Componente comp = SistemaComp.GetComponente(tipo, nombre, marca);
                                SistemaComp sistema = new();
                                sistema.Editar(new(comp.Id, comp.TipoProducto, comp.Nombre, comp.Marca, comp.Rgb, comp.Precio, comp.DescripcionProducto, comp.Stock - 1, comp.Color));
                                Sistema.EditarCliente(cliente);
                                SistemaCompras.AgregarCompraUsuario(new(comp, 1, DateTime.Now, cliente));

                                MessageBox.Show("Compra exitosa");
                                ActualizarDtgvProductos();
                            }
                            else
                            {
                                MessageBox.Show("Fondos insuficientes");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Ticket.GeneradorDeErrores(ex.Message, "private void btnComprar_Click(object sender, EventArgs e)");
                }

            }
            else { MessageBox.Show("Complete los datos bancarios"); }
        }

        /// <summary>
        /// limpio los text boxs
        /// </summary>
        private void LimpiarTextBoxs()
        {
            lsbComponente.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";
            listbRgb.Text = "";
            txtDescripcion.Text = "";
            lsbColor.Text = "";
            txtStock.Text = "";
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            this.btnEditar.Click -= ConfirmarEdicion;
            this.btnEditar.Click -= btnEditar_Click;
            this.btnEditar.Click += btnEditar_Click;
            this.btnEditar.Text = "Editar";
            LimpiarTextBoxs();
        }

        public void AgregarElementos()
        {
            listbRgb.Items.Add("Si");
            listbRgb.Items.Add("No");
            lsbComponente.Items.Add("PlacaDeVideo");
            lsbComponente.Items.Add("PlacaMadre");
            lsbComponente.Items.Add("Procesador");
            lsbComponente.Items.Add("Gabinete");
            lsbComponente.Items.Add("Disco");
            lsbComponente.Items.Add("MemoriaRam");
            lsbComponente.Items.Add("FuenteDeAlimentacion");
            lsbColor.Items.Add("Rojo");
            lsbColor.Items.Add("Blanco");
            lsbColor.Items.Add("Negro");
            lsbColor.Items.Add("Azul");
            lsbColor.Items.Add("Gris");
            lsbColor.Items.Add("Verde");
            lsbColor.Items.Add("Purpura");
            pnlMenuProductos.Visible = false;
            btnEsconder.Visible = false;

            btnComprar.Visible = false;
            lsbComponente.SelectedIndex = (int)tipoDeComponente;
            lsbComponente.Enabled = false;

            if (user is not Admin)
            {
                pnlMenuProductos.Visible = false;
                btnComprar.Visible = true;
                btnEsconder.Visible = false;
                btnMenuProductos.Visible = false;
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtMarca.Text) || listbRgb.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtStock.Text) || string.IsNullOrEmpty(txtPrecio.Text) ||
                lsbColor.SelectedIndex == -1 || lsbComponente.SelectedIndex == -1)
            {
                return false;
            }

            if (txtNombre.Text.Length >= 100 || txtMarca.Text.Length >= 100 || txtDescripcion.Text.Length >= 100)
            {
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || !float.TryParse(txtPrecio.Text, out float precio))
            {
                return false;
            }

            if (stock > 100000 || precio > 99999999)
            {
                return false;
            }

            return true;
        }   
       
        private void btnOrdenarPorNombre_Click(object sender, EventArgs e)
        {
            var list = SistemaComp.GetLista();
            list.Sort((a,b) => a.Nombre.CompareTo(b.Nombre));
            ActualizarDtgvProductos(list);
        }

        private void btnOrdenarPorPrecio_Click(object sender, EventArgs e)
        {
            var list = SistemaComp.GetLista();
            list.Sort((a, b) => b.Precio.CompareTo(a.Precio));
            ActualizarDtgvProductos(list);
        }      
    }
}
