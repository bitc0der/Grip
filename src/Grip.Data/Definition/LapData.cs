using System.Runtime.InteropServices;

namespace Grip.Data.Definition;

/// <summary>
/// Lap data
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct LapData
{
    /// <summary>
    /// Last lap time in milliseconds
    /// </summary>
    public uint LastLapTimeInMs;

    /// <summary>
    /// Current time around the lap in milliseconds
    /// </summary>
    public uint CurrentLapTimeInMs;

    /// <summary>
    /// Sector 1 time milliseconds part
    /// </summary>
    public ushort Sector1TimeMsPart;

    /// <summary>
    /// Sector 1 whole minute part
    /// </summary>
    public byte Sector1TimeMinutesPart;

    /// <summary>
    /// Sector 2 time milliseconds part
    /// </summary>
    public ushort Sector2TimeMsPart;

    /// <summary>
    /// Sector 2 whole minute part
    /// </summary>
    public byte Sector2TimeMinutesPart;

    /// <summary>
    /// Time delta to car in front milliseconds part
    /// </summary>
    public ushort DeltaToCarInFrontMsPart;

    /// <summary>
    /// Time delta to car in front whole minute part
    /// </summary>
    public byte DeltaToCarInFrontMinutesPart;

    /// <summary>
    /// Time delta to race leader milliseconds part
    /// </summary>
    public ushort DeltaToRaceLeaderMsPart;

    /// <summary>
    /// Time delta to race leader whole minute part
    /// </summary>
    public byte DeltaToRaceLeaderMinutesPart;

    /// <summary>
    /// Distance vehicle is around current lap in metres – could
    /// be negative if line hasn’t been crossed yet
    /// </summary>
    public float LapDistance;

    /// <summary>
    /// Total distance travelled in session in metres – could
    /// be negative if line hasn’t been crossed yet
    /// </summary>
    public float TotalDistance;

    /// <summary>
    /// Delta in seconds for safety car
    /// </summary>
    public float SafetyCarDelta;

    /// <summary>
    /// Car race position
    /// </summary>
    public byte CarPosition;

    /// <summary>
    /// Current lap number
    /// </summary>
    public byte CurrentLapNum;

    /// <summary>
    /// 0 = none, 1 = pitting, 2 = in pit area
    /// </summary>
    public byte PitStatus;

    /// <summary>
    /// Number of pit stops taken in this race
    /// </summary>
    public byte NumPitStops;

    /// <summary>
    /// 0 = sector1, 1 = sector2, 2 = sector3
    /// </summary>
    public byte Sector;

    /// <summary>
    /// Current lap invalid - 0 = valid, 1 = invalid
    /// </summary>
    public byte CurrentLapInvalid;

    /// <summary>
    /// Accumulated time penalties in seconds to be added
    /// </summary>
    public byte Penalties;

    /// <summary>
    /// Accumulated number of warnings issued
    /// </summary>
    public byte TotalWarnings;

    /// <summary>
    /// Accumulated number of corner cutting warnings issued
    /// </summary>
    public byte CornerCuttingWarnings;

    /// <summary>
    /// Num drive through pens left to serve
    /// </summary>
    public byte NumUnservedDriveThroughPens;

    /// <summary>
    /// Num stop go pens left to serve
    /// </summary>
    public byte NumUnservedStopGoPens;

    /// <summary>
    /// Grid position the vehicle started the race in
    /// </summary>
    public byte GridPosition;

    /// <summary>
    /// Status of driver - 0 = in garage, 1 = flying lap
    /// 2 = in lap, 3 = out lap, 4 = on track
    /// </summary>
    public byte DriverStatus;

    /// <summary>
    /// Result status - 0 = invalid, 1 = inactive, 2 = active
    /// 3 = finished, 4 = didnotfinish, 5 = disqualified
    /// 6 = not classified, 7 = retired
    /// </summary>
    public byte ResultStatus;

    /// <summary>
    /// Pit lane timing, 0 = inactive, 1 = active
    /// </summary>
    public byte PitLaneTimerActive;

    /// <summary>
    /// If active, the current time spent in the pit lane in ms
    /// </summary>
    public ushort PitLaneTimeInLaneInMs;

    /// <summary>
    /// Time of the actual pit stop in ms
    /// </summary>
    public ushort PitStopTimerInMs;

    /// <summary>
    /// Whether the car should serve a penalty at this stop
    /// </summary>
    public byte PitStopShouldServePen;

    /// <summary>
    /// Fastest speed through speed trap for this car in kmph
    /// </summary>
    public float SpeedTrapFastestSpeed;

    /// <summary>
    /// Lap no the fastest speed was achieved, 255 = not set
    /// </summary>
    public byte SpeedTrapFastestLap;
}