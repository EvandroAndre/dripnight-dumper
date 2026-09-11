using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudTokenGunProgressController : UIHudNameBaseController
{
	private float m_CameraDistanceMin;

	private float m_CameraDistanceMax;

	private float m_ScaleMin;

	private float m_ScaleMax;

	private float m_RightOffsetMin;

	private float m_RightOffsetMax;

	private float m_UpOffsetMin;

	private float m_UpOffsetMax;

	private UIHudTokenGunProgressView m_View;

	private Player m_BindPlayer;

	private AnimationState m_ProgressAnimationState;

	private uint m_CurrentProgress;

	private uint m_ExplodeEffectDelayCallID;

	private bool m_IsExploding;

	private bool m_IsFollowVisible;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindPlayer(Player player)
	{
	}

	public void SetProgress(uint progress)
	{
	}

	public void PlayExplodeEffect()
	{
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override void UpdateNamePosition()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnRecyle()
	{
	}

	private void InitProgressAnimationState()
	{
	}

	private void SampleProgressAnimation(float normalizedProgress)
	{
	}

	private void RefreshContentVisibleState()
	{
	}

	private void HideContentNodes()
	{
	}

	private void OnExplodeEffectFinished()
	{
	}

	private void CancelExplodeEffectDelayCall()
	{
	}

	private void ClearState()
	{
	}

	private void SetFollowVisible(bool visible)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_UpdateNamePosition()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecyle()
	{
	}
}
