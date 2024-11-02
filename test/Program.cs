using System.Globalization;

Random random = new Random();
bool playAgain = true;
String player;
String computer;
string response;
while (playAgain)
{
    player = "";
    computer = "";
    response = "";
    while (player != "rock" && player != "paper" && player != "scissors")
    {
        Console.Write("Enter rock, paper, scissors: ");
        player = Console.ReadLine();
        player = player.ToLower();
    }
    
    switch (random.Next(1, 4))
    {
        case 1:
            computer = "rock";
            break;
        case 2:
            computer = "paper";
            break;
        case 3:
            computer = "scissors";
            break;
    }
    Console.WriteLine("Player: " + player);
    Console.WriteLine("Computer: " + computer);
    switch (player)
    {
        case "rock":
            if (computer == "rock")
            {
                Console.WriteLine("Its a tie!");
            }
            else if (computer == "paper")
            {
                Console.WriteLine("You lose!");
            }
            else if (computer == "scissors"){

                Console.WriteLine("You win!");
            }
            break;
        case "paper":
            if (computer == "rock")
            {
                Console.WriteLine("You win!");
            }
            else if (computer == "paper")
            {
                Console.WriteLine("Its a tie!");
            }
            else if (computer == "scissors"){
                Console.WriteLine("You lose!");
            }
            break;
        case "scissors":
            if (computer == "rock")
            {
                Console.WriteLine("You lose!");
            }
            else if (computer == "paper")
            {
                Console.WriteLine("You win!");
            }
            else if (computer == "scissors"){
                Console.WriteLine("Its a tie!");
            }
            break;
    }
    Console.WriteLine("Would you like to play again?Y/N: ");
    response = Console.ReadLine();
    response = response.ToLower();
    if (response == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain= false;
    }

}


Console.WriteLine("Thanks for playing!");
Console.ReadKey();
