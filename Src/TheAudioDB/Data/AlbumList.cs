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
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TheAudioDB.Events;

namespace TheAudioDB.Data
{
    /// <summary>
    ///     AlbumList
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class AlbumList
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     Create new AlbumList
        /// </summary>
        public AlbumList()
        {
        }

        /// <summary>
        ///     Create new AlbumList with Result
        /// </summary>
        /// <param name="data">Result</param>
        public AlbumList(AlbumListResult data)
        {
            Data = data;
     
        }

        /// <summary>
        ///     All possible Data
        /// </summary>
        public AlbumListResult Data { get; set; }

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
    ///     List of Album
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class AlbumListResult
    {
        /// <summary>
        ///     List of Album
        /// </summary>
        [JsonProperty("album")]
        public List<Album> List { get; set; } = new List<Album>();
    }

    /// <summary>
    ///     Data for a Album
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class Album
    {
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
        ///     Year of Release
        /// </summary>
        [JsonProperty("intYearReleased")]
        public string IntYearReleased { get; set; } = string.Empty;

        /// <summary>
        ///     Genre
        /// </summary>
        [JsonProperty("strGenre")]
        public string StrGenre { get; set; } = string.Empty;

        /// <summary>
        ///     Subgenre
        /// </summary>
        [JsonProperty("strSubGenre")]
        public string StrSubGenre { get; set; } = string.Empty;

        /// <summary>
        ///     Releaseformat
        /// </summary>
        [JsonProperty("strReleaseFormat")]
        public string StrReleaseFormat { get; set; } = string.Empty;

        /// <summary>
        ///     Sales
        /// </summary>
        [JsonProperty("intSales")]
        public string IntSales { get; set; } = string.Empty;

        /// <summary>
        ///     Album Thumb
        /// </summary>
        [JsonProperty("strAlbumThumb")]
        public string StrAlbumThumb { get; set; } = string.Empty;

        /// <summary>
        ///     Album CD Art
        /// </summary>
        [JsonProperty("strAlbumCDart")]
        public string StrAlbumCDart { get; set; } = string.Empty;

        /// <summary>
        ///     Description EN
        /// </summary>
        [JsonProperty("strDescriptionEN")]
        public string StrDescriptionEn { get; set; } = string.Empty;

        /// <summary>
        ///     Description DE
        /// </summary>
        [JsonProperty("strDescriptionDE")]
        public string StrDescriptionDe { get; set; } = string.Empty;

        /// <summary>
        ///     Description FR
        /// </summary>
        [JsonProperty("strDescriptionFR")]
        public string StrDescriptionFr { get; set; } = string.Empty;

        /// <summary>
        ///     Description CN
        /// </summary>
        [JsonProperty("strDescriptionCN")]
        public string StrDescriptionCn { get; set; } = string.Empty;

        /// <summary>
        ///     Description IT
        /// </summary>
        [JsonProperty("strDescriptionIT")]
        public string StrDescriptionIt { get; set; } = string.Empty;

        /// <summary>
        ///     Description JP
        /// </summary>
        [JsonProperty("strDescriptionJP")]
        public string StrDescriptionJp { get; set; } = string.Empty;

        /// <summary>
        ///     Description RU
        /// </summary>
        [JsonProperty("strDescriptionRU")]
        public string StrDescriptionRu { get; set; } = string.Empty;

        /// <summary>
        ///     Description ES
        /// </summary>
        [JsonProperty("strDescriptionES")]
        public string StrDescriptionEs { get; set; } = string.Empty;

        /// <summary>
        ///     Description PT
        /// </summary>
        [JsonProperty("strDescriptionPT")]
        public string StrDescriptionPt { get; set; } = string.Empty;

        /// <summary>
        ///     Description SE
        /// </summary>
        [JsonProperty("strDescriptionSE")]
        public string StrDescriptionSe { get; set; } = string.Empty;

        /// <summary>
        ///     Description NL
        /// </summary>
        [JsonProperty("strDescriptionNL")]
        public string StrDescriptionNl { get; set; } = string.Empty;

        /// <summary>
        ///     Description HU
        /// </summary>
        [JsonProperty("strDescriptionHU")]
        public string StrDescriptionHu { get; set; } = string.Empty;

        /// <summary>
        ///     Description NO
        /// </summary>
        [JsonProperty("strDescriptionNO")]
        public string StrDescriptionNo { get; set; } = string.Empty;

        /// <summary>
        ///     Description IL
        /// </summary>
        [JsonProperty("strDescriptionIL")]
        public string StrDescriptionIl { get; set; } = string.Empty;

        /// <summary>
        ///     Description PL
        /// </summary>
        [JsonProperty("strDescriptionPL")]
        public string StrDescriptionPl { get; set; } = string.Empty;

        /// <summary>
        ///     Loved Count
        /// </summary>
        [JsonProperty("intLoved")]
        public string IntLoved { get; set; } = string.Empty;

        /// <summary>
        ///     Score
        /// </summary>
        [JsonProperty("intScore")]
        public string IntScore { get; set; } = string.Empty;

        /// <summary>
        ///     Review
        /// </summary>
        [JsonProperty("strReview")]
        public string StrReview { get; set; } = string.Empty;

        /// <summary>
        ///     Mood
        /// </summary>
        [JsonProperty("strMood")]
        public string StrMood { get; set; } = string.Empty;

        /// <summary>
        ///     Theme
        /// </summary>
        [JsonProperty("strTheme")]
        public string StrTheme { get; set; } = string.Empty;

        /// <summary>
        ///     Speed
        /// </summary>
        [JsonProperty("strSpeed")]
        public string StrSpeed { get; set; } = string.Empty;

        /// <summary>
        ///     Location
        /// </summary>
        [JsonProperty("strLocation")]
        public string StrLocation { get; set; } = string.Empty;

        /// <summary>
        ///     MusicBrainzID
        /// </summary>
        [JsonProperty("strMusicBrainzID")]
        public string StrMusicBrainzId { get; set; } = string.Empty;

        /// <summary>
        ///     MusicBrainzArtistID
        /// </summary>
        [JsonProperty("strMusicBrainzArtistID")]
        public string StrMusicBrainzArtistId { get; set; } = string.Empty;

        /// <summary>
        ///     ItunesID
        /// </summary>
        [JsonProperty("strItunesID")]
        public string StrItunesId { get; set; } = string.Empty;

        /// <summary>
        ///     AmazonID
        /// </summary>
        [JsonProperty("strAmazonID")]
        public string StrAmazonId { get; set; } = string.Empty;

        /// <summary>
        ///     Locked
        /// </summary>
        [JsonProperty("strLocked")]
        public string StrLocked { get; set; } = string.Empty;

        /// <summary>
        ///     Description
        /// </summary>
        [JsonProperty("strDescription")]
        public string StrDescription { get; set; } = string.Empty;
    }
}