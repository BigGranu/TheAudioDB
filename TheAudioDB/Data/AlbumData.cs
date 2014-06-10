using Newtonsoft.Json;

namespace TheAudioDB.Data
{
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

    [JsonProperty("idAlbum")]
    public string IdAlbum { get; set; }

    [JsonProperty("idArtist")]
    public string IdArtist { get; set; }

    [JsonProperty("strAlbum")]
    public string StrAlbum { get; set; }

    [JsonProperty("strArtist")]
    public string StrArtist { get; set; }

    [JsonProperty("intYearReleased")]
    public int IntYearReleased { get; set; }

    [JsonProperty("strGenre")]
    public string StrGenre { get; set; }

    [JsonProperty("strSubGenre")]
    public string StrSubGenre { get; set; }

    [JsonProperty("strReleaseFormat")]
    public string StrReleaseFormat { get; set; }

    [JsonProperty("intSales")]
    public int IntSales { get; set; }

    [JsonProperty("strAlbumThumb")]
    public string StrAlbumThumb { get; set; }

    [JsonProperty("strAlbumCDart")]
    public object StrAlbumCDart { get; set; }

    [JsonProperty("strDescriptionEN")]
    public string StrDescriptionEN { get; set; }

    [JsonProperty("strDescriptionDE")]
    public string StrDescriptionDE { get; set; }

    [JsonProperty("strDescriptionFR")]
    public string StrDescriptionFR { get; set; }

    [JsonProperty("strDescriptionCN")]
    public string StrDescriptionCN { get; set; }

    [JsonProperty("strDescriptionIT")]
    public string StrDescriptionIT { get; set; }

    [JsonProperty("strDescriptionJP")]
    public string StrDescriptionJP { get; set; }

    [JsonProperty("strDescriptionRU")]
    public string StrDescriptionRU { get; set; }

    [JsonProperty("strDescriptionES")]
    public string StrDescriptionES { get; set; }

    [JsonProperty("strDescriptionPT")]
    public string StrDescriptionPT { get; set; }

    [JsonProperty("strDescriptionSE")]
    public string StrDescriptionSE { get; set; }

    [JsonProperty("strDescriptionNL")]
    public string StrDescriptionNL { get; set; }

    [JsonProperty("strDescriptionHU")]
    public string StrDescriptionHU { get; set; }

    [JsonProperty("strDescriptionNO")]
    public string StrDescriptionNO { get; set; }

    [JsonProperty("strDescriptionIL")]
    public string StrDescriptionIL { get; set; }

    [JsonProperty("strDescriptionPL")]
    public string StrDescriptionPL { get; set; }

    [JsonProperty("intLoved")]
    public int IntLoved { get; set; }

    [JsonProperty("intScore")]
    public int IntScore { get; set; }

    [JsonProperty("strReview")]
    public string StrReview { get; set; }

    [JsonProperty("strMood")]
    public string StrMood { get; set; }

    [JsonProperty("strTheme")]
    public object StrTheme { get; set; }

    [JsonProperty("strSpeed")]
    public string StrSpeed { get; set; }

    [JsonProperty("strLocation")]
    public object StrLocation { get; set; }

    [JsonProperty("strMusicBrainzID")]
    public string StrMusicBrainzID { get; set; }

    [JsonProperty("strMusicBrainzArtistID")]
    public string StrMusicBrainzArtistID { get; set; }

    [JsonProperty("strItunesID")]
    public object StrItunesID { get; set; }

    [JsonProperty("strAmazonID")]
    public object StrAmazonID { get; set; }

    [JsonProperty("strLocked")]
    public string StrLocked { get; set; }

    [JsonProperty("strDescription")]
    public object StrDescription { get; set; }
  }
}
