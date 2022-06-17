
namespace Simulacion_TP1
{
    partial class Histograma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Histograma));
            this.reporteChiCuadrado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gdrNumeroGenerados = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblChiCuadrado = new System.Windows.Forms.Label();
            this.lblEstadistico = new System.Windows.Forms.Label();
            this.lblValorTabulado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblTablaChi = new System.Windows.Forms.Label();
            this.lblTablaKS = new System.Windows.Forms.Label();
            this.lblTablaFrecuencias = new System.Windows.Forms.Label();
            this.lblValoresRND = new System.Windows.Forms.Label();
            this.lblHistograma = new System.Windows.Forms.Label();
            this.lblValorKSTab = new System.Windows.Forms.Label();
            this.lblValorKS = new System.Windows.Forms.Label();
            this.lblValorKSTabNum = new System.Windows.Forms.Label();
            this.lblValorKSNum = new System.Windows.Forms.Label();
            this.lblResultadoKS = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrNumeroGenerados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteChiCuadrado
            // 
            this.reporteChiCuadrado.LocalReport.ReportEmbeddedResource = "Simulacion_TP1.Informe.rdlc";
            this.reporteChiCuadrado.Location = new System.Drawing.Point(204, 642);
            this.reporteChiCuadrado.Name = "reporteChiCuadrado";
            this.reporteChiCuadrado.ServerReport.BearerToken = null;
            this.reporteChiCuadrado.Size = new System.Drawing.Size(1108, 366);
            this.reporteChiCuadrado.TabIndex = 0;
            // 
            // gdrNumeroGenerados
            // 
            this.gdrNumeroGenerados.AllowUserToAddRows = false;
            this.gdrNumeroGenerados.AllowUserToDeleteRows = false;
            this.gdrNumeroGenerados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrNumeroGenerados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.Rnd});
            this.gdrNumeroGenerados.Location = new System.Drawing.Point(12, 25);
            this.gdrNumeroGenerados.Name = "gdrNumeroGenerados";
            this.gdrNumeroGenerados.ReadOnly = true;
            this.gdrNumeroGenerados.Size = new System.Drawing.Size(183, 1024);
            this.gdrNumeroGenerados.TabIndex = 1;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            this.i.ReadOnly = true;
            this.i.Width = 40;
            // 
            // Rnd
            // 
            this.Rnd.HeaderText = "Rnd";
            this.Rnd.Name = "Rnd";
            this.Rnd.ReadOnly = true;
            // 
            // lblChiCuadrado
            // 
            this.lblChiCuadrado.AutoSize = true;
            this.lblChiCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiCuadrado.Location = new System.Drawing.Point(683, 255);
            this.lblChiCuadrado.Name = "lblChiCuadrado";
            this.lblChiCuadrado.Size = new System.Drawing.Size(466, 18);
            this.lblChiCuadrado.TabIndex = 2;
            this.lblChiCuadrado.Text = "No se rechaza la hipotesis de que la distribucion sea Normal";
            // 
            // lblEstadistico
            // 
            this.lblEstadistico.AutoSize = true;
            this.lblEstadistico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadistico.Location = new System.Drawing.Point(1475, 197);
            this.lblEstadistico.Name = "lblEstadistico";
            this.lblEstadistico.Size = new System.Drawing.Size(47, 15);
            this.lblEstadistico.TabIndex = 3;
            this.lblEstadistico.Text = "label1";
            // 
            // lblValorTabulado
            // 
            this.lblValorTabulado.AutoSize = true;
            this.lblValorTabulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTabulado.Location = new System.Drawing.Point(1475, 220);
            this.lblValorTabulado.Name = "lblValorTabulado";
            this.lblValorTabulado.Size = new System.Drawing.Size(47, 15);
            this.lblValorTabulado.TabIndex = 4;
            this.lblValorTabulado.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1318, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estadístico de Prueba:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1318, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor Crítico Tabulado:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(446, 220);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(672, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(640, 220);
            this.dataGridView2.TabIndex = 8;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(204, 301);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(1108, 292);
            this.dataGridView3.TabIndex = 9;
            // 
            // lblTablaChi
            // 
            this.lblTablaChi.AutoSize = true;
            this.lblTablaChi.Location = new System.Drawing.Point(1191, 9);
            this.lblTablaChi.Name = "lblTablaChi";
            this.lblTablaChi.Size = new System.Drawing.Size(116, 13);
            this.lblTablaChi.TabIndex = 10;
            this.lblTablaChi.Text = "Tabla de Chi-Cuadrado";
            // 
            // lblTablaKS
            // 
            this.lblTablaKS.AutoSize = true;
            this.lblTablaKS.Location = new System.Drawing.Point(1241, 285);
            this.lblTablaKS.Name = "lblTablaKS";
            this.lblTablaKS.Size = new System.Drawing.Size(66, 13);
            this.lblTablaKS.TabIndex = 11;
            this.lblTablaKS.Text = "Tabla de KS";
            // 
            // lblTablaFrecuencias
            // 
            this.lblTablaFrecuencias.AutoSize = true;
            this.lblTablaFrecuencias.Location = new System.Drawing.Point(535, 9);
            this.lblTablaFrecuencias.Name = "lblTablaFrecuencias";
            this.lblTablaFrecuencias.Size = new System.Drawing.Size(110, 13);
            this.lblTablaFrecuencias.TabIndex = 12;
            this.lblTablaFrecuencias.Text = "Tabla de Frecuencias";
            // 
            // lblValoresRND
            // 
            this.lblValoresRND.AutoSize = true;
            this.lblValoresRND.Location = new System.Drawing.Point(120, 9);
            this.lblValoresRND.Name = "lblValoresRND";
            this.lblValoresRND.Size = new System.Drawing.Size(69, 13);
            this.lblValoresRND.TabIndex = 13;
            this.lblValoresRND.Text = "Valores RND";
            // 
            // lblHistograma
            // 
            this.lblHistograma.AutoSize = true;
            this.lblHistograma.Location = new System.Drawing.Point(1247, 626);
            this.lblHistograma.Name = "lblHistograma";
            this.lblHistograma.Size = new System.Drawing.Size(60, 13);
            this.lblHistograma.TabIndex = 14;
            this.lblHistograma.Text = "Histograma";
            // 
            // lblValorKSTab
            // 
            this.lblValorKSTab.AutoSize = true;
            this.lblValorKSTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorKSTab.Location = new System.Drawing.Point(1318, 569);
            this.lblValorKSTab.Name = "lblValorKSTab";
            this.lblValorKSTab.Size = new System.Drawing.Size(153, 15);
            this.lblValorKSTab.TabIndex = 18;
            this.lblValorKSTab.Text = "Valor Crítico Tabulado:";
            // 
            // lblValorKS
            // 
            this.lblValorKS.AutoSize = true;
            this.lblValorKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorKS.Location = new System.Drawing.Point(1318, 546);
            this.lblValorKS.Name = "lblValorKS";
            this.lblValorKS.Size = new System.Drawing.Size(150, 15);
            this.lblValorKS.TabIndex = 17;
            this.lblValorKS.Text = "Estadístico de prueba:";
            // 
            // lblValorKSTabNum
            // 
            this.lblValorKSTabNum.AutoSize = true;
            this.lblValorKSTabNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorKSTabNum.Location = new System.Drawing.Point(1468, 569);
            this.lblValorKSTabNum.Name = "lblValorKSTabNum";
            this.lblValorKSTabNum.Size = new System.Drawing.Size(47, 15);
            this.lblValorKSTabNum.TabIndex = 16;
            this.lblValorKSTabNum.Text = "label1";
            // 
            // lblValorKSNum
            // 
            this.lblValorKSNum.AutoSize = true;
            this.lblValorKSNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorKSNum.Location = new System.Drawing.Point(1468, 546);
            this.lblValorKSNum.Name = "lblValorKSNum";
            this.lblValorKSNum.Size = new System.Drawing.Size(47, 15);
            this.lblValorKSNum.TabIndex = 15;
            this.lblValorKSNum.Text = "label1";
            // 
            // lblResultadoKS
            // 
            this.lblResultadoKS.AutoSize = true;
            this.lblResultadoKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoKS.Location = new System.Drawing.Point(683, 596);
            this.lblResultadoKS.Name = "lblResultadoKS";
            this.lblResultadoKS.Size = new System.Drawing.Size(111, 18);
            this.lblResultadoKS.TabIndex = 19;
            this.lblResultadoKS.Text = "Resultado KS";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(201, 272);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(3115, 13);
            this.lblLinea.TabIndex = 20;
            this.lblLinea.Text = resources.GetString("lblLinea.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3115, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Histograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 1061);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblResultadoKS);
            this.Controls.Add(this.lblValorKSTab);
            this.Controls.Add(this.lblValorKS);
            this.Controls.Add(this.lblValorKSTabNum);
            this.Controls.Add(this.lblValorKSNum);
            this.Controls.Add(this.lblHistograma);
            this.Controls.Add(this.lblValoresRND);
            this.Controls.Add(this.lblTablaFrecuencias);
            this.Controls.Add(this.lblTablaKS);
            this.Controls.Add(this.lblTablaChi);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorTabulado);
            this.Controls.Add(this.lblEstadistico);
            this.Controls.Add(this.lblChiCuadrado);
            this.Controls.Add(this.gdrNumeroGenerados);
            this.Controls.Add(this.reporteChiCuadrado);
            this.Name = "Histograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histograma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Histograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrNumeroGenerados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteChiCuadrado;
        private System.Windows.Forms.DataGridView gdrNumeroGenerados;
        private System.Windows.Forms.Label lblChiCuadrado;
        private System.Windows.Forms.Label lblEstadistico;
        private System.Windows.Forms.Label lblValorTabulado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblTablaChi;
        private System.Windows.Forms.Label lblTablaKS;
        private System.Windows.Forms.Label lblTablaFrecuencias;
        private System.Windows.Forms.Label lblValoresRND;
        private System.Windows.Forms.Label lblHistograma;
        private System.Windows.Forms.Label lblValorKSTab;
        private System.Windows.Forms.Label lblValorKS;
        private System.Windows.Forms.Label lblValorKSTabNum;
        private System.Windows.Forms.Label lblValorKSNum;
        private System.Windows.Forms.Label lblResultadoKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rnd;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label label3;
    }
}