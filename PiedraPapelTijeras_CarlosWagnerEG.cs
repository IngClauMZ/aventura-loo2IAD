
Console.WriteLine("Juguemos piedra, papel o tijeras!");
while (true){
    Random random = new Random();
    string[] siguienteAccion = {"Piedra", "Papel", "Tijeras"};

    Console.Write("Elige tu siguiente movimiento! (piedra/papel/tijeras)");
    string accionJugador = (Console.ReadLine());

    string AccionCpu = siguienteAccion[random.Next(siguienteAccion.Length)];

    Console.WriteLine($"Computadora eligió: {AccionCpu}");


    if (accionJugador == AccionCpu)
    {
        Console.WriteLine("Empate! Intentemos de nuevo");
    }
    else
    {
        if ((accionJugador == "papel" && AccionCpu == "Tijeras") ||
        (accionJugador == "tijeras" && AccionCpu == "Piedra") ||
        (accionJugador == "piedra" && AccionCpu == "Papel"))
        Console.WriteLine("Perdiste.");
        
        else
            Console.WriteLine("Ganaste!");
                
    }
}
            