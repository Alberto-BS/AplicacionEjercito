using AplicacionEjercito;

Ejercito ejercito = new Ejercito();
fabricaMilitar fabricaMilitar = new fabricaMilitar();
Validador validador = new Validador();
if (validador.IsValid(ejercito))
{
ejercito.Add(fabricaMilitar.CrearTropas(EnumEjercito.Ametralladora));
}




Console.WriteLine($"mi ejercito tiene un blindaje de {ejercito.DameBlindaje()}");
Console.WriteLine($"mi ejercito tiene una velocidad de {ejercito.DameMovimiento()}");
Console.WriteLine($"mi ejercito tiene un CM de {ejercito.DameCM()}");
Console.WriteLine($"mi ejercito tiene un coste de {ejercito.DameCoste()}");


