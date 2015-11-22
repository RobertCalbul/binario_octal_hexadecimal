using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binario_octal_hexadecimal
{
///<summary>
///Clase principal de la aplicación.
///</summary>
///<remarks>
///Convierte numeros decimales (enteros) en su equvalente binario,
/// octal y hexadecimal
///</remarks>
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10500;
            Console.WriteLine("Conversion de numeros");
            Console.Write("Binario recursivo: {0} -> {1}", numero, ToBinaryRec(numero));
            Console.Write("\nBinario iterativo: {0} -> {1}", numero, ToBinaryIterative(numero));
            Console.WriteLine("\nBinario Simplificado: {0} -> {1}", numero, ToBinarySimple(numero));
            Console.WriteLine();
            Console.Write("Octal recursivo: {0} -> {1}", numero, ToOctalRec(numero));
            Console.Write("\nOctal iterativo: {0} -> {1}", numero, ToOctalIterative(numero));
            Console.WriteLine("\nOctal Simplificado: {0} -> {1}", numero, ToOctalSimple(numero));
            Console.WriteLine();
            Console.Write("Hexadecimal recursivo: {0} -> {1}", numero, ToHexaRec(numero));
            Console.Write("\nHexadecimal iterativo: {0} -> {1}", numero, ToHexaIterative(numero));
            Console.WriteLine("\nHexadecimal Simplificado: {0} -> {1}", numero, ToHexaSimple(numero));
            Console.ReadKey();
        }

        #region ToBinary
        ///<summary>
        ///Convierte un entero en Binario de forma recursiva
        ///</summary>
        ///<return>
        ///Devuelve un String con la conversion hecha
        ///</return>
        ///<param name="n">
        ///Numero a convertir
        ///</param>
        public static String ToBinaryRec(int n)
        {
            string digit = Convert.ToString(n % 2);
            if (n >= 2)
            {
                int resto = n / 2;
                string restoString = ToBinaryRec(resto);
                return restoString + digit;
            }
            return digit;
        }
        ///<summary>
        ///Convierte un entero en Binario de forma iterativa
        ///</summary>
        ///<return>
        ///Devuelve un String con la conversion hecha
        ///</return>
        ///<param name="n">
        ///Numero a convertir
        ///</param>
        private static String ToBinaryIterative(int n) {
            String resultado = String.Empty;
            while (n > 0) {
                int resto = n % 2;
                n = n / 2;
                resultado = resto.ToString() + resultado;
            }
            return resultado;
        }
        ///<summary>
        ///Convierte un entero en Binario de forma simplificada
        ///</summary>
        ///<return>
        ///Devuelve un String con la conversion hecha
        ///</return>
        ///<param name="n">
        ///Numero a convertir
        ///</param>
        private static String ToBinarySimple(int n) {
            return Convert.ToString(n, 2);
        }
        #endregion

        #region ToOctal
        ///<summary>
        ///Convierte un entero en Octal de forma recursiva
        ///</summary>
        ///<return>
        ///Devuelve un String con la conversion hecha
        ///</return>
        ///<param name="n">
        ///Numero a convertir
        ///</param>
        private static String ToOctalRec(int n)
        {
            String digito = Convert.ToString(n % 8);
            if (n >= 8)
            {
                int resto = n / 8;
                string restoString = ToOctalRec(resto);
                return restoString + digito;
            }
            return digito;
        }
        ///<summary>
        ///Convierte un entero en Octal de forma iterativa
        ///</summary>
        ///<return>
        ///Devuelve un String con la conversion hecha
        ///</return>
        ///<param name="n">
        ///Numero a convertir
        ///</param>
        private static String ToOctalIterative(int n) {
            String resultado = String.Empty;
            while (n > 0) {
                int resto = n % 8;
                n = n / 8;
                resultado = resto.ToString() + resultado;
            }
            return resultado;
        }
        ///<summary>
        ///Convierte un entero en Octal de forma simplificada
        ///</summary>
        ///<return>
        ///Devuelve un String con la conversion hecha
        ///</return>
        ///<param name="n">
        ///Numero a convertir
        ///</param>
        private static String ToOctalSimple(int n) {
            return Convert.ToString(n, 8);
        }
        #endregion

        #region ToHexa
        ///<summary>
        ///Convierte un entero en Hexadecimal de forma recursiva
        ///</summary>
        ///<return>
        ///Devuelve un String con la conversion hecha
        ///</return>
        ///<param name="n">
        ///Numero a convertir
        ///</param>
        private static String ToHexaRec(int n)
        {
            String resultado = String.Empty;
            String digito = Convert.ToString(n % 16);

            switch (n)
            {
                case 10: return "A";
                case 11: return "B";
                case 12: return "C";
                case 13: return "D";
                case 14: return "E";
                case 15: return "F";
            }
            
            if (n >= 16)
            {
                int resto = n / 16;
                string restoString = ToHexaRec(resto);
                return restoString + digito;
            }
            return n.ToString();
        }
        ///<summary>
        ///Convierte un entero en Hexadecimal de forma iterativa
        ///</summary>
        ///<return>
        ///Devuelve un String con la conversion hecha
        ///</return>
        ///<param name="n">
        ///Numero a convertir
        ///</param>
        private static String ToHexaIterative(int n) {
            String resultado = String.Empty;
            switch (n)
            {
                case 10: return "A";
                case 11: return "B";
                case 12: return "C";
                case 13: return "D";
                case 14: return "E";
                case 15: return "F";
            }
            while (n > 0) {
                int resto = n % 16;
                n = n / 16;
                resultado = resto.ToString() + resultado;
            }
            
            return resultado;
        }
        ///<summary>
        ///Convierte un entero en Hexadecimal de forma simplificada
        ///</summary>
        ///<return>
        ///Devuelve un String con la conversion hecha
        ///</return>
        ///<param name="n">
        ///Numero a convertir
        ///</param>
        private static String ToHexaSimple(int n) {
            return Convert.ToString(n, 16).ToUpper(); //Retorna la conversion del numero en base 16
        }
        #endregion
    }
}
