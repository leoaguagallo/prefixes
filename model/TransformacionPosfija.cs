namespace ConversionArimetica_Infija_Posfija_Prefija.model
{
    public class TransformacionPosfija
    {
        public Pila pila;
        public string expresionInfija;
        public int numeroCaracteres;
        public char[] VectorInfijo; //expresion normal es igual a infijo
        public char[] VectorPosfijo;

        public TransformacionPosfija(string expresionInfija)
        {
            this.expresionInfija = expresionInfija;
            this.numeroCaracteres = expresionInfija.Length;
            this.pila = new Pila(numeroCaracteres);
            this.VectorInfijo = new char[numeroCaracteres];
            this.VectorPosfijo = new char[numeroCaracteres];
        }

        public void ExpresionInfijoToVector()
        {
            //for (int i = 0; i < numeroCaracteres; i++)
            //{
            //    VectorInfijo[i] = expresionInfija.ToCharArray();
            //}
            VectorInfijo = expresionInfija.ToCharArray();
        }

        public int prioridadCaracter(char caracter)
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
                    prioridad = 3;
                    break;

                default:
                    break;
            }

            return prioridad;
        }

        public void TransformarPostfijo()
        {
            int cont = 0;

            for (int i = 0; i < numeroCaracteres; i++)
            {
                if (pila.pilaVacia() && (prioridadCaracter(VectorInfijo[i]) != -1))
                {
                    pila.apilar(VectorInfijo[i]);
                }
                else if (prioridadCaracter(VectorInfijo[i]) == -1)
                {
                    VectorPosfijo[cont] = VectorInfijo[i];
                    cont++;
                }
                else if (prioridadCaracter(VectorInfijo[i]) > prioridadCaracter((char)pila.cimaPila()))
                {
                    pila.apilar(VectorInfijo[i]);
                }
                else if (prioridadCaracter(VectorInfijo[i]) <= prioridadCaracter((char)pila.cimaPila()))
                {

                    while (!pila.pilaVacia() && (prioridadCaracter(VectorInfijo[i]) <= prioridadCaracter((char)pila.cimaPila())))
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
