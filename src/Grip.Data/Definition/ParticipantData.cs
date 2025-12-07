using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Participant data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
public struct ParticipantData
{
    /// <summary>
    /// Whether the vehicle is AI (1) or Human (0) controlled
    /// </summary>
    public byte AiControlled;

    /// <summary>
    /// Driver id - see appendix, 255 if network human
    /// </summary>
    public byte DriverId;

    /// <summary>
    /// Network id – unique identifier for network players
    /// </summary>
    public byte NetworkId;

    /// <summary>
    /// Team id - see appendix
    /// </summary>
    public byte TeamId;

    /// <summary>
    /// My team flag – 1 = My Team, 0 = otherwise
    /// </summary>
    public byte MyTeam;

    /// <summary>
    /// Race number of the car
    /// </summary>
    public byte RaceNumber;

    /// <summary>
    /// Nationality of the driver
    /// </summary>
    public byte Nationality;

    /// <summary>
    /// Name of participant in UTF-8 format – null terminated
    /// Will be truncated with … (U+2026) if too long
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
    public string Name;

    /// <summary>
    /// The player's UDP setting, 0 = restricted, 1 = public
    /// </summary>
    public byte YourTelemetry;

    /// <summary>
    /// The player's show online names setting, 0 = off, 1 = on
    /// </summary>
    public byte ShowOnlineNames;

    /// <summary>
    /// F1 World tech level
    /// </summary>
    public ushort TechLevel;

    /// <summary>
    /// 1 = Steam, 3 = PlayStation, 4 = Xbox, 6 = Origin, 255 = unknown
    /// </summary>
    public byte Platform;
}