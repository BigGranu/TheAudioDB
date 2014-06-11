using System.Runtime.Serialization;

namespace TheAudioDB.Data
{
  [DataContract]
  public class DiscographyData
  {
    public DiscographyData()
    {
      StrAlbum = string.Empty;
      IntYearReleased = 0;
    }

    [DataMember(Name = "strAlbum")]
    public string StrAlbum { get; set; }

    [DataMember(Name = "intYearReleased")]
    public int? IntYearReleased { get; set; }
  }
}
