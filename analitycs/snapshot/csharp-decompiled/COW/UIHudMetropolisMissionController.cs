using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudMetropolisMissionController : UIBaseController, IEasyList
{
	private UIHudMetropolisMissionView m_View;

	private AFBOKKIDEAB m_CurSelectedFactionID;

	private bool m_IsNeedToRefreshMission;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnMetropolisAreaTrack()
	{
	}

	private void RefreshMissionListByFactionId(AFBOKKIDEAB factionID = AFBOKKIDEAB.EMetropolisFaction_None)
	{
	}

	private void OnClickPoliceBtn()
	{
	}

	private void OnClickCriminalBtn()
	{
	}

	private void OnClickPrisonerBtn()
	{
	}

	private void OnRefreshMissionList()
	{
	}

	private void OnLocalPlayerFactionChange(object[] data)
	{
	}

	private void OnUpdateBonus()
	{
	}

	private void RefreshBonusInfo()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void RefreshTabInfo(AFBOKKIDEAB faction)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
