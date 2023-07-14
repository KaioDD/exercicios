using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Retangulo
{
    public class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public double CalcularArea()
        {
            return Altura * Largura;
        }
        public double CalcularPerimetro()
        {
            return 2 * (Altura + Largura);
        }
        public Double CalcularDiagonal()
        {
            return Math.Sqrt((Altura * Altura) + (Largura * Largura));
        }
    }
}
