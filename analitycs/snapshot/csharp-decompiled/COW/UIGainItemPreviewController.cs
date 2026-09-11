using GCommon;

namespace COW;

internal class UIGainItemPreviewController : UIPreviewNavigationController
{
	private uint m_previewItemId;

	private UIGainItemPreviewView m_View;

	private CSSharedItemData m_ItemData;

	private UIUtils.ScreenshotType m_CurrentScreenshotType;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnClose()
	{
	}

	private void RefreshUserInfo()
	{
	}

	private void UpdateHeadshot()
	{
	}

	private void UpdateHeadshot(uint iid)
	{
	}

	private void UpdateHeadshot(HeadPicData data)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnShowPreview(object[] para)
	{
	}

	private void SetRare()
	{
	}

	private void _ShowPreview()
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
