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
      Key actual = new Key("A", 1);

      Assert.Equal("A", actual.Root);
      Assert.Equal(1, actual.ChromaticIndex);
    }

    [Fact]
    public void TestCanCreateByRoot()
    {
      Key actual = Key.FromRoot("A");

      Assert.Equal("A", actual.Root);
      Assert.Equal(1, actual.ChromaticIndex);
    }

    [Fact]
    public void TestCreateInvalidKeyRaisesError()
    {
      Assert.Throws<Exception>(() => new Key("A", 10));
    }

    [Fact]
    public void TestCanTransposeUp()
    {
      Key OriginalKey = Key.FromRoot("A");
      Key NewKey = OriginalKey.TransposeUp(1);

      Assert.Equal("Bb", NewKey.Root);
    }

    [Fact]
    public void TestIsCagedKey()
    {
      foreach (string item in new string[] { "C", "A", "G", "E", "D" })
      {
        Key key = Key.FromRoot(item);

        Assert.True(key.IsCagedKey());
      }

      foreach (string item in new string[] { "Bb", "B", "Db", "Eb", "F", "Gb", "Ab" })
      {
        Key key = Key.FromRoot(item);

        Assert.False(key.IsCagedKey());
      }
    }
  }
}
