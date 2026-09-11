using GCommon;
using UnityEngine;

namespace COW;

public class FriendTagRuleData : CSVBaseData
{
	public RecommendedFriendTag Tag;

	public bool Switch;

	public int TagNumLimit;

	public Color BgColor;

	public string Key;

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
