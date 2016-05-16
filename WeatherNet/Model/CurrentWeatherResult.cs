using System;
using WeatherNet.Model;

namespace WeatherNet.Model
{
    /// <summary>
    ///     CurrentWeatherResult weather result type.
    /// </summary>
    public class CurrentWeatherResult : WeatherResult
    {
        /// <summary>
        ///     Time of SunSet in unixtime GMT.
        /// </summary>
        public DateTime SunSet { get; set; }

        /// <summary>
        ///     Time of SunRise in unixtime GMT.
        /// </summary>
        public DateTime SunRise { get; set; }
    }
}