using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudInventoryExchangeController : UIBaseController
{
	public static uint CurrentExchangeDataID;

	private UIHudInventoryExchangeView m_View;

	private int m_ItemNum;

	private List<UIHudInventoryExchangeItem> m_ItemList;

	private List<NAELPAAELNO> m_AllItemTempList;

	private List<NAELPAAELNO> m_UselessItemList;

	private float m_ClickCD;

	private float m_AutoCloseCD;

	private UIClickMask m_ClickMask;

	private UIWidget m_MaskFullRegion;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ClosePanel()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void ClearPanelInfo()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void AddMask()
	{
	}

	private void RemoveMask()
	{
	}

	private void RefreshByPickUpSuccess(GEvent data)
	{
	}

	public bool IsLimitedPickUp(ICLMFONIIKB pickItem)
	{
		return false;
	}

	public void SetViewData(ICLMFONIIKB pickItem, bool checkClickCD, UIWidget maskFullRegion)
	{
	}

	private void RefreshExchangeItem(List<NAELPAAELNO> paramList, ICLMFONIIKB pickItem, int pickCapacity, bool isUselessItem)
	{
	}

	private int SortItemListByCapacity(NAELPAAELNO item1, NAELPAAELNO item2)
	{
		return 0;
	}

	private int SortItemListByCapacityEffectiveness(NAELPAAELNO x, NAELPAAELNO y)
	{
		return 0;
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
