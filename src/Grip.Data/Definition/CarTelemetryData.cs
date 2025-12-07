using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Car telemetry data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct CarTelemetryData
{
    /// <summary>
    /// Speed of car in kilometres per hour
    /// </summary>
    public ushort Speed;

    /// <summary>
    /// Amount of throttle applied (0.0 to 1.0)
    /// </summary>
    public float Throttle;

    /// <summary>
    /// Steering (-1.0 (full lock left) to 1.0 (full lock right))
    /// </summary>
    public float Steer;

    /// <summary>
    /// Amount of brake applied (0.0 to 1.0)
    /// </summary>
    public float Brake;

    /// <summary>
    /// Amount of clutch applied (0 to 100)
    /// </summary>
    public byte Clutch;

    /// <summary>
    /// Gear selected (1-8, N=0, R=-1)
    /// </summary>
    public sbyte Gear;

    /// <summary>
    /// Engine RPM
    /// </summary>
    public ushort EngineRpm;

    /// <summary>
    /// 0 = off, 1 = on
    /// </summary>
    public byte Drs;

    /// <summary>
    /// Rev lights indicator (percentage)
    /// </summary>
    public byte RevLightsPercent;

    /// <summary>
    /// Rev lights (bit 0 = leftmost LED, bit 14 = rightmost LED)
    /// </summary>
    public ushort RevLightsBitValue;

    /// <summary>
    /// Brakes temperature (celsius)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public ushort[] BrakesTemperature;

    /// <summary>
    /// Tyres surface temperature (celsius)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] TyresSurfaceTemperature;

    /// <summary>
    /// Tyres inner temperature (celsius)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] TyresInnerTemperature;

    /// <summary>
    /// Engine temperature (celsius)
    /// </summary>
    public ushort EngineTemperature;

    /// <summary>
    /// Tyres pressure (PSI)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public float[] TyresPressure;

    /// <summary>
    /// Driving surface, see appendices
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] SurfaceType;
}
