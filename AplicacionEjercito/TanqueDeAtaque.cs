using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class TanqueDeAtaque : IUnidad
    {
        public double Blindaje { get; set; } = 4.8;
        public double PotenciaFuego { get; set; } = 9.8;
        public double Precio { get; set; } = 15600;
        public double Vel { get; set; } = 7.3;
    }
}