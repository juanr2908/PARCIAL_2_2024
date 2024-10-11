class AdivinaElNumero
{
    static void Main(string[] args)
    {
        string jugarDeNuevo = "s";

        while (jugarDeNuevo == "s")
        {
            // Escoger número de jugadores
            int numJugadores = 0;
            Console.WriteLine("Ingrese el número de jugadores (2-4): ");
            numJugadores = int.Parse(Console.ReadLine());

            if (numJugadores < 2 || numJugadores > 4)
            {
                Console.WriteLine("El número de jugadores debe ser entre 2 y 4.");
                continue; // Reinicia el ciclo si el número de jugadores no es válido
            }

            // Determinar el rango basado en el número de jugadores
            int rangoMaximo = 0;

            if (numJugadores == 2)
            {
                rangoMaximo = 50;
            }
            else if (numJugadores == 3)
            {
                rangoMaximo = 100;
            }
            else if (numJugadores == 4)
            {
                rangoMaximo = 200;
            }

            // Generar número aleatorio
            Random random = new Random();
            int numeroAleatorio = random.Next(0, rangoMaximo + 1);

            Console.WriteLine("Se ha generado un número aleatorio. ¡Empieza el juego!");

            bool juegoTerminado = false;
            int jugadorActual = 1;

            while (!juegoTerminado)
            {
                // Turno del jugador
                Console.WriteLine("Turno del Jugador " + jugadorActual);
                Console.WriteLine("Adivina el número: ");
                int numeroIngresado = int.Parse(Console.ReadLine());

                if (numeroIngresado > numeroAleatorio)
                {
                    Console.WriteLine("MENOR");
                }
                else if (numeroIngresado < numeroAleatorio)
                {
                    Console.WriteLine("MAYOR");
                }
                else
                {
                    Console.WriteLine("¡HAS GANADO, Jugador " + jugadorActual + "!");
                    juegoTerminado = true;
                }

                // Cambiar al siguiente jugador
                if (!juegoTerminado)
                {
                    jugadorActual++;

                    if (jugadorActual > numJugadores)
                    {
                        jugadorActual = 1;
                    }
                }
            }

            // Preguntar si quieren jugar de nuevo
            Console.WriteLine("¿Desean jugar de nuevo? (s/n): ");
            jugarDeNuevo = Console.ReadLine();
        }

        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
    }
}