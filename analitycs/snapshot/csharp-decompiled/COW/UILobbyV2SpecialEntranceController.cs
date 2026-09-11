using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILobbyV2SpecialEntranceController : UIBaseController
{
	private UILobbyV2SpecialEntranceView m_View;

	private UIModelCDNAd m_ModelCDN;

	private AdvertDesc m_SpeicalCDN;

	private UIModelRelayMart m_ModelRelayMart;

	private UITipsNormalController m_TipsCtrl;

	private ResourceID m_VFXResId;

	private GameObject m_VFXObj;

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

	public void RefreshData(AdvertDesc data)
	{
	}

	public void ResetTipsContainer(bool isShow)
	{
	}

	private void OnSpecialEntranceBtnClick()
	{
	}

	private void RefreshCountdownLabel()
	{
	}

	private void InitTipsView()
	{
	}

	private void RefreshVFX()
	{
	}

	private void InstantVFXObj()
	{
	}

	private void DestroyVFXObj()
	{
	}

	private EV2NavigationPageType GetSpecialEntranceType()
	{
		return EV2NavigationPageType.None;
	}

	private bool IsRelayMartSpecialEntrance()
	{
		return false;
	}

	private void _003CRefreshCountdownLabel_003Eb__13_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
