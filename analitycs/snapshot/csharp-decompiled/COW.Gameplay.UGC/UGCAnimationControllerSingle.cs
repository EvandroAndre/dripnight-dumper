using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCAnimationControllerSingle
{
	private class AnimationStateWrap
	{
		public bool m_isUnityState;

		private AnimationState m_unityState;

		public UGCAnimPlayable_State m_selfState;

		public WrapMode cacheWrapMode;

		public float cacheSpeed;

		public AnimationState UnityState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UGCAnimPlayable_State SelfState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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
	}

	private class AnimationClipInfo
	{
		public UGCResAnimationClip Clip;

		public string ClipUUID;

		public string ClipName;

		public bool IsLoop;

		public float PlaySpeed;

		public float Length;

		public float FadeInTime;

		public AnimationStateWrap PlayState;

		public bool IsDelayQueueForUnityAnimation;

		public bool IsDelayCrossForUnityAnimation;

		public float PrevEventTime;

		public void CopyTo(AnimationClipInfo dst)
		{
		}
	}

	private class AnimationStateInfo
	{
		public string StateName;

		public List<AnimationClipInfo> ClipInfos;

		public bool IsLoop;

		public float PlaySpeed;

		public float CurrentClipLeftTime;

		public bool AutoStopWhenTimeout;

		public void CopyTo(AnimationStateInfo dst)
		{
		}
	}

	private class CachePlayStateInfo
	{
		public int cacheType;

		public string stateName;

		public float speed;

		public bool overrideLoop;

		public bool isLoop;

		public float currentStateSpeed;

		public bool isStateLoop;

		public string currentClipName;

		public float currentClipProgress;

		public bool isClipLoop;

		public float currentClipSpeed;
	}

	private struct PrevStateInfo
	{
		public string StateName;

		public string ClipName;

		public float Progress;

		public bool IsLoop;
	}

	private Dictionary<string, AnimationStateInfo> m_name2StateInfo;

	private List<AnimationClipInfo> m_unityAnimationQueue;

	private bool m_useUnityAnimation;

	private string entityID;

	private AnimationStateInfo m_currentAnimationState;

	private CachePlayStateInfo m_cachePlayState;

	private Animation m_cacheAnimation;

	private UGCAnimPlayable_Simple m_simpleAnimation;

	private UGCResAnimationController m_resController;

	private string m_localStateName;

	private UGCResAnimationClip m_localSimulateClipRes;

	private PrevStateInfo m_prevInfo;

	private object[] m_EventArgs1;

	private object[] m_EventArgs2;

	private bool IsValid => false;

	private bool IsAllResLoaded => false;

	public bool IsSupportAnimation => false;

	public bool IsSupportAnimator => false;

	private void CrossFadeImpl(AnimationClipInfo stInfo)
	{
	}

	private void PlayQueuedImpl(AnimationClipInfo stInfo)
	{
	}

	private void CrossFadeQueuedImpl(AnimationClipInfo stInfo)
	{
	}

	private void updateUnityAnimationQueue()
	{
	}

	private void SetupAnimationImpl()
	{
	}

	private bool IsPlayingImpl(string stName)
	{
		return false;
	}

	private bool IsPlayingImpl()
	{
		return false;
	}

	public void SetAttachEntityID(string entityID)
	{
	}

	public bool InitWithAnimation(GameObject obj)
	{
		return false;
	}

	public bool InitWithAnimator(GameObject obj)
	{
		return false;
	}

	public void InitWithAnimatorOrAnimation(GameObject obj)
	{
	}

	public void LoadControllerByResUUID(string resUUID)
	{
	}

	public void LoadUGCResAnimationController(UGCResAnimationController controllerRes)
	{
	}

	public void AttachAnimation(Animation ani)
	{
	}

	public void AttachAnimation(Animator ani)
	{
	}

	public bool IsAnimationStateOriginLoop(string stateName)
	{
		return false;
	}

	public void SyncAnimationState(string stateName, float currentStateSpeed, bool isStateLoop, string currentClipName, float currentClipProgress, bool isClipLoop, float currentClipSpeed)
	{
	}

	public void SyncClipSpeed(string stateName, string currentClipName, float currentClipProgress, float currentClipSpeed, float currentStateSpeed)
	{
	}

	public void SyncClipLoop(string stateName, float currentStateSpeed, bool isStateLoop, string currentClipName, float currentClipProgress, bool isClipLoop, float currentClipSpeed)
	{
	}

	public void SyncStateLoop(string stateName, float currentStateSpeed, bool isStateLoop, string currentClipName, float currentClipProgress, bool isClipLoop, float currentClipSpeed)
	{
	}

	private bool ChangeCurrentAnimationState(string stateName, float speed, bool overrideLoop, bool isLoop)
	{
		return false;
	}

	private void PlayAnimationState(string stateName, float speed, bool overrideLoop, bool isLoop)
	{
	}

	private void RewindCurrentState(int startIndex = 0, bool forceQueued = false)
	{
	}

	public void Update(float deltaTime)
	{
	}

	private void onSimpleAnimationPrepareFrame()
	{
	}

	private void updateImpl(float deltaTime)
	{
	}

	private void UpdateAnimationState(float DeltaTime)
	{
	}

	public void PlayClientCustomClip(AnimationClip clip, bool isLoop)
	{
	}

	public void PlayClientCustomRes(UGCResAnimationClip resObj, bool isLoop)
	{
	}

	public void PauseCurrentAnimation(bool isPause)
	{
	}

	private void UpdateClientEvent(bool isSwitch)
	{
	}

	private void _003CLoadControllerByResUUID_003Eb__28_0(bool succ, UGCResAnimationController resObj)
	{
	}
}
