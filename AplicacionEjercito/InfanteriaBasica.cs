using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class InfanteriaBasica : IUnidad
    {
        public double Blindaje {get; set;} = 0;
        public double PotenciaFuego {get; set;} = 7;
        public double Precio {get; set;} = 250;
        public double Vel {get; set;} = 6;
    }
}