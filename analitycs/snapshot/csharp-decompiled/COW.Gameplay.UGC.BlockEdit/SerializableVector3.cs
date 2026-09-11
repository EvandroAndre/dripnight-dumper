using System.IO;
using UnityEngine;

namespace COW.Gameplay.UGC.BlockEdit;

public class SerializableVector3 : ISerializableValue
{
	public Vector3 Value;

	public byte Type => 0;

	public SerializableVector3()
	{
	}

	public SerializableVector3(Vector3 value)
	{
	}

	public void Serialize(BinaryWriter writer)
	{
	}

	public void Deserialize(BinaryReader reader)
	{
	}
}
