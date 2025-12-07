using System.Runtime.InteropServices;

namespace Grip.Data.Definition.Packet;

/// <summary>
/// The motion packet gives physics data for all the cars being driven.
/// 
/// Frequency: Rate as specified in menus
/// Size: 1349 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketMotionData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Data for all cars on track
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
    public CarMotionData[] CarMotionData;
}