using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHistoryRecordItemController : UIEasyListItemController
{
	private float StreakRatingAutoScrollTime;

	private UIHistoryRecordItemView m_View;

	private MatchRecordPersonal m_RecordData;

	private MobileReplayInfo m_ReplayData;

	private UIModelMatch m_ModelMatch;

	private UICenterOnChild m_StreakRatingCenter;

	private UIPanel m_StreakRatingPanel;

	private List<Transform> m_StreakRatingItems;

	private uint m_StreakRatingAutoScrollDelayCallID;

	private int m_LastStreakRatingIndex;

	private const string FIRST_STRING = "TXT_OB5_HISTORY_NO1";

	private const string TOP3_STRING = "TXT_OB5_HISTORY_TOP3";

	private const string TOP5_STRING = "TXT_OB5_HISTORY_TOP5";

	private const string TOP10_STRING = "TXT_OB5_HISTORY_TOP10";

	private const string Win_String = "T_26_YP_HISTORY_WIN";

	private const string Lose_string = "T_26_YP_HISTORY_LOSE";

	private const string Draw_String = "T_32_M_WS_PEACE";

	private const uint FIRST_COLOR = 4294949376u;

	private const uint HIGHRANK_COLOR = uint.MaxValue;

	public const string POSITIVE_DELTA_COLOR = "[62ffe3]";

	public const string NEGATIVE_DELTA_COLOR = "[ff2a00]";

	private Color colorbg1;

	private Color colorbg2;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnBRScoreDetailBtnClick()
	{
	}

	private bool IsMatchInfo4v4(MatchRecordPersonal data)
	{
		return false;
	}

	private ulong GetMvpPlayerAccount(List<TeammateStats> players, uint mode, List<TeammateStats> opponents)
	{
		return 0uL;
	}

	private void ShowMvp(bool isGiveUp)
	{
	}

	private void RefreshRating()
	{
	}

	private void RefreshStreakRatingContainer()
	{
	}

	private void RefreshStreakRatingScroll()
	{
	}

	private void OnAutoScrollStreakRatingItem()
	{
	}

	private void CancelStreakRatingAutoScroll()
	{
	}

	private bool TryGetRatingInfo(MatchRecordPersonal data, out float ratingNum, out ERanking.RankingMedalType medalType)
	{
		ratingNum = default(float);
		medalType = default(ERanking.RankingMedalType);
		return false;
	}

	private ERanking.RankingMedalType GetRatingMedalTypeByValue(float ratingNum)
	{
		return ERanking.RankingMedalType.RankingMedalType_NONE;
	}

	private static uint GetMedalStreakCount(MatchRecordPersonal data, ERanking.RankingMedalType medalType)
	{
		return 0u;
	}

	private void UpdateDelta(MatchRecordPersonal data)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshStreak()
	{
	}

	private void SetGroupHeadCount(uint groupMode)
	{
	}

	private void RefreshReplayBtn()
	{
	}

	private void OnPlayClick()
	{
	}

	private void OnSaveClick()
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
