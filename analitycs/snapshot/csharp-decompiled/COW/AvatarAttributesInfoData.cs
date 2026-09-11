using System.Collections.Generic;
using GCommon;

namespace COW;

public class AvatarAttributesInfoData : CSVBaseData
{
	public uint Id;

	public uint AttributeId;

	public uint difficulty;

	public string Desc;

	public string DescParams;

	public string[] Params;

	public uint level;

	public uint maxLevel;

	public string name;

	public ResourceID icon;

	public ResourceID iconQuality;

	public uint attributeShowType;

	public List<int> recommendWeaponType;

	public uint attributeType;

	public List<AttributeEffectInfo> EffectInfos;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
