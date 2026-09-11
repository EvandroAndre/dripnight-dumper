using System.IO;

namespace GCommon;

internal class C2S_UDP_Ack_Res
{
	public ushort RequiredOrderID;

	public uint AckOrderBits;

	public void Serialize(BinaryWriter writer)
	{
	}

	public void UnSerialize(BinaryReader reader)
	{
	}
}
