using System.Runtime.InteropServices;

namespace GCommon;

[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 8)]
public struct ReplicationDataValueUnion
{
	[FieldOffset(0)]
	public sbyte m_SByte;

	[FieldOffset(0)]
	public byte m_Byte;

	[FieldOffset(0)]
	public short m_Int16;

	[FieldOffset(0)]
	public ushort m_UInt16;

	[FieldOffset(0)]
	public int m_Int32;

	[FieldOffset(0)]
	public uint m_UInt32;

	[FieldOffset(0)]
	public long m_Int64;

	[FieldOffset(0)]
	public ulong m_UInt64;

	[FieldOffset(0)]
	public float m_Single;

	[FieldOffset(0)]
	public bool m_Boolean;
}
