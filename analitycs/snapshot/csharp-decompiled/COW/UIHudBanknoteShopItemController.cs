using System;
using GCommon;

namespace COW;

internal class UIHudBanknoteShopItemController : UIBaseController
{
	private UIHudInGameShopItemViewExt m_View;

	private bool m_Selected;

	public int m_Index;

	private Action<int> m_CallBack;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	public void SetUIData(uint itemID, int index, Action<int> callBack)
	{
	}

	private void OnItemBtnClick()
	{
	}

	public void SetSelected(bool v)
	{
	}

	public void UpdateUnLockState(bool isUnLock)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
