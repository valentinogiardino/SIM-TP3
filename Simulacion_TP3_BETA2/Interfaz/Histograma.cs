using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulacion_TP1.Controlador;

namespace Simulacion_TP1
{
    public partial class Histograma : Form
    {
        private Gestor gestor;

        //Constructor
        public Histograma(Gestor gestor)
        {
            
            InitializeComponent();
            this.gestor = gestor;           //Se guarda una referencia al gestor para permitir la comunicacion
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Histograma_Load(object sender, EventArgs e)
        {
            this.reporteChiCuadrado.RefreshReport();
            this.gestor.cargarPantallaHistograma();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Carga la tabla con los RNDs generados
        public void CargarTablaNumerosGenerados(List<double> listaNumerosGenerados)
        {
            for (int i = 0; i < listaNumerosGenerados.Count; i++)
            {
                gdrNumeroGenerados.Rows.Add(i + 1, listaNumerosGenerados[i]);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Carga la tabla estadistica de frecuencias
        public void cargarTablaEstadisticaInicial()
        {
            DataTable tabla = gestor.generarTablaEstadisticaInicial();    //Se le delega al gestor la generacion de la tabla
            dataGridView1.DataSource = tabla;
            dataGridView1.Refresh();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Se crea el Histograma
        public void CargarReporte()
        {
            List<double> listaFE = new List<double>();
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                listaFE.Add(double.Parse(fila.Cells[3].Value.ToString()));
            }
            DataTable tabla = gestor.generarTablaGrafico(listaFE);              //Se le delega al gestor la generacion de la tabla que servira de DataSource al histograma
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reporteChiCuadrado.LocalReport.ReportEmbeddedResource = "Simulacion_TP1.Interfaz.Informe.rdlc";
            reporteChiCuadrado.LocalReport.DataSources.Clear();
            reporteChiCuadrado.LocalReport.DataSources.Add(datos);
            reporteChiCuadrado.RefreshReport();
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Carga la tabla para la prueba de Chi-Cuadrado
        public void cargarTablaChi()
        {
            DataTable tabla = gestor.generarTablaChi();                 //Se le delega al gestor la generacion de la tabla
            dataGridView2.DataSource = tabla;
            dataGridView2.Refresh();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Carga la tabla para la prueba de KS
        public void cargarTablaKS()
        {
            DataTable tabla = gestor.generarTablaKS();                  //Se le delega al gestor la generacion de la tabla
            dataGridView3.DataSource = tabla;
            dataGridView3.Refresh();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Muestra el resultado de la prueba de Chi Cuadrado
        public void MostrarChiCuadrado()
        {
            bool resultadoPruebaChiCuadrado = this.gestor.pruebaChiCuadrado();      //Se le delega al gestor la realizacion de la prueba
            if (resultadoPruebaChiCuadrado)
            {
                lblChiCuadrado.ForeColor = System.Drawing.Color.Red;
                lblChiCuadrado.Text = "Según la prueba de Chi-Cuadrado, Se rechaza la hipotesis de que la distribucion sea " + this.gestor.nombreFuncion();
            }
            else
            {
                lblChiCuadrado.ForeColor = System.Drawing.Color.Green;
                lblChiCuadrado.Text = "Según la prueba de Chi-Cuadrado, No se rechaza la hipotesis de que la distribucion sea " + this.gestor.nombreFuncion();
            }
            double[] valores = this.gestor.mostrarValorChi();

            if (valores[0] == -1)
            {
                lblValorTabulado.Visible = false;
                lblEstadistico.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                lblChiCuadrado.Text = "No se puede realizar la prueba de Chi-Cuadrado";
            }
            else
            {
                lblValorTabulado.Text = valores[0].ToString();
            }

            lblEstadistico.Text = valores[1].ToString();

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Muestra el resultado de la prueba de Chi Cuadrado
        public void MostrarKS()
        {
            bool resultadoPruebaKS = this.gestor.pruebaKS();            //Se le delega al gestor la realizacion de la prueba
            if (resultadoPruebaKS)
            {
                lblResultadoKS.ForeColor = System.Drawing.Color.Red;
                lblResultadoKS.Text = "Según la prueba de KS, Se rechaza la hipotesis de que la distribucion sea " + this.gestor.nombreFuncion();
            }
            else
            {
                lblResultadoKS.ForeColor = System.Drawing.Color.Green;
                lblResultadoKS.Text = "Según la prueba de KS, No Se rechaza la hipotesis de que la distribucion sea " + this.gestor.nombreFuncion();

            }
            double[] valores = this.gestor.mostrarValorKS();
            lblValorKSNum.Text = valores[1].ToString();
            lblValorKSTabNum.Text = valores[0].ToString();

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        

    }
}
