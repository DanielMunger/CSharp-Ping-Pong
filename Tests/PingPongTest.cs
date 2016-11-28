using Xunit;

namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void IsDivisiblebyThree_ReplaceMultiplesofThree_true()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(true, testPingPong.IsDivisiblebyThree(9));
    }

    [Fact]
    public void IsDivisiblebyThree_ReplaceMultiplesofFive_true()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(true, testPingPong.IsDivisiblebyFive(55));
    }

    [Fact]
    public void IsDivisiblebyThree_ReplaceMultiplesofFifteen_true()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(true, testPingPong.IsDivisiblebyFifteen(90));
    }
  }
}
