using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Final classification data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct FinalClassificationData
{
    /// <summary>
    /// Finishing position
    /// </summary>
    public byte Position;

    /// <summary>
    /// Number of laps completed
    /// </summary>
    public byte NumLaps;

    /// <summary>
    /// Grid position of the car
    /// </summary>
    public byte GridPosition;

    /// <summary>
    /// Number of points scored
    /// </summary>
    public byte Points;

    /// <summary>
    /// Number of pit stops made
    /// </summary>
    public byte NumPitStops;

    /// <summary>
    /// Result status - 0 = invalid, 1 = inactive, 2 = active
    /// 3 = finished, 4 = didnotfinish, 5 = disqualified
    /// 6 = not classified, 7 = retired
    /// </summary>
    public byte ResultStatus;

    /// <summary>
    /// Best lap time of the session in milliseconds
    /// </summary>
    public uint BestLapTimeInMs;

    /// <summary>
    /// Total race time in seconds without penalties
    /// </summary>
    public double TotalRaceTime;

    /// <summary>
    /// Total penalties accumulated in seconds
    /// </summary>
    public byte PenaltiesTime;

    /// <summary>
    /// Number of penalties applied to this driver
    /// </summary>
    public byte NumPenalties;

    /// <summary>
    /// Number of tyres stints up to maximum
    /// </summary>
    public byte NumTyreStints;

    /// <summary>
    /// Actual tyres used by this driver
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] TyreStintsActual;

    /// <summary>
    /// Visual tyres used by this driver
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] TyreStintsVisual;

    /// <summary>
    /// The lap number stints end on
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] TyreStintsEndLaps;
}