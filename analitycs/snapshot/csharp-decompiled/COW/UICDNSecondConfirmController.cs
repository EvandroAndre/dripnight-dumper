using GCommon;

namespace COW;

public class UICDNSecondConfirmController : UIPopupWindowController
{
	private UICDNSecondConfirmView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(string contentKey, string titleKey = "", EventDelegate.Callback onConfirmClick = null)
	{
	}

	private void SetCDNTexture()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
