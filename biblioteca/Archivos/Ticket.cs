using iTextSharp.text.pdf;
using System.Text;
using iTextSharp.text;

namespace biblioteca.Archivos
{
    public class Ticket
    {
        static string ruta;

        static Ticket()
        {
            ruta = Environment.CurrentDirectory;
            ruta += @"/Archivos/";
        }
        public static void GeneradorDeErrores(string descripcion, string metodo)
        {

            string rutaCompleta = ruta + "LogDeErrores.txt";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n");
            sb.AppendLine($"Fecha del error: {DateTime.Now.ToString()}");
            sb.AppendLine("Descripcion: " + descripcion);
            sb.AppendLine("Sucedio en el metodo: " + metodo);

            File.AppendAllText(rutaCompleta, sb.ToString());

        }
        public static void EscribirDia(string nombre, int dia)
        {
            try
            {
                string rutaCompleta = ruta + nombre + ".txt";
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(dia.ToString());
                File.WriteAllText(rutaCompleta, sb.ToString());
            }
            catch (Exception ex)
            {
                GeneradorDeErrores(ex.Message, "EscribirDia(string nombre,int dia) ");
            }            
        }
        public static string LeerTicket(string nombre)
        {
            string datos = "";
            try
            {
                string rutaCompleta = ruta + nombre + ".txt";
                datos = File.ReadAllText(rutaCompleta);
            }
            catch (Exception ex)
            {
                GeneradorDeErrores(ex.Message, "LeerTicket(string nombre) ");
            }

            return datos;
        }

        public static void GenerarPDF(string productoMasVendido, List<string> topTresUsuarios, List<CompraUsuario> ventas)
        {
            string ruta = Path.Combine(Environment.CurrentDirectory, "Archivos");
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            string outputPath = Path.Combine(ruta, "ventasCompraJoaco.pdf");

            iTextSharp.text.Document document = new iTextSharp.text.Document();
            PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));

            document.Open();

            Paragraph titulo = new Paragraph("Ventas Compra Joaco", new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
            titulo.Alignment = Element.ALIGN_CENTER;
            document.Add(titulo);
            document.Add(new Paragraph(""));

            Paragraph productoVendido = new Paragraph("-Producto más vendido: " + productoMasVendido);
            document.Add(productoVendido);
            document.Add(new Paragraph(""));

            Paragraph topUsuariosTitulo = new Paragraph("-Top 3 usuarios con más gastos:");
            document.Add(topUsuariosTitulo);
            foreach (string usuario in topTresUsuarios)
            {
                Paragraph usuarioParagraph = new Paragraph(usuario, new Font(Font.FontFamily.HELVETICA, 10));
                document.Add(usuarioParagraph);
            }
            document.Add(new Paragraph(""));

            Paragraph ventasTitulo = new Paragraph("-Lista completa de ventas:");
            document.Add(ventasTitulo);
            foreach (var venta in ventas)
            {
                Paragraph ventaInfo = new Paragraph("- ID: " + venta.Id + " | Componente: " + venta.Componente.TipoProducto.ToString() + " | Producto: " + venta.Componente.Nombre + " | Monto: $" + venta.Componente.Precio.ToString("0.00"));
                document.Add(ventaInfo);
            }

            document.Close();
        }

    }
}

