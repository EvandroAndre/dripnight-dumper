using System.IO;

namespace COW.Gameplay.UGC.BlockEdit;

public class SerializableString : ISerializableValue
{
	public string Value;

	public byte Type => 0;

	public SerializableString()
	{
	}

	public SerializableString(string value)
	{
	}

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}
}
