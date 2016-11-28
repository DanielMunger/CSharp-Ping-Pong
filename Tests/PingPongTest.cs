using Xunit;
using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPongTest
  {
    // [Fact]
    // public void LoopTest()
    // {
    //   PingPong testPingPong = new PingPong(15);
    //   testPingPong.PingPongGenerator(15);
    //   var testList = testPingPong.GetList();
    //   Assert.Equal(true, testList.Count == 15);
    // }
    [Fact]
    public void ValueTest()
    {
      PingPong testPingPong = new PingPong(15);
      testPingPong.PingPongGenerator(3);
      List<string> testList = testPingPong.GetList();
      List<string> expectedList = new List<string> {"1", "2", "ping"};
      for (int i = 0; i < testList.Count; i++)
      {
        Assert.Equal(true, testList[i] == expectedList[i]);
      }
    }
  }
}
