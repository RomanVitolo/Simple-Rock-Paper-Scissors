Console.WriteLine("Rock Paper Scissors");

while (true)
{
    Console.WriteLine("Are you Ready?");
    Console.WriteLine("Let's begin!!!");

    var selectedChoice = SelectChoice();
    var userChoice = char.Parse(selectedChoice);

    Console.WriteLine($"You selected {userChoice}");

    var opponentChoice = GetOpponentChoice();

    Console.WriteLine($" I chose {opponentChoice}");

    DecidedWinner(opponentChoice, userChoice);

    Console.WriteLine("Do you want to play again?");
    Console.WriteLine("Enter YES to play again or any other key to stop...");

    var playAgain = Console.ReadLine();

    if (playAgain?.ToLower() == "yes")    
        continue;    
    else
        break;
    
}

string SelectChoice()
{
    Console.WriteLine("Choose R, P or S: [R]ock, [P]aper or [S]cissors");
    var saveSelectedChoice = Console.ReadLine();

    if (saveSelectedChoice?.ToLower() != "r" && saveSelectedChoice?.ToLower() != "p" && saveSelectedChoice?.ToLower() != "s")
    {
        Console.WriteLine("Please, select only one letter: R, P or S");
        saveSelectedChoice = SelectChoice();
        
    }
    return saveSelectedChoice;
}

char GetOpponentChoice()
{
    char[] options = new char[] { 'R', 'P', 'S' };

    Random random = new Random();
    int randomIndex = random.Next(0, options.Length);

    return options[randomIndex];
}

void DecidedWinner(char opponentChoice, char userChoice)
{
    if (opponentChoice == userChoice)
    {
        Console.WriteLine("Tie!");
        return;
    }        

    switch (userChoice)
    {
        case 'r':
            if (opponentChoice == 'P')
            {
                Console.WriteLine("Paper beats rock, I WIN!");
            }
            else if (opponentChoice == 'S')
            {
                Console.WriteLine("Rock beats scissors, YOU WIN!");
            }
            break;

        case 's':
            if (opponentChoice == 'P')
            {
                Console.WriteLine("Scissors beats paper, YOU WIN!");
            }
            else if (opponentChoice == 'R')
            {
                Console.WriteLine("Rock beats scissors, I WIN!");
            }
            break;

        case 'P':
            if (opponentChoice == 'S')
            {
                Console.WriteLine("Scissors beats paper, I WIN!");
            }
            else if (opponentChoice == 'R')
            {
                Console.WriteLine("Paper beats rock, YOU WIN!");
            }
            break;
        default:
            break;
    }
}

