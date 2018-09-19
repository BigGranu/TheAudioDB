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
    ///     DiscographyList
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class DiscographyList
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     Create new DiscographyList
        /// </summary>
        public DiscographyList()
        {
        }

        /// <summary>
        ///     Create new DiscographyList with Result
        /// </summary>
        /// <param name="data">Result</param>
        public DiscographyList(DiscographyListResult data)
        {
            Data = data;
        }

        /// <summary>
        ///     All possible Data
        /// </summary>
        public DiscographyListResult Data { get; set; }

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
    ///     List of Discogrphy
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class DiscographyListResult
    {
        /// <summary>
        ///     List of Discogrphy
        /// </summary>
        [JsonProperty("album")]
        public List<Discography> List { get; set; } = new List<Discography>();
    }

    /// <summary>
    ///     Data for a Discogrphy
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    
    public class Discography
    {
        /// <summary>
        ///     Album
        /// </summary>
        [JsonProperty("strAlbum")]
        public string StrAlbum { get; set; } = string.Empty;

        /// <summary>
        ///     Year of Release
        /// </summary>
        [JsonProperty("intYearReleased")]
        public int? IntYearReleased { get; set; }
    }
}