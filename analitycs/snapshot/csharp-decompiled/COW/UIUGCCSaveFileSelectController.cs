using System;
using GCommon;
using proto;

namespace COW;

internal class UIUGCCSaveFileSelectController : UIPopupWindowController
{
	private UIUGCCSaveFileSelectView m_View;

	private uint m_SelecetedSlot;

	private EWorkshop.SlotType m_SelectedSlotType;

	private bool m_SelectedLocal;

	private Action<bool> m_OnApplyCallBack;

	private UIModelSceneEdit m_ModelSceneEdit;

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

	public void SetSelect(uint selected, Action<bool> action, EWorkshop.SlotType slotType = EWorkshop.SlotType.SlotType_AUTHOR)
	{
	}

	private void OnCloseUI(object[] data)
	{
	}

	private void OnBtnApplyClick()
	{
	}

	private void OnBtnPublishedClick()
	{
	}

	private void OnBtnLocalClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
