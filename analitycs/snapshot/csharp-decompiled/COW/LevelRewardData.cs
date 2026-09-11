using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class LevelRewardData : CSVBaseData
{
	public uint m_TargetLevel;

	public uint m_AwardType1;

	public uint m_AwardID1;

	public uint m_AwardNum1;

	public uint m_AwardMaxNum1;

	public bool m_IsAward1Special;

	public uint m_AwardTime1;

	public uint m_AwardType2;

	public uint m_AwardID2;

	public uint m_AwardNum2;

	public uint m_AwardMaxNum2;

	public bool m_IsAward2Special;

	public uint m_AwardTime2;

	public uint m_AwardType3;

	public uint m_AwardID3;

	public uint m_AwardNum3;

	public uint m_AwardMaxNum3;

	public bool m_IsAward3Special;

	public uint m_AwardTime3;

	public List<AwardDesc> m_AwardList;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	private void BuildRewardList()
	{
	}

	public bool CheckItemIsSpecialReward(uint itemId)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
