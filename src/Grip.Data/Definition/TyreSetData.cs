using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Tyre set data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct TyreSetData
{
    /// <summary>
    /// Actual tyre compound used
    /// </summary>
    public byte ActualTyreCompound;
    
    /// <summary>
    /// Visual tyre compound used
    /// </summary>
    public byte VisualTyreCompound;
    
    /// <summary>
    /// Tyre wear (percentage)
    /// </summary>
    public byte Wear;
    
    /// <summary>
    /// Whether this set is currently available
    /// </summary>
    public byte Available;
    
    /// <summary>
    /// Recommended session for tyre set, see appendix
    /// </summary>
    public byte RecommendedSession;
    
    /// <summary>
    /// Laps left in this tyre set
    /// </summary>
    public byte LifeSpan;
    
    /// <summary>
    /// Max number of laps recommended for this compound
    /// </summary>
    public byte UsableLife;
    
    /// <summary>
    /// Lap delta time in milliseconds compared to fitted set
    /// </summary>
    public short LapDeltaTime;
    
    /// <summary>
    /// Whether the set is fitted or not
    /// </summary>
    public byte Fitted;
}