using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// The time trial data gives extra information only relevant to time trial game mode. This packet will not be sent in other game modes. 
///
/// Frequency: 1 per second
/// Size: 101 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketTimeTrialData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Player session best data set
    /// </summary>
    public TimeTrialDataSet PlayerSessionBestDataSet;

    /// <summary>
    /// Personal best data set
    /// </summary>
    public TimeTrialDataSet PersonalBestDataSet;

    /// <summary>
    /// Rival data set
    /// </summary>
    public TimeTrialDataSet RivalDataSet;
}