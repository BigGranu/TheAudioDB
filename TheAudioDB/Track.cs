using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using TheAudioDB.Data;

namespace TheAudioDB
{
  [DataContract]
  public class Track
  {
    [DataMember(Name = "track")]
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
      var c = new Track { List = new List<TrackData>() };
      c.List.Add(new TrackData());

      try
      {
        var request = WebRequest.Create(url);
        request.Proxy = WebRequest.DefaultWebProxy;
        request.Credentials = CredentialCache.DefaultCredentials; ;
        request.Proxy.Credentials = CredentialCache.DefaultCredentials;
        var response = request.GetResponse();
        var reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();

        Track tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings {UseSimpleDictionaryFormat = true};
      
          var serializer = new DataContractJsonSerializer(typeof(Track), settings);
          tmp = (Track)serializer.ReadObject(ms);          
        }

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
