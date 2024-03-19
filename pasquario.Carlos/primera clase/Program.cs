namespace primera_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            string edad;
            Console.Write("Ingrese su nombre : ");
            nombre = Console.ReadLine();
            Console.Write("ingrese su apellido : ");
            apellido = Console.ReadLine();
            Console.Write(" ingrese su edad :  ");
            edad = Console.ReadLine();
            Console.WriteLine("bienvenido  " + nombre + "  " + apellido);
            Console.WriteLine("  y su edad es : " + edad);
                      
        }
    }
}
