using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Event data packet
///
/// This packet gives details of events that happen during the course of a session.
///
/// Frequency: When the event occurs
/// Size: 45 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketEventData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Event string code, see <see cref="EventCodes"/>
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] EventStringCode;

    /// <summary>
    /// Event details - should be interpreted differently for each type
    /// </summary>
    public EventDataDetails EventDetails;
}