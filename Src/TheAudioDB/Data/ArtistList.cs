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
    ///     Artist
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class Artist
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     Create new Artist
        /// </summary>
        public Artist()
        {
        }

        /// <summary>
        ///     Create new Artist with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Artist(ArtistResult data)
        {
            Data = data;
 
        }

        /// <summary>
        ///     All possible Data
        /// </summary>
        public ArtistResult Data { get; set; }

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
    ///     List of Artist
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class ArtistList
    {
        /// <summary>
        ///     List of Artist
        /// </summary>
        [JsonProperty("artists")]
        public List<ArtistResult> List { get; set; } = new List<ArtistResult>();
    }

    /// <summary>
    ///     Data for a Artist
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class ArtistResult
    {
        /// <summary>
        ///     Artist ID
        /// </summary>
        [JsonProperty("idArtist")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        ///     Artist
        /// </summary>
        [JsonProperty("strArtist")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        ///     Artist Alternate
        /// </summary>
        [JsonProperty("strArtistAlternate")]
        public string NameAlternate { get; set; } = string.Empty;

        /// <summary>
        ///     Label ID
        /// </summary>
        [JsonProperty("idLabel")]
        public string Label { get; set; } = string.Empty;

        /// <summary>
        ///     Formed Year
        /// </summary>
        [JsonProperty("intFormedYear")]
        public string FormedYear { get; set; } = string.Empty;

        /// <summary>
        ///     Born Year
        /// </summary>
        [JsonProperty("intBornYear")]
        public string BornYear { get; set; } = string.Empty;

        /// <summary>
        ///     Died Year
        /// </summary>
        [JsonProperty("intDiedYear")]
        public string DiedYear { get; set; } = string.Empty;

        /// <summary>
        ///     Disbanded
        /// </summary>
        [JsonProperty("strDisbanded")]
        public string Disbanded { get; set; } = string.Empty;

        /// <summary>
        ///     Genre
        /// </summary>
        [JsonProperty("strGenre")]
        public string Genre { get; set; } = string.Empty;

        /// <summary>
        ///     Subgenre
        /// </summary>
        [JsonProperty("strSubGenre")]
        public string SubGenre { get; set; } = string.Empty;

        /// <summary>
        ///     Mood
        /// </summary>
        [JsonProperty("strMood")]
        public string Mood { get; set; } = string.Empty;

        /// <summary>
        ///     Website
        /// </summary>
        [JsonProperty("strWebsite")]
        public string Website { get; set; } = string.Empty;

        /// <summary>
        ///     Facebook
        /// </summary>
        [JsonProperty("strFacebook")]
        public string Facebook { get; set; } = string.Empty;

        /// <summary>
        ///     Twitter
        /// </summary>
        [JsonProperty("strTwitter")]
        public string Twitter { get; set; } = string.Empty;

        /// <summary>
        ///     Biography EN
        /// </summary>
        [JsonProperty("strBiographyEN")]
        public string BiographyEn { get; set; } = string.Empty;

        /// <summary>
        ///     Biography DE
        /// </summary>
        [JsonProperty("strBiographyDE")]
        public string BiographyDe { get; set; } = string.Empty;

        /// <summary>
        ///     Biography FR
        /// </summary>
        [JsonProperty("strBiographyFR")]
        public string BiographyFr { get; set; } = string.Empty;

        /// <summary>
        ///     Biography CN
        /// </summary>
        [JsonProperty("strBiographyCN")]
        public string BiographyCn { get; set; } = string.Empty;

        /// <summary>
        ///     Biography IT
        /// </summary>
        [JsonProperty("strBiographyIT")]
        public string BiographyIt { get; set; } = string.Empty;

        /// <summary>
        ///     Biography JP
        /// </summary>
        [JsonProperty("strBiographyJP")]
        public string BiographyJp { get; set; } = string.Empty;

        /// <summary>
        ///     Biography RU
        /// </summary>
        [JsonProperty("strBiographyRU")]
        public string BiographyRu { get; set; } = string.Empty;

        /// <summary>
        ///     Biography ES
        /// </summary>
        [JsonProperty("strBiographyES")]
        public string BiographyEs { get; set; } = string.Empty;

        /// <summary>
        ///     Biography PT
        /// </summary>
        [JsonProperty("strBiographyPT")]
        public string BiographyPt { get; set; } = string.Empty;

        /// <summary>
        ///     Biography SE
        /// </summary>
        [JsonProperty("strBiographySE")]
        public string BiographySe { get; set; } = string.Empty;

        /// <summary>
        ///     Biography NL
        /// </summary>
        [JsonProperty("strBiographyNL")]
        public string BiographyNl { get; set; } = string.Empty;

        /// <summary>
        ///     Biography HU
        /// </summary>
        [JsonProperty("strBiographyHU")]
        public string BiographyHu { get; set; } = string.Empty;

        /// <summary>
        ///     Biography NO
        /// </summary>
        [JsonProperty("strBiographyNO")]
        public string BiographyNo { get; set; } = string.Empty;

        /// <summary>
        ///     Biography IL
        /// </summary>
        [JsonProperty("strBiographyIL")]
        public string BiographyIl { get; set; } = string.Empty;

        /// <summary>
        ///     Biography PL
        /// </summary>
        [JsonProperty("strBiographyPL")]
        public string BiographyPl { get; set; } = string.Empty;

        /// <summary>
        ///     Gender
        /// </summary>
        [JsonProperty("strGender")]
        public string Gender { get; set; } = string.Empty;

        /// <summary>
        ///     Members
        /// </summary>
        [JsonProperty("intMembers")]
        public string Members { get; set; } = string.Empty;

        /// <summary>
        ///     Country
        /// </summary>
        [JsonProperty("strCountry")]
        public string Country { get; set; } = string.Empty;

        /// <summary>
        ///     Country Code
        /// </summary>
        [JsonProperty("strCountryCode")]
        public string Countrycode { get; set; } = string.Empty;

        /// <summary>
        ///     Artist Thumb
        /// </summary>
        [JsonProperty("strArtistThumb")]
        public string ArtistThumb { get; set; } = string.Empty;

        /// <summary>
        ///     Artist Logo
        /// </summary>
        [JsonProperty("strArtistLogo")]
        public string ArtistLogo { get; set; } = string.Empty;

        /// <summary>
        ///     Artist Fanart
        /// </summary>
        [JsonProperty("strArtistFanart")]
        public string ArtistFanart1 { get; set; } = string.Empty;

        /// <summary>
        ///     Artist Fanart 2
        /// </summary>
        [JsonProperty("strArtistFanart2")]
        public string ArtistFanart2 { get; set; } = string.Empty;

        /// <summary>
        ///     Artist Fanart 3
        /// </summary>
        [JsonProperty("strArtistFanart3")]
        public string ArtistFanart3 { get; set; } = string.Empty;

        /// <summary>
        ///     Artist Banner
        /// </summary>
        [JsonProperty("strArtistBanner")]
        public string ArtistBanner { get; set; } = string.Empty;

        /// <summary>
        ///     MusicBrainzID
        /// </summary>
        [JsonProperty("strMusicBrainzID")]
        public string MusicBrainzId { get; set; } = string.Empty;

        /// <summary>
        ///     LastFM Chart
        /// </summary>
        [JsonProperty("strLastFMChart")]
        public string LastFmChart { get; set; } = string.Empty;

        /// <summary>
        ///     Locked
        /// </summary>
        [JsonProperty("strLocked")]
        public string Locked { get; set; } = string.Empty;
    }
}