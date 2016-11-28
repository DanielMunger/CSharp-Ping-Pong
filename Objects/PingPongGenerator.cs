using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPong
  {
      private int _upperLimit;
      private static List<string> _listOfInts = new List<string> {};

      // public void PingPong(int UpperLimit)
      // {
      //   _upperLimit = UpperLimit;
      //   _listOfInts.Add(this);
      // }

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
  }
}
