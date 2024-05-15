using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public class Validador : IValidador
    {
        public bool IsValid(IEjercito ejercito)
        {
            return ejercito.DameCoste() > 10000;
        }
    }
}