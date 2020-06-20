using System.Collections.Generic;
using System.Linq;

namespace MusicLib
{
  public class Key
  {
    public string Root;
    public int ChromaticIndex;

    private static Dictionary<string, int> RootToIndex = CreateIndexMap();
    private static Dictionary<int, string> IndexToRoot = CreateRootMap();

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

    public Key TransposeUp(int steps)
    {
      int TransposeSteps = steps + this.ChromaticIndex;
      while(TransposeSteps > 12) { TransposeSteps -= 12; }
      return FromIndex(TransposeSteps);
    }

    public Key TransposeDown(int steps)
    {
      int TransposeSteps = this.ChromaticIndex - steps;
      while(TransposeSteps < 0) { TransposeSteps += 12; }
      return FromIndex(TransposeSteps);
    }

    private Key FromIndex(int index)
    {
      return new Key(IndexToRoot[index], index);
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

    private static Dictionary<int, string> CreateRootMap()
    {
      Dictionary<int, string> dict = new Dictionary<int, string>();
      dict.Add(1, "A");
      dict.Add(2, "Bb");
      dict.Add(3, "B");
      dict.Add(4, "C");
      dict.Add(5, "Db");
      dict.Add(6, "D");
      dict.Add(7, "Eb");
      dict.Add(8, "E");
      dict.Add(9, "F");
      dict.Add(10, "Gb");
      dict.Add(11, "G");
      dict.Add(12, "Ab");
      return dict;
    }
  }
}
