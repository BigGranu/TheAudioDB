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
  public class Artist
  {
    [DataMember(Name = "artists")]
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
        var request = WebRequest.Create(url);
        request.Proxy = WebRequest.DefaultWebProxy;
        request.Credentials = CredentialCache.DefaultCredentials; ;
        request.Proxy.Credentials = CredentialCache.DefaultCredentials;
        var response = request.GetResponse();
        var reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();

        Artist tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };

          var serializer = new DataContractJsonSerializer(typeof(Artist), settings);
          tmp = (Artist)serializer.ReadObject(ms);
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
      return "http://www.theaudiodb.com/api/v1/json/" + key + "/";
    }
  }
}
