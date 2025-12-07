using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Tyre stint history data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct TyreStintHistoryData
{
    /// <summary>
    /// Lap the tyre usage ends on (255 of current tyre)
    /// </summary>
    public byte EndLap;

    /// <summary>
    /// Actual tyres used by this driver
    /// </summary>
    public byte TyreActualCompound;

    /// <summary>
    /// Visual tyres used by this driver
    /// </summary>
    public byte TyreVisualCompound;
}