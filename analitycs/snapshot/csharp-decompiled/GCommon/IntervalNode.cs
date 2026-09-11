namespace GCommon;

public struct IntervalNode
{
	public const int LimitCount = int.MaxValue;

	public uint StartID;

	public uint NextID;

	public int Offset;

	public IntervalNodeType Type;

	public byte Sp;
}
