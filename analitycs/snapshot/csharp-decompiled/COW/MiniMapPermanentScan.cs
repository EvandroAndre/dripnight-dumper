using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class MiniMapPermanentScan
{
	private class ScanPoint
	{
		public UISprite Sprite;

		public TweenAlpha TweenAlpha;

		public Transform SpriteTrans;
	}

	private Transform m_MapContainer;

	private UISprite m_Point;

	private List<ScanPoint> m_ScanPoints;

	private float m_EndTime;

	private int m_PointCnt;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private CAJFIOIDPKC m_ScanData;

	public void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void OnUIInit(Transform container, UISprite point)
	{
	}

	public void OnUIDestroy()
	{
	}

	public void OnScan(GEvent data)
	{
	}

	private void ShowPoints()
	{
	}

	public void OnScanUpdate()
	{
	}
}
