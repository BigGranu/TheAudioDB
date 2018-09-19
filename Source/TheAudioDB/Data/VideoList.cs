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
    ///     VideoList
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class VideoList
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     Create new VideoList
        /// </summary>
        public VideoList()
        {
        }

        /// <summary>
        ///     Create new VideoList with Result
        /// </summary>
        /// <param name="data">Result</param>
        public VideoList(VideoListResult data)
        {
            Data = data;
        }

        /// <summary>
        ///     All possible Data
        /// </summary>
        public VideoListResult Data { get; set; }

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
    ///     List of Video
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class VideoListResult
    {
        /// <summary>
        ///     List of Video
        /// </summary>
        [JsonProperty("mvids")]
        public List<Mvid> List { get; set; } = new List<Mvid>();
    }

    /// <summary>
    ///     Data for a Video
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class Mvid
    {
        /// <summary>
        ///     Artist ID
        /// </summary>
        [JsonProperty("idArtist")]
        public string ArtistId { get; set; } = string.Empty;

        /// <summary>
        ///     MusicBrainzArtistID
        /// </summary>
        [JsonProperty("strMusicBrainzArtistID")]
        public string MusicBrainzArtistId { get; set; } = string.Empty;

        /// <summary>
        ///     Album ID
        /// </summary>
        [JsonProperty("idAlbum")]
        public string AlbumId { get; set; } = string.Empty;

        /// <summary>
        ///     Track ID
        /// </summary>
        [JsonProperty("idTrack")]
        public string TrackId { get; set; } = string.Empty;

        /// <summary>
        ///     Track
        /// </summary>
        [JsonProperty("strTrack")]
        public string Track { get; set; } = string.Empty;

        /// <summary>
        ///     Track Thumb
        /// </summary>
        [JsonProperty("strTrackThumb")]
        public string TrackThumb { get; set; } = string.Empty;

        /// <summary>
        ///     Musicvideo
        /// </summary>
        [JsonProperty("strMusicVid")]
        public string MusicVid { get; set; } = string.Empty;

        /// <summary>
        ///     Description
        /// </summary>
        [JsonProperty("strDescription")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        ///     Description EN
        /// </summary>
        [JsonProperty("strDescriptionEN")]
        public string DescriptionEn
        {
            get => Description;
            set => Description = value;
        }
    }
}