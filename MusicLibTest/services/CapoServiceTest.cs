using Xunit;
using MusicLib;
using System.Collections.Generic;

namespace MusicLibTest
{
  public class CapoServiceTest
  {
    [Fact]
    public void TestCapoService()
    {
      Song song = new Song(new List<Key> { Key.FromRoot("Ab") });

      List<Transposition> transpositions = new CapoService().Optimize(song);

      Assert.Equal("G", transpositions[0].NewSong.Keys[0].Root);
    }
  }
}
