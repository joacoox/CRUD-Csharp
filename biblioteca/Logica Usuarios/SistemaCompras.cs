using biblioteca.Base_de_datos_SQL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public static class SistemaCompras
    {
        
        /// <summary>
        /// agrega una compra a la queue
        /// </summary>
        /// <param name="compraUsuario"></param>
        public static void AgregarCompraUsuario(CompraUsuario compraUsuario)
        {
            CompraUsuarioGN lista = new();
            if (compraUsuario is not null)
            {
                lista.AgregarAsync(compraUsuario);
            }
        }
        /// <summary>
        /// Se fija el historial de compras de un usuario x
        /// </summary>
        /// <param name="user"></param>
        /// <returns>una queue con el historial de compras</returns>
        public static List<CompraUsuario> VerHistorialComprasUser(User user)
        {
            List<CompraUsuario> historialComprasUsuario = new List<CompraUsuario>();
            CompraUsuarioGN lista = new();

            foreach (CompraUsuario compraUser in lista.TraerAsync())
            {
                if (compraUser.Usuario == user)
                {
                    historialComprasUsuario.Add(compraUser);
                }
            }
            return historialComprasUsuario;
        }

        /// <summary>
        /// Se calcula todas las ventas
        /// </summary>
        /// <returns>retorna todo el dinero ganado</returns>
        public static float RetornarGananciasBrutas()
        {
            float acumulador = 0;
            CompraUsuarioGN lista = new();

            foreach (CompraUsuario item in lista.TraerAsync())
            {
                acumulador += item.Componente.Precio * item.Cantidad;
            }
            return acumulador;
        }

        public static List<CompraUsuario> VerHistorial()
        {

            CompraUsuarioGN lista = new();
            return lista.TraerAsync();
        }

        public static List<CompraUsuario> VerHistorialDelDia()
        {

            CompraUsuarioGN lista = new();
            List<CompraUsuario> listaDelDia = new();

            foreach (var item in lista.TraerAsync())
            {
                if (item.Fecha.Day == DateTime.Now.Day)
                {
                    listaDelDia.Add(item);
                }
            }

            return listaDelDia;
        }
        public static string ObtenerProductoMasVendidoYRecaudacion()
        {
            CompraUsuarioGN listaDB = new();

            var ventas = listaDB.TraerAsync();       
            Dictionary<string, (int cantidad, float totalRecaudado)> conteoProductos = new Dictionary<string, (int, float)>();

            float recaudacionTotal = 0;
            
            foreach (CompraUsuario venta in ventas)
            {
                if (conteoProductos.ContainsKey(venta.Componente.TipoProducto.ToString()))
                {
                    conteoProductos[venta.Componente.TipoProducto.ToString()] = (conteoProductos[venta.Componente.TipoProducto.ToString()].cantidad + 1,
                                                       conteoProductos[venta.Componente.TipoProducto.ToString()].totalRecaudado + venta.Componente.Precio);
                }
                else
                {
                    conteoProductos[venta.Componente.TipoProducto.ToString()] = (1, venta.Componente.Precio);
                }

                recaudacionTotal += venta.Componente.Precio;
            }
     
            KeyValuePair<string, (int cantidad, float totalRecaudado)> productoMasVendido =
                conteoProductos.OrderByDescending(p => p.Value.cantidad).FirstOrDefault();

            if (productoMasVendido.Key != null)
            {
                return $"El producto más vendido es '{productoMasVendido.Key}' con {productoMasVendido.Value.cantidad} ventas. Recaudación total: {recaudacionTotal}";
            }
            else
            {
                return "No se encontraron ventas de productos.";
            }
        }
        public static List<string> ObtenerTopTresUsuariosYGasto()
        {
            CompraUsuarioGN listaDB = new();

            var ventas = listaDB.TraerAsync();

            Dictionary<string, float> conteoGasto = new Dictionary<string, float>();

            foreach (CompraUsuario venta in ventas)
            {
                if (conteoGasto.ContainsKey(venta.Usuario.Nombre))
                {
                    conteoGasto[venta.Usuario.Nombre] += venta.Componente.Precio;
                }
                else
                {
                    conteoGasto[venta.Usuario.Nombre] = venta.Componente.Precio;
                }
            }

            List<string> topTresUsuariosYGasto = conteoGasto.OrderByDescending(u => u.Value)
                                                           .Take(3)
                                                           .Select(u => $"Usuario: {u.Key}, Gasto: {u.Value}")
                                                           .ToList();

            return topTresUsuariosYGasto;
        }

    }
}
