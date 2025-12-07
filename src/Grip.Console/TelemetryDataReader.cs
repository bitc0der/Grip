using System;
using Grip.Data;
using Grip.Data.Definition.Packet;

namespace Grip.Console;

internal sealed class TelemetryDataReader : DataReader
{
    private readonly TelemetryData _telemetryData;

    public TelemetryDataReader(TelemetryData telemetryData)
    {
        _telemetryData = telemetryData ?? throw new ArgumentNullException(nameof(telemetryData));
    }

    public override void Process(PacketHeader packetHeader)
    {
        _telemetryData.SetPlayerCarIndex(packetHeader.PlayerCarIndex);
    }

    public override void Process(PacketCarTelemetryData packetCarTelemetryData)
    {
        var playerCarTelemetryData = packetCarTelemetryData.CarTelemetryData[_telemetryData.PlayerCarIndex];

        _telemetryData.Set(
            throttlePosition: playerCarTelemetryData.Throttle,
            breakPosition: playerCarTelemetryData.Brake
        );
    }
}
