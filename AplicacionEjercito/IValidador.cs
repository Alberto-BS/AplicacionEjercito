using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AplicacionEjercito
{
    public interface IValidador
    {
       public bool IsValid(IEjercito ejercito);
    }
}