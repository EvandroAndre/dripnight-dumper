using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIBRMatchReviewEventItemController : UIBaseController
{
	private UIBRMatchReviewEventItemView m_View;

	private HJNFDCJPPDE m_EventData;

	private readonly List<UIWidget> m_AllWidgets;

	private readonly List<int> m_OriginalWidgetDepths;

	private const int MIN_WIDGET_DEPTH = 6;

	private const int PARACHUTE_ICON_SIZE = 38;

	private const float PARACHUTE_ICON_ALPHA = 0.6f;

	private const float PARACHUTE_ICON_OFFSET_Y = 10f;

	private int m_DefaultIconWidth;

	private int m_DefaultIconHeight;

	private Vector3 m_DefaultIconLocalPosition;

	private bool m_HasDefaultIconStyle;

	public NOOPBILFLIJ EventType => NOOPBILFLIJ.BRAnalysisEvent_ParachuteLand;

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

	public void SetData(HJNFDCJPPDE evt, Color teamColor)
	{
	}

	private static void ApplyEventIcon(UISprite target, HJNFDCJPPDE eventData)
	{
	}

	private static string GetEventSpriteName(HJNFDCJPPDE eventData)
	{
		return null;
	}

	private static string GetSpecialEventSpriteName(PHOPGMDJODO subType)
	{
		return null;
	}

	private void RefreshMapEventName(bool playAnim)
	{
	}

	public void PlayMapEventName(string locKey)
	{
	}

	public void HideMapEventName()
	{
	}

	private void RefreshMapEventName(string locKey, bool playAnim)
	{
	}

	public void SetKillMergeCount(int count)
	{
	}

	public void SetMapVisible(bool visible, bool playAnim)
	{
	}

	private static string GetMapEventNameLocKey(HJNFDCJPPDE evt)
	{
		return null;
	}

	private static int GetKillMergeCount(HJNFDCJPPDE evt)
	{
		return 0;
	}

	private static string GetSpecialEventMapNameLocKey(PHOPGMDJODO subType)
	{
		return null;
	}

	public void SetTransparent(bool transparent)
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public void SetLayerOrder(int order)
	{
	}

	private void RefreshIconOnlyMode(bool iconOnly)
	{
	}

	private static bool IsIconOnlyEvent(HJNFDCJPPDE evt)
	{
		return false;
	}

	private static bool IsParachuteLandEvent(HJNFDCJPPDE evt)
	{
		return false;
	}

	private void CacheAllWidgets()
	{
	}

	private void CacheDefaultIconStyle()
	{
	}

	private void RefreshParachuteIconStyle(bool isParachuteLand)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
