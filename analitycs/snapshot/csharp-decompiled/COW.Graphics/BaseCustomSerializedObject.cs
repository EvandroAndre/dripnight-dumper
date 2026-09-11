using System.IO;
using LitJson;
using UnityEngine;

namespace COW.Graphics;

public abstract class BaseCustomSerializedObject
{
	protected void WriteJsonVector3(ref JsonWriter writer, Vector3 vector)
	{
	}

	protected Vector3 ReadJsonVector3(JsonData json_data)
	{
		return default(Vector3);
	}

	protected void WriteJsonVector2(ref JsonWriter writer, Vector2 vector)
	{
	}

	protected Vector2 ReadJsonVector2(JsonData json_data)
	{
		return default(Vector2);
	}

	protected void WriteJsonQuaternion(ref JsonWriter writer, Quaternion qua)
	{
	}

	protected Quaternion ReadJsonQuaternion(JsonData json_data)
	{
		return default(Quaternion);
	}

	protected Vector3 ReadBinaryVector(ref BinaryReader reader)
	{
		return default(Vector3);
	}

	protected void WriteBinaryVecter(ref BinaryWriter writer, Vector3 value)
	{
	}

	protected Quaternion ReadBinaryQuaternion(ref BinaryReader reader)
	{
		return default(Quaternion);
	}

	protected void WriteBinaryVQuaternion(ref BinaryWriter writer, Quaternion value)
	{
	}

	public void BinaryRead(ref BinaryReader reader)
	{
	}

	public void BinaryWrite(ref BinaryWriter writer)
	{
	}

	public void JsonRead(JsonData json_data)
	{
	}

	public void JsonWrite(ref JsonWriter writer)
	{
	}

	protected virtual void OnBinaryRead(ref BinaryReader reader)
	{
	}

	protected virtual void OnBinaryWrite(ref BinaryWriter writer)
	{
	}

	protected abstract void OnJsonRead(JsonData json_data);

	protected abstract void OnJsonWrite(ref JsonWriter writer);
}
