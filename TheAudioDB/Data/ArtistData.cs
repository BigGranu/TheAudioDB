using Newtonsoft.Json;

namespace TheAudioDB.Data
{
  public class ArtistData
  {
    public ArtistData()
    {
      Id = string.Empty;
      Name = string.Empty;
      NameAlternate = string.Empty;
      Label = 0;
      FormedYear = 0;
      BornYear = 0;
      DiedYear = 0;
      Disbanded = string.Empty;
      Genre = string.Empty;
      SubGenre = string.Empty;
      Mood = string.Empty;
      Website = string.Empty;
      Facebook = string.Empty;
      Twitter = string.Empty;
      BiographyEn = string.Empty;
      BiographyDe = string.Empty;
      BiographyFr = string.Empty;
      BiographyCn = string.Empty;
      BiographyIt = string.Empty;
      BiographyJp = string.Empty;
      BiographyRu = string.Empty;
      BiographyEs = string.Empty;
      BiographyPt = string.Empty;
      BiographySe = string.Empty;
      BiographyNl = string.Empty;
      BiographyHu = string.Empty;
      BiographyNo = string.Empty;
      BiographyIl = string.Empty;
      BiographyPl = string.Empty;
      Gender = string.Empty;
      Members = 0;
      Country = string.Empty;
      Countrycode = string.Empty;
      ArtistThumb = string.Empty;
      ArtistLogo = string.Empty;
      ArtistFanart1 = string.Empty;
      ArtistFanart2 = string.Empty;
      ArtistFanart3 = string.Empty;
      ArtistBanner = string.Empty;
      MusicBrainzId = string.Empty;
      LastFmChart = string.Empty;
      Locked = string.Empty;
    }

    [JsonProperty("idArtist")]
    public string Id { get; set; }

    [JsonProperty("strArtist")]
    public string Name { get; set; }

    [JsonProperty("strArtistAlternate")]
    public string NameAlternate { get; set; }

    [JsonProperty("idLabel")]
    public int Label { get; set; }

    [JsonProperty("intFormedYear")]
    public int FormedYear { get; set; }

    [JsonProperty("intBornYear")]
    public int BornYear { get; set; }

    [JsonProperty("intDiedYear")]
    public int DiedYear { get; set; }

    [JsonProperty("strDisbanded")]
    public string Disbanded { get; set; }

    [JsonProperty("strGenre")]
    public string Genre { get; set; }

    [JsonProperty("strSubGenre")]
    public string SubGenre { get; set; }

    [JsonProperty("strMood")]
    public string Mood { get; set; }

    [JsonProperty("strWebsite")]
    public string Website { get; set; }

    [JsonProperty("strFacebook")]
    public string Facebook { get; set; }

    [JsonProperty("strTwitter")]
    public string Twitter { get; set; }

    [JsonProperty("strBiographyEN")]
    public string BiographyEn { get; set; }

    [JsonProperty("strBiographyDE")]
    public string BiographyDe { get; set; }

    [JsonProperty("strBiographyFR")]
    public string BiographyFr { get; set; }

    [JsonProperty("strBiographyCN")]
    public string BiographyCn { get; set; }

    [JsonProperty("strBiographyIT")]
    public string BiographyIt { get; set; }

    [JsonProperty("strBiographyJP")]
    public string BiographyJp { get; set; }

    [JsonProperty("strBiographyRU")]
    public string BiographyRu { get; set; }

    [JsonProperty("strBiographyES")]
    public string BiographyEs { get; set; }

    [JsonProperty("strBiographyPT")]
    public string BiographyPt { get; set; }

    [JsonProperty("strBiographySE")]
    public string BiographySe { get; set; }

    [JsonProperty("strBiographyNL")]
    public string BiographyNl { get; set; }

    [JsonProperty("strBiographyHU")]
    public string BiographyHu { get; set; }

    [JsonProperty("strBiographyNO")]
    public string BiographyNo { get; set; }

    [JsonProperty("strBiographyIL")]
    public string BiographyIl { get; set; }

    [JsonProperty("strBiographyPL")]
    public string BiographyPl { get; set; }

    [JsonProperty("strGender")]
    public string Gender { get; set; }

    [JsonProperty("intMembers")]
    public int Members { get; set; }

    [JsonProperty("strCountry")]
    public string Country { get; set; }

    [JsonProperty("strCountryCode")]
    public string Countrycode { get; set; }

    [JsonProperty("strArtistThumb")]
    public string ArtistThumb { get; set; }

    [JsonProperty("strArtistLogo")]
    public string ArtistLogo { get; set; }

    [JsonProperty("strArtistFanart")]
    public string ArtistFanart1 { get; set; }

    [JsonProperty("strArtistFanart2")]
    public string ArtistFanart2 { get; set; }

    [JsonProperty("strArtistFanart3")]
    public string ArtistFanart3 { get; set; }

    [JsonProperty("strArtistBanner")]
    public string ArtistBanner { get; set; }

    [JsonProperty("strMusicBrainzID")]
    public string MusicBrainzId { get; set; }

    [JsonProperty("strLastFMChart")]
    public string LastFmChart { get; set; }

    [JsonProperty("strLocked")]
    public string Locked { get; set; }
  }
}
