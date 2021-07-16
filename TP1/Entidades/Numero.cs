using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            SetNumero = numero.ToString();
        }
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }
        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        private double ValidarNumero(string strNumero)
        {
            double ValidatedNumber;
            if (double.TryParse(strNumero, out ValidatedNumber) == false)
            {
                ValidatedNumber = 0;
            }

            return ValidatedNumber;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double output;

            output = n1.numero + n2.numero;

            return output;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            double output;

            output = n1.numero - n2.numero;

            return output;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double output;

            if (n2.numero == 0)
            {
                output = Double.MinValue;
            }
            else
            {
                output = n1.numero / n2.numero;
            }

            return output;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            double output;

            output = n1.numero * n2.numero;

            return output;
        }


        private static bool EsBinario(string strNumero)
        {
            bool output = true;

            if (!String.IsNullOrEmpty(strNumero))
            {
                foreach (char auxChar in strNumero)
                {
                    if (auxChar != '0' && auxChar != '1')
                    {
                        output = false;
                        break;
                    }
                }
            }
            return output;
        }

        public static string BinarioDecimal(string binario)
        {           
            StringBuilder sb = new StringBuilder();                            

            if (Numero.EsBinario(binario) == true)
            {
                sb.Append( Convert.ToInt32(binario, 2).ToString());
            }
            else
            {
                sb.Append("Valor Invalido");
            }

            return sb.ToString();
        }
        public static string DecimalBinario(double numero)
        {
            return Convert.ToString((int)Math.Abs(numero), 2);
        }
        public static string DecimalBinario(string numero)
        {
            StringBuilder sb = new StringBuilder();
            

            if (double.TryParse(numero, out double resultado))
            {
                sb.Append(DecimalBinario(resultado));
            }
            else
            {
                sb.Append("Valor Invalido");
            }

            return sb.ToString();
        }

    }
}
