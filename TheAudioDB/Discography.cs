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
  public class Discography
  {
    [DataMember(Name = "album")]
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
        var request = WebRequest.Create(url);
        request.Proxy = WebRequest.DefaultWebProxy;
        request.Credentials = CredentialCache.DefaultCredentials; ;
        request.Proxy.Credentials = CredentialCache.DefaultCredentials;
        var response = request.GetResponse();
        var reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();

        Discography tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };

          var serializer = new DataContractJsonSerializer(typeof(Discography), settings);
          tmp = (Discography)serializer.ReadObject(ms);
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
