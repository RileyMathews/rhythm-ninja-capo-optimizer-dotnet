using System.Linq;
using System.Collections.Generic;

namespace MusicLib
{
  public class CapoService
  {
    public List<Transposition> Optimize(Song originalSong)
    {
      List<int> seeds = new List<int>() { 1, 2, 3, 4, 5 };
      List<Transposition> transpositions = seeds.Select(i => new Transposition(originalSong, i)).ToList();
      List<Transposition> transpositionsWithCagedKeys = transpositions.Where(i => i.NewSong.Keys.Any(key => this.CagedKeys.Contains(key.Root))).ToList();
      List<Transposition> transpositionsByCagedCount = transpositionsWithCagedKeys.OrderByDescending(i => i.NewSong.Keys.Count(key => this.CagedKeys.Contains(key.Root))).ToList();
      return transpositionsByCagedCount;
    }

    private string[] CagedKeys = { "C", "A", "G", "E", "D" };
  }
}
