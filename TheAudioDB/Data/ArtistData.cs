using System.Runtime.Serialization;

namespace TheAudioDB.Data
{
  [DataContract]
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

    [DataMember(Name = "idArtist")]
    public string Id { get; set; }

    [DataMember(Name = "strArtist")]
    public string Name { get; set; }

    [DataMember(Name = "strArtistAlternate")]
    public string NameAlternate { get; set; }

    [DataMember(Name = "idLabel")]
    public int? Label { get; set; }

    [DataMember(Name = "intFormedYear")]
    public int? FormedYear { get; set; }

    [DataMember(Name = "intBornYear")]
    public int? BornYear { get; set; }

    [DataMember(Name = "intDiedYear")]
    public int? DiedYear { get; set; }

    [DataMember(Name = "strDisbanded")]
    public string Disbanded { get; set; }

    [DataMember(Name = "strGenre")]
    public string Genre { get; set; }

    [DataMember(Name = "strSubGenre")]
    public string SubGenre { get; set; }

    [DataMember(Name = "strMood")]
    public string Mood { get; set; }

    [DataMember(Name = "strWebsite")]
    public string Website { get; set; }

    [DataMember(Name = "strFacebook")]
    public string Facebook { get; set; }

    [DataMember(Name = "strTwitter")]
    public string Twitter { get; set; }

    [DataMember(Name = "strBiographyEN")]
    public string BiographyEn { get; set; }

    [DataMember(Name = "strBiographyDE")]
    public string BiographyDe { get; set; }

    [DataMember(Name = "strBiographyFR")]
    public string BiographyFr { get; set; }

    [DataMember(Name = "strBiographyCN")]
    public string BiographyCn { get; set; }

    [DataMember(Name = "strBiographyIT")]
    public string BiographyIt { get; set; }

    [DataMember(Name = "strBiographyJP")]
    public string BiographyJp { get; set; }

    [DataMember(Name = "strBiographyRU")]
    public string BiographyRu { get; set; }

    [DataMember(Name = "strBiographyES")]
    public string BiographyEs { get; set; }

    [DataMember(Name = "strBiographyPT")]
    public string BiographyPt { get; set; }

    [DataMember(Name = "strBiographySE")]
    public string BiographySe { get; set; }

    [DataMember(Name = "strBiographyNL")]
    public string BiographyNl { get; set; }

    [DataMember(Name = "strBiographyHU")]
    public string BiographyHu { get; set; }

    [DataMember(Name = "strBiographyNO")]
    public string BiographyNo { get; set; }

    [DataMember(Name = "strBiographyIL")]
    public string BiographyIl { get; set; }

    [DataMember(Name = "strBiographyPL")]
    public string BiographyPl { get; set; }

    [DataMember(Name = "strGender")]
    public string Gender { get; set; }

    [DataMember(Name = "intMembers")]
    public int? Members { get; set; }

    [DataMember(Name = "strCountry")]
    public string Country { get; set; }

    [DataMember(Name = "strCountryCode")]
    public string Countrycode { get; set; }

    [DataMember(Name = "strArtistThumb")]
    public string ArtistThumb { get; set; }

    [DataMember(Name = "strArtistLogo")]
    public string ArtistLogo { get; set; }

    [DataMember(Name = "strArtistFanart")]
    public string ArtistFanart1 { get; set; }

    [DataMember(Name = "strArtistFanart2")]
    public string ArtistFanart2 { get; set; }

    [DataMember(Name = "strArtistFanart3")]
    public string ArtistFanart3 { get; set; }

    [DataMember(Name = "strArtistBanner")]
    public string ArtistBanner { get; set; }

    [DataMember(Name = "strMusicBrainzID")]
    public string MusicBrainzId { get; set; }

    [DataMember(Name = "strLastFMChart")]
    public string LastFmChart { get; set; }

    [DataMember(Name = "strLocked")]
    public string Locked { get; set; }
  }
}
