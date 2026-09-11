using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIWorkShopMapInfoDetailController : UIBaseController
{
	private UIWorkShopMapInfoDetailView m_View;

	private List<UIWorkshopMapItemController> m_WorkShopMapItems;

	private int m_LastSelectedIndex;

	private uint m_AutoScrollDelayCallID;

	private UIWorkshopMapItemController m_GameMapItemCache;

	private UIWorkshopMapItemController m_CdnMapItemCache;

	private int m_CurActiveItemCnt;

	private int m_RealItemCnt;

	private List<UISprite> m_LightDot;

	private bool m_CallBackInvokeAlways;

	private string gopos_value;

	private string sub_gopos;

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

	public void InitData(SceneEditSlotInfo info, string cdnUrl, string defaultUrl, int width, int height, string shareCode, Action itemClickCallBack = null, byte[] customCover = null, bool clickCallBackAlways = true, bool requestGoPosInfo = true)
	{
	}

	private void RequestGoPosInfo(string shareCode)
	{
	}

	private void Reset()
	{
	}

	private void OnAutoScrollAdItem()
	{
	}

	private void GetCenterItem(GameObject centerGo)
	{
	}

	private void RefreshDot()
	{
	}

	private void OnScrollViewDrag()
	{
	}

	private void OnContentCick()
	{
	}

	public int GetScrollViewPanelDepth()
	{
		return 0;
	}

	public void SetScrollViewDepth(int depth)
	{
	}

	public void SetScrollContentSize(int width, int height)
	{
	}

	public void SetDotInBottomRight(GameObject trans)
	{
	}

	private void _003CRequestGoPosInfo_003Eb__16_0(WorkShopVideoInfo data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
