using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCResAnimationClip : UGCResource
{
	protected AnimationClip m_clip;

	protected AnimationClip m_animatorClip;

	protected bool m_isSupportAnimatorClip;

	protected float m_length;

	protected float m_start;

	protected CAPGCBLDFJI m_resAnimationData;

	private UGCResAnimationClip m_refAnimClip;

	public bool IsValid => false;

	public bool IsSupportAnimation => false;

	public bool IsSupportAnimator => false;

	public AnimationClip clip => null;

	public AnimationClip animatorClip => null;

	public float Length => 0f;

	public CAPGCBLDFJI animationData => null;

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public override void OnUnityObjectLoaded(bool isSucc, Object resObject)
	{
	}

	public override void OnUnityObjectLoadedWithSub(bool isSucc, Object resObject, string subIndex)
	{
	}

	public override void ReleaseUnityResRef()
	{
	}

	private void _003CLoadFromData_003Eb__21_0(bool succ, UGCResAnimationClip resObj)
	{
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoaded(bool P0, Object P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoadedWithSub(bool P0, Object P1, string P2)
	{
	}

	public void _003C_003EiFixBaseProxy_ReleaseUnityResRef()
	{
	}
}
