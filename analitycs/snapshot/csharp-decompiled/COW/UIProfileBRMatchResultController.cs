using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileBRMatchResultController : UIProfileBaseMatchResultController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<TeammateStats, FriendInfo> _003C_003E9__23_0;

		internal FriendInfo _003COnFastGiftClick_003Eb__23_0(TeammateStats teamMate)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public ulong accountID;

		internal bool _003COnReportCheatSent_003Eb__0(CandidateReporteeData e)
		{
			return false;
		}
	}

	protected UIProfileBRMatchResultView m_View;

	private List<UIProfileNormalMatchResultItemController> m_ItemCtrlList;

	private Dictionary<ulong, ExtraPlayerDataForMatchResult> m_PlayerMatchResultDataMap;

	private MatchStats m_MatchStats;

	protected ulong m_MatchID;

	private bool m_SHowFastGift;

	private CandidateReporteeData m_DefaultReportee;

	private List<CandidateReporteeData> m_ReporteeList;

	private UIHudAvatarAttributeBoxController m_AttributeBox;

	protected List<UIProfileNormalMatchResultItemController> ItemCtrlList => null;

	protected Dictionary<ulong, ExtraPlayerDataForMatchResult> PlayerMatchResultDataMap => null;

	protected virtual int[] GetInfoTypes(int type)
	{
		return null;
	}

	protected override int[] GetInfoTypesData()
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitTypeList(MatchStats stats)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	private void OnClickDataBtn()
	{
	}

	private void OnClickReportBtn()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnNextBtnClick()
	{
	}

	private void OnFastGiftClick()
	{
	}

	private bool GetDataBtnVisibility()
	{
		return false;
	}

	protected override void OnChangePageType()
	{
	}

	protected void UpdateDataBtnStatus()
	{
	}

	protected override void UpdateInfoTitles()
	{
	}

	private Transform GetItemTransform(int index)
	{
		return null;
	}

	protected virtual int SortTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	protected virtual UIProfileNormalMatchResultItemController BuildChildController(Transform parent)
	{
		return null;
	}

	private void UpdatePlayerListInfo(List<TeammateStats> players)
	{
	}

	private void SendShareBtnClickLog()
	{
	}

	private TeammateStats ConstructSelfTeammateData(MatchStats stats)
	{
		return null;
	}

	protected ExtraPlayerDataForMatchResult GetPlayerMatchResultData(ulong accountID)
	{
		return null;
	}

	private void CreatePlayerMatchResultData(ulong accountID, ulong localPlayerID, bool isFriend = false)
	{
	}

	private void ConstructPlayerMatchResultInfo(MatchStats stats)
	{
	}

	private void OnReportCheatSent(object[] param)
	{
	}

	private void ShowAvatarAttributeBox(List<uint> showAttributes)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int[] _003C_003EiFixBaseProxy_GetInfoTypesData()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnChangePageType()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateInfoTitles()
	{
	}
}
