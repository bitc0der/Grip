using System.Runtime.InteropServices;

namespace Grip.Data.Definition.Packet;

/// <summary>
/// This packet details the car setups for each vehicle in the session. Note that in multiplayer games, other player cars will appear as blank, you will only be able to see your own car setup, regardless of the “Your Telemetry” setting. Spectators will also not be able to see any car setups.
///
/// Frequency: 2 per second
/// Size: 1133 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketCarSetupData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Car setup data for all cars
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
    public CarSetupData[] CarSetups;

    /// <summary>
    /// Value of front wing after next pit stop - player only
    /// </summary>
    public float NextFrontWingValue;
}