using SPR.Persona.Interfaces;

namespace SPR.Persona
{
    public class Persona : Metodos
    {
        private string nombre;
        private int edad;
        private string direccion;
        private string corrreoElectronico;

        public void EnviarCorrreoEletronico(string mensaje)
        {
            // logica para enviar correo eletronico
        }

        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre:{nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Direccion: {direccion}");
            Console.WriteLine($"Correo Eletronico:{corrreoElectronico}");
        }
        // Claramente este codigo estaba violentando el principio SPR ya que la clase no esta cumpliendo una unica responsabilidad
        // Ya que esta ejecundanco los metodos  EnviarCorrreoEletronico y ImprimirDatos.
        
        // Para implementar este principio lo que hice fue simplemente llevar los metodos a una interfaz.
    }
}
