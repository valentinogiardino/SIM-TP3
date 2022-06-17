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
    public partial class Pantalla : Form
    {

        private Gestor gestor;

        public Gestor Gestor { get => gestor; set => gestor = value; }

        //Constructor
        public Pantalla()
        {
            InitializeComponent();
            this.gestor = new Gestor(this); //Se guarda una referencia al gestor. El gestor tambien contendra una referencia a la pantalla. Esto permite la comunicacion
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Pantalla_Load(object sender, EventArgs e)
        {
            cmbIntervalos.Items.Add(5);
            cmbIntervalos.Items.Add(8);
            cmbIntervalos.Items.Add(10);
            cmbIntervalos.Items.Add(12);

            cmbFuncion.Items.Add("Uniforme");
            cmbFuncion.Items.Add("Normal");
            cmbFuncion.Items.Add("Exponencial");
            cmbFuncion.Items.Add("Poisson");


            panel1.Visible = false;
            btnAsistido.Visible = false;
            btnLibre.Visible = false;



            lblRecomendaciones.Text = "Para lograr el período máximo N: " + Environment.NewLine + "  c debe ser relativamente primo a m";
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Se toman los datos de la pantalla y se los manda al gestor para que inicie la generacion de numeros aleaotorios
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            string funcion = cmbFuncion.Text.ToString();
            if (cmbFuncion.Text.ToString() == "Normal" && btnFuncion2.Checked)
            {
                funcion = "Normal-Convolucion"; 
            }
            int cantidadNumeros = int.Parse(txtCantidadNumeros.Text.ToString());
            double parametroUno = double.Parse(txtParametro1.Text.ToString());
            double ParametroDos;
            if (txtParametro2.Text == "")
            {
                 ParametroDos = 0;
            }

            else
            {
                 ParametroDos = double.Parse(txtParametro2.Text.ToString());
            }

            int cantidadDecimales;
            if (txtDecimales.Text == "")
            {
                cantidadDecimales = 0;
            }

            else
            {
                cantidadDecimales = int.Parse(txtDecimales.Text.ToString());
            }

            int cantidadIntervalos = int.Parse(cmbIntervalos.Text.ToString());

            gestor.generarNumeros(funcion, cantidadNumeros, parametroUno, ParametroDos, cantidadDecimales, cantidadIntervalos);  
            gestor.generarReporte();
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void cmbIntervalos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerar.Enabled = true;
        }

        //Cambia la interfaz segun la distribucion seleccionada
        private void cmbFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCantidadNumeros.Visible = true;
            lblCantidadGenerar.Visible = true;
            lblDecimales.Visible = true;
            txtDecimales.Visible = true;
            btnGenerar.Visible = true;
            lblIntervalos.Visible = true;
            cmbIntervalos.Visible = true;
            groupBox1.Visible = true;


            if (cmbFuncion.SelectedItem.ToString() == "Normal")
            {
                btnFuncion1.Visible = true;
                btnFuncion2.Visible = true;

                btnFuncion1.Text = "Metodo Box-Muller";
                btnFuncion2.Text = "Convolucion";

                lblParametro1.Visible = true;
                lblParametro2.Visible = true;
                lblParametro1.Text = "Media";
                lblParametro2.Text = "Desviacion";
                txtParametro1.Visible = true;
                txtParametro2.Visible = true;

                lblRecomendaciones.Text = "Seleccione la Media" + Environment.NewLine + "Seleccione la Desviacion Estandar";



                cmbIntervalos.SelectedItem = null;
                cmbIntervalos.Visible = true;
                lblIntervalos.Visible = true;
                btnGenerar.Enabled = false;

            }

            if (cmbFuncion.SelectedItem.ToString() == "Uniforme")
            {
                btnFuncion1.Visible = false;
                btnFuncion2.Visible = false;

                btnFuncion1.Text = "Metodo Box-Muller";
                btnFuncion2.Text = "Convolucion";

                lblParametro1.Visible = true;
                lblParametro2.Visible = true;
                lblParametro1.Text = "A";
                lblParametro2.Text = "B";
                txtParametro1.Visible = true;
                txtParametro2.Visible = true;

                lblRecomendaciones.Text = "Seleccione el valor Inferior A" + Environment.NewLine + "Seleccione el valor Superior B";



                cmbIntervalos.SelectedItem = null;
                cmbIntervalos.Visible = true;
                lblIntervalos.Visible = true;
                btnGenerar.Enabled = false;

            }

            if (cmbFuncion.SelectedItem.ToString() == "Exponencial")
            {
                btnFuncion1.Visible = false;
                btnFuncion2.Visible = false;

                btnFuncion1.Text = "Metodo Box-Muller";
                btnFuncion2.Text = "Convolucion";

                lblParametro1.Visible = true;
                lblParametro2.Visible = false;
                lblParametro1.Text = "Media";
                lblParametro2.Text = "B";
                txtParametro1.Visible = true;
                txtParametro2.Visible = false;
                txtParametro2.Text = "";

                lblRecomendaciones.Text = "Seleccione el valor de la media";



                cmbIntervalos.SelectedItem = null;
                cmbIntervalos.Visible = true;
                lblIntervalos.Visible = true;
                btnGenerar.Enabled = false;

            }

            if (cmbFuncion.SelectedItem.ToString() == "Poisson")
            {

                btnFuncion1.Visible = false;
                btnFuncion2.Visible = false;

                btnFuncion1.Text = "Metodo Box-Muller";
                btnFuncion2.Text = "Convolucion";

                lblParametro1.Visible = true;
                lblParametro2.Visible = false;
                lblParametro1.Text = "Lambda";
                lblParametro2.Text = "B";
                lblDecimales.Visible = false;
                txtParametro1.Visible = true;
                txtParametro2.Visible = false;
                txtParametro2.Text = "";
                txtDecimales.Visible = false;
                txtDecimales.Text = "0";
                lblRecomendaciones.Text = "Seleccione el valor de Lambda";


                
                cmbIntervalos.SelectedItem = 5;
                cmbIntervalos.Visible = false;
                lblIntervalos.Visible = false;
                btnGenerar.Enabled = true;

            }
        }
            
    }
}
