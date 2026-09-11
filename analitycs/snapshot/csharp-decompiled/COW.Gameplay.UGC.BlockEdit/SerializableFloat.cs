using System.IO;

namespace COW.Gameplay.UGC.BlockEdit;

public class SerializableFloat : ISerializableValue
{
	public float Value;

	public byte Type => 0;

	public SerializableFloat()
	{
	}

	public SerializableFloat(float value)
	{
	}

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}
}
