using GCommon;
using UnityEngine;

public class WeaponTagInfoData : CSVBaseData
{
	public int TagID;

	public Color TagColor;

	public string TagKey;

	public string TagDesc;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
