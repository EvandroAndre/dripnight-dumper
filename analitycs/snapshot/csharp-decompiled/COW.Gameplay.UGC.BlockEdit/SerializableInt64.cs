using System.IO;

namespace COW.Gameplay.UGC.BlockEdit;

public class SerializableInt64 : ISerializableValue
{
	public long Value;

	public byte Type => 0;

	public SerializableInt64()
	{
	}

	public SerializableInt64(long value)
	{
	}

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}
}
