using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIProfileHistoryNodeController : UIBaseController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<MatchRecordPersonal> _003C_003E9__25_0;

		public static Predicate<MatchRecordPersonal> _003C_003E9__25_1;

		public static Predicate<TeammateStats> _003C_003E9__27_0;

		public static Comparison<MacthAchievementItem.ReplayFeedbackItemData> _003C_003E9__32_0;

		internal bool _003CShowHistoryRecord_003Eb__25_0(MatchRecordPersonal item)
		{
			return false;
		}

		internal bool _003CShowHistoryRecord_003Eb__25_1(MatchRecordPersonal item)
		{
			return false;
		}

		internal bool _003COnHistoryRecordClick_003Eb__27_0(TeammateStats x)
		{
			return false;
		}

		internal int _003CSetMatchAchievement_003Eb__32_0(MacthAchievementItem.ReplayFeedbackItemData a, MacthAchievementItem.ReplayFeedbackItemData b)
		{
			return 0;
		}
	}

	private MatchRecordPersonal m_MatchRecordData;

	private UIModelHuntingGround m_ModelHuntingGround;

	private UIModelProfile m_Model;

	private UIModelMatch m_ModelMatch;

	private UIProfileHistoryNodeView m_View;

	private MatchRecordPersonal m_MatchData;

	private List<uint> m_GameModeListShowKDRatio;

	private List<UIHistoryTeammateController> m_HistoryTeammate;

	private ulong m_UserAccountId;

	private ulong m_ClickReplayMatchID;

	private List<MacthAchievementItem> mlistMacthAchievementItems;

	private UIProfileController m_Profile;

	private UIProfileController Profile => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnHistoryDetailClick()
	{
	}

	private void OnRankRatingTipClick()
	{
	}

	private void OnHighlightBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public Transform GetLeftNode()
	{
		return null;
	}

	private void OnProfileNodeHistoryShare()
	{
	}

	private void SendShareBtnClickLog()
	{
	}

	public void ShowHistoryRecord()
	{
	}

	private void OnReplayRecordClick(object[] data)
	{
	}

	private void OnHistoryRecordClick(object[] data)
	{
	}

	private void SetUGCHistoryData(MatchRecordPersonal record)
	{
	}

	private void SetUGCCustomHistroyDataItem(UGCPlayerStats selfStats, MatchRecordPersonal matchRecordData)
	{
	}

	private void SetUGCHistoryDataItem(int index, UILabel label, UILabel value, int[] scoreType, int[] score, int ugcTemplateId)
	{
	}

	private void SetUGCHistoryTeammatesData(UGCMatchStats stats)
	{
	}

	private void SetMatchAchievement(MatchStats stats)
	{
	}

	private void RefreshHighLightSavedBtnState()
	{
	}

	private void OnHighlightSavedRefresh(object[] data)
	{
	}

	private void OnHighLightSavedBtnClick()
	{
	}

	private bool IsClanWar(uint matchMode, uint gameMode)
	{
		return false;
	}

	private bool ShowKDRatio(uint gameMode)
	{
		return false;
	}

	private void RefreshRatingMedalState(ERanking.RankingMedalType medalType)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private bool _003CShowHistoryRecord_003Eb__25_2(MatchRecordPersonal v)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
