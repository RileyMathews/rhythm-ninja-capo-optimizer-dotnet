using System.Linq;
using System.Collections.Generic;

namespace MusicLib
{
  public class CapoService
  {
    public Song originalSong;

    public CapoService(Song originalSong)
    {
      this.originalSong = originalSong;
    }
    public List<Transposition> Optimize()
    {
      List<int> seeds = new List<int>() { 1, 2, 3, 4, 5 };
      List<Transposition> transpositions = seeds.Select(i => new Transposition(originalSong, i)).ToList();
      List<Transposition> transpositionsWithCagedKeys = transpositions.Where(i => i.NewSong.Keys.Any(key => key.IsCagedKey())).ToList();
      List<Transposition> transpositionsByCagedCount = transpositionsWithCagedKeys.OrderByDescending(i => i.NewSong.Keys.Count(key => key.IsCagedKey())).ToList();
      return transpositionsByCagedCount;
    }
  }
}
