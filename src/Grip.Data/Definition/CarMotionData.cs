namespace Grip.Data.Definition;

public sealed class CarMotionData
{
    /// <summary>
    /// World space X position - metres
    /// </summary>
    public float WorldPositionX { get; set; }

    /// <summary>
    /// World space Y position
    /// </summary>
    public float WorldPositionY { get; set; }

    /// <summary>
    /// World space Z position
    /// </summary>
    public float WorldPositionZ { get; set; }

    /// <summary>
    /// Velocity in world space X – metres/s
    /// </summary>
    public float WorldVelocityX { get; set; }

    /// <summary>
    /// Velocity in world space Y
    /// </summary>
    public float WorldVelocityY { get; set; }

    /// <summary>
    /// Velocity in world space Z
    /// </summary>
    public float WorldVelocityZ { get; set; }

    /// <summary>
    /// World space forward X direction (normalised)
    /// </summary>
    public short WorldForwardDirX { get; set; }

    /// <summary>
    /// World space forward Y direction (normalised)
    /// </summary>
    public short WorldForwardDirY { get; set; }
    public short WorldForwardDirZ; // World space forward Z direction (normalised)
    public short WorldRightDirX; // World space right X direction (normalised)
    public short WorldRightDirY; // World space right Y direction (normalised)
    public short WorldRightDirZ; // World space right Z direction (normalised)
    public float GForceLateral; // Lateral G-Force component
    public float GForceLongitudinal; // Longitudinal G-Force component
    public float GForceVertical; // Vertical G-Force component
    public float Yaw; // Yaw angle in radians
    public float Pitch; // Pitch angle in radians
    public float Roll; // Roll angle in radians
};