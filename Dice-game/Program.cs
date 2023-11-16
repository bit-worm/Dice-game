
string? player1;
string? player2;
string? player3;
string? player4;


Console.WriteLine("\tROLL THE DICE GAME");
Console.Write("For game rules enter \"R\" ");
Console.Write("To play enter \"P\"> ");
var pressedKey = Console.ReadKey(true);
Console.WriteLine();


while ((pressedKey.Key != ConsoleKey.R) && (pressedKey.Key != ConsoleKey.P))
{
    Console.WriteLine("\tROLL THE DICE GAME");    
    Console.Write("For game rules enter \"R\" ");
    Console.WriteLine("To play enter \"P\"> ");
    pressedKey = Console.ReadKey(true);
    Console.WriteLine();
}

switch (pressedKey.Key)
{
    case ConsoleKey.R:
        System.Threading.Thread.Sleep(500);
        Console.WriteLine();
        Console.WriteLine("\tRULES");
        System.Threading.Thread.Sleep(200); Console.Write("This "); System.Threading.Thread.Sleep(200); Console.Write("is ");
        System.Threading.Thread.Sleep(200); Console.Write("a "); System.Threading.Thread.Sleep(200); Console.Write("game ");
        System.Threading.Thread.Sleep(200); Console.Write("of "); System.Threading.Thread.Sleep(200); Console.Write("1 ");
        System.Threading.Thread.Sleep(200); Console.Write("or "); System.Threading.Thread.Sleep(200); Console.Write("a ");
        System.Threading.Thread.Sleep(200); Console.Write("multiplayer "); System.Threading.Thread.Sleep(200); Console.Write("mode ");
        System.Threading.Thread.Sleep(200); Console.Write("of "); System.Threading.Thread.Sleep(200); Console.Write("upto ");
        System.Threading.Thread.Sleep(200); Console.Write("4 "); System.Threading.Thread.Sleep(200); Console.WriteLine("players. ");
        System.Threading.Thread.Sleep(200); Console.Write("It "); System.Threading.Thread.Sleep(200); Console.Write("consists ");
        System.Threading.Thread.Sleep(200); Console.Write("of "); System.Threading.Thread.Sleep(200); Console.Write("6 ");
        System.Threading.Thread.Sleep(200); Console.Write("rounds. "); System.Threading.Thread.Sleep(200); Console.Write("You ");
        System.Threading.Thread.Sleep(200); Console.Write("press "); System.Threading.Thread.Sleep(200); Console.Write("any ");
        System.Threading.Thread.Sleep(200); Console.Write("key "); System.Threading.Thread.Sleep(200); Console.Write("to ");
        System.Threading.Thread.Sleep(200); Console.Write("roll "); System.Threading.Thread.Sleep(200); Console.Write("the ");
        System.Threading.Thread.Sleep(200); Console.WriteLine("dice. "); System.Threading.Thread.Sleep(200); Console.Write("The ");
        System.Threading.Thread.Sleep(200); Console.Write("player "); System.Threading.Thread.Sleep(200); Console.Write("who ");
        System.Threading.Thread.Sleep(200); Console.Write("rolls "); System.Threading.Thread.Sleep(200); Console.Write("a ");
        System.Threading.Thread.Sleep(200); Console.Write("higher "); System.Threading.Thread.Sleep(200); Console.Write("number ");
        System.Threading.Thread.Sleep(200); Console.Write("gets "); System.Threading.Thread.Sleep(200); Console.Write("one ");
        System.Threading.Thread.Sleep(200); Console.Write("point. "); System.Threading.Thread.Sleep(200); Console.Write("The ");
        System.Threading.Thread.Sleep(200); Console.WriteLine("one "); System.Threading.Thread.Sleep(500); Console.Write("with ");
        System.Threading.Thread.Sleep(200); Console.Write("most "); System.Threading.Thread.Sleep(200); Console.Write("points ");
        System.Threading.Thread.Sleep(200); Console.Write("at "); System.Threading.Thread.Sleep(200); Console.Write("the ");
        System.Threading.Thread.Sleep(200); Console.Write("end "); System.Threading.Thread.Sleep(200); Console.Write("of ");
        System.Threading.Thread.Sleep(200); Console.Write("the "); System.Threading.Thread.Sleep(200); Console.Write("game ");
        System.Threading.Thread.Sleep(200); Console.WriteLine("wins.\n"); System.Threading.Thread.Sleep(200); Console.WriteLine("\tDEVELOPER");
        System.Threading.Thread.Sleep(200); Console.Write("Boniface "); System.Threading.Thread.Sleep(200); Console.Write("Sitati ");
        System.Threading.Thread.Sleep(200); Console.WriteLine("@bit_worm"); System.Threading.Thread.Sleep(200); Console.Write("\t-TitanBit ");
        System.Threading.Thread.Sleep(200); Console.WriteLine("Solutions LTD.\n"); System.Threading.Thread.Sleep(200); Console.WriteLine("\tDEDICATION");
        System.Threading.Thread.Sleep(200); Console.Write("Dedicated "); System.Threading.Thread.Sleep(200); Console.Write("to ");
        System.Threading.Thread.Sleep(200); Console.Write("A "); System.Threading.Thread.Sleep(200); Console.Write("BETTER ");
        System.Threading.Thread.Sleep(200); Console.WriteLine("TOMMORROW.");
        System.Threading.Thread.Sleep(200); Console.Write("ENJOY :) "); System.Threading.Thread.Sleep(200); Console.WriteLine("CHEERS!!\n"); ;
        break;

    case ConsoleKey.P:
        Console.WriteLine();
        break;
}

System.Threading.Thread.Sleep(200); Console.Write("Enter "); System.Threading.Thread.Sleep(200); Console.Write("the ");
System.Threading.Thread.Sleep(200); Console.Write("number "); System.Threading.Thread.Sleep(200); Console.Write("of ");
System.Threading.Thread.Sleep(200); Console.Write("players "); System.Threading.Thread.Sleep(200); Console.Write("(1, 2, 3, or 4): ");
int players = Convert.ToInt32(Console.ReadLine());
if (players == 1)
{
    Console.Write("Enter player's name: ");
    player1 = Console.ReadLine();

    int player1RandomNum;
    int compRandomNum;
    int player1Scores = 0;
    int compScores = 0;
    int round = 1;

    for (int i = 0; i < 6; i++)
    {
        System.Threading.Thread.Sleep(1500);
        Console.Clear();
        Console.WriteLine($"\tROUND {round}");
        round++;
        Console.Write($"{player1}> ");
        Console.ReadKey(true);
        Console.WriteLine();
        player1RandomNum = RandomNumber();
        compRandomNum = RandomNumber();
        System.Threading.Thread.Sleep(500);
        Console.WriteLine($"{player1} rolled a: {player1RandomNum}");
        Console.WriteLine("...");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine($"Enemy rolled a: {compRandomNum}\n");

        if (player1RandomNum > compRandomNum)
        {
            player1Scores++;
        }
        else
        {
            compRandomNum++;
        }

    }
    Console.Clear();
    Console.WriteLine();
    System.Threading.Thread.Sleep(200);
    if (player1Scores > compScores)
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player1} {player1Scores}");
        Console.WriteLine($"\tEnemy {compScores}");
        Console.WriteLine("\tYOU WIN!! :)");

    }
    else if (player1Scores < compScores)
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\tEnemy {compScores}");
        Console.WriteLine($"\t{player1} {player1Scores}");
        Console.WriteLine("\tYOU LOSE!! :(");
    }
    else
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\tEnemy: {compScores}");
        Console.WriteLine("\tIt's a DRAW.");
    }
  
}
else if (players == 2)
{
    Console.Write("Enter player one's name: ");
    player1 = Console.ReadLine();
    Console.Write("Enter player two's name: ");
    player2 = Console.ReadLine();

    int player1RandomNum;
    int player2RandomNum;
    int player1Scores = 0;
    int player2Scores = 0;
    int round = 1;

    for (int i = 0; i < 6; i++)
    {
        System.Threading.Thread.Sleep(1500);
        Console.Clear();
        Console.WriteLine($"\tROUND {round}");
        round++;
        Console.Write($"{player1}> ");
        Console.ReadKey(true);
        Console.WriteLine();
        player1RandomNum = RandomNumber();
        Console.WriteLine("...");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine($"{player1} rolled a: {player1RandomNum}\n");
        System.Threading.Thread.Sleep(200);
        Console.Write($"{player2}> ");
        Console.ReadKey(true);
        Console.WriteLine();
        player2RandomNum = RandomNumber();
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("...");
        Console.WriteLine($"{player2} rolled a: {player2RandomNum}\n");

        if (player1RandomNum > player2RandomNum)
        {
            player1Scores++;
        }
        else
        {
            player2Scores++;
        }

    }
    Console.Clear();
    Console.WriteLine();
    System.Threading.Thread.Sleep(200);
    if (player1Scores > player2Scores)
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\t{player2}: {player2Scores}");
        Console.WriteLine($"\t{player1} WINS!! :)");

    }
    else if (player1Scores < player2Scores)
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player2}: {player2Scores}");
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\t{player2} WINS!! :)");
    }
    else
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\t{player2}: {player2Scores}");
        Console.WriteLine("\tIt's a DRAW.");
    }
}
else if (players == 3)
{
    Console.Write("Enter player one's name: ");
    player1 = Console.ReadLine();
    Console.Write("Enter player two's name: ");
    player2 = Console.ReadLine();
    Console.Write("Enter player three's name: ");
    player3 = Console.ReadLine();

    int player1RandomNum;
    int player2RandomNum;
    int player3RandomNum;
    int player1Scores = 0;
    int player2Scores = 0;
    int player3Scores = 0;
    int round = 1;

    for (int i = 0; i < 6; i++)
    {
        System.Threading.Thread.Sleep(1500);
        Console.Clear();
        Console.WriteLine($"\tROUND {round}");
        round++;
        Console.Write($"{player1}> ");
        Console.ReadKey(true);
        Console.WriteLine();
        player1RandomNum = RandomNumber();
        Console.WriteLine("...");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine($"{player1} rolled a: {player1RandomNum}\n");
        System.Threading.Thread.Sleep(200);
        Console.Write($"{player2}> ");
        Console.ReadKey(true);
        Console.WriteLine();
        player2RandomNum = RandomNumber();
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("...");
        Console.WriteLine($"{player2} rolled a: {player2RandomNum}\n");
        System.Threading.Thread.Sleep(200);
        Console.Write($"{player3}> ");
        Console.ReadKey(true);
        Console.WriteLine();
        player3RandomNum = RandomNumber();
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("...");
        Console.WriteLine($"{player3} rolled a: {player3RandomNum}\n");

        if (player1RandomNum > player2RandomNum && player1RandomNum > player3RandomNum)
        {
            player1Scores++;
        }
        else if (player2RandomNum > player1RandomNum && player2RandomNum > player3RandomNum)
        {
            player2Scores++;
        }
        else player3Scores++;

    }
    Console.Clear();
    Console.WriteLine();
    System.Threading.Thread.Sleep(200);
    if (player1Scores > player2Scores && player1Scores > player3Scores)
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\t{player2}: {player2Scores}");
        Console.WriteLine($"\t{player3}: {player3Scores}");
        Console.WriteLine($"\t{player1} WINS!! :)");

    }
    else if (player2Scores > player1Scores && player2Scores > player3Scores)
    {
        Console.WriteLine("\tThe scores are!!");
        Console.WriteLine($"\t{player2}: {player2Scores}");
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\t{player3}: {player3Scores}");
        Console.WriteLine($"\t{player2} WINS!! :)");
    }
    else if (player3Scores > player1Scores && player3Scores > player2Scores)
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player3}: {player3Scores}");
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\t{player2}: {player2Scores}");
        Console.WriteLine($"\t{player3} WINS!! :)");
    }
    else
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\t{player2}: {player2Scores}");
        Console.WriteLine($"\t{player3}: {player3Scores}");
        Console.WriteLine("\tIts a DRAW.");
    }
}
else
{
    Console.Write("Enter player one's name: ");
    player1 = Console.ReadLine();
    Console.Write("Enter player two's name: ");
    player2 = Console.ReadLine();
    Console.Write("Enter player three's name: ");
    player3 = Console.ReadLine();
    Console.Write("Enter player four's name: ");
    player4 = Console.ReadLine();

    int player1RandomNum;
    int player2RandomNum;
    int player3RandomNum;
    int player4RandomNum;
    int player1Scores = 0;
    int player2Scores = 0;
    int player3Scores = 0;
    int player4Scores = 0;
    int round = 1;

    for (int i = 0; i < 6; i++)
    {
        System.Threading.Thread.Sleep(1500);
        Console.Clear();
        Console.WriteLine($"\tROUND {round}");
        round++;
        Console.Write($"{player1}> ");
        Console.ReadKey(true);
        Console.WriteLine();
        player1RandomNum = RandomNumber();
        Console.WriteLine("...");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine($"{player1} rolled a: {player1RandomNum}\n");
        System.Threading.Thread.Sleep(200);
        Console.Write($"{player2}> ");
        Console.ReadKey(true);
        Console.WriteLine();
        player2RandomNum = RandomNumber();
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("...");
        Console.WriteLine($"{player2} rolled a: {player2RandomNum}\n");
        System.Threading.Thread.Sleep(200);
        Console.Write($"{player3}> ");
        Console.ReadKey(true);
        Console.WriteLine();
        player3RandomNum = RandomNumber();
        Console.WriteLine("...");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine($"{player3} rolled a: {player3RandomNum}\n");
        System.Threading.Thread.Sleep(200);
        Console.Write($"{player4}> ");
        Console.ReadKey(true);
        Console.WriteLine();
        player4RandomNum = RandomNumber();
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("...");
        Console.WriteLine($"{player4} rolled a: {player4RandomNum}\n");

        if (player1RandomNum > player2RandomNum & player1RandomNum > player3RandomNum & player1RandomNum > player4RandomNum)
        {
            player1Scores++;
        }
        else if (player2RandomNum > player1RandomNum && player2RandomNum > player3RandomNum && player2RandomNum > player4RandomNum)
        {
            player2Scores++;
        }
        else if (player3RandomNum > player1RandomNum && player3RandomNum > player2RandomNum && player3RandomNum > player4RandomNum)
        {
            player3Scores++;
        }
        else player4Scores++;

    }
    Console.Clear();
    Console.WriteLine();
    System.Threading.Thread.Sleep(200);
    if (player1Scores > player2Scores && player1Scores > player3Scores && player1Scores > player4Scores)
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\t{player2}: {player2Scores}");
        Console.WriteLine($"\t{player3}: {player3Scores}");
        Console.WriteLine($"\t{player4}: {player4Scores}");
        Console.WriteLine($"\t{player1} WINS!! :)");

    }
    else if (player2Scores > player1Scores && player2Scores > player3Scores && player2Scores > player4Scores)
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player2}: {player2Scores}");
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\t{player3}: {player3Scores}");
        Console.WriteLine($"\t{player4}: {player4Scores}");
        Console.WriteLine($"\t{player2} WINS!! :)");
    }
    else if (player3Scores > player1Scores && player3Scores > player2Scores && player3Scores > player4Scores)
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player3}: {player3Scores}");
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\t{player2}: {player2Scores}");
        Console.WriteLine($"\t{player3}: {player3Scores}");
        Console.WriteLine($"\t{player3} WINS!! :)");
    }
    else if (player4Scores > player1Scores && player4Scores > player2Scores && player4Scores > player3Scores)
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player4}: {player4Scores}");
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\t{player2}: {player2Scores}");
        Console.WriteLine($"\t{player3}: {player3Scores}");
        Console.WriteLine($"\t{player4} WINS!! :)");
    }
    else
    {
        Console.WriteLine("\tThe scores are!!");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"\t{player1}: {player1Scores}");
        Console.WriteLine($"\t{player2}: {player2Scores}");
        Console.WriteLine($"\t{player3}: {player3Scores}");
        Console.WriteLine($"\t{player4}: {player4Scores}");
        Console.WriteLine("\tIts a DRAW.");
    }
}

System.Threading.Thread.Sleep(200);
Console.WriteLine();
Console.WriteLine("Thank you for playing.\nFollow @bit_worm_\nTitanBit Solutions - titanbit.com");
Console.WriteLine("Press any key to exit...");
Console.ReadKey(true);


int RandomNumber()
{
    Random random = new Random();
    return random.Next(1, 7);
}