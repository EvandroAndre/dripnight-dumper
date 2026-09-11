namespace GCommon;

internal class C2S_UDP_Ping_Req : UDPClientMessageBase
{
	public int SendTickCount;

	public short AveragePing;

	public short PingA500;

	public short RudpResendRate;

	public override void Serialize(FastBinaryWriter writer)
	{
	}

	public override void UnSerialize(FastBinaryReader reader)
	{
	}
}
