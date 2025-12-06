using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Weather forecast sample
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct WeatherForecastSample
{
    /// <summary>
    /// 0 = unknown, see appendix
    /// </summary>
    public byte SessionType;
    
    /// <summary>
    /// Time in minutes the forecast is for
    /// </summary>
    public byte TimeOffset;
    
    /// <summary>
    /// Weather - 0 = clear, 1 = light cloud, 2 = overcast
    /// 3 = light rain, 4 = heavy rain, 5 = storm
    /// </summary>
    public byte Weather;
    
    /// <summary>
    /// Track temp. in degrees Celsius
    /// </summary>
    public sbyte TrackTemperature;
    
    /// <summary>
    /// Track temp. change – 0 = up, 1 = down, 2 = no change
    /// </summary>
    public sbyte TrackTemperatureChange;
    
    /// <summary>
    /// Air temp. in degrees celsius
    /// </summary>
    public sbyte AirTemperature;
    
    /// <summary>
    /// Air temp. change – 0 = up, 1 = down, 2 = no change
    /// </summary>
    public sbyte AirTemperatureChange;
    
    /// <summary>
    /// Rain percentage (0-100)
    /// </summary>
    public byte RainPercentage;
}