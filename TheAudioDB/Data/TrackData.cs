using System.Runtime.Serialization;

namespace TheAudioDB.Data
{
  [DataContract]
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

    [DataMember(Name = "idTrack")]
    public string IdTrack { get; set; }

    [DataMember(Name = "idAlbum")]
    public string IdAlbum { get; set; }

    [DataMember(Name = "idArtist")]
    public string IdArtist { get; set; }

    [DataMember(Name = "strTrack")]
    public string StrTrack { get; set; }

    [DataMember(Name = "strAlbum")]
    public string StrAlbum { get; set; }

    [DataMember(Name = "strArtist")]
    public string StrArtist { get; set; }

    [DataMember(Name = "intCD")]
    public int? IntCD { get; set; }

    [DataMember(Name = "intDuration")]
    public int? IntDuration { get; set; }

    [DataMember(Name = "strGenre")]
    public string StrGenre { get; set; }

    [DataMember(Name = "strDescriptionEN")]
    public string StrDescriptionEN { get; set; }

    [DataMember(Name = "strTrackThumb")]
    public string StrTrackThumb { get; set; }

    [DataMember(Name = "strTrackLyrics")]
    public string StrTrackLyrics { get; set; }

    [DataMember(Name = "strMusicVid")]
    public string StrMusicVid { get; set; }

    [DataMember(Name = "strMusicVidDirector")]
    public string StrMusicVidDirector { get; set; }

    [DataMember(Name = "strMusicVidCompany")]
    public string StrMusicVidCompany { get; set; }

    [DataMember(Name = "strMusicVidScreen1")]
    public string StrMusicVidScreen1 { get; set; }

    [DataMember(Name = "strMusicVidScreen2")]
    public string StrMusicVidScreen2 { get; set; }

    [DataMember(Name = "strMusicVidScreen3")]
    public string StrMusicVidScreen3 { get; set; }

    [DataMember(Name = "intTrackNumber")]
    public int? IntTrackNumber { get; set; }

    [DataMember(Name = "intLoved")]
    public int? IntLoved { get; set; }

    [DataMember(Name = "strMusicBrainzID")]
    public string StrMusicBrainzID { get; set; }

    [DataMember(Name = "strMusicBrainzAlbumID")]
    public string StrMusicBrainzAlbumID { get; set; }

    [DataMember(Name = "strMusicBrainzArtistID")]
    public string StrMusicBrainzArtistID { get; set; }

    [DataMember(Name = "strLocked")]
    public string StrLocked { get; set; }
    //[DataMember(EmitDefaultValue = false)]
    //public string idTrack { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string idAlbum { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string idArtist { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strTrack { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strAlbum { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strArtist { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public int? intCD { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public int? intDuration { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strGenre { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strDescriptionEN { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strTrackThumb { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strTrackLyrics { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strMusicVid { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strMusicVidDirector { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strMusicVidCompany { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strMusicVidScreen1 { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strMusicVidScreen2 { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strMusicVidScreen3 { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public int? intTrackNumber { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public int? intLoved { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strMusicBrainzID { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strMusicBrainzAlbumID { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strMusicBrainzArtistID { get; set; }

    //[DataMember(EmitDefaultValue = false)]
    //public string strLocked { get; set; }
  }
}
