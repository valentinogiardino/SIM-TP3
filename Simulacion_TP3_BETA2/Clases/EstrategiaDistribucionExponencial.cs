using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP1.Clases
{
    public class EstrategiaDistribucionExponencial : EstrategiaTipoDistribucion     //Estrategia concreta que implementa la interfaz EstrategiaTipoDistribucion
    {
        private double parametroUno;

        public double ParametroUno { get => parametroUno; set => parametroUno = value; }

        public EstrategiaDistribucionExponencial()
        {
        }

        //Implementa el metodo polimorfico para generar los numeros aleatorios
        public List<double> generarNumeros(double parametroUno, double parametroDos, int cantidadNumerosSolicitados)
        {
            parametroUno = Math.Abs(parametroUno);
            this.parametroUno = parametroUno;
            List<double> listaNumeroGenerados = new List<double>();         // Crea una lista vacia de numeros generados

            Random random = new Random();
            double rnd;
            double x;
            do
            {

                rnd = random.NextDouble(); //Este truncamiento ajusta a la cantidad de decimales requerida
                x = -this.parametroUno * Math.Log(1 - rnd);
                listaNumeroGenerados.Add(x);              // agrega el numero generado a la lista


            } while (listaNumeroGenerados.Count < cantidadNumerosSolicitados);                    // el ciclo se repite solo 1 periodo.
            return listaNumeroGenerados;
        }

        //Implementa el metodo polimorfico para calcular la FE
        public double calcularFE(double limInf, double limSup, int cantidadNumerosSolicitados, int cantidadIntervalos)
        {

            //double p = (1 - Math.Exp(-parametroUno * limSup)) - (1 - Math.Exp(-parametroUno * limInf));
            double p = (1 - Math.Exp(-(1/parametroUno) * limSup)) - (1 - Math.Exp(-(1/parametroUno) * limInf));

            return (p * cantidadNumerosSolicitados);
        }
    }

}
