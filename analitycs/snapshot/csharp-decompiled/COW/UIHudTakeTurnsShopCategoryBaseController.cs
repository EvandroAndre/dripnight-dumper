using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudTakeTurnsShopCategoryBaseController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<uint> _003C_003E9__26_0;

		internal int _003CSetMysteryBoxUI_003Eb__26_0(uint a, uint b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public List<uint> qualityList;

		public int i;

		public Predicate<CSShopItemData> _003C_003E9__1;

		internal bool _003CSetMysteryBoxUI_003Eb__1(CSShopItemData item)
		{
			return false;
		}
	}

	private UIHudTakeTurnsShopCategoryBaseView m_View;

	private UIHudTakeTurnsShopItemBaseController m_FirstItem;

	private uint m_Filter;

	private List<CSShopItemData> m_MysteryBoxItemDataList;

	private List<UIHudTakeTurnsShopItemBaseController> m_ChildMysteryBoxController;

	private List<UIToggleButton> m_ToggleList;

	private bool m_UIDirty;

	private uint m_TopQuality;

	private Dictionary<uint, UIHudTakeTurnsShopItemBaseController> m_itemMap;

	private Color m_CategoryIconColorDefault;

	private int m_CategoryIconWidthDefault;

	private string m_CategoryIconDefault;

	public UIHudTakeTurnsShopItemBaseController FirstItem => null;

	public uint Filter()
	{
		return 0u;
	}

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

	private void RecordDefaultSkin()
	{
	}

	public bool IsQuickBuyItem(CSShopItemData item)
	{
		return false;
	}

	public void SetUIData(uint filter, List<CSShopItemData> itemList)
	{
	}

	public void RefreshUIData(uint filter, List<CSShopItemData> itemList, bool isPurchaseRefresh = false)
	{
	}

	protected virtual UIHudTakeTurnsShopItemBaseController CreateItem(Transform container)
	{
		return null;
	}

	private void SetFilterLabel(uint filter)
	{
	}

	private void SetSkin(bool resetToDefault = false)
	{
	}

	public void SetBombUIData(uint filter, List<TDMLikeShopConfigData> dataList)
	{
	}

	private bool SetMysteryBoxUI()
	{
		return false;
	}

	public bool UpdateMysteryBoxUI()
	{
		return false;
	}

	public Dictionary<uint, UIHudTakeTurnsShopItemBaseController> GetItemCtrlMap()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
