using System;
using System.IO;
using LitJson;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
public class GrassInst : BaseCustomSerializedObject
{
	public byte m_spriteID;

	public byte m_isHide;

	public Vector3 m_pos;

	public uint[] m_NormalAndRotation;

	public static void GetNormalValue(uint[] normal_and_rotation, ref Vector3 normal)
	{
	}

	public static void GetScaleValue(uint[] normal_and_rotation, ref float scale)
	{
	}

	public static void GetRotationW(uint[] normal_and_rotation, ref float rotation_w)
	{
	}

	public static void ChangeRotationW(ref uint[] normal_and_rotation, float rotation_w)
	{
	}

	public static void SplitNormalAndRotation(uint[] normal_and_rotation, ref Vector3 normal, ref Quaternion rotation)
	{
	}

	public static void CompressNormalAndRotation(Vector3 normal, Quaternion rotation, float scale, ref uint[] normal_and_rotation)
	{
	}

	protected override void OnBinaryRead(ref BinaryReader reader)
	{
	}

	protected override void OnBinaryWrite(ref BinaryWriter writer)
	{
	}

	protected override void OnJsonRead(JsonData json_data)
	{
	}

	public void OnFEJsonRead(JsonData json_data)
	{
	}

	protected override void OnJsonWrite(ref JsonWriter writer)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBinaryRead(ref BinaryReader P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBinaryWrite(ref BinaryWriter P0)
	{
	}
}
