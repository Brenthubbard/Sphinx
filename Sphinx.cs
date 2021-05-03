using System;

class Sphinx
{
  static void Main()
  {
    Console.WriteLine("Answer my question wrong and you will become intumed in my belly for all time. Are you willing to take that chance? If so press the Y key to continue");
    string answer = Console.ReadLine();
    if(answer == "Y" || answer == "y")
    {
    PlayGame();
    }
    else
    {
      Console.WriteLine("You may not Enter");
    }
  }
  static void PlayGame()
  {
    Console.WriteLine("What is full of holes but still holds water?");
    string answer = Console.ReadLine();
    if (answer == "A Sponge" || answer == "a sponge" || answer == "sponge")
    {
    Console.WriteLine("HAHAHA correct but you are not done YET!");
    PlayGame1();
    }
    else
    {
    Console.WriteLine("Your toast! GET IN MY BELLY. Do you want to just hop in or do you prefer me to chew you up first????");
    }
  }
static void  PlayGame1()
{
  Console.WriteLine("Your next questions 'Im tall when Im young and short when im old........what am I?'");
  string answer = Console.ReadLine();
  if (answer == "A Candle" || answer == "a candle" || answer == "candle")
  {
    Console.WriteLine("You are correct but you must finish the game or PERISH in the acids of my ancient stomach"),
  }
}
}
// PlayGame1(); 
// PlayGame2(); 
// PlayGame3(); 