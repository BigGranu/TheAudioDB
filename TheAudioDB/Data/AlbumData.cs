using System.Runtime.Serialization;

namespace TheAudioDB.Data
{
  [DataContract]
  public class AlbumData
  {
    public AlbumData()
    {
      IdAlbum = string.Empty;
      IdArtist = string.Empty;
      StrAlbum = string.Empty;
      StrArtist = string.Empty;
      IntYearReleased = 0;
      StrGenre = string.Empty;
      StrSubGenre = string.Empty;
      StrReleaseFormat = string.Empty;
      IntSales = 0;
      StrAlbumThumb = string.Empty;
      StrAlbumCDart = string.Empty;
      StrDescriptionEN = string.Empty;
      StrDescriptionDE = string.Empty;
      StrDescriptionFR = string.Empty;
      StrDescriptionCN = string.Empty;
      StrDescriptionIT = string.Empty;
      StrDescriptionJP = string.Empty;
      StrDescriptionRU = string.Empty;
      StrDescriptionES = string.Empty;
      StrDescriptionPT = string.Empty;
      StrDescriptionSE = string.Empty;
      StrDescriptionNL = string.Empty;
      StrDescriptionHU = string.Empty;
      StrDescriptionNO = string.Empty;
      StrDescriptionIL = string.Empty;
      StrDescriptionPL = string.Empty;
      IntLoved = 0;
      IntScore = 0;
      StrReview = string.Empty;
      StrMood = string.Empty;
      StrTheme = string.Empty;
      StrSpeed = string.Empty;
      StrLocation = string.Empty;
      StrMusicBrainzID = string.Empty;
      StrMusicBrainzArtistID = string.Empty;
      StrItunesID = string.Empty;
      StrAmazonID = string.Empty;
      StrLocked = string.Empty;
      StrDescription = string.Empty;
    }

    [DataMember(Name = "idAlbum")]
    public string IdAlbum { get; set; }

    [DataMember(Name = "idArtist")]
    public string IdArtist { get; set; }

    [DataMember(Name = "strAlbum")]
    public string StrAlbum { get; set; }

    [DataMember(Name = "strArtist")]
    public string StrArtist { get; set; }

    [DataMember(Name = "intYearReleased")]
    public int? IntYearReleased { get; set; }

    [DataMember(Name = "strGenre")]
    public string StrGenre { get; set; }

    [DataMember(Name = "strSubGenre")]
    public string StrSubGenre { get; set; }

    [DataMember(Name = "strReleaseFormat")]
    public string StrReleaseFormat { get; set; }

    [DataMember(Name = "intSales")]
    public int? IntSales { get; set; }

    [DataMember(Name = "strAlbumThumb")]
    public string StrAlbumThumb { get; set; }

    [DataMember(Name = "strAlbumCDart")]
    public object StrAlbumCDart { get; set; }

    [DataMember(Name = "strDescriptionEN")]
    public string StrDescriptionEN { get; set; }

    [DataMember(Name = "strDescriptionDE")]
    public string StrDescriptionDE { get; set; }

    [DataMember(Name = "strDescriptionFR")]
    public string StrDescriptionFR { get; set; }

    [DataMember(Name = "strDescriptionCN")]
    public string StrDescriptionCN { get; set; }

    [DataMember(Name = "strDescriptionIT")]
    public string StrDescriptionIT { get; set; }

    [DataMember(Name = "strDescriptionJP")]
    public string StrDescriptionJP { get; set; }

    [DataMember(Name = "strDescriptionRU")]
    public string StrDescriptionRU { get; set; }

    [DataMember(Name = "strDescriptionES")]
    public string StrDescriptionES { get; set; }

    [DataMember(Name = "strDescriptionPT")]
    public string StrDescriptionPT { get; set; }

    [DataMember(Name = "strDescriptionSE")]
    public string StrDescriptionSE { get; set; }

    [DataMember(Name = "strDescriptionNL")]
    public string StrDescriptionNL { get; set; }

    [DataMember(Name = "strDescriptionHU")]
    public string StrDescriptionHU { get; set; }

    [DataMember(Name = "strDescriptionNO")]
    public string StrDescriptionNO { get; set; }

    [DataMember(Name = "strDescriptionIL")]
    public string StrDescriptionIL { get; set; }

    [DataMember(Name = "strDescriptionPL")]
    public string StrDescriptionPL { get; set; }

    [DataMember(Name = "intLoved")]
    public int? IntLoved { get; set; }

    [DataMember(Name = "intScore")]
    public int? IntScore { get; set; }

    [DataMember(Name = "strReview")]
    public string StrReview { get; set; }

    [DataMember(Name = "strMood")]
    public string StrMood { get; set; }

    [DataMember(Name = "strTheme")]
    public object StrTheme { get; set; }

    [DataMember(Name = "strSpeed")]
    public string StrSpeed { get; set; }

    [DataMember(Name = "strLocation")]
    public object StrLocation { get; set; }

    [DataMember(Name = "strMusicBrainzID")]
    public string StrMusicBrainzID { get; set; }

    [DataMember(Name = "strMusicBrainzArtistID")]
    public string StrMusicBrainzArtistID { get; set; }

    [DataMember(Name = "strItunesID")]
    public object StrItunesID { get; set; }

    [DataMember(Name = "strAmazonID")]
    public object StrAmazonID { get; set; }

    [DataMember(Name = "strLocked")]
    public string StrLocked { get; set; }

    [DataMember(Name = "strDescription")]
    public object StrDescription { get; set; }
  }
}
