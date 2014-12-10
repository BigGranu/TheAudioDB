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

    public Track GetAllTracks(string albumId)
    {
        return GetTracksByAlbumId(albumId, API.Key);
    }

    private Album ByArtistAndAlbum(string artistName, string albumName, string apiKey)
    {
      return Get_Album(GetUrl(apiKey) + "/searchalbum.php?s=" + artistName + "&a=" + albumName);
    }

    private Album ByArtistname(string artistName, string apiKey)
    {
        return Get_Album(GetUrl(apiKey) + "/searchalbum.php?s=" + artistName);
    }

    private Album ByAlbumname(string albumName, string apiKey)
    {
        return Get_Album(GetUrl(apiKey) + "/searchalbum.php?a=" + albumName);
    }

    private Track GetTracksByAlbumId(string albumId, string apiKey)
    {
        return Get_Tracks(GetUrl(apiKey) + "/track.php?m=" + albumId);
    }

    private Track Get_Tracks(string url)
    {
        var c = new Track { List = new List<TrackData>() };
        c.List.Add(new TrackData());

        try
        {
            string json = MakeRequest(url);
            Track tmp;
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                var settings = new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true };

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

    private string MakeRequest(string url)
    {
        var request = WebRequest.Create(url);
        request.Proxy = WebRequest.DefaultWebProxy;
        request.Credentials = CredentialCache.DefaultCredentials; ;
        request.Proxy.Credentials = CredentialCache.DefaultCredentials;
        var response = request.GetResponse();
        var reader = new StreamReader(response.GetResponseStream());

        return reader.ReadToEnd();;
    }

    private Album Get_Album(string url)
    {
      var c = new Album {List = new List<AlbumData>()};
      c.List.Add(new AlbumData());

      try
      {
        string json = MakeRequest(url);        

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
      return "http://www.theaudiodb.com/api/v1/json/" + key;
    }
  }
}
