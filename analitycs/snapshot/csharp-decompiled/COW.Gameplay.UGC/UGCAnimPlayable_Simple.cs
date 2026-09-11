using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace COW.Gameplay.UGC;

public class UGCAnimPlayable_Simple
{
	public class LayerInfo
	{
		public uint m_layerIndex;

		public UGCAnimPlayable_IClipPlayer m_clipPlayer;

		public bool m_isAddition;

		public AvatarMask m_avatarMask;
	}

	public delegate void OnPrepareFrame();

	private Animator _003CAnim_003Ek__BackingField;

	private AnimationPlayableOutput m_animatorControllerOutput;

	private AnimationPlayableOutput m_selfOutput;

	private Playable m_animatorControllerPlayable;

	private bool m_autoFadeToAnimatorControllerPlayable;

	public Playable m_ActualPlayable;

	private AnimationLayerMixerPlayable m_layerMixer;

	private AnimationMixerPlayable m_mixMainAndAnimatorController;

	private List<LayerInfo> m_layers;

	private int m_curConnectStatus;

	private Playable m_animatorControllerParent;

	private int m_animatorControllerIndexInParent;

	private bool m_isForceSetAnimatorControllerWeight;

	private float m_forceSetAnimatorControllerWeight;

	private bool m_isAllDone;

	public float RemainTime;

	public OnPrepareFrame onPrepareFrame;

	private bool m_isFadingAnimatorController;

	public float m_animatorControllerWeight;

	public float m_animatorControllerTargetWeight;

	private float m_animatorControllerFadeSpeed;

	public Animator Anim
	{
		get
		{
			return _003CAnim_003Ek__BackingField;
		}
		set
		{
			_003CAnim_003Ek__BackingField = value;
		}
	}

	public PlayableGraph m_graph => default(PlayableGraph);

	public List<LayerInfo> Layers => null;

	public UGCAnimPlayable_IClipPlayer MainClipPlayer => null;

	public Playable RootPlayable => default(Playable);

	public bool isPlaying => false;

	// C# has no syntax for parameterized property 'Item'.
	public UGCAnimPlayable_State get_Item(string name)
	{
		return null;
	}

	public bool IsAllDone => false;

	private void disconnectByConnectStatus()
	{
	}

	private void refreshMixerOrLayerConnect()
	{
	}

	public void Clear(int stateMask = 0)
	{
	}

	public void EnableMultiLayer(bool refreshMixer = true)
	{
	}

	public void DisableMultiLayer()
	{
	}

	private LayerInfo getLayerByClipPlayer(UGCAnimPlayable_SingleClipPlayer clipPlayer)
	{
		return null;
	}

	public UGCAnimPlayable_SingleClipPlayer AddSingleClipPlayer(bool isAddition, bool autoMultiLayer)
	{
		return null;
	}

	public AvatarMask SetClipPlayerMask(UGCAnimPlayable_SingleClipPlayer clipPlayer, List<Transform> transformPathList)
	{
		return null;
	}

	public void SetClipPlayerMask(UGCAnimPlayable_SingleClipPlayer clipPlayer, AvatarMask avatarMask)
	{
	}

	public void ForceSetAnimatorControllerWeight(bool isEnable, float w)
	{
	}

	public void SetExistAnimatorControllerWeight(float w)
	{
	}

	public void CheckIfSomeObjectInvalid()
	{
	}

	public void AttachUnityPlayableWrap(UGCAnimPlayableUnityWrap unityWrap, bool isInit, bool restoreGraph = true)
	{
	}

	public void AddClip(string name, AnimationClip clip)
	{
	}

	public UGCAnimPlayable_State getStateByName(string stateName)
	{
		return null;
	}

	public UGCAnimPlayable_State Play(string stateName)
	{
		return null;
	}

	public UGCAnimPlayable_State CrossFade(string stateName, float fadeTime = 0.2f)
	{
		return null;
	}

	public UGCAnimPlayable_State PlayQueued(string stateName)
	{
		return null;
	}

	public UGCAnimPlayable_State CrossFadeQueued(string stateName, float fadeTime = 0.2f)
	{
		return null;
	}

	public bool IsPlaying(string stateName)
	{
		return false;
	}

	public void StopAll()
	{
	}

	public void OnPlayableCreate(Playable playable)
	{
	}

	public void OnGraphStop(Playable playable)
	{
	}

	public void Update(double animationDeltaTime)
	{
	}

	private void updateAnimatorControllerFade(float deltaTime)
	{
	}

	private void fadeAnimatorController(float targetWeight, float fadeTime)
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void CaptureSnap(UGCAnimPlayableSnapPlayer snapPlayer)
	{
	}

	public void ApplySnap(UGCAnimPlayableSnapPlayer snapPlayer)
	{
	}
}
