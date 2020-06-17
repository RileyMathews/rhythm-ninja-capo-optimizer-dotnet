using Xunit;
using MusicLib;
using System.Collections.Generic;

namespace MusicLibTest
{
  public class TranspositionTest
  {
    [Fact]
    public void TestCanCreateTransposition()
    {
      List<Key> keys = new List<Key>();
      keys.Add(Key.FromRoot("A"));
      keys.Add(Key.FromRoot("B"));
      Song originalSong = new Song(keys);

      Transposition actual = new Transposition(originalSong, 2);

      Assert.Equal("A", actual.OriginalSong.Keys[0].Root);
      Assert.Equal("G", actual.NewSong.Keys[0].Root);
    }
  }
}
