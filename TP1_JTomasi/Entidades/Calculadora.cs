﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static double Operar(Numero n1, Numero n2, string operador)
        {
            double ret = 0;
            switch (ValidarOperador(operador))
            {
                case "+":
                    ret = n1 + n2;
                    break;
                case "/":
                    ret = n1 / n2;
                    break;
                case "*":
                    ret = n1 * n2;
                    break;
                case "-":
                    ret = n1 - n2;
                    break;
            }
            return ret;
        }

        private static string ValidarOperador(string operador)
        {
            if (operador.In("+", "-", "/", "*"))
                return operador;
            return "+";
        }
    }
}
