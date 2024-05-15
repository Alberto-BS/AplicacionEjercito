using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class Sanitario : IUnidad
    {
        public double Blindaje {get; set;} = 5;
        public double PotenciaFuego {get; set;} = 0;
        public double Precio {get; set;} = 500;
        public double Vel {get; set;} = 7;
    }
}