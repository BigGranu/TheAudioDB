using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using TheAudioDB.Data;

namespace TheAudioDB
{
  public class Artist
  {
    [JsonProperty("artists")]
    public List<ArtistData> List { get; set; }

    public Artist()
    {
    }

    public Artist(string name)
    {
      List = ByName(name, API.Key).List;
    }

    public Artist(string name, string apiKey)
    {
      List = ByName(name, apiKey).List;
    }

    public Artist(Guid mbid)
    {
      List = ByMbId(mbid, API.Key).List;
    }

    public Artist(Guid mbid, string apiKey)
    {
      List = ByMbId(mbid, apiKey).List;
    }

    private Artist ByName(string name, string apiKey)
    {
      return GetArtist(GetUrl(apiKey) + "search.php?s=" + name);
    }

    private Artist ByMbId(Guid mbid, string apiKey)
    {
      return GetArtist(GetUrl(apiKey) + "artist-mb.php?i=" + mbid);
    }

    private Artist GetArtist(string url)
    {
      var c = new Artist {List = new List<ArtistData>()};
      c.List.Add(new ArtistData());

      try
      {
        string json;
        using (var w = new WebClient())
        {
          json = w.DownloadString(url);
        }

        var settings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
        var tmp = JsonConvert.DeserializeObject<Artist>(json, settings);
        return tmp ?? c;
      }
      catch (Exception)
      {
        return c;
      }
    }

    private string GetUrl(string key)
    {
      return "http://www.theaudiodb.com/api/v1/json/" + key + "/";
    }
  }
}
