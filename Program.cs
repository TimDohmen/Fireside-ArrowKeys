using System;
using keyboard_hero.Project;

namespace keyboard_hero
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Welcome To Keyboard Hero ! \n Press Any Key To Begin..");
      Console.ReadKey();
      Game game = new Game();
      game.Play();
    }
  }
}
