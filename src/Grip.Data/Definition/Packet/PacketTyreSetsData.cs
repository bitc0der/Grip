using System.Runtime.InteropServices;

namespace Grip.Data.Definition.Packet;

/// <summary>
/// This packets gives a more in-depth details about tyre sets assigned to a vehicle during the session.
///
/// Frequency: 20 per second but cycling through cars
/// Size: 231 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketTyreSetsData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Index of the car this data relates to
    /// </summary>
    public byte CarIdx;

    /// <summary>
    /// 13 (dry) + 7 (wet)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public TyreSetData[] TyreSetData;

    /// <summary>
    /// Index into array of fitted tyre
    /// </summary>
    public byte FittedIdx;
}