// This project is going to be a mini, rpg styled text based game.
// Using the thing's I've learned so far, I believe this could be improved using OOP
// Which I believe will be taught soon in this course.

// Variables
int playerHP = 10;
int playerArmor = 10;
int playerAttackLevel = 5;
int playerAttackDamage = 10;
decimal armorMultiplier = 0.2M;
string playerName = "";

Console.WriteLine("Welcome to txtFight, a small text based RPG game");
Console.WriteLine("Can you please enter your players name:");
bool flag = true;
do {
playerName = Console.ReadLine();
Console.WriteLine($"You entered {playerName} for your name. Is this correct?\nEnter [1] for Yes \t Enter [2] for No");
var isCorrectAnswer = Console.ReadLine();
if (isCorrectAnswer == "1") {
    flag = false;
Console.WriteLine($"Hello, {playerName} pleasure to meet you. Let's introduce you to your character.");
Console.WriteLine($"HP\t\tArmour\t\tAttack Level\t\tAttack DMG\t\tArmour Multi");
Console.WriteLine($"{playerHP}\t\t{playerArmor}\t\t{playerAttackLevel}\t\t{playerAttackDamage}\t\t{armorMultiplier}");
Console.ReadLine();

}
else
{
    Console.WriteLine("Please re-enter your name.");
}

}
while (flag == true);
