using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using TheAudioDB.Data;

namespace TheAudioDB
{
  public class Discography
  {
    [JsonProperty("album")]
    public List<DiscographyData> List { get; set; }

    public Discography()
    {
    }

    public Discography(string name)
    {
      List = ByName(name, API.Key).List;
    }

    public Discography(string name, string apiKey)
    {
      List = ByName(name, apiKey).List;
    }

    public Discography(Guid mbid)
    {
      List = ByMbId(mbid, API.Key).List;
    }

    public Discography(Guid mbid, string apiKey)
    {
      List = ByMbId(mbid, apiKey).List;
    }

    public Discography ByName(string name, string apiKey)
    {
      return GetDiscography(GetUrl(apiKey) + "discography.php?s=" + name);
    }

    public Discography ByMbId(Guid mbid, string apiKey)
    {
      return GetDiscography(GetUrl(apiKey) + "discography-mb.php?s=" + mbid);
    }

    private Discography GetDiscography(string url)
    {
      var c = new Discography {List = new List<DiscographyData>()};
      c.List.Add(new DiscographyData());

      try
      {
        string json;
        using (var w = new WebClient())
        {
          json = w.DownloadString(url);
        }

        var settings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
        var tmp = JsonConvert.DeserializeObject<Discography>(json, settings);
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
