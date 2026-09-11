using System.Collections.Generic;

namespace GCommon;

internal class S2C_C2S_RUDP_SPLITTED_DATAGRAM : UDPClientMessageBase
{
	public uint ID;

	public uint CMD;

	public byte Total;

	public byte Number;

	public byte SendOption;

	public ushort PayloadLength;

	public List<byte> Payload;

	public override void Serialize(FastBinaryWriter writer)
	{
	}

	public override void UnSerialize(FastBinaryReader reader)
	{
	}

	public override void Recycle()
	{
	}
}
