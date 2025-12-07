using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Event details packet
/// The event details packet is different for each type of event.
/// Make sure only the correct type is interpreted.
/// </summary>
[StructLayout(LayoutKind.Explicit, Pack = 1)]
public struct EventDataDetails
{
    /// <summary>
    /// Fastest lap event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FastestLap
    {
        /// <summary>
        /// Vehicle index of car achieving fastest lap
        /// </summary>
        public byte VehicleIdx;

        /// <summary>
        /// Lap time is in seconds
        /// </summary>
        public float LapTime;
    }

    /// <summary>
    /// Retirement event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Retirement
    {
        /// <summary>
        /// Vehicle index of car retiring
        /// </summary>
        public byte VehicleIdx;
    }

    /// <summary>
    /// Team mate in pits event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TeamMateInPits
    {
        /// <summary>
        /// Vehicle index of team mate
        /// </summary>
        public byte VehicleIdx;
    }

    /// <summary>
    /// Race winner event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RaceWinner
    {
        /// <summary>
        /// Vehicle index of the race winner
        /// </summary>
        public byte VehicleIdx;
    }

    /// <summary>
    /// Penalty event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Penalty
    {
        /// <summary>
        /// Penalty type – see Appendices
        /// </summary>
        public byte PenaltyType;

        /// <summary>
        /// Infringement type – see Appendices
        /// </summary>
        public byte InfringementType;

        /// <summary>
        /// Vehicle index of the car the penalty is applied to
        /// </summary>
        public byte VehicleIdx;

        /// <summary>
        /// Vehicle index of the other car involved
        /// </summary>
        public byte OtherVehicleIdx;

        /// <summary>
        /// Time gained, or time spent doing action in seconds
        /// </summary>
        public byte Time;

        /// <summary>
        /// Lap the penalty occurred on
        /// </summary>
        public byte LapNum;

        /// <summary>
        /// Number of places gained by this
        /// </summary>
        public byte PlacesGained;
    }

    /// <summary>
    /// Speed trap event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct SpeedTrap
    {
        /// <summary>
        /// Vehicle index of the vehicle triggering speed trap
        /// </summary>
        public byte VehicleIdx;

        /// <summary>
        /// Top speed achieved in kilometres per hour
        /// </summary>
        public float Speed;

        /// <summary>
        /// Overall fastest speed in session = 1, otherwise 0
        /// </summary>
        public byte IsOverallFastestInSession;

        /// <summary>
        /// Fastest speed for driver in session = 1, otherwise 0
        /// </summary>
        public byte IsDriverFastestInSession;

        /// <summary>
        /// Vehicle index of the vehicle that is the fastest in this session
        /// </summary>
        public byte FastestVehicleIdxInSession;

        /// <summary>
        /// Speed of the vehicle that is the fastest in this session
        /// </summary>
        public float FastestSpeedInSession;
    }

    /// <summary>
    /// Start lights event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct StartLights
    {
        /// <summary>
        /// Number of lights showing
        /// </summary>
        public byte NumLights;
    }

    /// <summary>
    /// Drive through penalty served event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct DriveThroughPenaltyServed
    {
        /// <summary>
        /// Vehicle index of the vehicle serving drive through
        /// </summary>
        public byte VehicleIdx;
    }

    /// <summary>
    /// Stop go penalty served event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct StopGoPenaltyServed
    {
        /// <summary>
        /// Vehicle index of the vehicle serving stop go
        /// </summary>
        public byte VehicleIdx;
    }

    /// <summary>
    /// Flashback event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Flashback
    {
        /// <summary>
        /// Frame identifier flashed back to
        /// </summary>
        public uint FlashbackFrameIdentifier;

        /// <summary>
        /// Session time flashed back to
        /// </summary>
        public float FlashbackSessionTime;
    }

    /// <summary>
    /// Buttons event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Buttons
    {
        /// <summary>
        /// Bit flags specifying which buttons are being pressed currently - see appendices
        /// </summary>
        public uint ButtonStatus;
    }

    /// <summary>
    /// Overtake event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Overtake
    {
        /// <summary>
        /// Vehicle index of the vehicle overtaking
        /// </summary>
        public byte OvertakingVehicleIdx;

        /// <summary>
        /// Vehicle index of the vehicle being overtaken
        /// </summary>
        public byte BeingOvertakenVehicleIdx;
    }

    /// <summary>
    /// Safety car event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct SafetyCar
    {
        /// <summary>
        /// 0 = No Safety Car, 1 = Full Safety Car
        /// 2 = Virtual Safety Car, 3 = Formation Lap Safety Car
        /// </summary>
        public byte SafetyCarType;

        /// <summary>
        /// 0 = Deployed, 1 = Returning, 2 = Returned
        /// 3 = Resume Race
        /// </summary>
        public byte EventType;
    }

    /// <summary>
    /// Collision event data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Collision
    {
        /// <summary>
        /// Vehicle index of the first vehicle involved in the collision
        /// </summary>
        public byte Vehicle1Idx;

        /// <summary>
        /// Vehicle index of the second vehicle involved in the collision
        /// </summary>
        public byte Vehicle2Idx;
    }

    // Union implementation using FieldOffset - all fields share the same memory location
    // Largest structure determines the total size (12 bytes for SpeedTrap)

    /// <summary>
    /// Fastest lap event data
    /// </summary>
    [FieldOffset(0)] public FastestLap FastestLapData;

    /// <summary>
    /// Retirement event data
    /// </summary>
    [FieldOffset(0)] public Retirement RetirementData;

    /// <summary>
    /// Team mate in pits event data
    /// </summary>
    [FieldOffset(0)] public TeamMateInPits TeamMateInPitsData;

    /// <summary>
    /// Race winner event data
    /// </summary>
    [FieldOffset(0)] public RaceWinner RaceWinnerData;

    /// <summary>
    /// Penalty event data
    /// </summary>
    [FieldOffset(0)] public Penalty PenaltyData;

    /// <summary>
    /// Speed trap event data
    /// </summary>
    [FieldOffset(0)] public SpeedTrap SpeedTrapData;

    /// <summary>
    /// Start lights event data
    /// </summary>
    [FieldOffset(0)] public StartLights StartLightsData;

    /// <summary>
    /// Drive through penalty served event data
    /// </summary>
    [FieldOffset(0)] public DriveThroughPenaltyServed DriveThroughPenaltyServedData;

    /// <summary>
    /// Stop go penalty served event data
    /// </summary>
    [FieldOffset(0)] public StopGoPenaltyServed StopGoPenaltyServedData;

    /// <summary>
    /// Flashback event data
    /// </summary>
    [FieldOffset(0)] public Flashback FlashbackData;

    /// <summary>
    /// Buttons event data
    /// </summary>
    [FieldOffset(0)] public Buttons ButtonsData;

    /// <summary>
    /// Overtake event data
    /// </summary>
    [FieldOffset(0)] public Overtake OvertakeData;

    /// <summary>
    /// Safety car event data
    /// </summary>
    [FieldOffset(0)] public SafetyCar SafetyCarData;

    /// <summary>
    /// Collision event data
    /// </summary>
    [FieldOffset(0)] public Collision CollisionData;
}