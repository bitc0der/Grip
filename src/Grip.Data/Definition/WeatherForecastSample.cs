namespace Grip.Data.Definition;

public sealed class WeatherForecastSample
{
    /// <summary>
    /// 0 = unknown, see appendix
    /// </summary>
    public byte SessionType { get; init; }

    /// <summary>
    /// Time in minutes the forecast is for
    /// </summary>
    public byte TimeOffset { get; init; }

    /// <summary>
    /// Weather - 0 = clear, 1 = light cloud, 2 = overcast, 3 = light rain, 4 = heavy rain, 5 = storm
    /// </summary>
    public byte Weather { get; set; }

    /// <summary>
    /// Track temp. in degrees Celsius
    /// </summary>
    public sbyte TrackTemperature { get; set; }

    /// <summary>
    /// Track temp. change – 0 = up, 1 = down, 2 = no change
    /// </summary>
    public sbyte TrackTemperatureChange { get; set; }

    /// <summary>
    /// Air temp. in degrees celsius
    /// </summary>
    public sbyte AirTemperature { get; init; }

    /// <summary>
    /// Air temp. change – 0 = up, 1 = down, 2 = no change
    /// </summary>
    public sbyte AirTemperatureChange { get; init; }

    /// <summary>
    /// Rain percentage (0-100)
    /// </summary>
    public sbyte RainPercentage { get; set; }
}