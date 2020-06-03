namespace MusicLib
{
  public class Transposition
  {
    public Song OriginalSong;
    public Song NewSong;
    public int StepsUp;

    public Transposition(Song originalSong, int stepsUp)
    {
      OriginalSong = originalSong;
      StepsUp = stepsUp;
      NewSong = originalSong.TransposeUp(stepsUp);
    }
  }
}
