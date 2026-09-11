using System;
using GCommon;

namespace COW;

internal class UICommonCharacterGuideController : UIBaseController
{
	private UICommonCharacterGuideView m_View;

	private uint m_DelayCallId;

	private Action m_CloseAction;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetCloseAction(Action closeAction)
	{
	}

	private void OnBtnCloseClick()
	{
	}

	public void SetViewData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
