using GCommon;
using UnityEngine;

namespace COW;

public class ChestChangeTextData : CSVBaseData, IGetId
{
	public uint ChangeSkinType;

	public uint TextType;

	public string Color;

	public string ColorStart;

	public string ColorEnd;

	public Vector3 ShadowPos;

	public string ShadowColor;

	public Vector3 OutlinePos;

	public string OutlineColor;

	public int Spacing;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public static uint GenerateKey(uint changeType, uint textType)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}
}
