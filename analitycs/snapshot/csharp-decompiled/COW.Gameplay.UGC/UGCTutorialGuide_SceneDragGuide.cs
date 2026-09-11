using System;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTutorialGuide_SceneDragGuide : UGCTutorialGuideBase
{
	private UGCTutorialGuideParam_SceneDragGuide m_Param;

	private bool m_ShowSuccess;

	private UICommonGuideController m_Controller;

	private const string HINT_ANCHOR_START = "Start";

	private const string HINT_ANCHOR_END = "End";

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

	private bool TryResolveEndpoint(string widgetKey, string posKey, bool hasDirectWorldPos, Vector3 directWorldPos, string label, Camera gameCamera, Camera uiCamera, Transform uiRoot, out Vector3 handLocal)
	{
		handLocal = default(Vector3);
		return false;
	}

	private void TryApplyHintEndpointOffset(Vector3 handFrom, Vector3 handTo)
	{
	}

	private bool TryResolveHintAnchorEndpoint(string endpoint, Vector3 handFrom, Vector3 handTo, out Vector3 anchorLocal)
	{
		anchorLocal = default(Vector3);
		return false;
	}

	private bool TryParseHintOffset(out Vector3 offset)
	{
		offset = default(Vector3);
		return false;
	}

	private bool TryParseOptionalFloat(string rawValue, string fieldName, out float value)
	{
		value = default(float);
		return false;
	}

	private Camera GetGameCamera()
	{
		return null;
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
