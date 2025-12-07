using System.Runtime.InteropServices;

namespace Grip.Data.Definition.Packet;

/// <summary>
/// Заголовок пакета данных
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketHeader
{
    /// <summary>
    /// 2024
    /// </summary>
    public ushort PacketFormat;

    /// <summary>
    /// Game year - last two digits e.g. 24
    /// </summary>
    public byte GameYear;

    /// <summary>
    /// Game major version - "X.00"
    /// </summary>
    public byte GameMajorVersion;

    /// <summary>
    /// Game minor version - "1.XX"
    /// </summary>
    public byte GameMinorVersion;

    /// <summary>
    /// Version of this packet type, all start from 1
    /// </summary>
    public byte PacketVersion;

    /// <summary>
    /// Identifier for the packet type, see below
    /// </summary>
    public PacketId PacketId;

    /// <summary>
    /// Unique identifier for the session
    /// </summary>
    public ulong SessionUid;

    /// <summary>
    /// Session timestamp
    /// </summary>
    public float SessionTime;

    /// <summary>
    /// Identifier for the frame the data was retrieved on
    /// </summary>
    public uint FrameIdentifier;

    /// <summary>
    /// Overall identifier for the frame the data was retrieved
    /// on, doesn't go back after flashbacks
    /// </summary>
    public uint OverallFrameIdentifier;

    /// <summary>
    /// Index of player's car in the array
    /// </summary>
    public byte PlayerCarIndex;

    /// <summary>
    /// Index of secondary player's car in the array (splitscreen)
    /// 255 if no second player
    /// </summary>
    public byte SecondaryPlayerCarIndex;
}