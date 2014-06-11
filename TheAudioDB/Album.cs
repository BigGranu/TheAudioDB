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
  public class Album
  {
    [DataMember(Name = "album")]
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
        var request = WebRequest.Create(url);
        request.Proxy = WebRequest.DefaultWebProxy;
        request.Credentials = CredentialCache.DefaultCredentials; ;
        request.Proxy.Credentials = CredentialCache.DefaultCredentials;
        var response = request.GetResponse();
        var reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();

        Album tmp;

        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
          var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };

          var serializer = new DataContractJsonSerializer(typeof(Album), settings);
          tmp = (Album)serializer.ReadObject(ms);
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
      return "http://www.theaudiodb.com/api/v1/json/" + key + "/searchalbum.php?";
    }
  }
}
