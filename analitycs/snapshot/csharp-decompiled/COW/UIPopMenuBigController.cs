using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIPopMenuBigController : UIPopMenuSmallControler
{
	private List<UIPopMenuItemBigController> m_UIPopMenuItemBigControllerList;

	public const int BIGCELLHEIGHT = 46;

	private new UIPopMenuBigView m_View;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void AdjustScrollView(bool changePosOnlyInFirstTime = false)
	{
	}

	public override void ShowPopUpItem()
	{
	}

	protected override void OnPopMenuClose()
	{
	}

	public void UpdateTitleAnchor(UIAnchor.Side tragetSide, int targetValue)
	{
	}

	public void UpdateArrUpAnchor(UIAnchor.Side tragetSide, int targetValue)
	{
	}

	public void UpdateArrDownAnchor(UIAnchor.Side tragetSide, int targetValue)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_AdjustScrollView(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowPopUpItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopMenuClose()
	{
	}
}
