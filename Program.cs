global using static System.Console;
using clase13.Modelo;



WriteLine("Hello");


Persona sujeto1 = new()
{
    NombreCompleto = "Guillermo Mazzari",
    NumeroDocumento = "95674765",
    Edad = 36,
    EstaCasado = true
};

sujeto1.Saludo();
WriteLine(sujeto1.ObtenerSaludo());
WriteLine(sujeto1.ObtenerSaludo("July"));
