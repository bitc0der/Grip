using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Lap history data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct LapHistoryData
{
    /// <summary>
    /// Lap time in milliseconds
    /// </summary>
    public uint LapTimeInMs;
    
    /// <summary>
    /// Sector 1 milliseconds part
    /// </summary>
    public ushort Sector1TimeMsPart;
    
    /// <summary>
    /// Sector 1 whole minute part
    /// </summary>
    public byte Sector1TimeMinutesPart;
    
    /// <summary>
    /// Sector 2 time milliseconds part
    /// </summary>
    public ushort Sector2TimeMsPart;
    
    /// <summary>
    /// Sector 2 whole minute part
    /// </summary>
    public byte Sector2TimeMinutesPart;
    
    /// <summary>
    /// Sector 3 time milliseconds part
    /// </summary>
    public ushort Sector3TimeMsPart;
    
    /// <summary>
    /// Sector 3 whole minute part
    /// </summary>
    public byte Sector3TimeMinutesPart;
    
    /// <summary>
    /// 0x01 bit set-lap valid,      0x02 bit set-sector 1 valid
    /// 0x04 bit set-sector 2 valid, 0x08 bit set-sector 3 valid
    /// </summary>
    public byte LapValidBitFlags;
}