using System.Runtime.InteropServices;

namespace Grip.Data.Definition.Packet;

/// <summary>
/// This packet contains lap times and tyre usage for the session. This packet works slightly differently to other packets. To reduce CPU and bandwidth, each packet relates to a specific vehicle and is sent every 1/20 s, and the vehicle being sent is cycled through. Therefore in a 20 car race you should receive an update for each vehicle at least once per second.
///
/// Note that at the end of the race, after the final classification packet has been sent, a final bulk update of all the session histories for the vehicles in that session will be sent.
///
/// Frequency: 20 per second but cycling through cars
/// Size: 1460 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketSessionHistoryData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Index of the car this lap data relates to
    /// </summary>
    public byte CarIdx;

    /// <summary>
    /// Num laps in the data (including current partial lap)
    /// </summary>
    public byte NumLaps;

    /// <summary>
    /// Number of tyre stints in the data
    /// </summary>
    public byte NumTyreStints;

    /// <summary>
    /// Lap the best lap time was achieved on
    /// </summary>
    public byte BestLapTimeLapNum;

    /// <summary>
    /// Lap the best Sector 1 time was achieved on
    /// </summary>
    public byte BestSector1LapNum;

    /// <summary>
    /// Lap the best Sector 2 time was achieved on
    /// </summary>
    public byte BestSector2LapNum;

    /// <summary>
    /// Lap the best Sector 3 time was achieved on
    /// </summary>
    public byte BestSector3LapNum;

    /// <summary>
    /// 100 laps of data max
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
    public LapHistoryData[] LapHistoryData;

    /// <summary>
    /// Tyre stint history data
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public TyreStintHistoryData[] TyreStintsHistoryData;
}