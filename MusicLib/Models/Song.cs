using System.Collections.Generic;
using System.Linq;

namespace MusicLib
{
  public class Song
  {
    public List<Key> Keys;

    public Song(List<Key> keys)
    {
      Keys = keys;
    }

    public Song TransposeUp(int stepsUp)
    {
      List<Key> newKeys = Keys.ConvertAll(key => key.TransposeUp(stepsUp));
      return new Song(newKeys);
    }

    public Song TranposeDown(int stepsDown)
    {
      List<Key> newKeys = Keys.ConvertAll(key => key.TransposeDown(stepsDown));
      return new Song(newKeys);
    }
  }
}
