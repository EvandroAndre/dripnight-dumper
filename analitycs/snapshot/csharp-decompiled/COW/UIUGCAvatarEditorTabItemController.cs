using System;
using GCommon;
using ReactUI;

namespace COW;

internal class UIUGCAvatarEditorTabItemController : UIBindItemListItemController
{
	private UIVariable var_TabID;

	private UIVariable var_TabName;

	private UIVariable var_TabIcon;

	private UIVariable var_ChildItemCount;

	private UIVariable var_IsEnable;

	protected Type mBaseType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
