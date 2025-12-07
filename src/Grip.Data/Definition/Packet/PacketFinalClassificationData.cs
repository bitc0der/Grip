using System.Runtime.InteropServices;

namespace Grip.Data.Definition.Packet;

/// <summary>
/// This packet details the final classification at the end of the race, and the data will match with the post race results screen. This is especially useful for multiplayer games where it is not always possible to send lap times on the final frame because of network delay.
///
/// Frequency: Once at the end of a race
/// Size: 1020 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketFinalClassificationData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Number of cars in the final classification
    /// </summary>
    public byte NumCars;

    /// <summary>
    /// Classification data for all cars
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
    public FinalClassificationData[] ClassificationData;
}