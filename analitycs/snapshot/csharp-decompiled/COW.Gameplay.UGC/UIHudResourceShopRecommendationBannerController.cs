using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW.Gameplay.UGC;

public class UIHudResourceShopRecommendationBannerController : UIBaseController, UITable2.IUITable2Item
{
	private class BannerItem
	{
		public int Index;

		public UIHudResourceShopRecommendationBannerItemController Controller;

		public GameObject DotGo;

		public UISprite DotSprite;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopEditorChoiceDesc> _003C_003E9__7_0;

		internal int _003CRefreshBanner_003Eb__7_0(WorkshopEditorChoiceDesc a, WorkshopEditorChoiceDesc b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public int nextIndex;

		internal bool _003CUpdate_003Eb__0(BannerItem e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public GameObject centerGo;

		internal bool _003COnCenterChild_003Eb__0(BannerItem e)
		{
			return false;
		}
	}

	private UIHudResourceShopRecommendationBannerView m_View;

	private readonly List<BannerItem> m_CachedItems;

	private int m_CurItemIndex;

	private float m_TimeElapsed;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshBanner(List<WorkshopEditorChoiceDesc> dataList)
	{
	}

	private void ClearItems()
	{
	}

	private void OnCenterChild(GameObject centerGo)
	{
	}

	private void RefreshDot()
	{
	}

	private void Update()
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
