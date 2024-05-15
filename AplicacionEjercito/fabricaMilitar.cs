using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class fabricaMilitar : IfabricaMilitar
    {
        public IUnidad CrearTropas(EnumEjercito Pepino)
        {
            switch (Pepino)
            {
                case EnumEjercito.Ametralladora:return new Ametralladora();
                case EnumEjercito.TransporteRapido:return new TransporteRapido();
                case EnumEjercito.TanqueDeAtaque:return new TanqueDeAtaque();
                case EnumEjercito.CañonAntiareo:return new CañonAntiareo();
                case EnumEjercito.InfanteriaBasica:return new InfanteriaBasica();
                case EnumEjercito.Sanitario:return new Sanitario();
                case EnumEjercito.Cañon:return new Cañon();
                case EnumEjercito.TorpederoMovil:return new TorpederoMovil();
                case EnumEjercito.transporte:return new Transporte();
                default: return null;
            }
        }

        internal IUnidad CrearTropas()
        {
            throw new NotImplementedException();
        }
    }
}