#region Copyright (C) 2015-2018 BigGranu

/*
    Copyright (C) 2015-2018 BigGranu

    This file is part of mInfo <https://github.com/BigGranu/MusicApiCollection>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using TheAudioDB.Events;

namespace TheAudioDB.Data
{
    /// <summary>
    ///     TrackList
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class TrackList
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     Create new TrackList
        /// </summary>
        public TrackList()
        {
        }

        /// <summary>
        ///     Create new TrackList with Result
        /// </summary>
        /// <param name="data">Result</param>
        public TrackList(TrackListResult data)
        {
            Data = data;
        }

        /// <summary>
        ///     All possible Data
        /// </summary>
        public TrackListResult Data { get; set; }

        /// <summary>
        ///     Error Message
        /// </summary>
        public string ErrorMessage { get; set; } = Exceptions.Message;

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred { get; set; } = Exceptions.ErrorOccurred;

        /// <summary>
        ///     Response
        /// </summary>
        public string Response { get; set; } = string.Empty;

        /// <summary>
        ///     HttpStatusCode of the last Response
        /// </summary>
        public HttpStatusCode ResponseCode { get; } = HttpStatusCode.OK;
    }

    /// <summary>
    ///     List of Track
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class TrackListResult
    {
        /// <summary>
        ///     List of Track
        /// </summary>
        [JsonProperty("track")]
        public List<Track> List { get; set; } = new List<Track>();
    }

    /// <summary>
    ///     Data for a Track
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class Track
    {
        /// <summary>
        ///     Track ID
        /// </summary>
        [JsonProperty("idTrack")]
        public string IdTrack { get; set; } = string.Empty;

        /// <summary>
        ///     Album ID
        /// </summary>
        [JsonProperty("idAlbum")]
        public string IdAlbum { get; set; } = string.Empty;

        /// <summary>
        ///     Artist ID
        /// </summary>
        [JsonProperty("idArtist")]
        public string IdArtist { get; set; } = string.Empty;

        /// <summary>
        ///     Track
        /// </summary>
        [JsonProperty("strTrack")]
        public string StrTrack { get; set; } = string.Empty;

        /// <summary>
        ///     Album
        /// </summary>
        [JsonProperty("strAlbum")]
        public string StrAlbum { get; set; } = string.Empty;

        /// <summary>
        ///     Artist
        /// </summary>
        [JsonProperty("strArtist")]
        public string StrArtist { get; set; } = string.Empty;

        /// <summary>
        ///     CD
        /// </summary>
        [JsonProperty("intCD")]
        public string IntCd { get; set; } = string.Empty;

        /// <summary>
        ///     Duration
        /// </summary>
        [JsonProperty("intDuration")]
        public string IntDuration { get; set; } = string.Empty;

        /// <summary>
        ///     Genre
        /// </summary>
        [JsonProperty("strGenre")]
        public string StrGenre { get; set; } = string.Empty;

        /// <summary>
        ///     Description EN
        /// </summary>
        [JsonProperty("strDescriptionEN")]
        public string StrDescriptionEn { get; set; } = string.Empty;

        /// <summary>
        ///     Track Thumb
        /// </summary>
        [JsonProperty("strTrackThumb")]
        public string StrTrackThumb { get; set; } = string.Empty;

        /// <summary>
        ///     Track Lyrics
        /// </summary>
        [JsonProperty("strTrackLyrics")]
        public string StrTrackLyrics { get; set; } = string.Empty;

        /// <summary>
        ///     Musicvideo
        /// </summary>
        [JsonProperty("strMusicVid")]
        public string StrMusicVid { get; set; } = string.Empty;

        /// <summary>
        ///     Musicvideo Director
        /// </summary>
        [JsonProperty("strMusicVidDirector")]
        public string StrMusicVidDirector { get; set; } = string.Empty;

        /// <summary>
        ///     Musicvideo Company
        /// </summary>
        [JsonProperty("strMusicVidCompany")]
        public string StrMusicVidCompany { get; set; } = string.Empty;

        /// <summary>
        ///     Musicvideo Scren 1
        /// </summary>
        [JsonProperty("strMusicVidScreen1")]
        public string StrMusicVidScreen1 { get; set; } = string.Empty;

        /// <summary>
        ///     Musicvideo Screen 2
        /// </summary>
        [JsonProperty("strMusicVidScreen2")]
        public string StrMusicVidScreen2 { get; set; } = string.Empty;

        /// <summary>
        ///     Musicvideo Screen 3
        /// </summary>
        [JsonProperty("strMusicVidScreen3")]
        public string StrMusicVidScreen3 { get; set; } = string.Empty;

        /// <summary>
        ///     Track Number
        /// </summary>
        [JsonProperty("intTrackNumber")]
        public string IntTrackNumber { get; set; } = string.Empty;

        /// <summary>
        ///     Loved
        /// </summary>
        [JsonProperty("intLoved")]
        public string IntLoved { get; set; } = string.Empty;

        /// <summary>
        ///     MusicBrainzID
        /// </summary>
        [JsonProperty("strMusicBrainzID")]
        public string StrMusicBrainzId { get; set; } = string.Empty;

        /// <summary>
        ///     MusicBrainzAlbumID
        /// </summary>
        [JsonProperty("strMusicBrainzAlbumID")]
        public string StrMusicBrainzAlbumId { get; set; } = string.Empty;

        /// <summary>
        ///     MusicBrainzArtistID
        /// </summary>
        [JsonProperty("strMusicBrainzArtistID")]
        public string StrMusicBrainzArtistId { get; set; } = string.Empty;

        /// <summary>
        ///     Locked
        /// </summary>
        [JsonProperty("strLocked")]
        public string StrLocked { get; set; } = string.Empty;
    }
}