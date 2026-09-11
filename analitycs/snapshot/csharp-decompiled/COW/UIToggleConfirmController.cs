using GCommon;
using UnityEngine;

namespace COW;

public class UIToggleConfirmController : UIPopupWindowController, IEasyList
{
	protected UIToggleConfirmView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RepositionBtnGroup(bool showConfirm, bool showCancel)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	protected virtual void OnConfirmBtn()
	{
	}

	protected virtual void OnCancelBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
