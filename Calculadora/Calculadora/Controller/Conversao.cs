using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Controller
{
    class Conversao
    {
        public static string InverterString(string str)
        {
            int tamanho = str.Length;

            char[] caracteres = new char[tamanho];

            for (int i = 0; i < tamanho ; i++)
            {
                caracteres[i] = str[tamanho - 1 - i];
            }

            return new string(caracteres);
        }
        public static string DecimalParaBinario(string numero)
        {
            long vlr = long.Parse(numero);
            string result = Convert.ToString(vlr, 2);

            string zero = "";
            int dif = 8 - result.Length;
            if(dif > 0)
            {
                for (int x = 1; x <= dif; x++)
                {
                    zero += "0";
                }

            }
             return zero + result;




            //int dividendo = Convert.ToInt32(numero);

            //if (dividendo == 0 || dividendo == 1)
            //{
            //    if(dividendo == 0)
            //    {
            //        for (int i = 0; i < 8; i++)
            //        {
            //            completa = "0" + completa;
            //        }
            //    }else if(dividendo == 1)
            //    {
            //        for (int i = 0; i < 8; i++)
            //        {
            //            completa = "0" + completa;
            //        }
            //    }
                
            //        return Convert.ToString(completa);
                
            //}

            //else 
            //{

            //    while (dividendo > 0)
            //    {

            //        valor += Convert.ToString(dividendo % 2);

            //        dividendo = dividendo / 2;

            //    }

            //    return InverterString(valor);

            //}

        }
    }
}
