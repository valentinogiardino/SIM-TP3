using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Simulacion_TP1.Clases;

namespace Simulacion_TP1.Controlador
{
    public class Gestor
    {
        private Pantalla pantalla;
        private Histograma pantallaReporte;
        private Generador generador;        //guarda referencia al generador creado
        public List<double> listaNumerosGenerados;
        public int[] arregloFrecuencias;
        public List<double> listaIntervalos;
        private int cantidadNumerosSolicitados;
        private int cantidadDecimales;
        private int cantidadIntervalosChi;
        private double estadisticoPrueba;
        private double estadisticoPruebaKS;

        private List<Renglon> primeraTablaEstadistica;

        public Pantalla Pantalla { get => pantalla; set => pantalla = value; }
        public int CantidadIntervalosChi { get => cantidadIntervalosChi; set => cantidadIntervalosChi = value; }
        public double EstadisticoPrueba { get => estadisticoPrueba; set => estadisticoPrueba = value; }

        public double EstadisticoPruebaKS { get => estadisticoPruebaKS; set => estadisticoPruebaKS = value; }
        public List<Renglon> PrimeraTablaEstadistica { get => primeraTablaEstadistica; set => primeraTablaEstadistica = value; }
        public Histograma PantallaReporte { get => pantallaReporte; set => pantallaReporte = value; }

        public Gestor(Pantalla pantalla)
        {
            this.pantalla = pantalla;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Crea un generador y le delega la generacion de los numeros aleatorios en la distribucion seleccionada
        public void generarNumeros(string funcion, int cantidadNumeros, double parametroUno, double parametroDos, int cantidadDecimales, int cantidadIntervalos)
        {
            this.cantidadNumerosSolicitados = cantidadNumeros;
            this.cantidadDecimales = cantidadDecimales;

            this.generador = new Generador(funcion, cantidadNumeros, parametroUno, parametroDos, cantidadDecimales, cantidadIntervalos);
            this.listaNumerosGenerados = new List<double>();
            foreach (double numero in this.generador.generarNumeros())
            {
                this.listaNumerosGenerados.Add(ajustarDecimales(numero));
            }
            obtenerFrecuencias();

        }

        //Se invoca al metodo del generador para contabilizar las frecuencias. 
        public int[] obtenerFrecuencias()
        {

            this.listaIntervalos = this.generador.generarIntervalos(this.listaNumerosGenerados);  //El gestor guarda los resultados en sus atributos.
            this.arregloFrecuencias = this.generador.contarFrecuencias(this.listaNumerosGenerados, this.listaIntervalos);
            return this.arregloFrecuencias;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Se instancia una pantalla para visualizar los reportes
        public void generarReporte()
        {
            Histograma pantallaReporte = new Histograma(this);
            this.pantallaReporte = pantallaReporte;
            pantallaReporte.ShowDialog();
        }

        public void cargarPantallaHistograma()
        {
            this.pantallaReporte.CargarTablaNumerosGenerados(listaNumerosGenerados);
            this.pantallaReporte.cargarTablaEstadisticaInicial();
            this.pantallaReporte.CargarReporte();
            this.pantallaReporte.cargarTablaChi();
            this.pantallaReporte.cargarTablaKS();
            this.pantallaReporte.MostrarChiCuadrado();
            this.pantallaReporte.MostrarKS();
        }


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //Se genera la tabla estadistica de frecuencias
    public DataTable generarTablaEstadisticaInicial()
        {
            DataTable tabla = new DataTable();
            DataColumn columna1 = new DataColumn("Desde");
            DataColumn columna2 = new DataColumn("Hasta");
            DataColumn columna3 = new DataColumn("FO");
            DataColumn columna4 = new DataColumn("FE");
            tabla.Columns.Add(columna1);
            tabla.Columns.Add(columna2);
            tabla.Columns.Add(columna3);
            tabla.Columns.Add(columna4);
            this.primeraTablaEstadistica = generarRenglonesPrimeraTablaEstadistica();   //Se crean los renglones de la tabla y luego se los itera
            foreach (Renglon renglon in primeraTablaEstadistica)
            {
                DataRow row = tabla.NewRow();
                row["Desde"] = renglon.Desde.ToString();
                row["Hasta"] = renglon.Hasta.ToString();
                row["FO"] = renglon.Fo.ToString();
                row["FE"] = renglon.Fe.ToString();

                tabla.Rows.Add(row);
            }
            return tabla;
        }

        //Se crea una lista de Renglones
        private List<Renglon> generarRenglonesPrimeraTablaEstadistica()
        {
            List<Renglon> tabla = new List<Renglon>();
            double limiteSup = this.listaNumerosGenerados.Max();
            double limiteInf = this.listaNumerosGenerados.Min();
            double amplitud = (limiteSup - limiteInf) / this.arregloFrecuencias.Count();

            for (int i = 0; i < this.listaIntervalos.Count; i++)            //El ciclo genera el nuevo limite a partir del limite anterior, sumandole la amplitud
            {
                double desde = ajustarDecimales(listaIntervalos[i] - amplitud);
                double hasta = listaIntervalos[i];
                double fo = arregloFrecuencias[i];
                double fe = ajustarDecimales(this.generador.calcularFE(desde, hasta));
                Renglon renglon = new Renglon(desde, hasta, fo, fe);
                tabla.Add(renglon);
            }
            return tabla;

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Se crea la tabla para generar el Histograma
        public DataTable generarTablaGrafico(List<double> listaFE)
        {
            DataTable tabla = new DataTable();
            DataColumn columna1 = new DataColumn("Intervalo");
            DataColumn columna2 = new DataColumn("FO");
            DataColumn columna3 = new DataColumn("FE");
            tabla.Columns.Add(columna1);
            tabla.Columns.Add(columna2);
            tabla.Columns.Add(columna3);


            double limiteSup = listaNumerosGenerados.Max();
            double limiteInf = listaNumerosGenerados.Min();
            double amplitud = (limiteSup - limiteInf) / this.arregloFrecuencias.Length;

            string frecuenciaEsperada = ((double)cantidadNumerosSolicitados / (double)this.arregloFrecuencias.Length).ToString();
            

            string funcion = this.generador.Funcion;

            string UiRegion = Thread.CurrentThread.CurrentUICulture.Name;       

            for (int i = 0; i < this.arregloFrecuencias.Length; i++)
            {
                DataRow row = tabla.NewRow();
                double limiteInferior = Math.Round((this.listaIntervalos[i] - amplitud), this.cantidadDecimales);
                if (funcion == "Poisson")
                {
                    row["Intervalo"] = limiteInferior.ToString();
                }
                else
                {
                    row["Intervalo"] = limiteInferior.ToString() + " - " + this.listaIntervalos[i].ToString();
                }
                row["FO"] = this.arregloFrecuencias[i];
                if (UiRegion == "es-ES")
                {
                    row["FE"] = listaFE[i].ToString();
                }
                else
                {
                    string frecuenciaEsperada2 = listaFE[i].ToString().Replace(",", ".");       //Se incluyo debido a problemas en el reporte generados por diferencia el el lenguaje de maquina que ejecuta
                    row["FE"] = frecuenciaEsperada2;
                }
                tabla.Rows.Add(row);
            }

            return tabla;
        }


        //Permite ajustar los decimales a los requeridos por el usuario
        private double ajustarDecimales(double numero)
        {
            double ajusteCantidadDecimales = Math.Pow(10, this.cantidadDecimales);
            return Math.Truncate((numero)* ajusteCantidadDecimales) / ajusteCantidadDecimales;
        }

        //Permite ajustar los decimales a una cantidad recibida por parametro
        private double ajustarDecimales(double numero, int cantidadDecimales)
        {
            double ajusteCantidadDecimales = Math.Pow(10, cantidadDecimales);
            return Math.Truncate((numero) * ajusteCantidadDecimales) / ajusteCantidadDecimales;
        }





        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Se genera la tabla para la prueba de chi cuadrado
        public DataTable generarTablaChi()
        {
            DataTable tabla = new DataTable();
            DataColumn columna1 = new DataColumn("Desde");
            DataColumn columna2 = new DataColumn("Hasta");
            DataColumn columna3 = new DataColumn("FO");
            DataColumn columna4 = new DataColumn("FE");
            DataColumn columna5 = new DataColumn("C");
            DataColumn columna6 = new DataColumn("C_AC");
            
            tabla.Columns.Add(columna1);
            tabla.Columns.Add(columna2);
            tabla.Columns.Add(columna3);
            tabla.Columns.Add(columna4);
            tabla.Columns.Add(columna5);
            tabla.Columns.Add(columna6);
            
            List<Renglon> lista = agruparRenglonesChi();            //Se genera una lista de renglones y se itera sobre ella para conformar la tabla
            foreach (Renglon renglon in lista)
            {
                DataRow row = tabla.NewRow();
                row["Desde"] = renglon.Desde.ToString();
                row["Hasta"] = renglon.Hasta.ToString();
                row["FO"] = renglon.Fo.ToString();
                row["FE"] = renglon.Fe.ToString();
                row["C"] = renglon.C.ToString();
                row["C_AC"] = renglon.C_ac.ToString();
              

                tabla.Rows.Add(row);
            }
            return tabla;
        }

        //Se agrupan los renglones de la tabla estadistica de frecuencias
        private List<Renglon> agruparRenglonesChi()
        {
            double c_Ac = 0;
            List<Renglon> tablaEstadisitica = this.primeraTablaEstadistica;
            List<Renglon> tablaChi = new List<Renglon>();
            for (int i = 0; i < tablaEstadisitica.Count; i++)               //Por cada intervalo guarda los datos del pivot de inicio
            {
                double nuevaFe = tablaEstadisitica[i].Fe;
                double nuevaFo = tablaEstadisitica[i].Fo;

                double desde = tablaEstadisitica[i].Desde;
                double nuevoHasta = tablaEstadisitica[i].Hasta;
                while (nuevaFe < 5)                                         //Si la FE es menor a 5 no se puede realizar la prueba de Chi-Cuadrado
                {                                                           //Debido a esto se agrupan los intervalos hacia adelante para llegar a 5
                    i++;
                    if (i >= tablaEstadisitica.Count)                       //Si no hay un siguiente intervalo para agrupar se corta
                    {
                        break;
                    }
                    nuevoHasta = tablaEstadisitica[i].Hasta;
                    nuevaFo += tablaEstadisitica[i].Fo;
                    nuevaFe += tablaEstadisitica[i].Fe;
                }
                if (nuevaFe >= 5)                                          //En caso de haber acumulado una FE mayor o igual a 5, se guarda el nuevo intervalo agrupado
                {                                                          

                    double c = ajustarDecimales((double)((Math.Pow((nuevaFe - nuevaFo), 2)) / nuevaFe), 4);
                    c_Ac += c;
                    Renglon renglon = new Renglon(desde, nuevoHasta, nuevaFo, nuevaFe);
                    renglon.C = c;
                    renglon.C_ac = c_Ac;
                    tablaChi.Add(renglon);
                }
                else
                {
                    //Si se llego al final y no se pudo obtener una FE mayor o igual a 5, se agrupa el restante con el ultimo intervalo ya agrupado
                    if (tablaChi.Count > 0)        //Se comprueba que exista un intervalo correctamente agrupado                        
                    {
                        Renglon ultimoRenglon = tablaChi.Last<Renglon>();       
                        tablaChi.RemoveAt(tablaChi.Count - 1);
                        ultimoRenglon.Hasta = nuevoHasta;
                        ultimoRenglon.Fo += nuevaFo;
                        ultimoRenglon.Fe += nuevaFe;

                        double c = ajustarDecimales((double)((Math.Pow((ultimoRenglon.Fe - ultimoRenglon.Fo), 2)) / ultimoRenglon.Fe), 4);
                        ultimoRenglon.C = c;
                        c_Ac += c;
                        ultimoRenglon.C_ac = c_Ac;
                        tablaChi.Add(ultimoRenglon);
                    }
                    
                }


            }

            this.cantidadIntervalosChi = tablaChi.Count();
            if (cantidadIntervalosChi > 0)
            {
                this.estadisticoPrueba = tablaChi.Last<Renglon>().C_ac;
            }
            return tablaChi;

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Se genera la tabla para la prueba de KS 
        public DataTable generarTablaKS()
        {
            DataTable tabla = new DataTable();
            DataColumn columna1 = new DataColumn("Desde");
            DataColumn columna2 = new DataColumn("Hasta");
            DataColumn columna3 = new DataColumn("FO");
            DataColumn columna4 = new DataColumn("FE");
            DataColumn columna5 = new DataColumn("PO");
            DataColumn columna6 = new DataColumn("PE");
            DataColumn columna7 = new DataColumn("PO_AC");
            DataColumn columna8 = new DataColumn("PE_AC");
            DataColumn columna9 = new DataColumn("|PO_AC-PE_AC|");
            DataColumn columna10 = new DataColumn("MAX");

            tabla.Columns.Add(columna1);
            tabla.Columns.Add(columna2);
            tabla.Columns.Add(columna3);
            tabla.Columns.Add(columna4);
            tabla.Columns.Add(columna5);
            tabla.Columns.Add(columna6);
            tabla.Columns.Add(columna7);
            tabla.Columns.Add(columna8);
            tabla.Columns.Add(columna9);
            tabla.Columns.Add(columna10);

            List<Renglon> lista = generarRenglonesKS();         //Se crean los renglones del KS y se los itera para conformar la tabla
            foreach (Renglon renglon in lista)
            {
                DataRow row = tabla.NewRow();
                row["Desde"] = renglon.Desde.ToString();
                row["Hasta"] = renglon.Hasta.ToString();
                row["FO"] = renglon.Fo.ToString();
                row["FE"] = renglon.Fe.ToString();
                row["PO"] = renglon.Po.ToString();
                row["PE"] = renglon.Pe.ToString();
                row["PO_AC"] = renglon.Po_Ac.ToString();
                row["PE_AC"] = renglon.Pe_ac.ToString();
                row["|PO_AC-PE_AC|"] = renglon.Diferencia_pope.ToString();
                row["MAX"] = renglon.Max.ToString();


                tabla.Rows.Add(row);
            }
            return tabla;
        }

        //Se crean los renglones para la prueba de KS a partir de la tabla estadistica de frecuencia
        private List<Renglon> generarRenglonesKS()          
        {
            List<Renglon> tablaEstadisitica = this.primeraTablaEstadistica;
            List<Renglon> tablaKS = new List<Renglon>();
            double po_ac = 0;
            double pe_ac = 0;
            double max = 0;
            foreach (Renglon renglon in tablaEstadisitica)
            {
                double po = ajustarDecimales((renglon.Fo / this.cantidadNumerosSolicitados),4);
                double pe = ajustarDecimales((renglon.Fe / this.cantidadNumerosSolicitados),4);
                po_ac += po;
                pe_ac += pe;

                double diferenciaPope = ajustarDecimales(Math.Abs(po_ac - pe_ac),4);

                if (diferenciaPope > max)           //Se busca la mayor diferencia |PO - PE|
                {
                    max = diferenciaPope;
                }
                Renglon renglonKS = renglon;
                renglonKS.Po = po;
                renglonKS.Pe = pe;
                renglonKS.Po_Ac = po_ac;
                renglonKS.Pe_ac = pe_ac;
                renglonKS.Diferencia_pope = diferenciaPope;
                renglonKS.Max = max;

                tablaKS.Add(renglonKS);
            }
            this.estadisticoPruebaKS = tablaKS.Last<Renglon>().Max;
            return tablaKS;

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Realiza la prueba de ChiCuadrado comparando el estadistico de prueba con el valor critico tabulado
        public bool pruebaChiCuadrado()
        {
            bool rechazarHipotesis = true;

            if (this.estadisticoPrueba <= obtenerValorCriticoTabulado())
            {
                rechazarHipotesis = false;
            }
            return rechazarHipotesis;
        }

        //Obtiene el valor critico tabulado para una confianza del 95
        private double obtenerValorCriticoTabulado()
        {
            double[] valoresCriticos = new double[] { -1, 3.84, 5.99, 7.82, 9.49, 11.07, 12.59, 14.07, 15.51, 16.92, 18.31, 19.68, 21.03, 22.36, 23.69, 25, 26.3, 27.59, 28.87, 30.14, 31.41, 32.67, 33.92, 35.17, 36.42, 37.65, 38.89, 40.11, 41.34, 42.56, 43.77, 44.99, 46.19, 47.4, 48.6, 49.8, 51, 52.19, 53.38, 54.57, 55.76, 56.94, 58.12, 59.3, 60.48, 61.66, 62.83, 64, 65.17, 66.34, 67.51 };

            int datosEmpiricos = obtenerCantidadDatosEmpiricos();

            int gradosLibertad = this.cantidadIntervalosChi - 1 - datosEmpiricos;

            if (gradosLibertad <= 0)
            {
                return valoresCriticos[0];
            }


            return valoresCriticos[gradosLibertad];
        }

        //Segun la funcion de distribucion retorna la cantidad de datos empiricos empleados
        private int obtenerCantidadDatosEmpiricos()
        {
            switch (this.generador.Funcion)
            {
                case "Exponencial":
                    return 1;
                case "Normal":
                    return 2;
                case "Normal-Convolucion":
                    return 2;
                case "Uniforme":
                    return 0;
                case "Poisson":
                    return 1;
                default:
                    int fe = -1;
                    return fe;

            }
        }


        public String nombreFuncion()
        {
            String funcion;
            funcion = this.generador.Funcion;
            if (funcion == "Normal-Convolucion")
            {
                funcion = "Normal";
            }
            return funcion;
        }


        public double[] mostrarValorChi()
        {
            double[] valores = new double[2];

            valores[0] = this.obtenerValorCriticoTabulado();
            valores[1] = this.estadisticoPrueba;

            return valores;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool pruebaKS()
        {
            bool rechazarHipotesis = true;

            if (this.estadisticoPruebaKS <= obtenerValorCriticoTabuladoKS())
            {
                rechazarHipotesis = false;
            }
            return rechazarHipotesis;
        }

        private double obtenerValorCriticoTabuladoKS()
        {
            double[] valoresCriticos = new double[] { 0.97500, 0.84189, 0.70760, 0.62394, 0.56328, 0.51926, 0.48342, 0.45427, 0.43001, 0.40925, 0.39122, 0.37543, 0.36143, 0.34890, 0.33750, 0.32733, 0.31796, 0.30936, 0.30143, 0.29408, 0.28724, 0.28087, 0.2749, 0.26931, 0.26404, 0.25908, 0.25438, 0.24993, 0.24571, 0.24170, 0.23788, 0.23424, 0.23076, 0.22743, 0.22425, 0.22119, 0.21826, 0.21544, 0.21273, 0.21012, 0.20760, 0.20517, 0.20283, 0.20056, 0.19837, 0.19625, 0.19420, 0.19221, 0.19028, 0.18841 };

            if (this.cantidadNumerosSolicitados > 50)
            {
                return (1.36 / Math.Sqrt(this.cantidadNumerosSolicitados));
            }

            return valoresCriticos[this.cantidadNumerosSolicitados -1 ];
        }

        public double[] mostrarValorKS()
        {
            double[] valores = new double[2];

            valores[0] = this.obtenerValorCriticoTabuladoKS();
            valores[1] = this.estadisticoPruebaKS;

            return valores;
        }

        




    }
}
