using GCommon;
using UnityEngine;

namespace COW;

public class UIPopMenuSmallControlerForScrollPanel : UIPopMenuSmallControler
{
	public Transform ScrollViewRoot;

	private Transform mScrollViewUpContainerParent;

	private Transform mScrollViewDownContainerContainerParent;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void ShowPopUpItem()
	{
	}

	protected override void OnPopMenuClose()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowPopUpItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopMenuClose()
	{
	}
}
