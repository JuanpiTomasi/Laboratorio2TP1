using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos y Propiedades
        private double _numero;

        private string SetNumero
        {
            set { _numero = ValidarNumero(value); }
        }
        #endregion

        #region Constructores
        public Numero()
        {

        }
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        public Numero(double numero)
        {
            this._numero = numero;
        }
        #endregion

        #region Metodos Privados
        private double ValidarNumero(string strNumero)
        {
            double aux = 0;
            double.TryParse(strNumero, out aux);
            return aux;
        }
        #endregion

        #region Metodos Publicos Estaticos

        public static string BinarioDecimal(string binario)
        {

            bool esValido = true;
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    esValido = false;
                    break;
                }
            }
            if (esValido)
            {
                double ret = 0;
                int pos = 0;
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    ret += Math.Pow(2, pos) * int.Parse(binario[i].ToString());
                    pos++;
                }
                return ret.ToString();
            }
            return "Valor Invalido";
        }



        public static string DecimalBinario(double numero)
        {
            string aux = "";
            string ret = "";
            numero = (int)numero;
            for (double i = numero; i >= 0; i--)
            {
                ret += (i % 2).ToString();
                i = (int)(i / 2);
                if (i == 0)
                    break;
                else
                    i++;
            }
            for (int i = ret.Length - 1; i >= 0; i--)
                aux += ret[i];

            return aux;
        }

        public static string DecimalBinario(string numero)
        {
            double aux = 0;
            if (double.TryParse(numero, out aux))
                return DecimalBinario(aux);
            return "Numero Invalido";
        }
        #endregion


        #region Operadores

        public static double operator +(Numero n1, Numero n2)
        {
            return n1._numero + n2._numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1._numero - n2._numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1._numero * n2._numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            return n1._numero / n2._numero;
        }
        #endregion
    }
}
