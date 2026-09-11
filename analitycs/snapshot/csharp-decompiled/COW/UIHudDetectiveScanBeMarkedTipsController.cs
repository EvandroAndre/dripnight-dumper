using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudDetectiveScanBeMarkedTipsController : UIBaseController
{
	private const float DefaultWarningAnimationLength = 1f;

	private UIHudDetectiveScanBeMarkedTipsView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetViewData(DetectiveScanBeMarkedTipsState state, float duration, float elapsed = 0f)
	{
	}

	private void ResetView()
	{
	}

	private void SetNodeActive(GameObject node, bool active)
	{
	}

	private void PlayWarningAnimation(float duration, float elapsed)
	{
	}

	private void StopWarningAnimation()
	{
	}

	private AnimationState GetWarningAnimationState(Animation animation)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
