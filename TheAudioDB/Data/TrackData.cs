using Newtonsoft.Json;

namespace TheAudioDB.Data
{
  public class TrackData
  {
    public TrackData()
    {
      IdTrack = string.Empty;
      IdAlbum = string.Empty;
      IdArtist = string.Empty;
      StrTrack = string.Empty;
      StrAlbum = string.Empty;
      StrArtist = string.Empty;
      IntCD = 0;
      IntDuration = 0;
      StrGenre = string.Empty;
      StrDescriptionEN = string.Empty;
      StrTrackThumb = string.Empty;
      StrTrackLyrics = string.Empty;
      StrMusicVid = string.Empty;
      StrMusicVidDirector = string.Empty;
      StrMusicVidCompany = string.Empty;
      StrMusicVidScreen1 = string.Empty;
      StrMusicVidScreen2 = string.Empty;
      StrMusicVidScreen3 = string.Empty;
      IntTrackNumber = 0;
      IntLoved = 0;
      StrMusicBrainzID = string.Empty;
      StrMusicBrainzAlbumID = string.Empty;
      StrMusicBrainzArtistID = string.Empty;
      StrLocked = string.Empty;
    }

    [JsonProperty("idTrack")]
    public string IdTrack { get; set; }

    [JsonProperty("idAlbum")]
    public string IdAlbum { get; set; }

    [JsonProperty("idArtist")]
    public string IdArtist { get; set; }

    [JsonProperty("strTrack")]
    public string StrTrack { get; set; }

    [JsonProperty("strAlbum")]
    public string StrAlbum { get; set; }

    [JsonProperty("strArtist")]
    public string StrArtist { get; set; }

    [JsonProperty("intCD")]
    public int IntCD { get; set; }

    [JsonProperty("intDuration")]
    public int IntDuration { get; set; }

    [JsonProperty("strGenre")]
    public string StrGenre { get; set; }

    [JsonProperty("strDescriptionEN")]
    public string StrDescriptionEN { get; set; }

    [JsonProperty("strTrackThumb")]
    public string StrTrackThumb { get; set; }

    [JsonProperty("strTrackLyrics")]
    public string StrTrackLyrics { get; set; }

    [JsonProperty("strMusicVid")]
    public string StrMusicVid { get; set; }

    [JsonProperty("strMusicVidDirector")]
    public string StrMusicVidDirector { get; set; }

    [JsonProperty("strMusicVidCompany")]
    public string StrMusicVidCompany { get; set; }

    [JsonProperty("strMusicVidScreen1")]
    public string StrMusicVidScreen1 { get; set; }

    [JsonProperty("strMusicVidScreen2")]
    public string StrMusicVidScreen2 { get; set; }

    [JsonProperty("strMusicVidScreen3")]
    public string StrMusicVidScreen3 { get; set; }

    [JsonProperty("intTrackNumber")]
    public int IntTrackNumber { get; set; }

    [JsonProperty("intLoved")]
    public int IntLoved { get; set; }

    [JsonProperty("strMusicBrainzID")]
    public string StrMusicBrainzID { get; set; }

    [JsonProperty("strMusicBrainzAlbumID")]
    public string StrMusicBrainzAlbumID { get; set; }

    [JsonProperty("strMusicBrainzArtistID")]
    public string StrMusicBrainzArtistID { get; set; }

    [JsonProperty("strLocked")]
    public string StrLocked { get; set; }
  }
}
