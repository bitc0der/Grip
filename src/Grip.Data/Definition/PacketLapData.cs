using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Lap data packet
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketLapData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Lap data for all cars on track
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
    public LapData[] LapData;

    /// <summary>
    /// Index of Personal Best car in time trial (255 if invalid)
    /// </summary>
    public byte TimeTrialPBCarIdx;

    /// <summary>
    /// Index of Rival car in time trial (255 if invalid)
    /// </summary>
    public byte TimeTrialRivalCarIdx;
}