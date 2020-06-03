using Xunit;
using MusicLib;
using System.Collections.Generic;

namespace MusicLibTest
{
  public class SongTest
  {
    [Fact]
    public void TestCanCreateSong()
    {
      List<Key> keys = new List<Key>();
      keys.Add(Key.FromRoot("A"));
      keys.Add(Key.FromRoot("B"));

      Song actual = new Song(keys);

      Assert.Equal("A", actual.Keys[0].Root);
      Assert.Equal("B", actual.Keys[1].Root);
    }

    [Fact]
    public void TestCanTranposeSong()
    {
      List<Key> keys = new List<Key>();
      keys.Add(Key.FromRoot("A"));
      keys.Add(Key.FromRoot("B"));
      Song originalSong = new Song(keys);

      Song actual = originalSong.TransposeUp(2);

      Assert.Equal("B", actual.Keys[0].Root);
      Assert.Equal("Db", actual.Keys[1].Root);
    }
  }
}
