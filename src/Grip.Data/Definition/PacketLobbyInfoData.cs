using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// This packet details the players currently in a multiplayer lobby. It details each player’s selected car, any AI involved in the game and also the ready status of each of the participants.
///
/// Frequency: Two every second when in the lobby
/// Size: 1306 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketLobbyInfoData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Number of players in the lobby data
    /// </summary>
    public byte NumPlayers;

    /// <summary>
    /// Lobby players data
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
    public LobbyInfoData[] LobbyPlayers;
}