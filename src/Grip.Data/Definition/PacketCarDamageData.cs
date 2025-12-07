using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// This packet details car damage parameters for all the cars in the race.
///
/// Frequency: 10 per second
/// Size: 953 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketCarDamageData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Car damage data for all cars
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
    public CarDamageData[] CarDamageData;
}