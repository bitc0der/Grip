namespace Grip.Data.Definition;

public enum PacketIds : byte
{
    /// <summary>
    /// Contains all motion data for player’s car – only sent while player is in control
    /// </summary>
    Motion = 0,

    /// <summary>
    /// Data about the session – track, time left
    /// </summary>
    Session = 1,

    /// <summary>
    /// Data about all the lap times of cars in the session
    /// </summary>
    LapData = 2,

    /// <summary>
    /// Various notable events that happen during a session
    /// </summary>
    Event = 3,

    /// <summary>
    /// List of participants in the session
    /// mostly relevant for multiplayer
    /// </summary>
    Participants = 4,

    /// <summary>
    /// Packet detailing car setups for cars in the race
    /// </summary>
    CarSetups = 5,

    /// <summary>
    /// Telemetry data for all cars
    /// </summary>
    CarTelemetry = 6,

    /// <summary>
    /// Status data for all cars
    /// </summary>
    CarStatus = 7,

    /// <summary>
    /// Final classification confirmation at the end of a race
    /// </summary>
    FinalClassification = 8,

    /// <summary>
    /// Information about players in a multiplayer lobby
    /// </summary>
    LobbyInfo = 9,

    /// <summary>
    /// Damage status for all cars
    /// </summary>
    CarDamage = 10,

    /// <summary>
    /// Lap and tyre data for session
    /// </summary>
    SessionHistory = 11,

    /// <summary>
    /// Extended tyre set data
    /// </summary>
    TyreSets = 12,

    /// <summary>
    /// Extended motion data for player car
    /// </summary>
    MotionEx = 13,

    /// <summary>
    /// Time Trial specific data
    /// </summary>
    TimeTrial = 14
}