using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UIScoreDetailTipsController : UIPopupWindowController
{
	private readonly float UpPop_Offset_Y;

	private const string STREAK_LABEL_GOLD = "T_52_TSY_GOLD_MEDAL_STREAK";

	private const string STREAK_LABEL_SILVER = "T_52_TSY_SILVER_MEDAL_STREAK";

	private const string STEAK_TIMES_LABEL = "T_52_TSY_MEDAL_STREAK_COUNT";

	private UIScoreDetailTipsView m_View;

	private uint m_ItemCount;

	private int m_StreakContainerHeight;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetContentPos(Vector3 target)
	{
	}

	public void SetData(ModeStatsScoreUpdateNtf scoreData)
	{
	}

	private string GetPointNameByScoreKey(EModeStats.ScoreKey scoreKey)
	{
		return null;
	}

	public void SetData(MatchIncome income, uint rank)
	{
	}

	public void SetDataByCSPeak(MatchIncome income)
	{
	}

	private void RefreshStreakMedal(MatchIncome income)
	{
	}

	private void AddScoreItem(string name, string value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
