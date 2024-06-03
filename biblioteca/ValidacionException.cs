using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class ValidacionException : Exception
    {
        public ValidacionException() { }

        public ValidacionException(string message) : base(message) { }

      
        public static void ValidarNombreUsuario(string cadena)
        {
            if (!IsValidNameOrPassword(cadena))
            {
                throw new ValidacionException("El nombre de usuario no cumple los requisitos, minimo 5 caracteres.");
            }
        }

        public static void ValidarContraseña(string cadena)
        {
            if (!IsValidNameOrPassword(cadena))
            {
                throw new ValidacionException("La contraseña no cumple los requisitos, minimo 5 caracteres.");
            }
        }

        public static void ValidarNumeroTarjetaCredito(float numero)
        {
            if (!IsValidCreditCardNumber(numero))
            {
                throw new ValidacionException("El número de tarjeta de crédito no es válido.");
            }
        }

        public static void ValidarNumeroSeguridad(int numero)
        {
            if (!IsValidSecurityNumber(numero))
            {
                throw new ValidacionException("El número de seguridad no es válido.");
            }
        }

        public static void ValidarFechaVencimiento(string fechaVencimiento)
        {
            if (!EsFechaVencimientoValida(fechaVencimiento))
            {
                throw new ValidacionException("La fecha de vencimiento no es válida.");
            }
        }

        /// <summary>
        /// recibe una cadena y verifica si es apta para el nombre la contra del user
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>true si es valida, false de lo contrario</returns>
        public static bool IsValidNameOrPassword(string cadena)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(cadena))
            {
                if (cadena.Length >= 5 && cadena.Length < 20)
                {
                    result = true;
                }

            }
            return result;
        }
        /// <summary>
        /// si el numero de la tarjeta de credito es valido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>true si es valida, false de lo contrario</returns>
        public static bool IsValidCreditCardNumber(float numero)
        {
            bool result = false;
            if (numero > 1000000000000000 && numero <= 9999999999999999)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// si el numero de seguridad es valido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>true si es valida, false de lo contrario</returns>
        public static bool IsValidSecurityNumber(int numero)
        {
            bool result = false;
            if (numero >= 100 && numero <= 999)
            {
                result = true;
            }
            return result;
        }
        public static bool EsFechaVencimientoValida(string fechaVencimiento)
        {
            if (fechaVencimiento.Length != 5 || fechaVencimiento[2] != '/')
            {
                return false;
            }

            string[] partes = fechaVencimiento.Split('/');
            if (partes.Length != 2)
            {
                return false;
            }

            if (!int.TryParse(partes[0], out int mes) || !int.TryParse(partes[1], out int anio))
            {
                return false;
            }

            int anioActual = DateTime.Now.Year % 100;

            if (mes < 1 || mes > 12 || anio < anioActual || anio > anioActual + 10)
            {
                return false;
            }

            return true;
        }       
    }

}
