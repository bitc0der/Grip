namespace Grip.Data.Definition;

public sealed class PacketHeader
{
    /// <summary>
    /// 2024
    /// </summary>
    public ushort PacketFormat { get; init; }

    /// <summary>
    /// Game year - last two digits e.g. 24
    /// </summary>
    public byte GameYear { get; init; }

    /// <summary>
    /// Game major version - "X.00"
    /// </summary>
    public byte GameMajorVersion { get; init; }

    /// <summary>
    /// Game minor version - "1.XX"
    /// </summary>
    public byte GameMinorVersion { get; init; }

    /// <summary>
    /// Version of this packet type, all start from 1
    /// </summary>
    public byte PacketVersion { get; init; }

    /// <summary>
    /// Identifier for the packet type, see below
    /// </summary>
    public byte PacketId { get; init; }

    /// <summary>
    /// Unique identifier for the session
    /// </summary>
    public ulong SessionUid { get; init; }

    /// <summary>
    /// Session timestamp
    /// </summary>
    public float SessionTime { get; init; }

    /// <summary>
    /// Identifier for the frame the data was retrieved on
    /// </summary>
    public uint FrameIdentifier { get; init; }

    /// <summary>
    /// Overall identifier for the frame the data was retrieved
    /// on, doesn't go back after flashbacks
    /// </summary>
    public uint OverallFrameIdentifier { get; init; }

    /// <summary>
    /// Index of player's car in the array
    /// </summary>
    public byte PlayerCarIndex { get; init; }

    /// <summary>
    /// Index of secondary player's car in the array (splitscreen)
    /// 255 if no second player
    /// </summary>
    public byte SecondaryPlayerCarIndex { get; init; }
};