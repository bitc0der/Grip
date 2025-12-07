using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// This is a list of participants in the race. If the vehicle is controlled by AI, then the name will be the driver name. If this is a multiplayer game, the names will be the Steam Id on PC, or the LAN name if appropriate.
/// N.B. on Xbox One, the names will always be the driver name, on PS4 the name will be the LAN name if playing a LAN game, otherwise it will be the driver name. 
/// The array should be indexed by vehicle index.
///
/// Frequency: Every 5 seconds
/// Size: 1350 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketParticipantsData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Number of active cars in the data – should match number of cars on HUD
    /// </summary>
    public byte NumActiveCars;

    /// <summary>
    /// Participants data for all cars
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
    public ParticipantData[] Participants;
}