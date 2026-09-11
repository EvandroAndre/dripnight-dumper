using System.IO;

namespace COW.Gameplay.UGC.BlockEdit;

public class SerializableInt16 : ISerializableValue
{
	public short Value;

	public byte Type => 0;

	public SerializableInt16()
	{
	}

	public SerializableInt16(short value)
	{
	}

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}
}
