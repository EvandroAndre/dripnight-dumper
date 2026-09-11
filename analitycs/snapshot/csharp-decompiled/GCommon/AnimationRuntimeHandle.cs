using System;

namespace GCommon;

public class AnimationRuntimeHandle
{
	protected AnimationSystemComponent m_AnimationSystemComponent;

	protected AnimationConfigData m_ConfigData;

	protected bool m_HasFinished;

	protected int m_CurrentNameHash;

	protected float m_LastTime;

	protected AnimationConfigData m_LastData;

	protected bool m_IsLooping;

	protected Action<float> m_AnimatorCheck;

	protected Action m_AnimatorFinishCallBack;

	protected Action<bool> m_AnimatorRealFinishCallBack;

	private uint index;

	private float m_custormEndNormalizeTime;

	public bool IsLooping
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint UniqueIndex => 0u;

	public AnimationConfigData configData => null;

	public void Reset(AnimationSystemComponent animationSystemComponent, AnimationConfigData data, uint uniqueIndex)
	{
	}

	public void SetAction(Action<float> callback)
	{
	}

	public void SetFinishCallback(Action callback, float custormEndNormalizeTime = -1f)
	{
	}

	public void SetRealFinishCallback(Action<bool> callback, float custormEndNormalizeTime = -1f)
	{
	}

	public bool CheckEnding(AnimationSystemComponent aniSys, int layer)
	{
		return false;
	}

	public int GetCurrentHash()
	{
		return 0;
	}

	public int GetAnimID()
	{
		return 0;
	}

	protected virtual void OnReset()
	{
	}

	internal void SetAnimationFinished()
	{
	}

	public virtual bool CanInterrupted()
	{
		return false;
	}
}
