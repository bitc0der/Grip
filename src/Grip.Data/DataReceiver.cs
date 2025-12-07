using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Grip.Data.Definition.Packet;
using Grip.Data.Infrastructure;

namespace Grip.Data;

public sealed class DataReceiver
{
    private readonly IPEndPoint _ipEndPoint;
    private readonly DataReader _dataReader;
    private readonly DataLogger? _dataLogger;

    public DataReceiver(IPEndPoint ipEndPoint, DataReader dataReader, DataLogger? dataLogger = null)
    {
        _ipEndPoint = ipEndPoint ?? throw new ArgumentNullException(nameof(ipEndPoint));
        _dataReader = dataReader ?? throw new ArgumentNullException(nameof(dataReader));
        _dataLogger = dataLogger;
    }

    public async Task ReceiveAsync(CancellationToken cancellationToken = default)
    {
        using var udpClient = new UdpClient();

        udpClient.Connect(_ipEndPoint);

        while (true)
        {
            var header = await ReceiveAsync<PacketHeader>(udpClient, cancellationToken);

            _dataReader.Process(header);

            switch (header.PacketId)
            {
                case PacketId.Motion:
                    var packetMotionData = await ReceiveAsync<PacketMotionData>(udpClient, cancellationToken);
                    _dataReader.Process(packetMotionData);
                    break;
                case PacketId.Session:
                    var packetSessionData = await ReceiveAsync<PacketSessionData>(udpClient, cancellationToken);
                    _dataReader.Process(packetSessionData);
                    break;
                case PacketId.LapData:
                    var packetLapData = await ReceiveAsync<PacketLapData>(udpClient, cancellationToken);
                    _dataReader.Process(packetLapData);
                    break;
                case PacketId.Event:
                    var packetEventData = await ReceiveAsync<PacketEventData>(udpClient, cancellationToken);
                    _dataReader.Process(packetEventData);
                    break;
                case PacketId.Participants:
                    var packetParticipantsData =
                        await ReceiveAsync<PacketParticipantsData>(udpClient, cancellationToken);
                    _dataReader.Process(packetParticipantsData);
                    break;
                case PacketId.CarSetups:
                    var packetCarSetupData = await ReceiveAsync<PacketCarSetupData>(udpClient, cancellationToken);
                    _dataReader.Process(packetCarSetupData);
                    break;
                case PacketId.CarTelemetry:
                    var packetCarTelemetryData =
                        await ReceiveAsync<PacketCarTelemetryData>(udpClient, cancellationToken);
                    _dataReader.Process(packetCarTelemetryData);
                    break;
                case PacketId.CarStatus:
                    var packetCarStatusData = await ReceiveAsync<PacketCarStatusData>(udpClient, cancellationToken);
                    _dataReader.Process(packetCarStatusData);
                    break;
                case PacketId.FinalClassification:
                    var packetFinalClassificationData =
                        await ReceiveAsync<PacketFinalClassificationData>(udpClient, cancellationToken);
                    _dataReader.Process(packetFinalClassificationData);
                    break;
                case PacketId.LobbyInfo:
                    var packetLobbyInfoData = await ReceiveAsync<PacketLobbyInfoData>(udpClient, cancellationToken);
                    _dataReader.Process(packetLobbyInfoData);
                    break;
                case PacketId.CarDamage:
                    var packetCarDamageData = await ReceiveAsync<PacketCarDamageData>(udpClient, cancellationToken);
                    _dataReader.Process(packetCarDamageData);
                    break;
                case PacketId.SessionHistory:
                    var packetSessionHistoryData =
                        await ReceiveAsync<PacketSessionHistoryData>(udpClient, cancellationToken);
                    _dataReader.Process(packetSessionHistoryData);
                    break;
                case PacketId.TyreSets:
                    var packetTyreSetsData =
                        await ReceiveAsync<PacketTyreSetsData>(udpClient, cancellationToken);
                    _dataReader.Process(packetTyreSetsData);
                    break;
                case PacketId.MotionEx:
                    var packetMotionExData =
                        await ReceiveAsync<PacketMotionExData>(udpClient, cancellationToken);
                    _dataReader.Process(packetMotionExData);
                    break;
                case PacketId.TimeTrial:
                    var packetTimeTrialData =
                        await ReceiveAsync<PacketTimeTrialData>(udpClient, cancellationToken);
                    _dataReader.Process(packetTimeTrialData);
                    break;
                default:
                    throw new InvalidOperationException(message: $"Unknown packet id '{header.PacketId}'");
            }
        }
    }

    private async Task<T> ReceiveAsync<T>(UdpClient udpClient, CancellationToken cancellationToken)
        where T : struct
    {
        ArgumentNullException.ThrowIfNull(udpClient);

        var result = await udpClient.ReceiveAsync(cancellationToken);

        if (_dataLogger is not null && result.Buffer.Length > 0)
        {
            await _dataLogger.LogDataAsync(result.Buffer, cancellationToken);
        }

        var value = ReadStruct<T>(result.Buffer);

        return value;
    }

    private static T ReadStruct<T>(byte[] buffer)
        where T : struct
    {
        var size = Marshal.SizeOf<T>();

        if (size > buffer.Length)
            throw new InvalidOperationException("Struct size is greater than buffer size");

        return BinaryDeserializer.Deserialize<T>(buffer);
    }
}
