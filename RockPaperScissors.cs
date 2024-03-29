using System;
using System.IO;

Random r1 = new Random();
int computerMoveInt = r1.Next(1,3);

string computerMoveStr;
string playerMoveStr;


const int rock = 1;
const int paper = 2;
// const int Scissors = 3;


if (computerMoveInt == rock)
{
    computerMoveStr = "Rock";
}
else if (computerMoveInt == paper)
{
    computerMoveStr = "Paper";
}
else 
{
    computerMoveStr = "Scissors";
}

Console.WriteLine("Computer has chosen Move, Your turn (1 = rock, 2 = Paper and 3 = Scissors)");
int playerMoveInt = Convert.ToInt32(Console.ReadLine());
if (playerMoveInt == rock)
{
    playerMoveStr = "Rock";
}
else if (playerMoveInt == paper)
{
    playerMoveStr = "Paper";
}
else 
{
    playerMoveStr = "Scissors";
}

DecideWinner(computerMoveInt, playerMoveInt,playerMoveStr ,computerMoveStr);

void Draw(string computerMoveString)
{
    Console.WriteLine("Both Sides Chose " + computerMoveString + " Resulting in a draw");
}

void PlayerWins(string playerMoveString, string computerMoveString)
{
    Console.WriteLine("Player Chose " + playerMoveString + " and computer chose " + computerMoveString + " resulting in player win!");
}

void ComputerWins(string playerMoveString, string computerMoveString)
{
    Console.WriteLine("Player Chose " + playerMoveString + " and computer chose " + computerMoveString + " resulting in player loss");
}

void DecideWinner(int computerMoveInteger, int playerMoveInteger, string playerMoveStr, string computerMoveStr)
{
    if (computerMoveInteger != 1) //if computer doesnt choose rock
    {
        if (computerMoveInteger - 1 == playerMoveInteger) // if computer doesnt choose rock and chooses something that wins against the players choice  
        {
            ComputerWins(playerMoveStr, computerMoveStr);
        }
        else if (computerMoveInteger == playerMoveInteger) // if computer doesnt choose the same as the player, its choice doesn't win against players choice and it isnt 1 Player wins
        {
            Draw(computerMoveStr);
        }
        else 
        {
            PlayerWins(playerMoveStr, computerMoveStr); // if none of the previous conditions are met Player Wins
        }
    }
    else 
    {
        if (playerMoveInteger == 3)
        {
            ComputerWins(playerMoveStr, computerMoveStr);
        }
        else if (computerMoveInteger == playerMoveInteger)
        {
            Draw(computerMoveStr);
        }
        else 
        {
            PlayerWins(playerMoveStr, computerMoveStr);
        }
    }
}

Console.WriteLine("press enter to close");
Console.ReadLine();