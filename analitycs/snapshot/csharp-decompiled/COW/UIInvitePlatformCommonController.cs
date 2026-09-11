using GCommon;

namespace COW;

internal class UIInvitePlatformCommonController : UIPopupWindowController
{
	private UIUtils.ShareUrlType m_ShareUrlType;

	protected UIInvitePlatformCommonView m_View;

	private UIModelShare m_ModelShare;

	private object[] m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnLineClick()
	{
	}

	private void OnWhatsAppClick()
	{
	}

	private void OnInstagramClick()
	{
	}

	private void OnBindInviteClick()
	{
	}

	private void OnOtherClick()
	{
	}

	private void OnCopyLink()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
