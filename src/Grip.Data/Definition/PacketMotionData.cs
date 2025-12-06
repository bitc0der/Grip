namespace Grip.Data.Definition;

public sealed class PacketMotionData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header { get; init; }

    /// <summary>
    /// Data for all cars on track (22)
    /// </summary>
    public CarMotionData[] CarMotionData { get; init; }
}