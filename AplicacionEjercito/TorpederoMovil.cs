using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class TorpederoMovil : IUnidad
    {
        public double Blindaje { get; set;} = 2;
        public double PotenciaFuego { get; set; } = 19;
        public double Precio { get; set;} = 1350;
        public double Vel { get; set;} = 3;
    }
}