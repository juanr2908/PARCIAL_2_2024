public class Program
{
    // Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo, consiste en adivinar un número ℕ aleatorio que el sistema escoge de un determinado rango y lo guarda en memoria sin ser revelado.

    private static void Main(string[] args)
    {
        Console.WriteLine("Adivina el numero");
        Console.WriteLine("Ingrese el número de jugadores (2-4): ");
        int.Parse(Console.ReadLine());
        int numerodejugadores = 0;
        {
            string jugardenuevo = "s";
        while (jugardenuevo == "s") 
            
            


if (numerodejugadores < 2 || numerodejugadores > 4)

{
    Console.WriteLine("El número de jugadores debe ser entre 2 y 4.");
    continue; 



int rangoMaximo = 0;

if (numerodejugadores == 2)
{
    rangoMaximo = 50;
}
else if (numerodejugadores == 3)
{
    rangoMaximo = 100;
}
else if (numerodejugadores == 4)
{
    rangoMaximo = 200;
















