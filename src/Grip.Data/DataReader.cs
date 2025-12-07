using Grip.Data.Definition.Packet;

namespace Grip.Data;

public abstract class DataReader
{
    public virtual void Process(PacketHeader packetHeader)
    {
    }

    public virtual void Process(PacketMotionData packetMotionData)
    {
    }

    public virtual void Process(PacketSessionData packetSessionData)
    {
    }

    public virtual void Process(PacketLapData packetLapData)
    {
    }

    public virtual void Process(PacketEventData packetLapData)
    {
    }

    public virtual void Process(PacketCarStatusData packetCarStatusData)
    {
    }

    public virtual void Process(PacketFinalClassificationData packetFinalClassificationData)
    {
    }

    public virtual void Process(PacketParticipantsData packetParticipantsData)
    {
    }

    public virtual void Process(PacketCarSetupData packetParticipantsData)
    {
    }

    public virtual void Process(PacketCarTelemetryData packetParticipantsData)
    {
    }

    public virtual void Process(PacketLobbyInfoData packetParticipantsData)
    {
    }

    public virtual void Process(PacketCarDamageData packetParticipantsData)
    {
    }

    public virtual void Process(PacketSessionHistoryData packetParticipantsData)
    {
    }

    public virtual void Process(PacketTyreSetsData packetParticipantsData)
    {
    }

    public virtual void Process(PacketMotionExData packetParticipantsData)
    {
    }

    public virtual void Process(PacketTimeTrialData packetParticipantsData)
    {
    }
}
