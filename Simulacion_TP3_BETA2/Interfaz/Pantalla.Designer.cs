
namespace Simulacion_TP1
{
    partial class Pantalla
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblParametro1 = new System.Windows.Forms.Label();
            this.lblParametro2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnAsistido = new System.Windows.Forms.RadioButton();
            this.btnLibre = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.cmbFuncion = new System.Windows.Forms.ComboBox();
            this.btnFuncion2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecomendaciones = new System.Windows.Forms.Label();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.txtParametro2 = new System.Windows.Forms.MaskedTextBox();
            this.txtParametro1 = new System.Windows.Forms.MaskedTextBox();
            this.txtCantidadNumeros = new System.Windows.Forms.MaskedTextBox();
            this.lblDecimales = new System.Windows.Forms.Label();
            this.txtDecimales = new System.Windows.Forms.MaskedTextBox();
            this.lblCantidadGenerar = new System.Windows.Forms.Label();
            this.btnFuncion1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblParametro1
            // 
            this.lblParametro1.AutoSize = true;
            this.lblParametro1.Location = new System.Drawing.Point(103, 187);
            this.lblParametro1.Name = "lblParametro1";
            this.lblParametro1.Size = new System.Drawing.Size(61, 13);
            this.lblParametro1.TabIndex = 0;
            this.lblParametro1.Text = "Parametro1";
            this.lblParametro1.Visible = false;
            // 
            // lblParametro2
            // 
            this.lblParametro2.AutoSize = true;
            this.lblParametro2.Location = new System.Drawing.Point(100, 223);
            this.lblParametro2.Name = "lblParametro2";
            this.lblParametro2.Size = new System.Drawing.Size(64, 13);
            this.lblParametro2.TabIndex = 3;
            this.lblParametro2.Text = "Parametro 2";
            this.lblParametro2.Visible = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Location = new System.Drawing.Point(438, 272);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(101, 46);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Visible = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnAsistido
            // 
            this.btnAsistido.AutoSize = true;
            this.btnAsistido.Checked = true;
            this.btnAsistido.Location = new System.Drawing.Point(16, 16);
            this.btnAsistido.Name = "btnAsistido";
            this.btnAsistido.Size = new System.Drawing.Size(91, 17);
            this.btnAsistido.TabIndex = 1;
            this.btnAsistido.TabStop = true;
            this.btnAsistido.Text = "Modo Asistido";
            this.btnAsistido.UseVisualStyleBackColor = true;
            // 
            // btnLibre
            // 
            this.btnLibre.AutoSize = true;
            this.btnLibre.Location = new System.Drawing.Point(140, 16);
            this.btnLibre.Name = "btnLibre";
            this.btnLibre.Size = new System.Drawing.Size(78, 17);
            this.btnLibre.TabIndex = 2;
            this.btnLibre.Text = "Modo Libre";
            this.btnLibre.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLibre);
            this.panel1.Controls.Add(this.btnAsistido);
            this.panel1.Location = new System.Drawing.Point(43, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 54);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSeleccion);
            this.panel2.Controls.Add(this.cmbFuncion);
            this.panel2.Controls.Add(this.btnFuncion2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lblIntervalos);
            this.panel2.Controls.Add(this.cmbIntervalos);
            this.panel2.Controls.Add(this.txtParametro2);
            this.panel2.Controls.Add(this.txtParametro1);
            this.panel2.Controls.Add(this.txtCantidadNumeros);
            this.panel2.Controls.Add(this.lblDecimales);
            this.panel2.Controls.Add(this.txtDecimales);
            this.panel2.Controls.Add(this.lblCantidadGenerar);
            this.panel2.Controls.Add(this.btnFuncion1);
            this.panel2.Controls.Add(this.lblParametro1);
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Controls.Add(this.lblParametro2);
            this.panel2.Location = new System.Drawing.Point(43, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 491);
            this.panel2.TabIndex = 10;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(72, 19);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(238, 13);
            this.lblSeleccion.TabIndex = 18;
            this.lblSeleccion.Text = "Seleccione el tipo de muestra que desea obtener";
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncion.FormattingEnabled = true;
            this.cmbFuncion.Location = new System.Drawing.Point(418, 11);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(121, 21);
            this.cmbFuncion.TabIndex = 17;
            this.cmbFuncion.SelectedIndexChanged += new System.EventHandler(this.cmbFuncion_SelectedIndexChanged);
            // 
            // btnFuncion2
            // 
            this.btnFuncion2.AutoSize = true;
            this.btnFuncion2.Location = new System.Drawing.Point(280, 56);
            this.btnFuncion2.Name = "btnFuncion2";
            this.btnFuncion2.Size = new System.Drawing.Size(72, 17);
            this.btnFuncion2.TabIndex = 16;
            this.btnFuncion2.TabStop = true;
            this.btnFuncion2.Text = "Funcion 2";
            this.btnFuncion2.UseVisualStyleBackColor = true;
            this.btnFuncion2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecomendaciones);
            this.groupBox1.Location = new System.Drawing.Point(81, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recomendaciones";
            this.groupBox1.Visible = false;
            // 
            // lblRecomendaciones
            // 
            this.lblRecomendaciones.AutoSize = true;
            this.lblRecomendaciones.Location = new System.Drawing.Point(6, 23);
            this.lblRecomendaciones.Name = "lblRecomendaciones";
            this.lblRecomendaciones.Size = new System.Drawing.Size(35, 13);
            this.lblRecomendaciones.TabIndex = 0;
            this.lblRecomendaciones.Text = "label1";
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Location = new System.Drawing.Point(358, 190);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(116, 13);
            this.lblIntervalos.TabIndex = 13;
            this.lblIntervalos.Text = "Cantidad de Intervalos:";
            this.lblIntervalos.Visible = false;
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.ItemHeight = 13;
            this.cmbIntervalos.Location = new System.Drawing.Point(477, 187);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(62, 21);
            this.cmbIntervalos.TabIndex = 12;
            this.cmbIntervalos.Visible = false;
            this.cmbIntervalos.SelectedIndexChanged += new System.EventHandler(this.cmbIntervalos_SelectedIndexChanged);
            // 
            // txtParametro2
            // 
            this.txtParametro2.Location = new System.Drawing.Point(181, 223);
            this.txtParametro2.Name = "txtParametro2";
            this.txtParametro2.Size = new System.Drawing.Size(100, 20);
            this.txtParametro2.TabIndex = 7;
            this.txtParametro2.Visible = false;
            // 
            // txtParametro1
            // 
            this.txtParametro1.Location = new System.Drawing.Point(181, 180);
            this.txtParametro1.Name = "txtParametro1";
            this.txtParametro1.Size = new System.Drawing.Size(100, 20);
            this.txtParametro1.TabIndex = 6;
            this.txtParametro1.Visible = false;
            // 
            // txtCantidadNumeros
            // 
            this.txtCantidadNumeros.Location = new System.Drawing.Point(181, 135);
            this.txtCantidadNumeros.Mask = "99999999";
            this.txtCantidadNumeros.Name = "txtCantidadNumeros";
            this.txtCantidadNumeros.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadNumeros.TabIndex = 5;
            this.txtCantidadNumeros.ValidatingType = typeof(int);
            this.txtCantidadNumeros.Visible = false;
            // 
            // lblDecimales
            // 
            this.lblDecimales.AutoSize = true;
            this.lblDecimales.Location = new System.Drawing.Point(366, 142);
            this.lblDecimales.Name = "lblDecimales";
            this.lblDecimales.Size = new System.Drawing.Size(105, 13);
            this.lblDecimales.TabIndex = 11;
            this.lblDecimales.Text = "Precisión Decimales:";
            this.lblDecimales.Visible = false;
            // 
            // txtDecimales
            // 
            this.txtDecimales.Location = new System.Drawing.Point(477, 139);
            this.txtDecimales.Mask = "99";
            this.txtDecimales.Name = "txtDecimales";
            this.txtDecimales.Size = new System.Drawing.Size(62, 20);
            this.txtDecimales.TabIndex = 10;
            this.txtDecimales.ValidatingType = typeof(int);
            this.txtDecimales.Visible = false;
            // 
            // lblCantidadGenerar
            // 
            this.lblCantidadGenerar.AutoSize = true;
            this.lblCantidadGenerar.Location = new System.Drawing.Point(59, 142);
            this.lblCantidadGenerar.Name = "lblCantidadGenerar";
            this.lblCantidadGenerar.Size = new System.Drawing.Size(110, 13);
            this.lblCantidadGenerar.TabIndex = 9;
            this.lblCantidadGenerar.Text = "Cantidad de números:";
            this.lblCantidadGenerar.Visible = false;
            // 
            // btnFuncion1
            // 
            this.btnFuncion1.AutoSize = true;
            this.btnFuncion1.Checked = true;
            this.btnFuncion1.Location = new System.Drawing.Point(61, 56);
            this.btnFuncion1.Name = "btnFuncion1";
            this.btnFuncion1.Size = new System.Drawing.Size(72, 17);
            this.btnFuncion1.TabIndex = 3;
            this.btnFuncion1.TabStop = true;
            this.btnFuncion1.Text = "Funcion 1";
            this.btnFuncion1.UseVisualStyleBackColor = true;
            this.btnFuncion1.Visible = false;
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Pantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador Números Pseudoaleatorios";
            this.Load += new System.EventHandler(this.Pantalla_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblParametro1;
        private System.Windows.Forms.Label lblParametro2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RadioButton btnAsistido;
        private System.Windows.Forms.RadioButton btnLibre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton btnFuncion1;
        private System.Windows.Forms.Label lblDecimales;
        private System.Windows.Forms.MaskedTextBox txtDecimales;
        private System.Windows.Forms.Label lblCantidadGenerar;
        private System.Windows.Forms.MaskedTextBox txtParametro2;
        private System.Windows.Forms.MaskedTextBox txtParametro1;
        private System.Windows.Forms.MaskedTextBox txtCantidadNumeros;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecomendaciones;
        private System.Windows.Forms.RadioButton btnFuncion2;
        private System.Windows.Forms.ComboBox cmbFuncion;
        private System.Windows.Forms.Label lblSeleccion;
    }
}

