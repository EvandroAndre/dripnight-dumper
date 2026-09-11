using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace COW.Gameplay.UGC;

public class UGCAnimPlayable_State
{
	private enum EStatus
	{
		idle,
		playing
	}

	public enum EFadeStatus
	{
		none,
		fading,
		fadein,
		fadeout
	}

	protected int m_id;

	public int MaskState;

	public AnimationClipPlayable ClipPlayable;

	private PlayableGraph m_graph;

	public AnimationClip m_clip;

	public WrapMode m_PlayingWrapMode;

	public float prevCheckTime;

	public int prevCheckIndex;

	public int prevCheckLoopCount;

	private float m_cacheSpeed;

	private float m_cacheDuration;

	private float m_logicDuration;

	private float m_logicTime;

	public float freezeAfterTime;

	public float freezeAnimationTime;

	public bool m_enableDelayTime;

	public float delayTime;

	public float delayTimeDeltaScale;

	public string name;

	public int visitID;

	private EStatus m_playingStatus;

	private bool m_playingStatusDirty;

	public int IndexInParentMixer;

	public int IndexConnected;

	private EFadeStatus m_fadeStatus;

	private bool m_isFading;

	public bool IsWeightDirty;

	public float weight;

	public float fadeTime;

	private float m_fadeSpeed;

	public float m_targetFadeWeight;

	private float m_nextSimulateCompletedTime;

	private bool m_enableSimulateCompleted;

	private float m_simulateCompletedDuration;

	public Action onStatePlayCompleted;

	private bool m_isPlayingOrQueued;

	private UGCAnimPlayable_State m_cloneFromState;

	public List<UGCAnimPlayable_State> m_cloneStatePool;

	public int ID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public WrapMode PlayingWrapMode
	{
		get
		{
			return WrapMode.Default;
		}
		set
		{
		}
	}

	public bool IsLooping => false;

	public bool IsClipLooping => false;

	public float time
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float normalizedTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float logicTime => 0f;

	public int timeAsLoopCount => 0;

	public float speed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float length => 0f;

	public float duration
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float logicDuration
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float clampDuration => 0f;

	public WrapMode wrapMode
	{
		get
		{
			return WrapMode.Default;
		}
		set
		{
		}
	}

	public bool IsPlaying => false;

	public bool IsPlayingStatusDirty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isFading => false;

	public bool IsPlayingOrQueued
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDone => false;

	public float remainingTime => 0f;

	public void ResetTempValue()
	{
	}

	public void SetUserDelayTime(float inDelayTime)
	{
	}

	public void ResotreWithGraphChanged(PlayableGraph graph)
	{
	}

	private void initClip()
	{
	}

	public void Init(string inName, AnimationClip clip, PlayableGraph graph)
	{
	}

	public void ReplaceAnimationClip(AnimationClip clip)
	{
	}

	public void FadeTo(float targetWeight, float inFadeTime)
	{
	}

	public void FadeIn(float inFadeTime)
	{
	}

	public void FadeOut(float inFadeTime)
	{
	}

	public void SetWeight(float newWeight)
	{
	}

	private void forceWeight(float weight)
	{
	}

	public void EnableSimulateCompleted(bool enable, float simulateDuration)
	{
	}

	private void updateSimulateCompleted(float deltaTime)
	{
	}

	public void Stop(bool invokeCompleted = true)
	{
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public void StateUpdate(double animationDeltaTime)
	{
	}

	public void Rewind(bool callPlay)
	{
	}

	public UGCAnimPlayable_State CloneState()
	{
		return null;
	}

	private void AddClonedToPool(UGCAnimPlayable_State state)
	{
	}

	public void Free()
	{
	}

	public void CaptureStateSnap(UGCAnimPlayableSnapClip clipSnap)
	{
	}

	public void ApplySnap(UGCAnimPlayableSnapClip clipSnap)
	{
	}
}
