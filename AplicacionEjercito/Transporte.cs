using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class Transporte : IUnidad
    {
        public double Blindaje { get; set; } = 1.4;
        public double PotenciaFuego {get; set;} = 0;
        public double Precio {get; set;} = 4200;
        public double Vel {get; set;} = 4.5;
    }
}