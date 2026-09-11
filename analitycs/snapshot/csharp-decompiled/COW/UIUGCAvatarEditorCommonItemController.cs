using System;
using GCommon;
using ReactUI;

namespace COW;

internal class UIUGCAvatarEditorCommonItemController : UIBindItemListItemController
{
	private UIVariable var_ID;

	private UIVariable var_FFBaseItemInfo;

	private UIVariable var_QualityBG;

	private UIVariable var_QualityColoredBG;

	private UIVariable var_QualityPlus;

	private UIVariable var_OrangeQualityPlus;

	private UIVariable var_Icon;

	private UIVariable var_UseSelfIcon;

	private UIVariable var_IsEmpty;

	private UIVariable var_IsDisableQuality;

	private UIVariable var_Name;

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

	private void setQulityIcon(bool enable)
	{
	}

	private void setWeaponIcon(UIModelUGCResourceSelect.AvatarEditorItemData item)
	{
	}

	private void setAnimationState(UIModelUGCResourceSelect.AvatarEditorItemData item)
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
