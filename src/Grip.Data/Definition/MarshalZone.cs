namespace Grip.Data.Definition;

public struct MarshalZone
{
    /// <summary>
    /// Fraction (0..1) of way through the lap the marshal zone starts
    /// </summary>
    public float ZoneStart { get; init; }

    /// <summary>
    /// -1 = invalid/unknown, 0 = none, 1 = green, 2 = blue, 3 = yellow
    /// </summary>
    public sbyte ZoneFlag { get; set; }
}