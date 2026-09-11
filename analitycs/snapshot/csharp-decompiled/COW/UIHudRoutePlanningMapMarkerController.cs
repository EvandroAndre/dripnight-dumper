using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRoutePlanningMapMarkerController : UIManagedMapContentIconController
{
	private const int m_PointingStateIconsMaxDepth = 44;

	private const int m_PointingStateBgMaxDepth = 43;

	private const int m_DotLineMaxDepth = 30;

	private const int m_TeamMemberPointingStateDepthOffset = 3;

	private const int m_TeamMemberDotLienDepthOffset = 1;

	private const float m_MinimapScaleFactor = 0.55f;

	private const float m_NotPassedMarkerAlpha = 1f;

	private const float m_PassedMarkerAlpha = 0.5f;

	private UIHudRoutePlanningMapMarkerView m_View;

	private UIHudRoutePlanningMapMarkerViewData m_ViewData;

	protected override void RestoreBeforeRecycled()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetLocalRotation(Quaternion localRotation)
	{
	}

	public override void SetLocalScale(Vector3 localScale)
	{
	}

	public override void SetViewData(object viewData)
	{
	}

	public bool IsReached()
	{
		return false;
	}

	public uint GetMarkerUUID()
	{
		return 0u;
	}

	public void SetAsWaypoint(UIHudRoutePlanningMapMarkerController target)
	{
	}

	public void SetAsEndpoint()
	{
	}

	public void SetReached(bool reached)
	{
	}

	public void UpdatePassedMarkerAlpha(UIHudRoutePlanningMapMarkerController nextMarker)
	{
	}

	private void UpdatePointingStateIconsWithState(ERoutePlanningMarkerState state)
	{
	}

	private void UpdatePassedMarkerAlphaInternal(UIHudRoutePlanningMapMarkerController nextMarker)
	{
	}

	private void SetPointingStateIconsColor(Color color)
	{
	}

	private void SetPointingStateIconsColorWithIndex(int teamIndex)
	{
	}

	private void SetDepthsWithIndex(int teamIndex)
	{
	}

	private void SetupDefaultState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetLocalRotation(Quaternion P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetLocalScale(Vector3 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0)
	{
	}
}
