namespace SampleAPIKeyAuthentication
{
    public class WeatherDetailModel
    {
        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Temperature in C
        /// </summary>
        public int TemperatureInC { get; set; }
        /// <summary>
        /// Temperature in F
        /// </summary>
        public int TemperatureInF => 32 + (int)(TemperatureInC / 0.5556);
        /// <summary>
        /// Summary
        /// </summary>
        public string? Summary { get; set; }
    }
}
