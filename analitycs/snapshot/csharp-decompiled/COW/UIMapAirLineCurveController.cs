using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIMapAirLineCurveController : UIBaseController
{
	private const int MAX_STEP_NUM = 40;

	private const float MAX_TEXTURE_SCALE = 8f;

	private UIMapAirLineCurveView m_View;

	private Vector2 m_TexScale;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void InitAirLineParam(UIMapUtil.EMapType mapType, AirtransportParams airline, UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void ShowAircraftAndResidueAirLine()
	{
	}

	public void CloseAircraftAndResidueAirLine()
	{
	}

	public void UpdateResidueAirLine(AirtransportParams airline, float ratio)
	{
	}

	public void RefreshAirLineAlpha(bool isOnBoard)
	{
	}

	public Vector2 GetCurveAirlineMapPositionByRatio(float yParam, float ratio, float length)
	{
		return default(Vector2);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
