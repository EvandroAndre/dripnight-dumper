using COW.GamePlay;
using UnityEngine;

namespace GCommon;

public class AnimationSystemComponent : MonoBehaviour, FOKBHOEDEMJ
{
	public delegate void AnimationComponentPlay(AnimationID animID);

	private const uint MAX_ANIM_LAYER_NB = 8u;

	protected Animator m_defaultAnimator;

	protected Animator m_Animator;

	protected RuntimeAnimatorController m_runtimeController;

	protected AnimatorOverrideController m_CurrentOverrideController;

	protected uint m_delayCall;

	protected AnimationRuntimeHandle[] m_CurrentHandles;

	protected AnimationID[] m_DefaultAnims;

	protected AnimatorCullingMode m_defaultCullingMode;

	private int m_SwitchAnimationControllTickCount;

	protected bool m_OptSwitchAnimatorController;

	private static uint uniqueIndex;

	public AnimationComponentPlay OnAnimationComponentPlayCall;

	private float mfReplaySpeed;

	private int _003CReplaySpeedKey_003Ek__BackingField;

	public float ReplaySpeed
	{
		get
		{
			return 0f;
		}
		protected set
		{
		}
	}

	public int ReplaySpeedKey
	{
		get
		{
			return _003CReplaySpeedKey_003Ek__BackingField;
		}
		set
		{
			_003CReplaySpeedKey_003Ek__BackingField = value;
		}
	}

	public int SwitchAnimationControllTickCount => 0;

	protected virtual uint GetMaxLayerUsed()
	{
		return 0u;
	}

	public virtual AnimationRuntimeHandle PlayAnim(AnimationID animID, bool canTransitionToSelf = false, float noramlized_time = 0f, bool useInstantSwitch = false, bool loop = false)
	{
		return null;
	}

	public AnimationRuntimeHandle PlayAnim<T>(AnimationID animID, bool canTransitionToSelf = false, float noramlized_time = 0f, bool useInstantSwitch = false, bool loop = false) where T : AnimationRuntimeHandle, new()
	{
		return null;
	}

	public void AddDefaultState(AnimationID animID)
	{
	}

	public bool IsPlaying(AnimationID animID)
	{
		return false;
	}

	public AnimationRuntimeHandle GetCurrentRunningHandlerByAnimId(AnimationID animID)
	{
		return null;
	}

	public AnimationID GetCurrentAnimID(int layerIndex)
	{
		return default(AnimationID);
	}

	public bool CanInterrupted()
	{
		return false;
	}

	public bool CanInterrupted(int layerIndex)
	{
		return false;
	}

	public void TransitionAllLayerToDefaultState()
	{
	}

	public void TransitionToDefaultState(int layerIndex, bool useInstantSwitch = false, bool notNeedRefreshUpbodyLayer = false)
	{
	}

	public void PauseAnimation()
	{
	}

	public static void ReportAnimError(RuntimeAnimatorController runCtrl, string msg)
	{
	}

	public virtual void OnAnimControllerSwitched()
	{
	}

	private void SwitchAnimControllerImpl(AnimatorOverrideController runCtrl)
	{
	}

	public virtual void SwitchAnimController(AnimatorOverrideController runCtrl)
	{
	}

	protected void SwitchDynamicAnimController(AnimatorOverrideController runCtrl)
	{
	}

	internal void SetAnimationFinished(AnimationID animID, bool autoTransitionToDefaultState)
	{
	}

	protected virtual void OnHandleAnimationFinished(AnimationID animID)
	{
	}

	protected virtual void BeforeTransitionToDefaultStateAfterFinish()
	{
	}

	protected virtual void OnTransitionToDefaultState(int layerIndex, bool immediately = false, bool notNeedRefreshUpbodyLayer = false)
	{
	}

	public AnimationRuntimeHandle GetCurrentRunningHandler(int layerIndex)
	{
		return null;
	}

	public bool HasAnimator()
	{
		return false;
	}

	protected virtual T PlayAnimInternal<T>(AnimationConfigData data, bool useInstantSwitch, float normalized_time = 0f, bool loop = false) where T : AnimationRuntimeHandle, new()
	{
		return null;
	}

	protected virtual void CrossFadeAnim(AnimationID animInPlaying, bool usingFixedTime, int stateHashName, float transitionDuration, int layer, float timeOffset)
	{
	}

	protected virtual void Awake()
	{
	}

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layer)
	{
		return default(AnimatorStateInfo);
	}

	protected bool UpdateCheckEnding()
	{
		return false;
	}

	protected void CancelDelayCall()
	{
	}

	private void OnDestroy()
	{
	}

	public virtual void EnableAnimator(bool enabled)
	{
	}

	public void SetReplaySpeed(float speed)
	{
	}

	public virtual float GetRealSpeed()
	{
		return 0f;
	}
}
