namespace GCommon;

internal class S2C_UDP_Ping_Res : UDPClientMessageBase
{
	public int SendTickCount;

	public override void UnSerialize(FastBinaryReader reader)
	{
	}

	public override void Serialize(FastBinaryWriter writer)
	{
	}

	public override bool CanCache()
	{
		return false;
	}
}
