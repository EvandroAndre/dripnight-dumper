using System.IO;

namespace COW.Gameplay.UGC.BlockEdit;

public class SerializableBool : ISerializableValue
{
	public bool Value;

	public byte Type => 0;

	public SerializableBool()
	{
	}

	public SerializableBool(bool value)
	{
	}

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}
}
