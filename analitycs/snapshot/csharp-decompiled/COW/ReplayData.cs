using System.IO;
using System.Runtime.InteropServices;
using GCommon;

namespace COW;

public class ReplayData
{
	[StructLayout(LayoutKind.Explicit)]
	private struct FloatToUint
	{
		[FieldOffset(0)]
		public float fVal;

		[FieldOffset(0)]
		public uint uVal;
	}

	public bool ForKillCam;

	public float Time;

	public byte SendOption;

	public ushort Cmd;

	public ushort Length;

	public byte[] Data;

	private static FloatToUint m_FloatToUint;

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}

	public static bool TryDeserialize(BinaryReader reader, ref ReplayData replayData)
	{
		return false;
	}

	public ReplayData Clone()
	{
		return null;
	}

	public void CopyFrom(UDPMsgPacket packet)
	{
	}

	public void DeepCopyFrom(UDPMsgPacket packet)
	{
	}

	public void InitBuffer(uint bufferLength)
	{
	}

	public static implicit operator UDPMsgPacket(ReplayData replay)
	{
		return null;
	}
}
