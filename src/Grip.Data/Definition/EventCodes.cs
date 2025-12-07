namespace Grip.Data.Definition;

/// <summary>
/// Event codes for F1 game events
/// </summary>
public static class EventCodes
{
    /// <summary>
    /// Sent when the session starts
    /// </summary>
    public const string SessionStarted = "SSTA";

    /// <summary>
    /// Sent when the session ends
    /// </summary>
    public const string SessionEnded = "SEND";

    /// <summary>
    /// When a driver achieves the fastest lap
    /// </summary>
    public const string FastestLap = "FTLP";

    /// <summary>
    /// When a driver retires
    /// </summary>
    public const string Retirement = "RTMT";

    /// <summary>
    /// Race control have enabled DRS
    /// </summary>
    public const string DrsEnabled = "DRSE";

    /// <summary>
    /// Race control have disabled DRS
    /// </summary>
    public const string DrsDisabled = "DRSD";

    /// <summary>
    /// Your team mate has entered the pits
    /// </summary>
    public const string TeamMateInPits = "TMPT";

    /// <summary>
    /// The chequered flag has been waved
    /// </summary>
    public const string ChequeredFlag = "CHQF";

    /// <summary>
    /// The race winner is announced
    /// </summary>
    public const string RaceWinner = "RCWN";

    /// <summary>
    /// A penalty has been issued – details in event
    /// </summary>
    public const string PenaltyIssued = "PENA";

    /// <summary>
    /// Speed trap has been triggered by fastest speed
    /// </summary>
    public const string SpeedTrapTriggered = "SPTP";

    /// <summary>
    /// Start lights – number shown
    /// </summary>
    public const string StartLights = "STLG";

    /// <summary>
    /// Lights out
    /// </summary>
    public const string LightsOut = "LGOT";

    /// <summary>
    /// Drive through penalty served
    /// </summary>
    public const string DriveThroughServed = "DTSV";

    /// <summary>
    /// Stop go penalty served
    /// </summary>
    public const string StopGoServed = "SGSV";

    /// <summary>
    /// Flashback activated
    /// </summary>
    public const string Flashback = "FLBK";

    /// <summary>
    /// Button status changed
    /// </summary>
    public const string ButtonStatus = "BUTN";

    /// <summary>
    /// Red flag shown
    /// </summary>
    public const string RedFlag = "RDFL";

    /// <summary>
    /// Overtake occurred
    /// </summary>
    public const string Overtake = "OVTK";

    /// <summary>
    /// Safety car event – details in event
    /// </summary>
    public const string SafetyCar = "SCAR";

    /// <summary>
    /// Collision between two vehicles has occurred
    /// </summary>
    public const string Collision = "COLL";
}