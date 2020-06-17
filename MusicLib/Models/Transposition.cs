namespace MusicLib
{
  public class Transposition
  {
    public Song OriginalSong;
    public Song NewSong;
    public int StepsDown;

    public Transposition(Song originalSong, int stepsDown)
    {
      OriginalSong = originalSong;
      StepsDown = stepsDown;
      NewSong = originalSong.TranposeDown(stepsDown);
    }
  }
}
