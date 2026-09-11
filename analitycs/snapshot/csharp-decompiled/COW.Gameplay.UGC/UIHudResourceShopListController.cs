using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UIHudResourceShopListController : UIPopupWindowController, IEasyList
{
	private UIHudResourceShopListView m_View;

	private ResourceShopRecommendationData m_Data;

	private readonly List<UGCResourceShopItem> m_Items;

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

	public void SetData(ResourceShopRecommendationData data)
	{
	}

	private void RefreshItems(List<UGCResourceShopItem> sourceItems)
	{
	}

	private void CheckExposure()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
