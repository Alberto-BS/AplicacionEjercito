using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class CañonAntiareo : IUnidad
    {
        public double Blindaje {get; set;} = 0;
        public double PotenciaFuego {get; set; } = 22;
        public double Precio {get; set;} = 1100;
        public double Vel {get; set;} = 0;
    }
}