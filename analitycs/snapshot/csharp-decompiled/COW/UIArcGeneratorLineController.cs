using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIArcGeneratorLineController : UIBaseController
{
	public int CurGroupId;

	private BezierSlide m_Slide;

	private UIArcGeneratorLineView m_View;

	private UIMapBaseController m_MapBaseCtrl;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private float DefaultDetectionWidth;

	private float DefaultGrowWidth;

	private float DefaultDarkWidth;

	private List<GameObject> m_StationUIs;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	private bool CheckLocalPlayerOn()
	{
		return false;
	}

	public void SetData(int groupId, BezierSlide slide, UIMapBaseController mapBaseCtrl, UIMapUtil.MapOffsetContext ctx)
	{
	}

	private void OnEnable()
	{
	}

	private void RefreshLine()
	{
	}

	private void RefreshScan()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
