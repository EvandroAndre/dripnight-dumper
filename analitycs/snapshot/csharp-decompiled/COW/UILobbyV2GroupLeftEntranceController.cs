using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2GroupLeftEntranceController : UIBaseController
{
	private UILobbyV2GroupLeftEntranceView m_View;

	private UILobbyV2Controller m_ParentCtrl;

	private UIModelUser m_ModelUser;

	private string m_EventsIconDefaultName;

	private UITipsNormalController m_TeamBPTipsCtrl;

	private UITipsNormalController m_TeamStoreTipsCtrl;

	private UITipsNormalController m_TeamGachaTipsCtrl;

	private UITipsNormalController m_TeamMissionTipsCtrl;

	private UITipsNormalController m_TeamEventTipsCtrl;

	private UITipsNormalController m_TeamDrawShopTipsCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InjectComponentsFromView()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public void RefreshStoreView()
	{
	}

	public void RefreshGachaView()
	{
	}

	public void RefreshDrawShopView()
	{
	}

	public void RefreshBooyahPassView()
	{
	}

	public void RefreshEventsView(string iconStr, bool needShowVeteranIcon)
	{
	}

	public void RefreshMissionView()
	{
	}

	private void UpdateLevelEntrance(uint entranceType)
	{
	}

	public void InitTeamTipsCtrl(ETipsType type, int num)
	{
	}

	public void RefreshLobbyBPRedTips()
	{
	}

	private void InitTipsCtrl(ref UITipsNormalController ctrl, Transform trans, TipsIconType iconType, ETipsType eTipsType = ETipsType.None)
	{
	}

	private void OnStoreBtnClick()
	{
	}

	private void OnGachaBtnClick()
	{
	}

	private void OnDrawShopBtnClick()
	{
	}

	private void OnEventsBtnClick()
	{
	}

	private void OnMissionBtnClick()
	{
	}

	private void OnBooyahPassBtnClick()
	{
	}

	private void OnBtnClickLog(string log)
	{
	}

	private void OnLeftBtnAndEntranceRepositon()
	{
	}

	public void RefreshUnlockVFXEntrance(List<LevelEntranceData> list)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
