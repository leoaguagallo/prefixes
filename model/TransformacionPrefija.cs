using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionArimetica_Infija_Posfija_Prefija.model
{
    public class TransformacionPrefija
    {
        public Pila pila;
        public string expresionInfija;
        public int numeroCaracteres;
        public char[] VectorInfijo; //expresion normal es igual a infijo
        public char[] VectorPrefijo;
        public List<char> repos;

        public TransformacionPrefija(string expresionInfija)
        {
            this.expresionInfija = expresionInfija;
            this.numeroCaracteres = expresionInfija.Length;
            this.pila = new Pila(numeroCaracteres);
            this.VectorInfijo = new char[numeroCaracteres];
            this.VectorPrefijo = new char[numeroCaracteres];
            this.repos = new List<char>();
        }

        public void ExpresionInfijoToVector()
        {
            VectorInfijo = expresionInfija.ToCharArray();
        }

        public int prioridadOnExpresion(char caracter)
        {
            int prioridad = -1;

            switch (caracter)
            {
                case '+':
                case '-':
                    prioridad = 1;
                    break;

                case '*':
                case '/':
                    prioridad = 2;
                    break;

                case '^':
                    prioridad = 4;
                    break;

                case '(':
                    prioridad = 5;
                    break;

                case ')':
                    prioridad = -2;
                    break;
            }

            return prioridad;
        }

        public int prioridadOnPila(char caracter)
        {
            int prioridad = -1;

            switch (caracter)
            {
                case '(':
                    prioridad = 0;
                    break;

                case '+':
                case '-':
                    prioridad = 1;
                    break;

                case '*':
                case '/':
                    prioridad = 2;
                    break;

                case '^':
                    prioridad = 3;
                    break;
            }

            return prioridad;
        }

        public void TransformarPrefija()
        {
            int cont = 0;

            for (int i = 0; i < numeroCaracteres; i++)
            {
                if (pila.pilaVacia() && (prioridadOnExpresion(VectorInfijo[i]) != -1))
                {
                    pila.apilar(VectorInfijo[i]);
                }
                else if (prioridadOnExpresion(VectorInfijo[i]) == -1)
                {
                    repos.Add(VectorInfijo[i]);
                }
                else if (prioridadOnExpresion(VectorInfijo[i]) == -2) // si se cierra parentesis ")"
                {
                    while (!pila.pilaVacia())
                    {
                        string au = pila.cimaPila() + "";
                        if (!au.Equals("("))
                        {
                            VectorPrefijo[cont] = (char)pila.desapilar();
                            cont++;
                        }
                        else
                        {
                            pila.desapilar();
                            break;
                        }
                    }
                }
                else if (prioridadOnExpresion(VectorInfijo[i]) > prioridadOnPila((char)pila.cimaPila()))
                {
                    pila.apilar(VectorInfijo[i]);
                }
                else if (prioridadOnExpresion(VectorInfijo[i]) <= prioridadOnPila((char)pila.cimaPila()))
                {
                    VectorPrefijo[cont] = VectorInfijo[i];
                    cont++;

                    while (!pila.pilaVacia() && (prioridadOnExpresion(VectorInfijo[i]) <= prioridadOnPila((char)pila.cimaPila())))
                    {
                        VectorPrefijo[cont] = (char)pila.desapilar();
                        cont++;
                    }
                    
                    for (int k = 0; k < repos.Count(); k++)
                    {
                        VectorPrefijo[cont] = repos.ElementAt(k);
                        cont++;
                    }

                    repos = null;
                    repos = new List<char>();
                }

            }

            while (!pila.pilaVacia())
            {
                VectorPrefijo[cont] = (char)pila.desapilar();
                cont++;

            }

            for (int k = 0; k < repos.Count(); k++)
            {
                    VectorPrefijo[cont] = repos.ElementAt(k);
                    //repos.RemoveAt(k); //remuevo de la lista el caracter
                    cont++;
            }
         

        }

        public string getExpresionPREFIJA()
        {
            string res = "";
            for (int i = 0; i < numeroCaracteres; i++)
            {
                res += VectorPrefijo[i];
            }
            return res;
        }


    }

}
