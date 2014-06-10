using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using TheAudioDB.Data;

namespace TheAudioDB
{
  public class Track
  {
    [JsonProperty("track")]
    public List<TrackData> List { get; set; }

    public Track()
    {
    }

    public Track(string artistName, string trackName)
    {
      List = ByName(artistName, trackName, API.Key).List;
    }

    public Track(string artistName, string trackName, string apiKey)
    {
      List = ByName(artistName, trackName, apiKey).List;
    }

    private Track ByName(string artistName, string trackName, string apiKey)
    {
      return GetTrack(GetUrl(apiKey) + "s=" + artistName + "&t=" + trackName);
    }

    private static Track GetTrack(string url)
    {
      var c = new Track {List = new List<TrackData>()};
      c.List.Add(new TrackData());

      try
      {
        string json;
        using (var w = new WebClient())
        {
          json = w.DownloadString(url);
        }

        var settings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
        var tmp = JsonConvert.DeserializeObject<Track>(json, settings);
        return tmp ?? c;
      }
      catch (Exception)
      {
        return c;
      }
    }

    private string GetUrl(string key)
    {
      return "http://www.theaudiodb.com/api/v1/json/" + key + "/searchtrack.php?";
    }

  }
}
