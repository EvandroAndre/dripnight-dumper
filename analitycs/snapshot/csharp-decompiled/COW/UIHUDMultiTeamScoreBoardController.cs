using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDMultiTeamScoreBoardController<T> : UIBaseController where T : UIHUDMultiTeamScoreBoardTeamItemController
{
	private UIHUDMultiTeamLeaderboardView m_View;

	protected Dictionary<BHGGAEEHJCO, UIHUDMultiTeamScoreBoardPlayerItemController> m_ItemCtrlDic;

	private Dictionary<byte, T> m_TeamDict;

	private List<int> m_InfoTypeList;

	private bool m_EnableReport;

	private bool m_NeedSort;

	private JEFNJMJMAPF[] m_RankScoreDatas;

	private AMEEGELHGFG mGame;

	protected List<int> InfoTypeList => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public virtual void RegisterUIEvent()
	{
	}

	protected virtual void SetInfoType()
	{
	}

	private int SortTeamView(Transform tr1, Transform tr2)
	{
		return 0;
	}

	private void UpdateTitles()
	{
	}

	public virtual void RefreshGrid()
	{
	}

	protected void RefreshItemDataByPlayerID(BHGGAEEHJCO playerId, int intoType)
	{
	}

	private void Sort(BHGGAEEHJCO pId)
	{
	}

	private void OnClickReportBtn()
	{
	}

	private void ClosePage()
	{
	}

	public virtual void OnAddPlayer(GEvent data)
	{
	}

	protected virtual void AddTeamItem(byte teamId)
	{
	}

	protected virtual T GetTeamItem(byte teamIndex)
	{
		return null;
	}

	protected void AddTeammateItem(Player player)
	{
	}

	public virtual void OnPlayerQuit(object[] param)
	{
	}

	protected virtual void OnKillCountChanged(object[] param)
	{
	}

	protected virtual void OnDeadCountChanged(object[] param)
	{
	}

	protected virtual void OnAssistCountChanged(object[] param)
	{
	}

	protected virtual void OnTotalDamageChanged(object[] param)
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private int SortForRank(JEFNJMJMAPF a, JEFNJMJMAPF b)
	{
		return 0;
	}
}
