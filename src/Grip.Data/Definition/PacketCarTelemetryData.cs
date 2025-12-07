using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// This packet details telemetry for all the cars in the race. It details various values that would be recorded on the car such as speed, throttle application, DRS etc. Note that the rev light configurations are presented separately as well and will mimic real life driver preferences.
///
/// Frequency: Rate as specified in menus
/// Size: 1352 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketCarTelemetryData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Car telemetry data for all cars
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
    public CarTelemetryData[] CarTelemetryData;

    /// <summary>
    /// Index of MFD panel open - 255 = MFD closed
    /// Single player, race – 0 = Car setup, 1 = Pits
    /// 2 = Damage, 3 =  Engine, 4 = Temperatures
    /// May vary depending on game mode
    /// </summary>
    public byte MfdPanelIndex;

    /// <summary>
    /// See above
    /// </summary>
    public byte MfdPanelIndexSecondaryPlayer;

    /// <summary>
    /// Suggested gear for the player (1-8)
    /// 0 if no gear suggested
    /// </summary>
    public sbyte SuggestedGear;
}