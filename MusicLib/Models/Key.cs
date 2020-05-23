using System.Collections.Generic;

namespace MusicLib
{
  public class Key
  {
    public string Root;
    public int ChromaticIndex;

    private static Dictionary<string, int> RootToIndex = CreateIndexMap();

    public Key(string root, int index)
    {
      if(index != RootToIndex[root])
      {
        throw new System.Exception();
      }
      Root = root;
      ChromaticIndex = index;
    }

    public static Key FromRoot(string root)
    {
      return new Key(root, RootToIndex[root]);
    }

    private static Dictionary<string, int> CreateIndexMap()
    {
      Dictionary<string, int> dict = new Dictionary<string, int>();
      dict.Add("A", 1);
      dict.Add("Bb", 2);
      dict.Add("B", 3);
      dict.Add("C", 4);
      dict.Add("Db", 5);
      dict.Add("D", 6);
      dict.Add("Eb", 7);
      dict.Add("E", 8);
      dict.Add("F", 9);
      dict.Add("Gb", 10);
      dict.Add("G", 11);
      dict.Add("Ab", 12);
      return dict;
    }
  }
}
