using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class NumericService
    {
        private int[] Valores;
        private int Contador;
        public NumericService() //constructor
        {
            Valores = new int[100];
            Contador = 0;
        }
        public void Registrar(int valor) 
        {
            if (Contador<100 && Contador>=0) 
            {
                Valores[Contador] = valor;
                Contador++;
            }
        }
        public int VerContador() 
        {
            return Contador;
        }
        public int VerValores(int idx) 
        {
            if (idx>=0 && idx<Contador) 
            {
                return Valores[idx];
            }

            return 0;
        }
        public double CalcularPromedio() 
        {
            int acum=0;
            double prom = 0;

            for (int i = 0; i < Contador; i++) 
            {
                acum += Valores[i];
            }
            if (Contador>0) 
            {
                prom= 1.0*acum/Contador;
            }
            return prom;
        }
        public int Buscar(int valor) 
        {
            int idx = -1;
            int n = 0;

            while (n < Contador && idx == -1)
            {
                if (Valores[n] == valor)
                {
                    idx = n;
                    return Valores[idx];
                }
                n++;
            }
            return idx;
        }
        public void OrdenarValores() 
        {
            int i = 0;
            int j = 0;
            int aux = 0;

            for (i=0;i<Contador-1;i++) 
            {
                for (j = i+1; j < Contador; j++) 
                {
                    if (Valores[i] > Valores[j])
                    {
                        aux = Valores[i];
                        Valores[i] = Valores[j];
                        Valores[j] = aux;
                    }
                }
            }
        }

        /*int[] ListarValoresSuperiores(int cant) 
        {

        }
        */

    }
}
