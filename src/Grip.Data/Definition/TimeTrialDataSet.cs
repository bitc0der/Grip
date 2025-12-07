using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Time trial data set
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct TimeTrialDataSet
{
    /// <summary>
    /// Index of the car this data relates to
    /// </summary>
    public byte CarIdx;

    /// <summary>
    /// Team id - see appendix
    /// </summary>
    public byte TeamId;

    /// <summary>
    /// Lap time in milliseconds
    /// </summary>
    public uint LapTimeInMs;

    /// <summary>
    /// Sector 1 time in milliseconds
    /// </summary>
    public uint Sector1TimeInMs;

    /// <summary>
    /// Sector 2 time in milliseconds
    /// </summary>
    public uint Sector2TimeInMs;

    /// <summary>
    /// Sector 3 time in milliseconds
    /// </summary>
    public uint Sector3TimeInMs;

    /// <summary>
    /// 0 = off, 1 = medium, 2 = full
    /// </summary>
    public byte TractionControl;

    /// <summary>
    /// 1 = manual, 2 = manual & suggested gear, 3 = auto
    /// </summary>
    public byte GearboxAssist;

    /// <summary>
    /// 0 (off) - 1 (on)
    /// </summary>
    public byte AntiLockBrakes;

    /// <summary>
    /// 0 = Realistic, 1 = Equal
    /// </summary>
    public byte EqualCarPerformance;

    /// <summary>
    /// 0 = No, 1 = Yes
    /// </summary>
    public byte CustomSetup;

    /// <summary>
    /// 0 = invalid, 1 = valid
    /// </summary>
    public byte Valid;
}