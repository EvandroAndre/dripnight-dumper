using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace COW.Gameplay.UGC;

public class UGCAnimPlayable_SingleClipPlayer : UGCAnimPlayable_IClipPlayer
{
	private string _003Cname_003Ek__BackingField;

	private AnimationMixerPlayable m_Mixer;

	public PlayableGraph m_graph;

	private List<UGCAnimPlayable_State> m_allClipStates;

	private bool m_isAllDone;

	private List<UGCAnimPlayable_State> m_playingClipStates;

	private int m_mixerInputCount;

	private List<UGCAnimPlayable_State> m_queuedStates;

	private bool[] m_tempSnapClipStatus;

	private float m_remainTime;

	private float m_userWeight;

	private float m_fadeWeight;

	private bool m_isFading;

	private float m_fadeTime;

	private float m_fadeSpeed;

	private float m_targetFadeWeight;

	private bool m_isWeightDirty;

	private float m_defaultFadeDuration;

	private int m_applySnapVisitID;

	public string name
	{
		get
		{
			return _003Cname_003Ek__BackingField;
		}
		set
		{
			_003Cname_003Ek__BackingField = value;
		}
	}

	public Playable RootPlayable => default(Playable);

	public List<UGCAnimPlayable_State> AllClipStates => null;

	public bool IsAllDone => false;

	public int StateCount => 0;

	// C# has no syntax for parameterized property 'Item'.
	public UGCAnimPlayable_State get_Item(int index)
	{
		return null;
	}

	public bool isPlaying => false;

	public bool isEmpty => false;

	public bool isQueueEmpty => false;

	public float remainTime => 0f;

	// C# has no syntax for parameterized property 'Item'.
	public UGCAnimPlayable_State get_Item(string name)
	{
		return null;
	}

	public bool isWeightDirty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float weight => 0f;

	public float userWeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void Create(PlayableGraph graph)
	{
	}

	public void Clear(bool isDestroy, int maskState = 0)
	{
	}

	public void Resume()
	{
	}

	public void ResotreWithGraphChanged(PlayableGraph graph)
	{
	}

	private void validateMixerInputCount(int count)
	{
	}

	public int AddClip(string name, AnimationClip clip, int mask = 0)
	{
		return 0;
	}

	private void updateQueuedStateDelayTime(float deltaTime)
	{
	}

	public float PlayerUpdate(double animationDeltaTime)
	{
		return 0f;
	}

	public UGCAnimPlayable_State getStateByName(string stateName)
	{
		return null;
	}

	public UGCAnimPlayable_State getUnusedState(int stateID)
	{
		return null;
	}

	public UGCAnimPlayable_State getUnusedState(string stateName)
	{
		return null;
	}

	private void clearQueue()
	{
	}

	public void Stop()
	{
	}

	public void StopState(string stateName)
	{
	}

	private bool fadeOutAllPlayingState(float fadeTime)
	{
		return false;
	}

	private void onRequestPlay(UGCAnimPlayable_State state)
	{
	}

	public UGCAnimPlayable_State Play(string stateName, float duration = -1f)
	{
		return null;
	}

	public UGCAnimPlayable_State CrossFade(string stateName, float fadeTime = 0.2f, float duration = -1f)
	{
		return null;
	}

	private void crossFadeState(UGCAnimPlayable_State state, float fadeTime, bool needClearQueue, float duration)
	{
	}

	public UGCAnimPlayable_State PlayQueued(string stateName, float duration = -1f)
	{
		return null;
	}

	public UGCAnimPlayable_State CrossFadeQueued(string stateName, float fadeTime = 0.2f, float duration = -1f)
	{
		return null;
	}

	public UGCAnimPlayable_State Play(int stateID, float duration = -1f)
	{
		return null;
	}

	public UGCAnimPlayable_State CrossFade(int stateID, float fadeTime = 0.2f, float duration = -1f)
	{
		return null;
	}

	public UGCAnimPlayable_State PlayQueued(int stateID, float delayTime = 0f, float duration = -1f)
	{
		return null;
	}

	public UGCAnimPlayable_State CrossFadeQueued(int stateID, float fadeTime = 0.2f, float delayTime = 0f, float duration = -1f)
	{
		return null;
	}

	public bool IsPlaying(string stateName)
	{
		return false;
	}

	public void FadeTo(float targetWeight, float inFadeTime)
	{
	}

	private bool updateFade()
	{
		return false;
	}

	public bool CaptureLayerSnap(UGCAnimPlayableSnapLayer snap)
	{
		return false;
	}

	public void ApplySnap(UGCAnimPlayableSnapLayer snap)
	{
	}
}
