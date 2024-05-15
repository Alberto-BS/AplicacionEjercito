using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class Cañon : IUnidad
    {
        public double Blindaje {get; set;} = 0;
        public double PotenciaFuego {get; set;} = 14;
        public double Precio { get; set; } = 1100;
        public double Vel {get; set;} = 0;
    }
}