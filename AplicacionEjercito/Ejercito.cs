using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class Ejercito : IEjercito 
    {
        List<IUnidad> unidad = new List<IUnidad>();
        double blindajeTotal = 0;
        double PotenciaFuegoTotal = 0;
        double VelocidadTotal = 0;
        double PrecioTotal = 0; 
    
    

        public void Add(IUnidad tropa)
        {
            unidad.Add(tropa);
            blindajeTotal += tropa.Blindaje;
            PotenciaFuegoTotal += tropa.PotenciaFuego;
            VelocidadTotal += tropa.Vel;
            PrecioTotal += tropa.Precio;
        }

        public double DameBlindaje()
        {return blindajeTotal;}

        public double DameCM()
        { return ((PotenciaFuegoTotal * VelocidadTotal) / 2) / (100 - blindajeTotal);}

        public double DameCoste()
        { return PrecioTotal; }

        public double DameFuego()
        { return PotenciaFuegoTotal; }

        public double DameMovimiento()
        { return VelocidadTotal; }

        public int ElementoTotal()
        { return unidad.Count(); }
    }
}