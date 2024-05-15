using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class Ametralladora : IUnidad
    {
        public double Blindaje {get; set;} = 0;
        public double PotenciaFuego {get; set;} = 10;
        public double Precio {get; set;} = 400;
        public double Vel {get; set;} = 4;
    }
}