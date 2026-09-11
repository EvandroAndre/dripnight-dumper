using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILegendGachaAdsController : UIBaseController
{
	private uint m_GachaID;

	private UILegendGachaAdsView m_View;

	private UICenterOnChild m_wrapCenter;

	private List<UILobbyAdItemController> m_AdItems;

	private int m_LastSelectedIndex;

	private List<UIModelLobbyAds.AdInfo> m_AdInfoList;

	private Vector3 m_ScrollViewOriginalLocalPosition;

	private uint m_AutoScrollDelayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnLegendGachaAdClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void RefreshUIData(uint gachaID, List<AdvertDesc> advertList)
	{
	}

	private void OnAutoScrollAdItem()
	{
	}

	private void GetCenterItem(GameObject centerGo)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
