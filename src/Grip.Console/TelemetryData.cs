namespace Grip.Console;

public delegate void TelemetryUpdated();

internal sealed class TelemetryData
{
    public int PlayerCarIndex { get; private set; } = -1;

    public float ThrottlePosition { get; private set; }

    public float BreakPosition { get; private set; } = 0f;

    public TelemetryUpdated Updated { get; set; }

    public void SetPlayerCarIndex(int playerCarIndex)
    {
        PlayerCarIndex = playerCarIndex;
    }

    public void Set(float throttlePosition, float breakPosition)
    {
        ThrottlePosition = throttlePosition;
        BreakPosition = breakPosition;

        Notify();
    }

    private void Notify()
    {
        var updated = Updated;
        updated();
    }
}
