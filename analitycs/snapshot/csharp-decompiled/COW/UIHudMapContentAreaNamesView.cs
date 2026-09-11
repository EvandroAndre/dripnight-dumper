using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class UIHudMapContentAreaNamesView : MonoBehaviour
{
	private List<MapContentAreaNameItem> AreaNameItems;

	private uint? m_ZoneTimeSpan;

	private int? m_ZoneStageID;

	private Vector3? m_SafeZoneCenter;

	private float? m_SafeZoneRadius;

	private bool? m_ShowingRectSafeZone;

	private float? m_SafeZoneLength;

	private float? m_SafeZoneWidth;

	private Vector3? m_SafeZoneForward;

	private Vector4? m_MapOffset;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private bool m_AllowDisplayInfo;

	private uint m_POIDisplayInfoHideDelayCallID;

	public void Init(UIMapUtil.MapOffsetContext ctx)
	{
	}

	private void OnDestroy()
	{
	}

	public void SetAllowPOIDisplayInfo(bool allowDisplayInfo)
	{
	}

	public void RefreshPOIDisplayInfo()
	{
	}

	public bool CanShowPOIDisplayInfo()
	{
		return false;
	}

	private void TryStartPOIDisplayInfoHideDelayCall()
	{
	}

	private void CancelPOIDisplayInfoHideDelayCall()
	{
	}

	private void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public Vector3 MapLocalPositionToWorldPosition(Vector3 mapLocalPosition)
	{
		return default(Vector3);
	}

	public void SetFontColorBySafeZone(SafeZone safeZone)
	{
	}
}
