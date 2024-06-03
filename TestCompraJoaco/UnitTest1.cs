using biblioteca;

namespace TestCompraJoaco
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow("123/")]
        [DataRow("as/ds")]
        [DataRow("48/44")]
        [DataRow("4132")]
        [DataRow("/123")]
        [DataRow("123451")]
        [DataRow("32/12")]
        [DataRow("13/22")]
        [TestMethod]
        public void FechaDeVencimientoNoValida(string fechaVencimiento)
        {
            bool retorno;

            
            retorno = ValidacionException.EsFechaVencimientoValida(fechaVencimiento);

            Assert.IsFalse(retorno);
        }
        [DataRow("08/24")]
        [DataRow("06/25")]
        [DataRow("03/26")]
        [TestMethod]
        public void FechaDeVencimientoValida(string fechaVencimiento)
        {
            bool retorno;

            retorno = ValidacionException.EsFechaVencimientoValida(fechaVencimiento);

            Assert.IsTrue(retorno);
        }
        [DataRow(1)]
        [DataRow(1111)]
        [DataRow(11)]
        [DataRow(99)]
        [TestMethod]
        public void CodigoDeSeguridadNoValido(int code)
        {
            bool retorno;


            retorno = ValidacionException.IsValidSecurityNumber(code);

            Assert.IsFalse(retorno);
        }

        [DataRow(111)]
        [DataRow(999)]
        [DataRow(316)]
        [DataRow(719)]
        [TestMethod]
        public void CodigoDeSeguridadValido(int code)
        {
            bool retorno;


            retorno = ValidacionException.IsValidSecurityNumber(code);

            Assert.IsTrue(retorno);
        }
        [DataRow(123400000000000f)]
        [DataRow(12340000000000011f)]
        [TestMethod]
        public void NumeroDeTarjetaNoValido(float numeroTarjeta)
        {
            bool retorno;


            retorno = ValidacionException.IsValidCreditCardNumber(numeroTarjeta);

            Assert.IsFalse(retorno);
        }
        [DataRow(1234000000003000f)]
        [DataRow(5434123590030801f)]
        [TestMethod]
        public void NumeroDeTarjetaValido(float numeroTarjeta)
        {
            bool retorno;


            retorno = ValidacionException.IsValidCreditCardNumber(numeroTarjeta);

            Assert.IsTrue(retorno);
        }
        [DataRow("asdbassssssssssssssssssssssssssssss")]
        [DataRow("asd")]
        [DataRow("a")]
        [DataRow("")]
        [DataRow(null)]
        [DataRow("1234")]
        [TestMethod]
        public void NombreOContraseñaNoValido(string cadena)
        {
            bool retorno;


            retorno = ValidacionException.IsValidNameOrPassword(cadena);

            Assert.IsFalse(retorno);
        }
        [DataRow("joaco123")]
        [DataRow("pepeAudaz")]
        [DataRow("juancarlo")]
        [TestMethod]
        public void NombreOContraseñaValido(string cadena)
        {
            bool retorno;


            retorno = ValidacionException.IsValidNameOrPassword(cadena);

            Assert.IsTrue(retorno);
        }

    }
}