using System.Collections.Generic;
using System.Timers;

namespace keyboard_hero.Models
{
  class ActiveGame
  {
    public bool Playing { get; set; }
    public int Score { get; set; }
    public List<string> Directions { get; set; } = new List<string>() { "Up", "Down", "Left", "Right" };
    public Timer Timer { get; set; }
    public string Target { get; set; }

    public ActiveGame()
    {
      Score = 0;
      Playing = true;
    }
  }
}