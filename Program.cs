// This project is going to be a mini, rpg styled text based game.
// Using the thing's I've learned so far, I believe this could be improved using OOP
// Which I believe will be taught soon in this course.

// Variables
int playerHP = 10;
int playerArmor = 10;
int playerAttackLevel = 5;
int playerAttackDamage = 10;
decimal armorMultiplier = 0.2d;
string playerName = "";

Console.WriteLine("Welcome to txtFight, a small text based RPG game");
Console.WriteLine("Can you please enter your players name:");
bool flag = true;
do {
playerName = Console.ReadLine();
Console.WriteLine($"You entered {playerName} for your name. Is this correct?");

}
while (flag == true);
