using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// For the normalised vectors below, to convert to float values divide by 32767.0f – 16-bit signed values are used to pack the data and on the assumption that direction values are always between -1.0f and 1.0f.
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct CarMotionData
{
    /// <summary>
    /// World space X position - metres
    /// </summary>
    public float WorldPositionX;

    /// <summary>
    /// World space Y position
    /// </summary>
    public float WorldPositionY;

    /// <summary>
    /// World space Z position
    /// </summary>
    public float WorldPositionZ;

    /// <summary>
    /// Velocity in world space X – metres/s
    /// </summary>
    public float WorldVelocityX;

    /// <summary>
    /// Velocity in world space Y
    /// </summary>
    public float WorldVelocityY;

    /// <summary>
    /// Velocity in world space Z
    /// </summary>
    public float WorldVelocityZ;

    /// <summary>
    /// World space forward X direction (normalised)
    /// </summary>
    public short WorldForwardDirX;

    /// <summary>
    /// World space forward Y direction (normalised)
    /// </summary>
    public short WorldForwardDirY;

    /// <summary>
    /// World space forward Z direction (normalised)
    /// </summary>
    public short WorldForwardDirZ;

    /// <summary>
    /// World space right X direction (normalised)
    /// </summary>
    public short WorldRightDirX;

    /// <summary>
    /// World space right Y direction (normalised)
    /// </summary>
    public short WorldRightDirY;

    /// <summary>
    /// World space right Z direction (normalised)
    /// </summary>
    public short WorldRightDirZ;

    /// <summary>
    /// Lateral G-Force component
    /// </summary>
    public float GForceLateral;

    /// <summary>
    /// Longitudinal G-Force component
    /// </summary>
    public float GForceLongitudinal;

    /// <summary>
    /// Vertical G-Force component
    /// </summary>
    public float GForceVertical;

    /// <summary>
    /// Yaw angle in radians
    /// </summary>
    public float Yaw;

    /// <summary>
    /// Pitch angle in radians
    /// </summary>
    public float Pitch;

    /// <summary>
    /// Roll angle in radians
    /// </summary>
    public float Roll;
}