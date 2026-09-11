using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudLoadoutSupportController : UIBaseController
{
	private UIHudLoadoutSupportView m_View;

	private List<UIHudLoadoutSupportBuffItemController> m_BuffItemControllerList;

	private List<UIHudLoadoutSupportBuffSlotController> m_BuffSlotControllerList;

	private int m_CurChooseSlotIndex;

	private uint m_CurChooseBuffDataID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private void SetRightInputCheckUpperPanel(bool b)
	{
	}

	private void InitBuffItems()
	{
	}

	private void InitBuffSlots()
	{
	}

	private void OnLoadoutSupportSlotStateAllModified(uint playerID)
	{
	}

	private void OnLoadoutSupportSlotCacheBuffChanged(uint slotIndex)
	{
	}

	private void OnTokenChanged(int data)
	{
	}

	private void RefreshLabelBuffDesc(uint buffDataId)
	{
	}

	private void DoAutoChooseDefaultSlot()
	{
	}

	public void DoAutoChooseNextSlot()
	{
	}

	public void OnChooseSlot(int slotIndex)
	{
	}

	public void OnChooseBuffItem(uint buffDataId, bool needModifyCache = true)
	{
	}

	private void OnLoadoutSupportForceFinish()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	public bool IsBuffTeammateActivationState(uint buffDataID)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
