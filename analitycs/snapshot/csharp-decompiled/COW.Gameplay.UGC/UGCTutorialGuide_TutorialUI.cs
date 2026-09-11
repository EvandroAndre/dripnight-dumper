using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTutorialGuide_TutorialUI : UGCTutorialGuideBase
{
	private TutorialUIType m_DisplayType;

	private bool m_IsValidType;

	private bool m_ShowSuccess;

	private UITutorialIndicatorController m_Controller;

	private UGCTutorialGuideParam_TutorialUI m_Param;

	private static readonly HashSet<int> s_SupportedTypes;

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

	private void LiftGuideDepthAbovePopupIfNeeded(UIWidget targetWidget)
	{
	}

	private Vector3 ParsePositionOffset()
	{
		return default(Vector3);
	}

	private TutorialSetting BuildTutorialSetting()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDispose()
	{
	}
}
