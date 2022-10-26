using TesteLocation;

int score = 0, foodX = 0, foodY = 0;

Position[] positions = new Position[1];
positions[0] = new Position() { X = 1, Y = 1};

Start();
SetFood();
Info();

Console.WriteLine();

while (true)
{
    var key =  Console.ReadKey();
    Console.Clear();
    switch (key.Key)
    {
        case ConsoleKey.W:
            positions[0].Y++;
            if (positions[0].Y == foodY && positions[0].X == foodX)
            {
                score++;
                SetFood();
            }
            break;
        case ConsoleKey.S:
            positions[0].Y--;
            if (positions[0].Y == foodY && positions[0].X == foodX)
            {
                score++;
                SetFood();
            }
            break;
        case ConsoleKey.D:
            positions[0].X++;
            if (positions[0].Y == foodY && positions[0].X == foodX)
            {
                score++;
                SetFood();
            }
            break;
        case ConsoleKey.A:
            positions[0].X--;
            if (positions[0].Y == foodY && positions[0].X == foodX)
            {
                score++;
                SetFood();
            }
            break;
    }

    if (score != 5)
    {
        Info();
    }
    else
    {
        Console.WriteLine("You won!");
    }
}

void Start()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Title = "Jogo da cobrinha";
    Console.WriteLine("Jogo da cobrinha (no console)");
    Console.Beep();
}

void SetFood()
{
    foodX = new Random().Next(1, 20);
    foodY = new Random().Next(1, 20);
}

void Info()
{
    Console.WriteLine($"Food X: {foodX}, Food Y: {foodY}");
    Console.WriteLine($"Score: {score}");
    Console.WriteLine(positions[0]);
    Console.WriteLine();
}