using System;

namespace ConversionArimetica_Infija_Posfija_Prefija.model
{
    public class Pila
    {
        public int tamanio;
        public int numeroElementos;
        public Object[] V;

        public Pila()
        {
        }

        public Pila(int tamanio)
        {
            this.numeroElementos = 0;
            this.tamanio = tamanio;
            this.V = new Object[tamanio];
        }

        public void apilar(Object elemento)
        {
            if (!pilaLlena())
            {
                V[numeroElementos] = elemento;
                numeroElementos++;
            }

        }

        public Object desapilar()
        {
            Object aux = null;
            if (!pilaVacia())
            {
                aux = V[numeroElementos - 1];
                numeroElementos--;
            }

            return aux;
        }

        public Boolean pilaVacia()
        {
            if (numeroElementos == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean pilaLlena()
        {
            if (numeroElementos == tamanio)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Object cimaPila()
        {
            return V[numeroElementos - 1];
        }

        //public string reportePila()
        //{
        //    string res = "Pila vacia!";
        //    if (!pilaVacia())
        //    {
        //        res = "DEUDOR \t VALOR \n";

        //        CuentasPorCobrar deudas;

        //        for (int i = 0; i < numeroElementos; i++)
        //        {
        //            deudas = (CuentasPorCobrar)V[i];
        //            res += deudas.nombrePersona + "\t" + deudas.valor + "\n";
        //        }
        //    }
        //    return res;
        //}
    }
}
