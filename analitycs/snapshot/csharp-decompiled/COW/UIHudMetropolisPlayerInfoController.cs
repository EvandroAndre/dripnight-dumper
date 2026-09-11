using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisPlayerInfoController : UIBaseController
{
	private UIHudMetropolisPlayerInfoView m_View;

	private FUIMetropolisPlayerDetailData m_DetailInfo;

	private List<UIHudMetropolisFactionStar> m_StarList;

	private List<UIHudMetropolisFactionStar> m_DetailStarList;

	private bool m_IsShowDetail;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnPressDetailInfo(GameObject go, bool value)
	{
	}

	private void OnClickSwitchFactionBtn()
	{
	}

	private void OnAddLocalPlayer(object[] data)
	{
	}

	private void OnJoinMatchFinished()
	{
	}

	private void OnShowChangeFaction(object[] data)
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private void OnCurCoinChanged(int data)
	{
	}

	private void OnMetroArrestChanged(object[] data)
	{
	}

	private void OnKillCountChanged(object[] data)
	{
	}

	protected void OnHypeLevelChange(object[] data)
	{
	}

	private void RefreshFactionInfo()
	{
	}

	private void RefreshLevelInfo()
	{
	}

	private void RefreshDetailInfo()
	{
	}

	private void UpdateDetailInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
