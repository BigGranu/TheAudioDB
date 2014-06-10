namespace TheAudioDB
{
  public class API
  {
    public Track Track;
    public Artist Artist;
    public Album Album;
    public Discography Discography;

    public static string Key = string.Empty;

    public API(string apiKey)
    {
      Key = apiKey;
      Track = new Track();
      Artist = new Artist();
      Album = new Album();
      Discography = new Discography();
    }
  }
}
