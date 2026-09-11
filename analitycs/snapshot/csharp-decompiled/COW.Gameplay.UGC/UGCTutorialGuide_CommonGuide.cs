using System;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTutorialGuide_CommonGuide : UGCTutorialGuideBase
{
	private const int DEFAULT_DEPTH_OFFSET = 2;

	private TutorialUIType m_DisplayType;

	private bool m_IsValidType;

	private bool m_ShowSuccess;

	private UICommonGuideController m_Controller;

	private UGCTutorialGuideParam_CommonGuide m_Param;

	protected override void OnInit()
	{
	}

	protected override void OnShow(Action onComplete)
	{
	}

	protected override void OnHide()
	{
	}

	protected override void OnDispose()
	{
	}

	public void LiftGuideDepthAboveMaskIfNeeded(int maskDepth)
	{
	}

	private GameObject ResolveTargetObject()
	{
		return null;
	}

	private bool TryResolveVirtualCircleTarget(GameObject targetObject, out Vector3 localPos, out float radius)
	{
		localPos = default(Vector3);
		radius = default(float);
		return false;
	}

	private void LiftGuideDepthAbovePopupIfNeeded(UIWidget targetWidget)
	{
	}

	private void LiftGuideDepthAbovePopupIfNeeded(GameObject targetObject)
	{
	}

	private void LiftGuideDepthAtLeast(int targetGuideDepth, string reason)
	{
	}

	private void TryShowStandaloneArrow(UIAnchor.Side side)
	{
	}

	private Camera GetGameCamera()
	{
		return null;
	}

	private Vector3 ParseVector(string xStr, string yStr)
	{
		return default(Vector3);
	}

	private bool TryParsePositiveFloat(string value, out float result)
	{
		result = default(float);
		return false;
	}

	private int ParseDepthOffset()
	{
		return 0;
	}

	private UIAnchor.Side ParseAnchorSide(string sideStr)
	{
		return UIAnchor.Side.BottomLeft;
	}

	public void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDispose()
	{
	}
}
