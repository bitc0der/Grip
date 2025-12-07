using System.Runtime.InteropServices;

namespace Grip.Data.Definition.Packet;

/// <summary>
/// The motion packet gives extended data for the car being driven with the goal of being able to drive a motion platform setup.
///
/// Frequency: Rate as specified in menus
/// Size: 237 bytes
/// Version: 1
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketMotionExData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Note: All wheel arrays have the following order:
    /// RL, RR, FL, FR
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public float[] SuspensionPosition;

    /// <summary>
    /// RL, RR, FL, FR
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public float[] SuspensionVelocity;

    /// <summary>
    /// RL, RR, FL, FR
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public float[] SuspensionAcceleration;

    /// <summary>
    /// Speed of each wheel
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public float[] WheelSpeed;

    /// <summary>
    /// Slip ratio for each wheel
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public float[] WheelSlipRatio;

    /// <summary>
    /// Slip angles for each wheel
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public float[] WheelSlipAngle;

    /// <summary>
    /// Lateral forces for each wheel
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public float[] WheelLatForce;

    /// <summary>
    /// Longitudinal forces for each wheel
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public float[] WheelLongForce;

    /// <summary>
    /// Height of centre of gravity above ground
    /// </summary>
    public float HeightOfCogAboveGround;

    /// <summary>
    /// Velocity in local space – metres/s
    /// </summary>
    public float LocalVelocityX;

    /// <summary>
    /// Velocity in local space
    /// </summary>
    public float LocalVelocityY;

    /// <summary>
    /// Velocity in local space
    /// </summary>
    public float LocalVelocityZ;

    /// <summary>
    /// Angular velocity x-component – radians/s
    /// </summary>
    public float AngularVelocityX;

    /// <summary>
    /// Angular velocity y-component
    /// </summary>
    public float AngularVelocityY;

    /// <summary>
    /// Angular velocity z-component
    /// </summary>
    public float AngularVelocityZ;

    /// <summary>
    /// Angular acceleration x-component – radians/s/s
    /// </summary>
    public float AngularAccelerationX;

    /// <summary>
    /// Angular acceleration y-component
    /// </summary>
    public float AngularAccelerationY;

    /// <summary>
    /// Angular acceleration z-component
    /// </summary>
    public float AngularAccelerationZ;

    /// <summary>
    /// Current front wheels angle in radians
    /// </summary>
    public float FrontWheelsAngle;

    /// <summary>
    /// Vertical forces for each wheel
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public float[] WheelVertForce;

    /// <summary>
    /// Front plank edge height above road surface
    /// </summary>
    public float FrontAeroHeight;

    /// <summary>
    /// Rear plank edge height above road surface
    /// </summary>
    public float RearAeroHeight;

    /// <summary>
    /// Roll angle of the front suspension
    /// </summary>
    public float FrontRollAngle;

    /// <summary>
    /// Roll angle of the rear suspension
    /// </summary>
    public float RearRollAngle;

    /// <summary>
    /// Yaw angle of the chassis relative to the direction
    /// of motion - radians
    /// </summary>
    public float ChassisYaw;
}