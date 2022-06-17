using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simulacion_TP1.Clases
{
    public class EstrategiaDistribucionNormalConvolucion : AbstractDistribucionNormal       //Clase hija que Hereda de AbstractDistribucionNormal
    {
        public EstrategiaDistribucionNormalConvolucion()
        {
        }

        //Sobreescribe el metodo vacio definido en el padre
        public override List<double> generarNumeros(double parametroUno, double parametroDos, int cantidadNumerosSolicitados)
        {
            parametroDos = Math.Abs(parametroDos);
            this.parametroUno = parametroUno;
            this.parametroDos = parametroDos;
            double acum = 0;
            double z;

            List<double> listaNumeroGenerados = new List<double>();         // Crea una lista vacia de numeros generados

            Random random = new Random();
            do
            {
                for (int i = 0; i < 12; i++)
                {
                    acum += random.NextDouble();
                    Thread.Sleep(1);
                }

                z = ((acum - 6) * this.parametroDos + this.parametroUno);
                acum = 0;


                listaNumeroGenerados.Add(z);

            } while (listaNumeroGenerados.Count < cantidadNumerosSolicitados);                    // el ciclo se repite solo 1 periodo.
            return listaNumeroGenerados;
        }


        //El metodo para calcular la FE lo desde el padre
    }
}
