using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaIchisNormalWholeRowItemController : UIBaseController, UITable2.IUITable2Item
{
	private class TierBlockGroup
	{
		public ESharedGacha.RareType tier;

		public List<IchisSortableGoodsData> items;
	}

	private UIGachaIchisNormalWholeRowItemView m_View;

	private UIGachaIchisWholeRowItemBaseView m_BaseView;

	private IchisTableRowData m_RowData;

	private List<UIGachaIchisNoramlQualityBlockItemController> m_BlockCtrls;

	private Transform[] m_Slots;

	private const float FULL_ROW_BG_WIDTH = 514f;

	private const float INTER_BLOCK_GAP = 5f;

	private const float SINGLE_ITEM_BONUS = 4f;

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

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void SetBlockPanelDepth(int depth)
	{
	}

	public void PlayCountRefreshReveal()
	{
	}

	private void RefreshRowDisplay()
	{
	}

	private void ComputeBlockLayout(List<TierBlockGroup> blockGroups, out int[] blockWidths, out float totalLayoutWidth)
	{
		blockWidths = null;
		totalLayoutWidth = default(float);
	}

	private List<TierBlockGroup> GroupItemsByTier(List<IchisSortableGoodsData> items)
	{
		return null;
	}

	private void HideAllSlots()
	{
	}

	private void EnsureBlockCount(int count)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
