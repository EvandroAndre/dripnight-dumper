using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudMetropolisInGameShopController : UIHudCSShopController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<uint> _003C_003E9__13_0;

		internal int _003CRebuildUIElement_003Eb__13_0(uint x, uint y)
		{
			return 0;
		}
	}

	private bool m_ShopItemInited;

	private BGMFPPDLCBB m_ChoosedItemInfo;

	private int m_CurBagCapacity;

	private int m_MaxBagCapacity;

	private GIBKFCLGNBJ m_CurrentShopID;

	private bool m_HasSetUIData;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void ShowByShopID(GIBKFCLGNBJ shopID)
	{
	}

	protected override void SetUIData()
	{
	}

	protected override void ResetShopItems()
	{
	}

	protected override void RefreshUIData(bool isPurchaseRefresh = false)
	{
	}

	protected override bool OnCheckItemCanPurchase(Player player, CSShopItemData item, HENEHAGJCLI itemData)
	{
		return false;
	}

	protected override UIHudCSEquipCategoryController CreateCategory(Transform container)
	{
		return null;
	}

	private void RebuildUIElement(Dictionary<uint, List<CSShopItemData>> itemMap)
	{
	}

	public void _003C_003EiFixBaseProxy_SetUIData()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetShopItems()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshUIData(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_OnCheckItemCanPurchase(Player P0, CSShopItemData P1, HENEHAGJCLI P2)
	{
		return false;
	}

	public UIHudCSEquipCategoryController _003C_003EiFixBaseProxy_CreateCategory(Transform P0)
	{
		return null;
	}
}
