using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaIchisNoramlQualityBlockItemController : UIBaseController
{
	private UIGachaIchisNoramlQualityBlockItemView m_View;

	private UIGachaIchisQualityBlockItemBaseView m_BaseView;

	public const int DEFAULT_BG_WIDTH = 514;

	private ESharedGacha.RareType m_Tier;

	private List<IchisSortableGoodsData> m_Items;

	private bool m_IsSingleSSpecial;

	private bool m_HideQualityBadge;

	private int m_BgWidth;

	private uint m_ChestId;

	private uint m_ChestSubId;

	private UIPanel m_Panel;

	private List<UIGachaIchisNoramlShowItemController> m_ShowItemCtrls;

	private Transform[] m_Slots;

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

	public void SetBlockData(ESharedGacha.RareType tier, List<IchisSortableGoodsData> items, bool isSingleSSpecial, bool hideQualityBadge, int bgWidth)
	{
	}

	public void SetChestIds(uint chestId, uint chestSubId)
	{
	}

	public List<UIGachaIchisNoramlShowItemController> GetShowItemCtrls()
	{
		return null;
	}

	public void SetPanelDepth(int depth)
	{
	}

	private void RefreshBlockDisplay()
	{
	}

	private void RefreshBgWidth()
	{
	}

	private void RefreshQualityBadge()
	{
	}

	private void RefreshItemSlots()
	{
	}

	private int GetCenterStartSlot(int count)
	{
		return 0;
	}

	private void HideAllSlots()
	{
	}

	private void EnsureShowItemCount(int count)
	{
	}

	private static string GetTierBadgeSprite(ESharedGacha.RareType tier)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
