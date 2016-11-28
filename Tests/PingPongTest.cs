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
  }
}
