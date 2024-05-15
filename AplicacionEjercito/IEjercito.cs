using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public interface IEjercito
    {
        double DameCoste();

        public double DameCM();
        public double DameBlindaje();
        public double DameFuego();
        public double DameMovimiento();
        public void Add(IUnidad tropa);
        public int ElementoTotal();
    }
}