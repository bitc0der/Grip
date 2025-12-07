using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// This packet details car statuses for all the cars in the race.
///
/// Frequency: Rate as specified in menus
/// Size: 1239 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketCarStatusData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Car status data for all cars
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
    public CarStatusData[] CarStatusData;
}