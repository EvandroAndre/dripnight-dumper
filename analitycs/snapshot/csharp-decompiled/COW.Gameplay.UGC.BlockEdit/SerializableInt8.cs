using System.IO;

namespace COW.Gameplay.UGC.BlockEdit;

public class SerializableInt8 : ISerializableValue
{
	public byte Value;

	public byte Type => 0;

	public SerializableInt8()
	{
	}

	public SerializableInt8(byte value)
	{
	}

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}
}
