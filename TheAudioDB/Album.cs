using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using TheAudioDB.Data;

namespace TheAudioDB
{
  public class Album
  {
    [JsonProperty("album")]
    public List<AlbumData> List { get; set; }

    public Album()
    {     
    }

    public Album(string artistName, string albumName)
    {
      if (artistName != "" & albumName != "")
        List = ByArtistAndAlbum(artistName, albumName, API.Key).List;

      if (artistName != "" & albumName == "")
        List = ByArtistname(artistName, API.Key).List;

      if (artistName == "" & albumName != "")
        List = ByAlbumname(albumName, API.Key).List;
    }

    public Album(string artistName, string albumName, string apiKey)
    {
      if (artistName != "" & albumName != "")
        List = ByArtistAndAlbum(artistName, albumName, apiKey).List;

      if (artistName != "" & albumName == "")
        List = ByArtistname(artistName, apiKey).List;

      if (artistName == "" & albumName != "")
        List = ByAlbumname(albumName, apiKey).List;
    }

    private Album ByArtistAndAlbum(string artistName, string albumName, string apiKey)
    {
      return Get_Album(GetUrl(apiKey) + "s=" + artistName + "&a=" + albumName);
    }

    private Album ByArtistname(string artistName, string apiKey)
    {
      return Get_Album(GetUrl(apiKey) + "s=" + artistName);
    }

    private Album ByAlbumname(string albumName, string apiKey)
    {
      return Get_Album(GetUrl(apiKey) + "a=" + albumName);
    }

    private Album Get_Album(string url)
    {
      var c = new Album {List = new List<AlbumData>()};
      c.List.Add(new AlbumData());

      try
      {
        string json;
        using (var w = new WebClient())
        {
          json = w.DownloadString(url);
        }

        var settings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
        var tmp = JsonConvert.DeserializeObject<Album>(json, settings);
        return tmp ?? c;
      }
      catch (Exception)
      {
        return c;
      }
    }

    private string GetUrl(string key)
    {
      return "http://www.theaudiodb.com/api/v1/json/" + key + "/searchalbum.php?";
    }
  }
}
