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

using System;
using TheAudioDB.Events;

namespace TheAudioDB.Helper
{
    /// <summary>
    ///     Json Functions
    /// </summary>
    internal class Json
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     Deserialize a json string as Object
        /// </summary>
        /// <typeparam name="T">Objecttype</typeparam>
        /// <param name="json">Jsonstring</param>
        /// <returns></returns>
        public static T Deserialize<T>(string json)
        {
            try
            {
                var settings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
                return JsonConvert.DeserializeObject<T>(json, settings);
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
                return (T) Activator.CreateInstance(typeof (T));
            }
        }
    }
}