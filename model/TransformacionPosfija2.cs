namespace ConversionArimetica_Infija_Posfija_Prefija.model
{
    public class TransformacionPosfija2
    {
        public Pila pila;
        public string expresionInfija;
        public int numeroCaracteres;
        public char[] VectorInfijo; //expresion normal es igual a infijo
        public char[] VectorPosfijo;

        public TransformacionPosfija2(string expresionInfija)
        {
            this.expresionInfija = expresionInfija;
            this.numeroCaracteres = expresionInfija.Length;
            this.pila = new Pila(numeroCaracteres);
            this.VectorInfijo = new char[numeroCaracteres];
            this.VectorPosfijo = new char[numeroCaracteres];
        }

        public void ExpresionInfijoToVector()
        {
            VectorInfijo = expresionInfija.ToCharArray();
        }

        public string getVecInfijo()
        {
            string r = "";
            for (int i = 0; i < VectorInfijo.Length; i++)
            {
                r += VectorInfijo[i] + " - ";
            }
            return r;
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

        public void TransformarPostfijo()
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
                    VectorPosfijo[cont] = VectorInfijo[i];
                    cont++;
                }
                else if (prioridadOnExpresion(VectorInfijo[i]) == -2) // si se cierra parentesis ")"
                {
                    while (!pila.pilaVacia())
                    {
                        string au = pila.cimaPila() + "";
                        if (!au.Equals("("))
                        {
                            VectorPosfijo[cont] = (char)pila.desapilar();
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
                    while (!pila.pilaVacia() && (prioridadOnExpresion(VectorInfijo[i]) <= prioridadOnPila((char)pila.cimaPila())))
                    {
                        VectorPosfijo[cont] = (char)pila.desapilar();
                        cont++;
                    }
                    pila.apilar(VectorInfijo[i]);
                }

            }

            while (!pila.pilaVacia())
            {
                VectorPosfijo[cont] = (char)pila.desapilar();
                cont++;

            }

        }

        public string getExpresionPOSFIJA()
        {
            string res = "";
            for (int i = 0; i < numeroCaracteres; i++)
            {
                res += VectorPosfijo[i];
            }
            return res;
        }
    }
}
