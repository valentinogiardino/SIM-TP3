using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP1.Clases
{
    //Clase para modelar los renglones de las tablas
    public class Renglon
    {
        private double desde;
        private double hasta;
        private double fo;
        private double fe;

        private double c;
        private double c_ac;

        private double po;
        private double pe;
        private double po_Ac;
        private double pe_ac;
        private double diferencia_pope;
        private double max;

        public Renglon(double desde, double hasta, double fo, double fe)
        {
            this.Desde = desde;
            this.Hasta = hasta;
            this.Fo = fo;
            this.Fe = fe;
        }

        public double Desde { get => desde; set => desde = value; }
        public double Hasta { get => hasta; set => hasta = value; }
        public double Fo { get => fo; set => fo = value; }
        public double Fe { get => fe; set => fe = value; }
        public double C { get => c; set => c = value; }
        public double C_ac { get => c_ac; set => c_ac = value; }
        public double Po { get => po; set => po = value; }
        public double Pe { get => pe; set => pe = value; }
        public double Po_Ac { get => po_Ac; set => po_Ac = value; }
        public double Pe_ac { get => pe_ac; set => pe_ac = value; }
        public double Diferencia_pope { get => diferencia_pope; set => diferencia_pope = value; }
        public double Max { get => max; set => max = value; }
    }
}
