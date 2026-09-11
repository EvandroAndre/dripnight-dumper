using GCommon;
using proto;

namespace COW;

public class UIHUDShareBannerController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHUDShareBannerView m_View;

	private UIModelSetting m_ModelSetting;

	private UIModelFriends m_ModelFriends;

	private UIModelCDNAd m_ModelCDNAd;

	private string m_ShareCode;

	private bool m_hasSendRequest;

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

	public void SetViewData(MessageInfo msgInfo)
	{
	}

	public void SetPanelDepth(int depth)
	{
	}

	private void InitHUDIcon()
	{
	}

	private void OnLinkClick()
	{
	}

	private void HandleUseHudSettingRes(CSUseHudSettingsShareCodeRes data)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
