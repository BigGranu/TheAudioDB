using Newtonsoft.Json;

namespace TheAudioDB.Data
{
  public class DiscographyData
  {
    public DiscographyData()
    {
      StrAlbum = string.Empty;
      IntYearReleased = 0;
    }

    [JsonProperty("strAlbum")]
    public string StrAlbum { get; set; }

    [JsonProperty("intYearReleased")]
    public int IntYearReleased { get; set; }
  }
}
