using GCommon;
using message;

namespace COW;

public class UIHudLoadoutSupportBuffSlotController : UIBaseController
{
	private UIHudLoadoutSupportBuffSlotView m_View;

	private int m_Index;

	private uint m_BuffDataID;

	private ALOABDFBMHO m_CurState;

	private UIHudLoadoutSupportController m_ParentCtrl;

	private bool m_IsChoose;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public void InitData(int index)
	{
	}

	private void OnBtnChooseClick()
	{
	}

	public bool IsCanChoose()
	{
		return false;
	}

	public void SetChooseState(bool isChoose)
	{
	}

	private void OnBtnCancelClick()
	{
	}

	private void OnBtnUnlockClick()
	{
	}

	private void OnLoadoutSupportSlotStateAllModified(uint playerID)
	{
	}

	private void OnLoadoutSupportSlotCacheBuffChanged(uint slotIndex)
	{
	}

	private void OnPlayerMoneyChanged(int num)
	{
	}

	private void Refresh()
	{
	}

	private void RefreshState(ALOABDFBMHO eState)
	{
	}

	private void RefreshFilledState()
	{
	}

	private void RefreshCanUnLockedState()
	{
	}

	private bool CanUnlockSlot()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
