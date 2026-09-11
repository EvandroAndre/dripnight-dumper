using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardAdsController : UIBaseController
{
	public enum EDotPosType
	{
		OnCdn,
		BelowCdn,
		BelowCdnXY
	}

	protected UIStandardAdsView m_View;

	protected UICenterOnChild m_wrapCenter;

	protected List<UILobbyDotController> m_DotCtrls;

	protected List<UIStandardAdsItemController> m_AdItems;

	protected int m_LastSelectedIndex;

	protected List<UIModelLobbyAds.AdInfo> m_AdInfoList;

	protected uint m_AutoScrollDelayCallID;

	protected UIDragScrollView m_Drag;

	protected UINavigationUtil.UINavigationFrom m_NavType;

	protected bool m_NeedGopos;

	protected Action<int> m_CenterOnCallBack;

	protected const int DefaultDotWidth = 20;

	protected const int DefaultDotHeight = 5;

	protected const int DotsOnCdnPosY = -220;

	protected int m_DotsBelowCdnPosY;

	protected int m_Width;

	protected int m_Heidth;

	protected float m_ScrollTime;

	protected bool m_IsAutoScrollView;

	protected bool m_IsDragStopAutoScroll;

	protected AdsLogEventType m_AdsLogEventType;

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

	public void UpdatePanelDepth(int newDepth)
	{
	}

	public void UpdateDragContentDepth(int newDepth)
	{
	}

	public void SetAutoScroll(bool isAutoScroll, float scrollTime, bool IsDragStopAutoScroll = false)
	{
	}

	public void OnDragStarted()
	{
	}

	public void OnDragFinished()
	{
	}

	public int GetLastSelectedIndex()
	{
		return 0;
	}

	public void ScrollTo(int index)
	{
	}

	public void InitSize(int width, int height, bool autoResizeBoxCollider = true)
	{
	}

	public void SetContentView(int width, int height, int posY, int dotPosY, int contentWidth, int contentHeight, int adsWidth, int adsHeight)
	{
	}

	public void SetViewData(List<UIModelLobbyAds.AdInfo> adInfoList, UINavigationUtil.UINavigationFrom newNavType, int dotWidth = 20, int dotHeight = 5, EDotPosType dotPosType = EDotPosType.OnCdn, int dosOffsetPosY = 0, bool reuseItem = true, StandaddAdsItemType type = StandaddAdsItemType.Normal)
	{
	}

	public void SetGridValue(int cellWidth, int cellHeight, UIWidget.Pivot pivot = UIWidget.Pivot.Center)
	{
	}

	protected void OnAutoScrollAdItem()
	{
	}

	public List<UIStandardAdsItemController> GetAdsItem()
	{
		return null;
	}

	public void SetCenterOnCallBack(Action<int> callback)
	{
	}

	private void GetCenterItem(GameObject centerGo)
	{
	}

	private void onAdsClicked()
	{
	}

	public void SetDotSpriteType(UIBasicSprite.Type type)
	{
	}

	public void SetDotSprite(string enableName, string disableName, bool makePixelPerfect = true)
	{
	}

	public void SetDotLocalPosition(Vector3 pos)
	{
	}

	public void ShowDots(bool isShow)
	{
	}

	public void ShowDotEnableBG(bool isShow)
	{
	}

	public void SetDotColor(Color enableColor, Color disableColor)
	{
	}

	public void SetAdsLogEventType(AdsLogEventType type)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
