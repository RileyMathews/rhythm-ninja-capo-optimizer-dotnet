using System;
using Xunit;
using MusicLib;

namespace MusicLibTest
{
  public class KeyTest
  {
    [Fact]
    public void TestCanCreateKey()
    {
      Key actual = new Key("A", 0);

      Assert.Equal("A", actual.root);
    }
  }
}
