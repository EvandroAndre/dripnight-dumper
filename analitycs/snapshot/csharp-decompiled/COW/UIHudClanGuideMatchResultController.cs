using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudClanGuideMatchResultController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<TeammateStats, FriendInfo> _003C_003E9__27_0;

		internal FriendInfo _003COnSendGiftBtnClick_003Eb__27_0(TeammateStats teamMate)
		{
			return null;
		}
	}

	private UIHudClanGuideMatchResultView m_View;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIModelMatch m_ModelMatch;

	private LeaderBoardInfo m_BoardInfoBeforeMatchResult;

	private bool m_PlyerEffectClanRank;

	private MatchStats m_MatchStats;

	private MatchIncome m_MatchIncome;

	private LeaderBoardInfo m_CurLeaderBoardInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void RefreshNormalNode()
	{
	}

	private BriefClanInfo GetMyTeamBriefClanInfo(MatchStats stats)
	{
		return null;
	}

	private BriefClanInfo GetOpTeamBriefClanInfo(MatchStats stats)
	{
		return null;
	}

	private void RefreshBeAceClanNode()
	{
	}

	public void SetViewData(MatchStats matchStats, MatchIncome matchIncome)
	{
	}

	private void GetClanLeaderBoardInfo()
	{
	}

	private void RefreshRankPoint(uint matchMode)
	{
	}

	private void RefreshRankNode(object[] data)
	{
	}

	private void OnShareBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnQuestionBtnClick()
	{
	}

	private void OnSendGiftBtnClick()
	{
	}

	private void OnNextBtnClick()
	{
	}

	private void OnDataPageBtnClick()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private bool _003CSetViewData_003Eb__19_0(GuildWarPointParamDesc x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
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
