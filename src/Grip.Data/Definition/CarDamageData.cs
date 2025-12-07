using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Car damage data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct CarDamageData
{
    /// <summary>
    /// Tyre wear (percentage)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public float[] TyresWear;

    /// <summary>
    /// Tyre damage (percentage)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] TyresDamage;

    /// <summary>
    /// Brakes damage (percentage)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] BrakesDamage;

    /// <summary>
    /// Front left wing damage (percentage)
    /// </summary>
    public byte FrontLeftWingDamage;

    /// <summary>
    /// Front right wing damage (percentage)
    /// </summary>
    public byte FrontRightWingDamage;

    /// <summary>
    /// Rear wing damage (percentage)
    /// </summary>
    public byte RearWingDamage;

    /// <summary>
    /// Floor damage (percentage)
    /// </summary>
    public byte FloorDamage;

    /// <summary>
    /// Diffuser damage (percentage)
    /// </summary>
    public byte DiffuserDamage;

    /// <summary>
    /// Sidepod damage (percentage)
    /// </summary>
    public byte SidepodDamage;

    /// <summary>
    /// Indicator for DRS fault, 0 = OK, 1 = fault
    /// </summary>
    public byte DrsFault;

    /// <summary>
    /// Indicator for ERS fault, 0 = OK, 1 = fault
    /// </summary>
    public byte ErsFault;

    /// <summary>
    /// Gear box damage (percentage)
    /// </summary>
    public byte GearBoxDamage;

    /// <summary>
    /// Engine damage (percentage)
    /// </summary>
    public byte EngineDamage;

    /// <summary>
    /// Engine wear MGU-H (percentage)
    /// </summary>
    public byte EngineMguhWear;

    /// <summary>
    /// Engine wear ES (percentage)
    /// </summary>
    public byte EngineEsWear;

    /// <summary>
    /// Engine wear CE (percentage)
    /// </summary>
    public byte EngineCeWear;

    /// <summary>
    /// Engine wear ICE (percentage)
    /// </summary>
    public byte EngineIceWear;

    /// <summary>
    /// Engine wear MGU-K (percentage)
    /// </summary>
    public byte EngineMgukWear;

    /// <summary>
    /// Engine wear TC (percentage)
    /// </summary>
    public byte EngineTcWear;

    /// <summary>
    /// Engine blown, 0 = OK, 1 = fault
    /// </summary>
    public byte EngineBlown;

    /// <summary>
    /// Engine seized, 0 = OK, 1 = fault
    /// </summary>
    public byte EngineSeized;
}
