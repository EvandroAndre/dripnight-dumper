using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudVerticleViewTeamScoreBoardController : UIBaseController
{
	private UIHudVerticleViewTeamScoreBoardView m_View;

	private GIFGAGAGFLA m_Game;

	private float m_CountDownTime;

	private bool m_IsCountDownStart;

	private bool m_NeedToRefreshGrid;

	private Dictionary<BHGGAEEHJCO, UIHudVerticleViewTeamScoreBoardItemController> m_ItemCtrlDic;

	private List<UIHudVerticleViewTeamScoreBoardItemController> m_LeftItemList;

	private List<UIHudVerticleViewTeamScoreBoardItemController> m_RightItemList;

	private bool m_EnableReport;

	private Dictionary<BHGGAEEHJCO, UIHudVerticleViewTeamScoreBoardItemController> ItemCtrlList => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void Update()
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	protected override void OnDestroy()
	{
	}

	private void ClosePage()
	{
	}

	private void OnClickNextBtn()
	{
	}

	private void OnClickReportBtn()
	{
	}

	public UIHudVerticleViewTeamScoreBoardItemController InitOneItem(Transform parent)
	{
		return null;
	}

	public void OnAddPlayer(GEvent param)
	{
	}

	public override void Show()
	{
	}

	private bool IsTeamOnLeft(BHGGAEEHJCO pId)
	{
		return false;
	}

	public void OnMatchEnd()
	{
	}

	public void OnPlayerQuit(object[] param)
	{
	}

	public void RefreshGrid()
	{
	}

	private int SortPlayerDataByTeamIndex(Transform tr1, Transform tr2)
	{
		return 0;
	}

	private int SortPlayerData(Transform tr1, Transform tr2)
	{
		return 0;
	}

	public void UpdateLeftScore(int leftScore)
	{
	}

	public void UpdateRightScore(int rightScore)
	{
	}

	private void UpdateAllTitle()
	{
	}

	public void UpdateTeamInfo(Player player, bool isUpdateLeft)
	{
	}

	private void OnPlayerRoleChanged(object[] param)
	{
	}

	private void OnPlayerMatchInfoChange(object[] param)
	{
	}

	private void RefreshItemDataByPlayerID(VerticleViewPlayer player)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
