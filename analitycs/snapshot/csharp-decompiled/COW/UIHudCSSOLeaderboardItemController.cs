using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudCSSOLeaderboardItemController : UIBaseController
{
	private UIHudCSSOLeaderboardItemView m_View;

	private UIModelMatch m_ModelMatch;

	private byte m_TeamID;

	private byte m_LastRoundTeamID;

	private List<UILabel> m_NameList;

	private List<UILabel> m_KillNumList;

	private int m_Index;

	private uint m_DelayCallID;

	private uint m_AnimDelayCallID;

	private bool m_ShowNormalMatch;

	private bool m_ShowSpecialMatch;

	private Color m_BGBaseColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetDataInfo(byte lastRoundTeamID, byte teamID, int index)
	{
	}

	public void SetDataInfo(byte teamID, int index)
	{
	}

	public void SetMatchInfo(bool showNormalMatch, bool showSpecialMatch, bool showImmediately = false)
	{
	}

	private void RefreshPlayersInfo(byte teamID)
	{
	}

	private string PlayerKDAString(HKKMLEMBAGG killInfo)
	{
		return null;
	}

	private void RefreshBattleResult()
	{
	}

	private void HideBattleResult()
	{
	}

	private void PlayAnim()
	{
	}

	private void OnAnimFinish()
	{
	}

	private void RefreshRankChange()
	{
	}

	private void RefreshEliminateState(byte teamID)
	{
	}

	private bool IsLastRoundEliminate(byte teamID)
	{
		return false;
	}

	private void RefreshTeamInfoView(byte teamID)
	{
	}

	private void RefreshIndex()
	{
	}

	private void RefreshMatchInfo()
	{
	}

	private void RefreshBGColor(byte teamID)
	{
	}

	private void RefreshTeamName(byte teamID)
	{
	}

	private void _003CSetDataInfo_003Eb__15_0()
	{
	}

	private void _003CPlayAnim_003Eb__22_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
