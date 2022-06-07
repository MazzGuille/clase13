namespace clase13.Modelo
{
    public class Persona
    {
        public Persona()
        {
            WriteLine("Se ha instancuado una persona");
        }

        public string? NombreCompleto { get; set; }
        public string? NumeroDocumento { get; set; }
        public int Edad { get; set; }
        public bool EstaCasado { get; set; }

        public string ObtenerSaludo()
        {
            return ($"Hola soy {NombreCompleto}");
        }

        public string ObtenerSaludo(string NombreDeLaPersona)
        {
            return ($"Hola {NombreDeLaPersona}, soy {NombreCompleto}");
        }

        public void Saludo()
        {
            WriteLine("Hola desde la clase");
        }
    }
}
