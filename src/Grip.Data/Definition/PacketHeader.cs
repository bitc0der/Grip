using System.Runtime.InteropServices;

/// <summary>
/// Заголовок пакета данных
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketHeader
{
    /// <summary>
    /// 2024
    /// </summary>
    public ushort PacketFormat { get; set; }

    /// <summary>
    /// Game year - last two digits e.g. 24
    /// </summary>
    public byte GameYear { get; set; }

    /// <summary>
    /// Game major version - "X.00"
    /// </summary>
    public byte GameMajorVersion { get; set; }

    /// <summary>
    /// Game minor version - "1.XX"
    /// </summary>
    public byte GameMinorVersion { get; set; }

    /// <summary>
    /// Version of this packet type, all start from 1
    /// </summary>
    public byte PacketVersion { get; set; }

    /// <summary>
    /// Identifier for the packet type, see below
    /// </summary>
    public byte PacketId { get; set; }

    /// <summary>
    /// Unique identifier for the session
    /// </summary>
    public ulong SessionUid { get; set; }

    /// <summary>
    /// Session timestamp
    /// </summary>
    public float SessionTime { get; set; }

    /// <summary>
    /// Identifier for the frame the data was retrieved on
    /// </summary>
    public uint FrameIdentifier { get; set; }

    /// <summary>
    /// Overall identifier for the frame the data was retrieved
    /// on, doesn't go back after flashbacks
    /// </summary>
    public uint OverallFrameIdentifier { get; set; }

    /// <summary>
    /// Index of player's car in the array
    /// </summary>
    public byte PlayerCarIndex { get; set; }

    /// <summary>
    /// Index of secondary player's car in the array (splitscreen)
    /// 255 if no second player
    /// </summary>
    public byte SecondaryPlayerCarIndex { get; set; }
}