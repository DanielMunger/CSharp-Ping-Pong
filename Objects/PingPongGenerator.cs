using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPong
  {
      private int _upperLimit;
      private static List<string> _listOfInts = new List<string> {};

      public PingPong(int UpperLimit)
      {
        _upperLimit = UpperLimit;
      }

      public bool IsDivisiblebyThree(int EqualityTest)
      {
        return EqualityTest % 3 == 0;
      }

      public bool IsDivisiblebyFive(int EqualityTest)
      {
        return EqualityTest % 5 == 0;
      }

      public bool IsDivisiblebyFifteen(int EqualityTest)
      {
        return EqualityTest % 15 == 0;
      }

      public List<string> PingPongGenerator(int upperLimit)
      {
        for (int i = 1; i <= upperLimit; i++)
        {
          if (IsDivisiblebyFifteen(i)) {
            _listOfInts.Add("ping-pong");
          } else if (IsDivisiblebyFive(i)) {
            _listOfInts.Add("pong");
          } else if (IsDivisiblebyThree(i)) {
              _listOfInts.Add("ping");
          } else {
           _listOfInts.Add(i.ToString());
         }
        }
        foreach (var item in _listOfInts)
        {
          System.Console.WriteLine(item);
        }
        return _listOfInts;
      }

      public List<string> GetList()
      {
        return _listOfInts;
      }
  }
}
