using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UIHudResourceShopRecommendationItemControllder : UIBaseController, UITable2.IUITable2Item
{
	private const int DisplayCount = 7;

	private UIHudResourceShopRecommendationItemView m_View;

	private ResourceShopRecommendationData m_Data;

	private readonly List<UIHudResourceShopItemController> m_CachedItemControllers;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetViewData(ResourceShopRecommendationData data)
	{
	}

	private void RefreshTitle()
	{
	}

	private void RefreshItems()
	{
	}

	private UIHudResourceShopItemController GetOrCreateItemController(int index)
	{
		return null;
	}

	private void OnMoreBtnClick()
	{
	}

	public void CheckExposure()
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
