using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UIHudResourceShopSubCategoryController : IEasyList
{
	private UIHudResourceShopController m_MainController;

	private UIEasyList m_EasyList;

	private UIScrollView m_ScrollView;

	public UIHudResourceShopSubCategoryController(UIHudResourceShopController mainController, UIHudResourceShopView mainView)
	{
	}

	public void RefreshItems(List<ResourceShopSubCategoryItem> dataList)
	{
	}

	public void SelectAll()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}
}
