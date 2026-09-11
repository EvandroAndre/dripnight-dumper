using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCameraTemplatePortraitPanelController : UIHudCameraTemplatePanelController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetDefaultTab()
	{
	}

	protected override void OnCloseBtnClick()
	{
	}

	public override void ResetAll()
	{
	}

	public void UnChooseAllItem()
	{
	}

	protected override UIHudCameraTemplateItemController GetItemCtrl(Transform transform)
	{
		return null;
	}

	protected override void SwitchTab(bool isPhoto)
	{
	}

	public void _003C_003EiFixBaseProxy_SetDefaultTab()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetAll()
	{
	}

	public UIHudCameraTemplateItemController _003C_003EiFixBaseProxy_GetItemCtrl(Transform P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SwitchTab(bool P0)
	{
	}
}
