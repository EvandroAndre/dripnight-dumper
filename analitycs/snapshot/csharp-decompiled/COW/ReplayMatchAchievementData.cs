using System;
using GCommon;

namespace COW;

public class ReplayMatchAchievementData : CSVBaseData, IComparable<ReplayMatchAchievementData>
{
	private ResourceID m_AchievementBigIcon;

	private ResourceID m_AchievementBigIcon_India;

	private ResourceID m_AchievementSmallIcon;

	private ResourceID m_AchievementSmallIcon_India;

	public uint AchievementID;

	public string m_AchievementBigIconName;

	public ResourceID AchievementBigIconEffect;

	public string m_AchievementSmallIconName;

	public ResourceID AchievementSmallIconEffect;

	public string m_AchievementName;

	public string AchievementDes;

	public string AchievementHighlightDes;

	public bool SplitDes;

	public uint Priority;

	public uint AchievementGroup;

	public ResourceID AchievementBigIcon => default(ResourceID);

	public ResourceID AchievementSmallIcon => default(ResourceID);

	public string AchievementName => null;

	public int CompareTo(ReplayMatchAchievementData other)
	{
		return 0;
	}

	public override void PostDeserializeData()
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
