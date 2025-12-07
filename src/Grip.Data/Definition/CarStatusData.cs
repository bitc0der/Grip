using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Car status data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct CarStatusData
{
    /// <summary>
    /// Traction control - 0 = off, 1 = medium, 2 = full
    /// </summary>
    public byte TractionControl;

    /// <summary>
    /// 0 (off) - 1 (on)
    /// </summary>
    public byte AntiLockBrakes;

    /// <summary>
    /// Fuel mix - 0 = lean, 1 = standard, 2 = rich, 3 = max
    /// </summary>
    public byte FuelMix;

    /// <summary>
    /// Front brake bias (percentage)
    /// </summary>
    public byte FrontBrakeBias;

    /// <summary>
    /// Pit limiter status - 0 = off, 1 = on
    /// </summary>
    public byte PitLimiterStatus;

    /// <summary>
    /// Current fuel mass
    /// </summary>
    public float FuelInTank;

    /// <summary>
    /// Fuel capacity
    /// </summary>
    public float FuelCapacity;

    /// <summary>
    /// Fuel remaining in terms of laps (value on MFD)
    /// </summary>
    public float FuelRemainingLaps;

    /// <summary>
    /// Cars max RPM, point of rev limiter
    /// </summary>
    public ushort MaxRpm;

    /// <summary>
    /// Cars idle RPM
    /// </summary>
    public ushort IdleRpm;

    /// <summary>
    /// Maximum number of gears
    /// </summary>
    public byte MaxGears;

    /// <summary>
    /// 0 = not allowed, 1 = allowed
    /// </summary>
    public byte DrsAllowed;

    /// <summary>
    /// 0 = DRS not available, non-zero - DRS will be available in [X] metres
    /// </summary>
    public ushort DrsActivationDistance;

    /// <summary>
    /// F1 Modern - 16 = C5, 17 = C4, 18 = C3, 19 = C2, 20 = C1
    /// 21 = C0, 7 = inter, 8 = wet
    /// F1 Classic - 9 = dry, 10 = wet
    /// F2 – 11 = super soft, 12 = soft, 13 = medium, 14 = hard
    /// 15 = wet
    /// </summary>
    public byte ActualTyreCompound;

    /// <summary>
    /// F1 visual (can be different from actual compound)
    /// 16 = soft, 17 = medium, 18 = hard, 7 = inter, 8 = wet
    /// F1 Classic – same as above
    /// F2 ‘19, 15 = wet, 19 – super soft, 20 = soft
    /// 21 = medium , 22 = hard
    /// </summary>
    public byte VisualTyreCompound;

    /// <summary>
    /// Age in laps of the current set of tyres
    /// </summary>
    public byte TyresAgeLaps;

    /// <summary>
    /// -1 = invalid/unknown, 0 = none, 1 = green
    /// 2 = blue, 3 = yellow
    /// </summary>
    public sbyte VehicleFiaFlags;

    /// <summary>
    /// Engine power output of ICE (W)
    /// </summary>
    public float EnginePowerIce;

    /// <summary>
    /// Engine power output of MGU-K (W)
    /// </summary>
    public float EnginePowerMguk;

    /// <summary>
    /// ERS energy store in Joules
    /// </summary>
    public float ErsStoreEnergy;

    /// <summary>
    /// ERS deployment mode, 0 = none, 1 = medium
    /// 2 = hotlap, 3 = overtake
    /// </summary>
    public byte ErsDeployMode;

    /// <summary>
    /// ERS energy harvested this lap by MGU-K
    /// </summary>
    public float ErsHarvestedThisLapMguk;

    /// <summary>
    /// ERS energy harvested this lap by MGU-H
    /// </summary>
    public float ErsHarvestedThisLapMguh;

    /// <summary>
    /// ERS energy deployed this lap
    /// </summary>
    public float ErsDeployedThisLap;

    /// <summary>
    /// Whether the car is paused in a network game
    /// </summary>
    public byte NetworkPaused;
}