using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaIchis55QualityBlockItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIGachaIchis55QualityBlockItemView m_View;

	private UIGachaIchisQualityBlockItemBaseView m_BaseView;

	private IchisTableRowData m_RowData;

	private UIPanel m_Panel;

	private List<UIGachaIchis55ShowItemController> m_ShowItemCtrls;

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

	public void PlayCountRefreshReveal()
	{
	}

	private void RefreshDisplay()
	{
	}

	private void RefreshQualityBadge()
	{
	}

	private void RefreshItemSlots()
	{
	}

	private void HideAllSlots()
	{
	}

	private void HideAllShowItems()
	{
	}

	private void EnsureShowItemCount(int count)
	{
	}

	public void SetBlockPanelDepth(int depth)
	{
	}

	private void SetPanelDepth(int depth)
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
