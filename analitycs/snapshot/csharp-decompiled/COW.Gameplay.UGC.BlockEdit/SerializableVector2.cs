using System.IO;
using UnityEngine;

namespace COW.Gameplay.UGC.BlockEdit;

public class SerializableVector2 : ISerializableValue
{
	public Vector2 Value;

	public byte Type => 0;

	public SerializableVector2()
	{
	}

	public SerializableVector2(Vector2 value)
	{
	}

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}
}
