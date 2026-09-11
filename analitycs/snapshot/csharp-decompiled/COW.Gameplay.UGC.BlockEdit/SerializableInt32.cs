using System.IO;

namespace COW.Gameplay.UGC.BlockEdit;

public class SerializableInt32 : ISerializableValue
{
	public int Value;

	public byte Type => 0;

	public SerializableInt32()
	{
	}

	public SerializableInt32(int value)
	{
	}

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}
}
