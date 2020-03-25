using System;
using System.Timers;
using keyboard_hero.Models;

namespace keyboard_hero.Project
{
  class Game
  {

    ActiveGame _game = new ActiveGame();
    internal void Play()
    {
      Console.Clear();
      while (_game.Playing)
      {
        SetTarget();
        SetTimer();
        PlayerInput();
        _game.Timer.Dispose();
      }
      System.Console.WriteLine("You scored {0}", _game.Score);
      Console.WriteLine("Press any key to play again or q to quit.");
      string input = Console.ReadKey().Key.ToString().ToLower();
      if (input == "q")
      {
        System.Console.WriteLine("GoodBye");
      }
      else
      {
        _game.Playing = true;
        _game.Score = 0;
        Play();
      }
    }

    private void SetTarget()
    {
      int index = new Random().Next(4);
      _game.Target = _game.Directions[index];
      System.Console.WriteLine(_game.Target);
    }

    private void PlayerInput()
    {
      string input = Console.ReadKey().Key.ToString();
      // System.Console.WriteLine(input);
      if (!input.Contains("Arrow"))
      {
        _game.Playing = false;
      }

      input = input.Split("A")[0];
      Console.WriteLine(input);
      CompareDirections(input);

    }

    private void CompareDirections(string input)
    {
      if (_game.Target != input)
      {
        _game.Playing = false;
      }
      else
      {
        _game.Score++;
      }

    }

    private void SetTimer()
    {
      _game.Timer = new Timer();
      _game.Timer.Interval = 3000 - (_game.Score * 75);
      _game.Timer.Elapsed += TimesUp;
      _game.Timer.Start();
    }

    private void TimesUp(object source, ElapsedEventArgs e)
    {
      _game.Playing = false;
      _game.Timer.Dispose();
      System.Console.WriteLine("Times Up! Press spacebar to continue");
    }

  }
}