using GCommon;
using UnityEngine;

namespace COW;

internal class UIGameSafeZoneChooseRangeController : UIBaseController
{
	private UIGameSafeZoneChooseRangeView m_View;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private Vector3 mSelectCenterPos;

	private float maxSelectDisSqr;

	private float showTipDisSqr;

	private float selectRaduis;

	private float lastTipsTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetRootVisible(bool visible)
	{
	}

	public void SetInitData(Vector3 basePos, float baseRadius, float selectRadius, float extend, UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void SetInput()
	{
	}

	public Vector3 AdjustChoosePos(ref Vector3 pos, Vector3 worldpos)
	{
		return default(Vector3);
	}

	public void SetPos(Vector3 pos)
	{
	}

	public UIWidget GetGuideWidget()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
