int[ , ] map = new int[63,12];

bool gameRunning = true;

int HP = 100;
int Score = 0;
usernameSelection:
Console.Write("Please enter your name: ");
string userName = Console.ReadLine();
if (userName == null)
{
    Console.Clear();
    Console.WriteLine("Please enter a name");
    Thread.Sleep(500);
    Console.Clear();
    goto usernameSelection;
}
if (userName.Length > 10)
{
    Console.Clear();
    Console.WriteLine("Please enter a name with less than 11 characters");
    Thread.Sleep(1500);
    Console.Clear();
    goto usernameSelection;
}


int windowHeight = map.GetLength(1);
int windowWidth = map.GetLength(0);

while (gameRunning)
{
    Console.CursorVisible = false;
    for (int i = 0; i < windowHeight ; i++)
    {
        for (int j = 0; j < windowWidth; j++)
        {
            Console.Write(map[j, i]);
        }
        Console.Write("\n");
    }
    Console.WriteLine($"{userName}: {HP} HP   Score: {Score}");
    Thread.Sleep(1000);
    Console.Clear();
}