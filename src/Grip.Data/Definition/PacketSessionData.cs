using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Packet session data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PacketSessionData
{
    /// <summary>
    /// Header
    /// </summary>
    public PacketHeader Header;

    /// <summary>
    /// Weather - 0 = clear, 1 = light cloud, 2 = overcast
    /// 3 = light rain, 4 = heavy rain, 5 = storm
    /// </summary>
    public byte Weather;

    /// <summary>
    /// Track temp. in degrees celsius
    /// </summary>
    public sbyte TrackTemperature;

    /// <summary>
    /// Air temp. in degrees celsius
    /// </summary>
    public sbyte AirTemperature;

    /// <summary>
    /// Total number of laps in this race
    /// </summary>
    public byte TotalLaps;

    /// <summary>
    /// Track length in metres
    /// </summary>
    public ushort TrackLength;

    /// <summary>
    /// 0 = unknown, see appendix
    /// </summary>
    public byte SessionType;

    /// <summary>
    /// -1 for unknown, see appendix
    /// </summary>
    public sbyte TrackId;

    /// <summary>
    /// Formula, 0 = F1 Modern, 1 = F1 Classic, 2 = F2,
    /// 3 = F1 Generic, 4 = Beta, 6 = Esports
    /// 8 = F1 World, 9 = F1 Elimination
    /// </summary>
    public byte Formula;

    /// <summary>
    /// Time left in session in seconds
    /// </summary>
    public ushort SessionTimeLeft;

    /// <summary>
    /// Session duration in seconds
    /// </summary>
    public ushort SessionDuration;

    /// <summary>
    /// Pit speed limit in kilometres per hour
    /// </summary>
    public byte PitSpeedLimit;

    /// <summary>
    /// Whether the game is paused – network game only
    /// </summary>
    public byte GamePaused;

    /// <summary>
    /// Whether the player is spectating
    /// </summary>
    public byte IsSpectating;

    /// <summary>
    /// Index of the car being spectated
    /// </summary>
    public byte SpectatorCarIndex;

    /// <summary>
    /// SLI Pro support, 0 = inactive, 1 = active
    /// </summary>
    public byte SliProNativeSupport;

    /// <summary>
    /// Number of marshal zones to follow
    /// </summary>
    public byte NumMarshalZones;

    /// <summary>
    /// List of marshal zones – max 21
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
    public MarshalZone[] MarshalZones;

    /// <summary>
    /// 0 = no safety car, 1 = full
    /// 2 = virtual, 3 = formation lap
    /// </summary>
    public byte SafetyCarStatus;

    /// <summary>
    /// 0 = offline, 1 = online
    /// </summary>
    public byte NetworkGame;

    /// <summary>
    /// Number of weather samples to follow
    /// </summary>
    public byte NumWeatherForecastSamples;

    /// <summary>
    /// Array of weather forecast samples
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public WeatherForecastSample[] WeatherForecastSamples;

    /// <summary>
    /// 0 = Perfect, 1 = Approximate
    /// </summary>
    public byte ForecastAccuracy;

    /// <summary>
    /// AI Difficulty rating – 0-110
    /// </summary>
    public byte AiDifficulty;

    /// <summary>
    /// Identifier for season - persists across saves
    /// </summary>
    public uint SeasonLinkIdentifier;

    /// <summary>
    /// Identifier for weekend - persists across saves
    /// </summary>
    public uint WeekendLinkIdentifier;

    /// <summary>
    /// Identifier for session - persists across saves
    /// </summary>
    public uint SessionLinkIdentifier;

    /// <summary>
    /// Ideal lap to pit on for current strategy (player)
    /// </summary>
    public byte PitStopWindowIdealLap;

    /// <summary>
    /// Latest lap to pit on for current strategy (player)
    /// </summary>
    public byte PitStopWindowLatestLap;

    /// <summary>
    /// Predicted position to rejoin at (player)
    /// </summary>
    public byte PitStopRejoinPosition;

    /// <summary>
    /// 0 = off, 1 = on
    /// </summary>
    public byte SteeringAssist;

    /// <summary>
    /// 0 = off, 1 = low, 2 = medium, 3 = high
    /// </summary>
    public byte BrakingAssist;

    /// <summary>
    /// 1 = manual, 2 = manual & suggested gear, 3 = auto
    /// </summary>
    public byte GearboxAssist;

    /// <summary>
    /// 0 = off, 1 = on
    /// </summary>
    public byte PitAssist;

    /// <summary>
    /// 0 = off, 1 = on
    /// </summary>
    public byte PitReleaseAssist;

    /// <summary>
    /// 0 = off, 1 = on
    /// </summary>
    public byte ErsAssist;

    /// <summary>
    /// 0 = off, 1 = on
    /// </summary>
    public byte DrsAssist;

    /// <summary>
    /// 0 = off, 1 = corners only, 2 = full
    /// </summary>
    public byte DynamicRacingLine;

    /// <summary>
    /// 0 = 2D, 1 = 3D
    /// </summary>
    public byte DynamicRacingLineType;

    /// <summary>
    /// Game mode id - see appendix
    /// </summary>
    public byte GameMode;

    /// <summary>
    /// Ruleset - see appendix
    /// </summary>
    public byte RuleSet;

    /// <summary>
    /// Local time of day - minutes since midnight
    /// </summary>
    public uint TimeOfDay;

    /// <summary>
    /// 0 = None, 2 = Very Short, 3 = Short, 4 = Medium
    /// 5 = Medium Long, 6 = Long, 7 = Full
    /// </summary>
    public byte SessionLength;

    /// <summary>
    /// 0 = MPH, 1 = KPH
    /// </summary>
    public byte SpeedUnitsLeadPlayer;

    /// <summary>
    /// 0 = Celsius, 1 = Fahrenheit
    /// </summary>
    public byte TemperatureUnitsLeadPlayer;

    /// <summary>
    /// 0 = MPH, 1 = KPH
    /// </summary>
    public byte SpeedUnitsSecondaryPlayer;

    /// <summary>
    /// 0 = Celsius, 1 = Fahrenheit
    /// </summary>
    public byte TemperatureUnitsSecondaryPlayer;

    /// <summary>
    /// Number of safety cars called during session
    /// </summary>
    public byte NumSafetyCarPeriods;

    /// <summary>
    /// Number of virtual safety cars called
    /// </summary>
    public byte NumVirtualSafetyCarPeriods;

    /// <summary>
    /// Number of red flags called during session
    /// </summary>
    public byte NumRedFlagPeriods;

    /// <summary>
    /// 0 = Off, 1 = On
    /// </summary>
    public byte EqualCarPerformance;

    /// <summary>
    /// 0 = None, 1 = Flashbacks, 2 = Auto-recovery
    /// </summary>
    public byte RecoveryMode;

    /// <summary>
    /// 0 = Low, 1 = Medium, 2 = High, 3 = Unlimited
    /// </summary>
    public byte FlashbackLimit;

    /// <summary>
    /// 0 = Simplified, 1 = Realistic
    /// </summary>
    public byte SurfaceType;

    /// <summary>
    /// 0 = Easy, 1 = Hard
    /// </summary>
    public byte LowFuelMode;

    /// <summary>
    /// 0 = Manual, 1 = Assisted
    /// </summary>
    public byte RaceStarts;

    /// <summary>
    /// 0 = Surface only, 1 = Surface & Carcass
    /// </summary>
    public byte TyreTemperature;

    /// <summary>
    /// 0 = On, 1 = Off
    /// </summary>
    public byte PitLaneTyreSim;

    /// <summary>
    /// 0 = Off, 1 = Reduced, 2 = Standard, 3 = Simulation
    /// </summary>
    public byte CarDamage;

    /// <summary>
    /// 0 = Reduced, 1 = Standard, 2 = Simulation
    /// </summary>
    public byte CarDamageRate;

    /// <summary>
    /// 0 = Off, 1 = Player-to-Player Off, 2 = On
    /// </summary>
    public byte Collisions;

    /// <summary>
    /// 0 = Disabled, 1 = Enabled
    /// </summary>
    public byte CollisionsOffForFirstLapOnly;

    /// <summary>
    /// 0 = On, 1 = Off (Multiplayer)
    /// </summary>
    public byte MpUnsafePitRelease;

    /// <summary>
    /// 0 = Disabled, 1 = Enabled (Multiplayer)
    /// </summary>
    public byte MpOffForGriefing;

    /// <summary>
    /// 0 = Regular, 1 = Strict
    /// </summary>
    public byte CornerCuttingStringency;

    /// <summary>
    /// 0 = Off, 1 = On
    /// </summary>
    public byte ParcFermeRules;

    /// <summary>
    /// 0 = Automatic, 1 = Broadcast, 2 = Immersive
    /// </summary>
    public byte PitStopExperience;

    /// <summary>
    /// 0 = Off, 1 = Reduced, 2 = Standard, 3 = Increased
    /// </summary>
    public byte SafetyCar;

    /// <summary>
    /// 0 = Broadcast, 1 = Immersive
    /// </summary>
    public byte SafetyCarExperience;

    /// <summary>
    /// 0 = Off, 1 = On
    /// </summary>
    public byte FormationLap;

    /// <summary>
    /// 0 = Broadcast, 1 = Immersive
    /// </summary>
    public byte FormationLapExperience;

    /// <summary>
    /// 0 = Off, 1 = Reduced, 2 = Standard, 3 = Increased
    /// </summary>
    public byte RedFlags;

    /// <summary>
    /// 0 = Off, 1 = On
    /// </summary>
    public byte AffectsLicenceLevelSolo;

    /// <summary>
    /// 0 = Off, 1 = On
    /// </summary>
    public byte AffectsLicenceLevelMp;

    /// <summary>
    /// Number of session in following array
    /// </summary>
    public byte NumSessionsInWeekend;

    /// <summary>
    /// List of session types to show weekend
    /// structure - see appendix for types
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] WeekendStructure;

    /// <summary>
    /// Distance in m around track where sector 2 starts
    /// </summary>
    public float Sector2LapDistanceStart;

    /// <summary>
    /// Distance in m around track where sector 3 starts
    /// </summary>
    public float Sector3LapDistanceStart;
}