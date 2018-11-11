using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace ProyectoASPEmenic.Clases
{
    public class Validacion
    {
        Regex regex = new Regex("^\\d{8}-\\d$");

        //validacion de DUI
        public Boolean EsDui(String dui)
        {
            if (regex.IsMatch(dui))
            {
                int digitoVerificador = Convert.ToInt32(dui.Substring(9, 1));
                int suma = 0;
                for (int i = 9; i >= 2; i--)
                {
                    int digito = Convert.ToInt32(dui.Substring(9 - i, 1));
                    suma += (i * digito);
                }
                int residuoVerificador = 10 - (suma % 10);
                if (digitoVerificador == residuoVerificador || residuoVerificador == 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        //validacion de NIT
        public Boolean EsNit(string cadena)
        {
            //Creamos metodo estatico para poderlo llamar en cualquier parte; pedimos como datos una cadena string donde se aloja el nit
            int calculo = 0;//Variable para llevar el control de la suma del algoritmo
            int digitos = Int32.Parse(cadena.Substring(11, 4));//Tomamos los digitos que estan entre la posicion 12 y 15
            bool resultado;

            if (digitos <= 100)
            {//Verificamos que estos digitos sean menores o iguales a 100

                for (int posicion = 0; posicion <= 14; posicion++)
                {
                    //Ciclo que nos ayuda a ir aumentando la posicion que se utiliza posteriormente en el algoritmo
                    if (!(posicion == 4 || posicion == 11))
                    {
                        calculo += (14 * (int)(Char.GetNumericValue(cadena[posicion])));

                    }
                    //Si la posicion no es 4 ni 11 (que son los guiones) se ejecuta esta operacion
                    calculo = calculo % 11;//Al calculo se le va sacando el modular de 11
                }
            }
            else
            {
                int n = 1;//Variable contadora
                for (int posicion = 0; posicion <= 14; posicion++)
                {
                    //Ciclo que nos ayuda a ir aumentando la posicion que se utiliza posteriormente en el algoritmo
                    if (!(posicion == 4 || posicion == 11))
                    {
                        double absoluto = Math.Abs((n + 4) / 6);
                        calculo = (int)(calculo + (((int)Char.GetNumericValue(cadena[posicion])) * ((3 + 6 * Math.Floor(absoluto)) - n)));
                        n++;
                    }
                    //Si la posicion no es 4 ni 11 (que son los guiones) se ejecuta esta operacion
                }
                calculo = calculo % 11;//sacamos el modular 11 de calculo
                if (calculo > 1)
                {
                    calculo = 11 - calculo;//Si el resultado nos da mayor a uno se le resta a 11 esta respuesta
                }
                else
                {
                    calculo = 0;//Sino el calculo lo hacemos 0
                }
            }
            resultado = (calculo == (int)(Char.GetNumericValue(cadena[16]))); //Verificamos si el calculo es direfente del resultado de nuestro algoritmo, si lo es entonces es falso
            return resultado;//enviamos el resultado
        }

        

    }
}